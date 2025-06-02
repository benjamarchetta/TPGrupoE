using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Model
{
    public class EmitirRemitoModel
    {
        // Guardo las órdenes filtradas según transportista y cliente
        public List<OrdenPreparacionEntidad> OrdenesFiltradas { get; private set; } = new();

        // Guardo los transportistas como objetos para mostrar en ComboBox
        public List<ComboBoxItem> Transportistas { get; private set; } = new();

        public EmitirRemitoModel()
        {
            CargarTransportistas(); // Al iniciar el modelo cargo los transportistas disponibles
        }

        public void CargarDatosIniciales()
        {
            ClienteAlmacen.LeerCliente();
            OrdenPreparacionAlmacen.LeerOP();
            OrdenEntregaAlmacen.LeerOE();
            RemitoAlmacen.LeerRemito();
        }

        public List<ClienteEntidad> ObtenerClientes()
        {
            return ClienteAlmacen.Clientes.ToList(); // Devuelvo todos los clientes del almacén
        }

        public void CargarOrdenesPorTransportistaYCliente(int dni, int idCliente)
        {
            // Busco solo las OP que coinciden con transportista, cliente, que estén preparadas y tengan OE pendiente
            OrdenesFiltradas = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(op =>
                    op.DniTransportista == dni &&
                    op.IdCliente == idCliente &&
                    op.Estado == EstadoOrdenPreparacion.Preparada &&
                    OrdenEntregaAlmacen.OrdenesEntrega.Any(oe => oe.IdOrdenPreparacion.Contains(op.IdOrdenPreparacion) && oe.Estado == EstadoOrdenEntrega.Pendiente)
                ).ToList();
        }

        public string EmitirRemito(int dniTransportista, int idCliente, List<int> idsOrdenes)
        {
            if (idsOrdenes.Count == 0)
                return "No hay órdenes seleccionadas.";

            // Creo un nuevo ID de Remito
            int nuevoId = RemitoAlmacen.Remitos.Count + 1;

            RemitoEntidad remito = new()
            {
                IdRemito = nuevoId,
                DNITransportista = dniTransportista,
                IDCliente = idCliente,
                FechaEmision = DateTime.Now,
                IDOrdenPreparacion = idsOrdenes
            };

            // Agrego el nuevo remito al almacén
            var lista = RemitoAlmacen.Remitos as List<RemitoEntidad>;
            if (lista != null)
                lista.Add(remito);

            RemitoAlmacen.GrabarRemito();

            // Actualizo estado de OP y OE
            foreach (var id in idsOrdenes)
            {
                var orden = OrdenPreparacionAlmacen.OrdenesPreparacion.FirstOrDefault(op => op.IdOrdenPreparacion == id);
                if (orden != null)
                    orden.MarcarOpDespachada();

                var entrega = OrdenEntregaAlmacen.OrdenesEntrega.FirstOrDefault(oe => oe.IdOrdenPreparacion.Contains(id));
                if (entrega != null)
                    entrega.Estado = EstadoOrdenEntrega.Cumplida;
            }

            OrdenPreparacionAlmacen.GrabarOP();
            OrdenEntregaAlmacen.GrabarOE();

            return nuevoId.ToString();
        }

        private void CargarTransportistas()
        {
            // Cargo solo transportistas de OP en estado 'Preparada', sin duplicar DNIs
            Transportistas = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(op => op.Estado == EstadoOrdenPreparacion.Preparada)
                .Select(op => op.DniTransportista)
                .Distinct()
                .Select(dni => new ComboBoxItem
                {
                    Text = $"DNI: {dni}",
                    Value = dni
                })
                .ToList();
        }
    }

    // Clase auxiliar para mostrar en ComboBox
    public class ComboBoxItem
    {
        public string Text { get; set; } = "";
        public int Value { get; set; }
        public override string ToString() => Text;
    }
}
