using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.ProductosOP;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Model
{

    internal partial class EmpaquetadoModel
    {
        public List<OrdenDePreparacionAEmpaquetar> OrdenesDePreparacionAEmpaquetar { get; private set; }

        private List<ProductoOP> ProductosIniciales = new List<ProductoOP>();
        public List<OrdenPreparacion> OrdenesDePreparacion { get; private set; }

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
        public string CrearOrdenEntrega(OrdenDePreparacionAEmpaquetar ordenDePreparacionAEmpaquetar)
        {

            int idOp = int.Parse(ordenDePreparacionAEmpaquetar.IdOrdenPreparacion);

            // Marcar como empaquetada
            MarcarOrdenComoEmpaquetada(ordenDePreparacionAEmpaquetar);

            // Crear OE solo para esta OP
            var ordenEntregaACrear = new OrdenEntregaEntidad
            {
                Estado = EstadoOrdenEntrega.Pendiente,
                IdOrdenPreparacion = new List<int> { idOp }
            };

            OrdenEntregaAlmacen.NuevaOE(ordenEntregaACrear);

            // Mostrar todo en un solo mensaje
            MessageBox.Show(
                $"¡Listo! Empaquetaste la órden de preparación Nº {ordenDePreparacionAEmpaquetar.IdOrdenPreparacion}.\n" +
                $"\nSe creó la Orden de Entrega Nº {ordenEntregaACrear.IdOrdenEntrega} para su despacho correctamente.",
                "Empaquetado confirmado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            return null;
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
