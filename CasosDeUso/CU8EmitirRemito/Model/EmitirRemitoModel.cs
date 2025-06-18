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

        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; }
        public List<Transportista> Transportistas { get; private set; }
        public List<Cliente> Clientes { get; private set; }

        public EmitirRemitoModel()
        {
            OrdenesDePreparacion = new List<OrdenPreparacion>();

            CargarTransportistas();
        }
        public string ValidarTransportista(string dniTransportista)
        {
            if (dniTransportista == null || dniTransportista == "")
            {
                return "Por favor seleccione un transportista valido.";
            }

            return null;
        }
        public void CargarOrdenesPorTransportista(string dniTransportista)
        {
            OrdenesDePreparacion = [];
            var ordenesDeEntregaParaDespacho = OrdenEntregaAlmacen.BuscarOrdenesDeEntregaCumplidas();

            foreach (var ordenEntrega in ordenesDeEntregaParaDespacho)
            {
                foreach (var idOrdenPreparacion in ordenEntrega.IdOrdenPreparacion)
                {
                    var ordenEntidad = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOrdenPreparacion);

                    if (ordenEntidad.DniTransportista.ToString() == dniTransportista && ordenEntidad.Estado != EstadoOrdenPreparacion.Despachada)
                    {
                        var ordenPreparacion = new OrdenPreparacion(ordenEntidad.IdOrdenPreparacion, ordenEntidad.DniTransportista.ToString(), ordenEntidad.Estado, ordenEntrega.IdOrdenEntrega, ordenEntidad.IdCliente);
                        OrdenesDePreparacion.Add(ordenPreparacion);
                    }
                }
            }
        }
        private void CargarTransportistas()
        {
            Transportistas = new List<Transportista>();

            var transportistasConOrdenesParaDespacho = OrdenPreparacionAlmacen.BuscarTransportistasConOrdenesParaDespacho();
            foreach (var dniTransportista in transportistasConOrdenesParaDespacho)
            {
                Transportista transportista = new Transportista(dniTransportista.ToString());
                Transportistas.Add(transportista);
            }
        }
        public void CargarClientesPorTransportista(string dniTransportista)
        {
            Clientes = new List<Cliente>();

            var ordenesPreparadas = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas();

            foreach (var ordenEntidad in ordenesPreparadas)
            {
                if (ordenEntidad.DniTransportista.ToString() == dniTransportista &&
             ordenEntidad.Estado == EstadoOrdenPreparacion.Preparada)
                {
                    var clienteEntidad = ClienteAlmacen.BuscarClientePorId(ordenEntidad.IdCliente);
                    if (clienteEntidad != null && 
                        !Clientes.Any(c => c.Cuit == clienteEntidad.Cuit))
                    {
                        var cliente = new Cliente(clienteEntidad.Cuit, clienteEntidad.RazonSocial);
                        Clientes.Add(cliente);
                    }
                }
            }
        }

        private void ActualizarOrdenDeEntrega(int idOrdenEntrega)
        {
            bool marcarOrdenComoCumplida = true;

            var ordenEntrega = OrdenEntregaAlmacen.BuscarOrdenPorId(idOrdenEntrega);

            foreach (var idOrdenPreparacion in ordenEntrega.IdOrdenPreparacion)
            {
                var ordenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOrdenPreparacion);

                if (ordenPrep.Estado != EstadoOrdenPreparacion.Despachada)
                {
                    marcarOrdenComoCumplida = false;
                }
            }

            if (marcarOrdenComoCumplida)
            {
                ordenEntrega.MarcarComoCumplida();
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

            foreach (var orden in OrdenesDePreparacion)
            {
                var ordenPreparacion = OrdenPreparacionAlmacen.BuscarOrdenesPorId(orden.Id);
                ordenPreparacion.MarcarOpDespachada();
                remito.IDOrdenPreparacion.Add(ordenPreparacion.IdOrdenPreparacion);
                ActualizarOrdenDeEntrega(orden.IdOrdenEntrega);
            }

            RemitoAlmacen.NuevoRemito(remito);
            OrdenesDePreparacion = [];

            return null;
        }
    }
}