using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using static TPGrupoE.CasosDeUso.CU8EmitirRemito.Model.EmitirRemitoModel;


namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Model
{
    internal partial class EmitirRemitoModel
    {
        public List<OrdenPreparacion> OrdenesSeleccionadas { get; private set; } = new();
        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; }
        public List<Transportista> Transportistas { get; private set; }
        public List<Cliente> Clientes { get; private set; }

        public EmitirRemitoModel()
        {
            OrdenesDePreparacion = new List<OrdenPreparacion>();
        }
        public void CargarOrdenesPorTransportistaYCliente(string dniTransportista, string cuitCliente)
        {
            OrdenesDePreparacion = [];

            var ordenesPreparadas = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas();

            foreach (var orden in ordenesPreparadas)
            {
                var cliente = ClienteAlmacen.BuscarClientePorId(orden.IdCliente);
                if (cliente == null) continue;

                if (orden.DniTransportista.ToString() == dniTransportista && cliente.Cuit == cuitCliente)
                {
                    var ordenPreparacion = new OrdenPreparacion(
                        orden.IdOrdenPreparacion,
                        orden.DniTransportista.ToString(),
                        orden.Estado,
                        orden.IdCliente,
                        orden.FechaEntrega
                    );

                    OrdenesDePreparacion.Add(ordenPreparacion);
                }
            }
        }

        public void CargarClientesPorTransportista(string dniTransportista)
        {
            Clientes = new List<Cliente>();

            var ordenes = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas()
                .Where(op => op.DniTransportista.ToString() == dniTransportista)
                .ToList();

            foreach (var op in ordenes)
            {
                var cliente = ClienteAlmacen.BuscarClientePorId(op.IdCliente);
                if (cliente != null && !Clientes.Any(c => c.Cuit == cliente.Cuit))
                {
                    Clientes.Add(new Cliente(cliente.Cuit, cliente.RazonSocial));
                }
            }
        }

        public void CargarTransportistasPorCliente(string cuitCliente)
        {
            Transportistas = new List<Transportista>();

            var ordenes = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas();

            foreach (var op in ordenes)
            {
                var cliente = ClienteAlmacen.BuscarClientePorId(op.IdCliente);
                if (cliente != null && cliente.Cuit == cuitCliente)
                {
                    var dni = op.DniTransportista.ToString();
                    if (!Transportistas.Any(t => t.Documento == dni))
                    {
                        Transportistas.Add(new Transportista(dni));
                    }
                }
            }
        }

        public void CargarTodosLosTransportistas()
        {
            Transportistas = new List<Transportista>();

            var ordenes = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas();
            foreach (var op in ordenes)
            {
                var dni = op.DniTransportista.ToString();
                if (!Transportistas.Any(t => t.Documento == dni))
                {
                    Transportistas.Add(new Transportista(dni));
                }
            }
        }

        public void CargarTodosLosClientes()
        {
            Clientes = new List<Cliente>();

            var ordenes = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas();
            foreach (var op in ordenes)
            {
                var cliente = ClienteAlmacen.BuscarClientePorId(op.IdCliente);
                if (cliente != null && !Clientes.Any(c => c.Cuit == cliente.Cuit))
                {
                    Clientes.Add(new Cliente(cliente.Cuit, cliente.RazonSocial));
                }
            }
        }

        public string MarcarOpDespachada()
        {
            if (OrdenesDePreparacion.Count == 0)
            {
                return "No hay ninguna orden para marcar como despachada.";
            }

            var primeraOrden = OrdenPreparacionAlmacen.BuscarOrdenesPorId(OrdenesDePreparacion[0].Id);

            RemitoEntidad remito = new();

            remito.DNITransportista = primeraOrden.DniTransportista;
            remito.IDCliente = primeraOrden.IdCliente;
            remito.IDOrdenPreparacion = [];

            foreach (var orden in OrdenesSeleccionadas)
            {
                var ordenPreparacion = OrdenPreparacionAlmacen.BuscarOrdenesPorId(orden.Id);
                ordenPreparacion.MarcarOpDespachada();
                remito.IDOrdenPreparacion.Add(ordenPreparacion.IdOrdenPreparacion);
            }

            RemitoAlmacen.NuevoRemito(remito);
            OrdenesDePreparacion = [];

            return null;
        }

        public bool HayOrdenesPreparadas()
        {
            var ordenesPreparadas = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas();
            return ordenesPreparadas != null && ordenesPreparadas.Count > 0;
        }

        public (List<Transportista> transportistas, List<Cliente> clientes) ObtenerFiltrosDisponibles()
        {
            var ordenes = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas();
            var transportistas = new List<Transportista>();
            var clientes = new List<Cliente>();

            foreach (var op in ordenes)
            {
                var cliente = ClienteAlmacen.BuscarClientePorId(op.IdCliente);
                if (cliente == null) continue;

                if (!transportistas.Any(t => t.Documento == op.DniTransportista.ToString()))
                    transportistas.Add(new Transportista(op.DniTransportista.ToString()));

                if (!clientes.Any(c => c.Cuit == cliente.Cuit))
                    clientes.Add(new Cliente(cliente.Cuit, cliente.RazonSocial));
            }

            return (transportistas, clientes);
        }
    }
}