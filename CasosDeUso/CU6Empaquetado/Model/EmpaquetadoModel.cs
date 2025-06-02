using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using TPGrupoE.CasoU_EmpaquetadoOrdenes;
using TPGrupoE.CasoU_Orden_Preparacion;
using TPGrupoE_CU_OrdenPreparacion_Model;

namespace TPGrupoE.CasoU_Empaquetado
{

    internal class EmpaquetadoModel
    {
        public List<OrdenDePreparacionAEmpaquetar> OrdenesDePreparacionAEmpaquetar { get; private set; }

        private List<Almacenes.ProductoAlmacen> ProductosIniciales = new List<Almacenes.ProductoAlmacen>();

        public EmpaquetadoModel()
        {
            ProductosIniciales = new List<Almacenes.ProductoAlmacen>();
            OrdenesDePreparacionAEmpaquetar = new List<OrdenDePreparacionAEmpaquetar>();
            var ordenesDePreparacionSeleccionadas = OrdenPreparacionAlmacen.ObtenerOrdenesSeleccionadas();

            foreach (var ordenPreparacion in ordenesDePreparacionSeleccionadas)
            {
                OrdenDePreparacionAEmpaquetar ordenDePreparacionAEmpaquetar = new OrdenDePreparacionAEmpaquetar();
                ordenDePreparacionAEmpaquetar.Producto = new List<CasoU_EmpaquetadoOrdenes.ProductoAlmacen>(); 

                ordenDePreparacionAEmpaquetar.Id = ordenPreparacion.IdOrdenPreparacion.ToString();

                foreach (var productoOrden in ordenPreparacion.ProductoOrden)
                {
                    CasoU_EmpaquetadoOrdenes.ProductoAlmacen productoAAgregar = new CasoU_EmpaquetadoOrdenes.ProductoAlmacen();

                    ProductoEntidad producto = Almacenes.ProductoAlmacen.BuscarProductoPorId(productoOrden.IdProducto);

                    productoAAgregar.IdProducto = producto.IdProducto.ToString();
                    productoAAgregar.DescripcionProducto = ProductoOrden.DescripcionProducto;
                    productoAAgregar.Cantidad = productoOrden.Cantidad;

                    ordenDePreparacionAEmpaquetar.Producto.Add(productoAAgregar);
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

            var ordenPreparacion = OrdenPreparacionAlmacen.ObtenerOrdenPorId(int.Parse(orden.Id));

            ordenPreparacion.MarcarComoPreparada();

            OrdenesDePreparacionAEmpaquetar.Remove(orden);
        }
    }
}
