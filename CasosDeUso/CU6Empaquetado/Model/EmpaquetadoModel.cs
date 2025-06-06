using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.ProductosOP;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Model
{

    internal partial class EmpaquetadoModel
    {
        public List<OrdenDePreparacionAEmpaquetar> OrdenesDePreparacionAEmpaquetar { get; private set; }

        private List<ProductoOP> ProductosIniciales = new List<ProductoOP>();

        public EmpaquetadoModel()
        {
            ProductosIniciales = new List<ProductoOP>();
            OrdenesDePreparacionAEmpaquetar = new List<OrdenDePreparacionAEmpaquetar>();
            var ordenesDePreparacionSeleccionadas = OrdenPreparacionAlmacen.BuscarOrdenesSeleccionadas();

            foreach (var ordenPreparacion in ordenesDePreparacionSeleccionadas)
            {
                OrdenDePreparacionAEmpaquetar ordenDePreparacionAEmpaquetar = new OrdenDePreparacionAEmpaquetar();
                ordenDePreparacionAEmpaquetar.ProductosOP = [];
                ordenDePreparacionAEmpaquetar.IdOrdenPreparacion = ordenPreparacion.IdOrdenPreparacion.ToString();

                foreach (var productoOrden in ordenPreparacion.ProductoOrden)
                {

                    StockFisicoEntidad stock = StockFisicoAlmacen.ObtenerStockPorId(productoOrden.IdProducto);
                    ProductoEntidad producto = ProductoAlmacen.BuscarProductoPorId(productoOrden.IdProducto);
                    ProductoOP productoAAgregar = new ProductoOP();
                    productoAAgregar.Id = stock.IdProducto.ToString();
                    productoAAgregar.Cantidad = productoOrden.Cantidad;
                    productoAAgregar.Descripcion = producto.DescripcionProducto;
                    ordenDePreparacionAEmpaquetar.ProductosOP.Add(productoAAgregar);
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

            var ordenPreparacion = OrdenPreparacionAlmacen.BuscarOrdenesPorId(int.Parse(orden.IdOrdenPreparacion));

            ordenPreparacion.MarcarOpEmpaquetada();

            OrdenesDePreparacionAEmpaquetar.Remove(orden);
        }

    }
}
