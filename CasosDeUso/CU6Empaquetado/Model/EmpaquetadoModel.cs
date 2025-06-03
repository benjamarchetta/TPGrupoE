using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model;
//using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Model
{

    internal partial class EmpaquetadoModel
    {
        public List<OrdenDePreparacionAEmpaquetar> OrdenesDePreparacionAEmpaquetar { get; private set; }

        private List<Producto> ProductosIniciales = new List<Producto>();

        public EmpaquetadoModel()
        {
            ProductosIniciales = new List<Producto>();
            OrdenesDePreparacionAEmpaquetar = new List<OrdenDePreparacionAEmpaquetar>();
            var ordenesDePreparacionSeleccionadas = OrdenPreparacionAlmacen.BuscarOrdenesSeleccionadas();

            foreach (var ordenPreparacion in ordenesDePreparacionSeleccionadas)
            {
                OrdenDePreparacionAEmpaquetar ordenDePreparacionAEmpaquetar = new OrdenDePreparacionAEmpaquetar();
                //ordenDePreparacionAEmpaquetar.Producto = [];
                //ordenDePreparacionAEmpaquetar.Id = ordenPreparacion.IdOrdenPreparacion.ToString();

                foreach (var productoOrden in ordenPreparacion.ProductoOrden)
                {

                    //StockFisicoEntidad stock = StockFisicoAlmacen.ObtenerStockPorId(productoOrden.IdProducto);
                    ProductoEntidad producto = ProductoAlmacen.BuscarProductoPorId(productoOrden.IdProducto);
                    //Producto productoAAgregar = new Producto();
                    //productoAAgregar.IdProducto = stock.IdProducto.ToString();
                    //productoAAgregar.Cantidad = productoOrden.Cantidad;
                    //productoAAgregar.DescripcionProducto = producto.DescripcionProducto;
                    //ordenDePreparacionAEmpaquetar.Productos.Add(productoAAgregar);
                }

                OrdenesDePreparacionAEmpaquetar.Add(ordenDePreparacionAEmpaquetar);

            }
        }

        public void MarcarOrdenComoEmpaquetada(OrdenDePreparacionAEmpaquetar orden)
        {
            if (orden == null)
            {
                return;
            }

            //var ordenPreparacion = OrdenPreparacionAlmacen.BuscarOrdenesPorId(int.Parse(orden.IdPreparacion));

            //ordenPreparacion.MarcarOpEmpaquetada();

            OrdenesDePreparacionAEmpaquetar.Remove(orden);
        }

    }
}
