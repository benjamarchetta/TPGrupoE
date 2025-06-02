using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Model
{
    public class ComboBoxItem
    {
        public string Text { get; set; } = "";
        public int Value { get; set; }

        public override string ToString() => Text;
    }
    public class EmitirRemitoModel
    {
        public List<OrdenPreparacionEntidad> OrdenesFiltradas { get; private set; } = new();
        public List<ComboBoxItem> Transportistas { get; private set; } = new();

        public void CargarDatosIniciales()
        {
            ClienteAlmacen.LeerCliente();
            OrdenPreparacionAlmacen.LeerOP();
            OrdenEntregaAlmacen.LeerOE();
            RemitoAlmacen.LeerRemito();
        }

        public void CargarTransportistasDisponibles()
        {
            Transportistas = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(op => op.Estado == EstadoOrdenPreparacion.Preparada &&
                             op.FechaEntrega.Date == DateTime.Today &&
                             OrdenEntregaAlmacen.OrdenesEntrega.Any(oe => oe.IdOrdenPreparacion.Contains(op.IdOrdenPreparacion) &&
                                                                           oe.Estado == EstadoOrdenEntrega.Pendiente))
                .Select(op => op.DniTransportista)
                .Distinct()
                .Select(dni => new ComboBoxItem { Text = $"DNI: {dni}", Value = dni })
                .ToList();
        }

        public List<ClienteEntidad> ObtenerClientesDeTransportista(int dni)
        {
            var clientesConOP = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(op => op.DniTransportista == dni &&
                             op.Estado == EstadoOrdenPreparacion.Preparada &&
                             op.FechaEntrega.Date == DateTime.Today)
                .Select(op => op.IdCliente)
                .Distinct()
                .ToList();

            return ClienteAlmacen.Clientes
                .Where(c => clientesConOP.Contains(c.IdCliente))
                .ToList();
        }

        public void CargarOrdenesPorTransportistaYCliente(int dni, int idCliente)
        {
            OrdenesFiltradas = OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(op =>
                    op.DniTransportista == dni &&
                    op.IdCliente == idCliente &&
                    op.Estado == EstadoOrdenPreparacion.Preparada &&
                    op.FechaEntrega.Date == DateTime.Today &&
                    OrdenEntregaAlmacen.OrdenesEntrega.Any(oe => oe.IdOrdenPreparacion.Contains(op.IdOrdenPreparacion) &&
                                                                 oe.Estado == EstadoOrdenEntrega.Pendiente))
                .ToList();
        }

        public string EmitirRemito(int dniTransportista, int idCliente, List<int> idsOrdenes)
        {
            if (idsOrdenes.Count == 0)
                return "No hay órdenes seleccionadas.";

            int nuevoId = RemitoAlmacen.Remitos.Count + 1;

            var remito = new RemitoEntidad
            {
                IdRemito = nuevoId,
                DNITransportista = dniTransportista,
                IDCliente = idCliente,
                FechaEmision = DateTime.Now,
                IDOrdenPreparacion = idsOrdenes
            };

            if (RemitoAlmacen.Remitos is List<RemitoEntidad> lista)
                lista.Add(remito);

            RemitoAlmacen.GrabarRemito();

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
    }
}
