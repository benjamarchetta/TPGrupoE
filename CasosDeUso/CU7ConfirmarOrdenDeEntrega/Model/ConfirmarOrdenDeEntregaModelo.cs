using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;
using TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model;
using TPGrupoE.CasosDeUso.CU6Empaquetado.Model;


namespace TPGrupoE.CasosDeUso.CU7ConfirmarOrdenDeEntrega.Model
{
    internal partial class ConfirmarOrdenDeEntregaModelo
    {
        public List<OrdenDePreparacionADespachar> OrdenesDePreparacion { get; private set; }

        public ConfirmarOrdenDeEntregaModelo()
        {
            OrdenesDePreparacion = new List<OrdenDePreparacionADespachar>();

            var ordenesPreparacionEmpaquetadas = OrdenPreparacionAlmacen.BuscarOrdenesEmpaquetadas();

            foreach (var ordenPreparacion in ordenesPreparacionEmpaquetadas)
            {
                OrdenDePreparacionADespachar ordenADespachar = new OrdenDePreparacionADespachar();
                ordenADespachar.IdOrdenPreparacion = ordenPreparacion.IdOrdenPreparacion;
                ordenADespachar.FechaEntrega = ordenPreparacion.FechaEntrega;
                ordenADespachar.ProductosOP = new List<ProductoOP>();

                foreach (var productoOrden in ordenPreparacion.ProductoOrden)
                {
                    ProductoEntidad producto = ProductoAlmacen.BuscarProductoPorId(productoOrden.IdProducto);

                    ProductoOP productoOP = new ProductoOP
                    {
                        Id = productoOrden.IdProducto.ToString(),
                        Cantidad = productoOrden.Cantidad,
                        Descripcion = producto?.DescripcionProducto ?? "Sin descripción"
                    };

                    ordenADespachar.ProductosOP.Add(productoOP);
                }

                var ordenEntrega = OrdenEntregaAlmacen.BuscarOrdenQueContieneOp(ordenPreparacion.IdOrdenPreparacion);
                ordenADespachar.IdOrdenEntrega = ordenEntrega?.IdOrdenEntrega ?? -1;

                OrdenesDePreparacion.Add(ordenADespachar);
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

        public void MarcarComoPreparada(OrdenPreparacionEntidad orden)
        {
            if (orden == null) return;

            orden.MarcarOpPreparada();
        }

        public void ConfirmarOrdenEntrega()
        {
            foreach (var ordenADespachar in OrdenesDePreparacion)
            {
                var entidad = OrdenPreparacionAlmacen.BuscarOrdenesPorId(ordenADespachar.IdOrdenPreparacion);
                if (entidad == null) continue;

                MarcarComoPreparada(entidad);

                var ordenEntrega = OrdenEntregaAlmacen.BuscarOrdenQueContieneOp(ordenADespachar.IdOrdenPreparacion);
                if (ordenEntrega == null) continue;

                bool todasPreparadas = ordenEntrega.IdOrdenPreparacion
                    .All(id => OrdenPreparacionAlmacen.BuscarOrdenesPorId(id).Estado == EstadoOrdenPreparacion.Preparada);

                if (todasPreparadas)
                {
                    ordenEntrega.MarcarComoCumplida();
                }
            }

            OrdenEntregaAlmacen.GrabarOE();
            OrdenPreparacionAlmacen.GrabarOP();
        }
    }
}
