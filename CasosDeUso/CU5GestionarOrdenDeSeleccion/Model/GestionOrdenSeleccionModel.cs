using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;


namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model
{
    internal class GestionOrdenSeleccionModel
    {
        public List<OrdenSeleccionDTO> OrdenesDeSeleccion { get; private set; }

        public GestionOrdenSeleccionModel()
        {
            CargarOrdenesPendientes();
        }

        private void CargarOrdenesPendientes()
        {
            var ordenes = OrdenPickingAlmacen.BuscarOrdenesPendientes();
            OrdenesDeSeleccion = new List<OrdenSeleccionDTO>();

            foreach (var orden in ordenes)
            {
                string clienteNombre = "N/A";
                DateTime? fechaMasProxima = null;

                foreach (var idOp in orden.IdOrdenPreparacion)
                {
                    var op = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOp);
                    if (op == null) continue;

                    var cliente = ClienteAlmacen.BuscarClientePorId(op.IdCliente);
                    if (cliente != null)
                        clienteNombre = cliente.RazonSocial;

                    if (fechaMasProxima == null || op.FechaEntrega < fechaMasProxima)
                        fechaMasProxima = op.FechaEntrega;
                }

                OrdenesDeSeleccion.Add(new OrdenSeleccionDTO
                {
                    IdOrdenSeleccion = orden.IdOrdenSeleccion,
                    Cliente = clienteNombre,
                    Estado = orden.Estado.ToString(),
                    FechaDespacho = fechaMasProxima?.ToString("dd/MM/yyyy") ?? "Sin fecha"
                });
            }
        }

        public List<ProductoDetalleDTO> ObtenerDetalleProductos(int idOrdenSeleccion)
        {
            var ordenSeleccion = OrdenPickingAlmacen.BuscarOrdenPorId(idOrdenSeleccion);
            var lista = new List<ProductoDetalleDTO>();

            if (ordenSeleccion == null) return lista;

            foreach (var idOrdenPrep in ordenSeleccion.IdOrdenPreparacion)
            {
                var ordenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOrdenPrep);
                if (ordenPrep == null) continue;

                foreach (var producto in ordenPrep.ProductoOrden)
                {
                    var productoEntidad = ProductoAlmacen.BuscarProductoPorId(producto.IdProducto);
                    var stock = StockFisicoAlmacen.ObtenerStockPorId(producto.IdProducto);

                    string ubicacion = "Sin ubicación";
                    if (stock != null && stock.Posiciones.Any())
                    {
                        ubicacion = string.Join(", ", stock.Posiciones.Select(p => $"{p.Posicion} (Cantidad: {p.Cantidad})"));
                    }

                    lista.Add(new ProductoDetalleDTO
                    {
                        Sku = productoEntidad?.Sku ?? "N/A",
                        Descripcion = productoEntidad?.DescripcionProducto ?? "Sin descripción",
                        Cantidad = producto.Cantidad,
                        PalletCerrado = producto.PalletCerrado ? "Sí" : "No",
                        Ubicacion = ubicacion
                    });
                }
            }

            return lista;
        }

        public void ConfirmarSeleccion(int idOrdenSeleccion)
        {
            var ordenSeleccion = OrdenPickingAlmacen.BuscarOrdenPorId(idOrdenSeleccion);
            if (ordenSeleccion == null) return;

            ordenSeleccion.Estado = EstadoOrdenSeleccion.Cumplida;

            foreach (var idOrdenPrep in ordenSeleccion.IdOrdenPreparacion)
            {
                var ordenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOrdenPrep);
                if (ordenPrep == null) continue;

                ordenPrep.MarcarOpSeleccionada();

                foreach (var producto in ordenPrep.ProductoOrden)
                {
                    StockFisicoAlmacen.DescontarProductoPorPosicion(
                        producto.IdProducto,
                        ordenPrep.IdCliente,
                        producto.Cantidad);
                }

                OrdenPreparacionAlmacen.ActualizarOrdenPreparacion(ordenPrep);
            }

            OrdenPickingAlmacen.GrabarOS();
            OrdenPreparacionAlmacen.GrabarOP();
            StockFisicoAlmacen.GrabarStock();

            CargarOrdenesPendientes(); // Recarga la lista actualizada
        }
    }
}
