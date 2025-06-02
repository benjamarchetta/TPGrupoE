using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Model
{
    internal class EmitirRemitoModel
    {
        public List<OrdenPreparacionEntidad> OrdenesFiltradas { get; private set; } = new();

        // Llama a los métodos que cargan los datos desde los archivos JSON
        public void CargarDatosIniciales()
        {
            ClienteAlmacen.LeerCliente();
            OrdenPreparacionAlmacen.LeerOP();
            OrdenEntregaAlmacen.LeerOE();
            RemitoAlmacen.LeerRemito();
        }

        // Devuelve todos los clientes cargados (para poblar el ComboBox)
        public List<ClienteEntidad> ObtenerClientes()
        {
            return ClienteAlmacen.Clientes.ToList();
        }

        // Devuelve los DNIs únicos de transportistas que tienen alguna OP
        public List<int> ObtenerTransportistas()
        {
            return OrdenPreparacionAlmacen.OrdenesPreparacion
                .Select(op => op.DniTransportista)
                .Distinct()
                .ToList();
        }

        // Filtra las OPs según transportista, cliente y estado "Preparada",
        // y que además estén vinculadas a una OE en estado "Pendiente"
        public List<OrdenPreparacionEntidad> BuscarOrdenesFiltradas(int dniTransportista, int idCliente)
        {
            var ordenesPreparadas = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas();
            var ordenesEntregaPendiente = OrdenEntregaAlmacen.BuscarOrdenesParaDespachar();

            // Buscamos los IDs de todas las OP que están vinculadas a OE pendientes
            var idsEntregaPendientes = ordenesEntregaPendiente
                .SelectMany(oe => oe.IdOrdenPreparacion)
                .ToHashSet();

            // Ahora filtramos las OP que cumplen con todos los criterios
            OrdenesFiltradas = ordenesPreparadas
                .Where(op => op.DniTransportista == dniTransportista &&
                             op.IdCliente == idCliente &&
                             idsEntregaPendientes.Contains(op.IdOrdenPreparacion))
                .ToList();

            return OrdenesFiltradas;
        }

        // Emite un nuevo remito, cambia estados y guarda los cambios en disco
        public string EmitirRemito(int idCliente, int dniTransportista, List<int> ordenesSeleccionadas)
        {
            // Crear y guardar el nuevo remito
            var remito = new RemitoEntidad
            {
                IDCliente = idCliente,
                DNITransportista = dniTransportista,
                IDOrdenPreparacion = ordenesSeleccionadas
            };

            RemitoAlmacen.NuevoRemito(remito);
            RemitoAlmacen.GrabarRemito();

            // Actualiza estado de cada OP a "Despachada"
            foreach (var idOp in ordenesSeleccionadas)
            {
                var op = OrdenPreparacionAlmacen.OrdenesPreparacion.FirstOrDefault(o => o.IdOrdenPreparacion == idOp);
                if (op != null) op.Estado = EstadoOrdenPreparacion.Despachada;
            }

            // Actualiza estado de OE a "Cumplida" si todas sus OP están despachadas
            foreach (var oe in OrdenEntregaAlmacen.OrdenesEntrega)
            {
                if (ordenesSeleccionadas.All(id => oe.IdOrdenPreparacion.Contains(id)))
                {
                    oe.Estado = EstadoOrdenEntrega.Cumplida;
                }
            }

            // Guardar cambios
            OrdenPreparacionAlmacen.GrabarOP();
            OrdenEntregaAlmacen.GrabarOE();

            // Devuelvo el ID del remito generado como string con prefijo "R-"
            return $"R-{remito.IdRemito}";
        }
    }

}
