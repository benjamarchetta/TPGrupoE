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
       
        
       /* 
        public static List<OrdenPickingEntidad> Ordenes
        {
            get
            {
                var Ordenes = new List<OrdenPickingEntidad>();
                foreach (var Orden in OrdenPickingAlmacen.OrdenesPicking)
                {
                    Ordenes.Add(new OrdenPickingEntidad
                    {     
                      
                        IdOrdenSeleccion = Orden.IdOrdenSeleccion,
                        EstadoOrdenSeleccion=Orden.EstadoOrdenSeleccion,
                        IdOrdenPreparacion=Orden.IdOrdenPreparacion,
                     
                    });
                }
                return Ordenes;
            }
        }
       */
        public GestionOrdenSeleccionModel()
        {
            OrdenPickingAlmacen.LeerOS();
            OrdenPreparacionAlmacen.LeerOP();
            StockFisicoAlmacen.LeerStock();

            // Filtra órdenes de selección pendientes
            OrdenesDeSeleccion = OrdenPickingAlmacen
                .BuscarOrdenesPendientes()
                .ToList();

            // Mensaje para mostrar cuántas se cargaron
            MessageBox.Show($"Se encontraron {OrdenesDeSeleccion.Count} órdenes de selección pendientes.");
        }

        // Devuelve el detalle de productos de una orden de selección
        public List<ProductoOrden> ObtenerDetalleProductos(int idOrdenSeleccion)
        {
            var ordenSeleccion = OrdenPickingAlmacen.BuscarOrdenPorId(idOrdenSeleccion);
            var productos = new List<ProductoOrden>();

            if (ordenSeleccion == null) return productos;

            foreach (var idOrdenPrep in ordenSeleccion.IdOrdenPreparacion)
            {
                var ordenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOrdenPrep);
                if (ordenPrep != null)
                {
                    productos.AddRange(ordenPrep.ProductoOrden);
                }
            }

            return productos;
        }

        // Confirma una orden de selección, actualiza estados y descuenta stock
        public void ConfirmarSeleccion(int idOrdenSeleccion)
        {
            var ordenSeleccion = OrdenPickingAlmacen.BuscarOrdenPorId(idOrdenSeleccion);
            if (ordenSeleccion == null) return;

            // Cambiar estado a "Cumplida"
            ordenSeleccion.Estado = EstadoOrdenSeleccion.Cumplida;

            foreach (var idOrdenPrep in ordenSeleccion.IdOrdenPreparacion)
            {
                var ordenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOrdenPrep);
                if (ordenPrep == null) continue;

                ordenPrep.Estado = EstadoOrdenPreparacion.Seleccionada;

                foreach (var producto in ordenPrep.ProductoOrden)
                {
                    StockFisicoAlmacen.DescontarProductoPorPosicion(
                        producto.IdProducto,
                        ordenPrep.IdCliente,
                        producto.Cantidad);
                }
            }

            // Guardar los cambios en los archivos
            OrdenPickingAlmacen.GrabarOS();
            OrdenPreparacionAlmacen.GrabarOP();
            StockFisicoAlmacen.GrabarStock();

            // Volver a leer los datos actualizados
            OrdenPreparacionAlmacen.LeerOP();
            StockFisicoAlmacen.LeerStock();

            // Actualizar lista de pendientes en memoria
            OrdenesDeSeleccion = OrdenPickingAlmacen
                .BuscarOrdenesPendientes()
                
                .ToList();
        }
    }






}