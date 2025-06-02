using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using static TPGrupoE.CasosDeUso.CU7CargarOrdenDeEntrega.Model.OrdenDeEntregaModelo;


namespace TPGrupoE.CasosDeUso.CU7CargarOrdenDeEntrega.Model
{
    internal partial class OrdenDeEntregaModelo
    {

        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; }

        public OrdenDeEntregaModelo()
        {
            OrdenesDePreparacion = new List<OrdenPreparacion>();

            var ordenesPreparacionPreparadas = OrdenPreparacionAlmacen.BuscarOrdenesPreparadas();

            foreach (var ordenPreparacionPreparada in ordenesPreparacionPreparadas)
            {
                var cliente = ClienteAlmacen.BuscarClientePorId(ordenPreparacionPreparada.IdCliente);
                OrdenPreparacion ordenPreparacion = new OrdenPreparacion(
                    ordenPreparacionPreparada.IdOrdenPreparacion,
                    cliente.Cuit,
                    cliente.RazonSocial,
                    ordenPreparacionPreparada.DniTransportista,
                    ordenPreparacionPreparada.Estado,
                    ordenPreparacionPreparada.FechaEntrega
                    );

                OrdenesDePreparacion.Add(ordenPreparacion);
            }
        }

        public string ValidarOrdenEntrega()
        {
            if (OrdenesDePreparacion.Count == 0)
            {
                return "Debe haber al menos una orden de preparacion para crear una orden de entrega";
            }

            return null;
        }

        public string CrearOrdenEntrega()
        {

            var ordenEntregaACrear = new OrdenEntregaEntidad();

            ordenEntregaACrear.Estado = EstadoOrdenEntrega.Pendiente;
            ordenEntregaACrear.IdOrdenPreparacion = [];

            foreach (var ordenPreparacion in OrdenesDePreparacion)
            {
                OrdenPreparacionEntidad ordenPreparacionEntidad = OrdenPreparacionAlmacen.BuscarOrdenesPorId(ordenPreparacion.IdOrdenPreparacion);
                ordenPreparacionEntidad.MarcarOpPreparada();
                ordenEntregaACrear.IdOrdenPreparacion.Add(ordenPreparacion.IdOrdenPreparacion);
            }

            OrdenesDePreparacion = new List<OrdenPreparacion>();

            var ordenEntrega = OrdenEntregaAlmacen.NuevaOE(ordenEntregaACrear);

            return null;
        }
    }
}
