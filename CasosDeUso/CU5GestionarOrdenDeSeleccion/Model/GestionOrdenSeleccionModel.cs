using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model
{
    public class GestionOrdenSeleccionModel
    {
        public List<OrdenSeleccionEntidad> OrdenesPendientes { get; private set; }
        public List<OrdenSeleccionEntidad> OrdenesSeleccionadas { get; private set; }
        public List<DetalleOrdenSeleccion> DetalleMercaderia { get; private set; }

        public GestionOrdenSeleccionModel()
        {
            OrdenesPendientes = OrdenSeleccionAlmacen.ObtenerOrdenesPendientes();
            OrdenesSeleccionadas = new List<OrdenSeleccionEntidad>();
            DetalleMercaderia = new List<DetalleOrdenSeleccion>();
        }

        // Carga el detalle de productos de las órdenes seleccionadas
        public void CargarDetalleMercaderia()
        {
            DetalleMercaderia.Clear();
            foreach (var orden in OrdenesSeleccionadas)
            {
                var detalles = OrdenPreparacionAlmacen.ObtenerDetallesPorOrden(orden.IDsOrdenesPreparacion);
                DetalleMercaderia.AddRange(detalles);
            }
        }

        // Confirma la selección y actualiza estados
        public bool ConfirmarSeleccion(string usuario)
        {
            try
            {
                // 1. Validar stock antes de confirmar
                if (!StockAlmacen.ValidarStock(DetalleMercaderia))
                    return false;

                // 2. Actualizar estados
                foreach (var orden in OrdenesSeleccionadas)
                {
                    orden.Estado = EstadoOrdenSeleccion.Cumplida;
                    orden.FechaConfirmacion = DateTime.Now;
                    orden.UsuarioConfirmacion = usuario;
                    OrdenSeleccionAlmacen.Actualizar(orden);

                    // 3. Actualizar órdenes de preparación
                    foreach (var id in orden.IDsOrdenesPreparacion)
                    {
                        var op = OrdenPreparacionAlmacen.ObtenerOrdenPorId(id);
                        op.Estado = EstadoOrdenPreparacion.Seleccionada;
                        OrdenPreparacionAlmacen.Actualizar(op);
                    }
                }

                // 4. Dar de baja el stock (FIFO)
                StockAlmacen.DarBajaStock(DetalleMercaderia);

                return true;
            }
            catch (Exception ex)
            {
                // Loggear error
                return false;
            }
        }
    }

}

