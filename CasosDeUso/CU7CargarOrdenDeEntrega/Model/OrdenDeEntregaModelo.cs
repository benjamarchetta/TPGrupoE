using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model;


namespace TPGrupoE.CasosDeUso.CU7CargarOrdenDeEntrega.Model
{
    internal partial class OrdenDeEntregaModelo
    {

        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; }

        public OrdenDeEntregaModelo()
        {

            OrdenesDePreparacion = new List<OrdenPreparacion>();

            var ordenesPreparacionEmpaquetadas = OrdenPreparacionAlmacen.BuscarOrdenesEmpaquetadas();

            foreach (var ordenPreparacionEmpaquetada in ordenesPreparacionEmpaquetadas)
            {
                var cliente = ClienteAlmacen.BuscarClientePorId(ordenPreparacionEmpaquetada.IdCliente);
                OrdenPreparacion ordenPreparacion = new OrdenPreparacion(
                    ordenPreparacionEmpaquetada.IdOrdenPreparacion,
                    cliente.Cuit,
                    cliente.RazonSocial,
                    ordenPreparacionEmpaquetada.DniTransportista,
                    ordenPreparacionEmpaquetada.Estado,
                    ordenPreparacionEmpaquetada.FechaEntrega
                    );

                OrdenesDePreparacion.Add(ordenPreparacion);
            }
        }

        public string ValidarOrdenEntrega()
        {
            if (OrdenesDePreparacion.Count == 0)
            {
                return "No hay ninguna orden empaquetada para liberar al Sector Despacho";
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
