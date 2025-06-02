using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;


namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model

{
    internal class GestionOrdenSeleccionModel
    {
        public List<OrdenPickingEntidad> OrdenesDeSeleccion { get; private set; }
        // carga json y filtra las órdenes de selección pendientes
        public GestionOrdenSeleccionModel()
        {
            OrdenPickingAlmacen.LeerOS();
            OrdenesDeSeleccion = OrdenPickingAlmacen.BuscarOrdenesPendientes();
        }
        // Crea una nueva orden de selección con los IDs de las órdenes de preparación
        public List<ProductoOrden> ObtenerDetalleProductos(int idOrdenSeleccion)
        {
            var ordenSeleccion = OrdenPickingAlmacen.BuscarOrdenPorId(idOrdenSeleccion);
            var productos = new List<ProductoOrden>();

            foreach (var idOrdenPrep in ordenSeleccion.IdOrdenPreparacion)
            {
                var ordenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOrdenPrep);
                productos.AddRange(ordenPrep.ProductoOrden); // ya trae SKU, tipo, cantidad, etc.
            }

            return productos;
        }
        // Confirma la selección de la orden de picking y actualiza los estados de las órdenes de preparación y el stock físico
        public void ConfirmarSeleccion(int idOrdenSeleccion)
        { // Obtener la orden de picking y cambiar su estado
            var ordenSeleccion = OrdenPickingAlmacen.BuscarOrdenPorId(idOrdenSeleccion);
            if (ordenSeleccion == null) return;
            // Cambiar estado a "Cumplida"
            ordenSeleccion.Estado = EstadoOrdenSeleccion.Cumplida;

            // Iterar sobre cada ID de orden de preparación vinculada
            foreach (var idOrdenPrep in ordenSeleccion.IdOrdenPreparacion)
            {
                var ordenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOrdenPrep);
                if (ordenPrep == null) continue;
                // Marcar la orden de preparación como "Seleccionada"
                ordenPrep.Estado = EstadoOrdenPreparacion.Seleccionada;
                // Descontar stock físico de cada producto
                foreach (var producto in ordenPrep.ProductoOrden)
                {
                    StockFisicoAlmacen.DescontarProductoPorPosicion(
                        producto.IdProducto,
                        ordenPrep.IdCliente,
                        producto.Cantidad);
                }
            }

            // Grabar cambios en archivos
            OrdenPickingAlmacen.GrabarOS();
            OrdenPreparacionAlmacen.GrabarOP();
            StockFisicoAlmacen.GrabarStock();
        }
    }
}