using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenPreparacionAlmacen
    {
        private static List<OrdenPreparacionEntidad> ordenesDePreparacion = new List<OrdenPreparacionEntidad>

        {
            /*
            new OrdenPreparacionEntidad { IdOrdenPreparacion = 1001, IdCliente = 1, Estado = EstadoOrdenPreparacion.Pendiente, FechaEntrega = DateTime.Now.AddDays(5), PalletCerrado = false, productosOrden = new List<ProductoOrden> { new ProductoOrden { sku = "PROD001", TipoProducto = "x", Cantidad = 50 } } },
            new OrdenPreparacionEntidad { IdOrdenPreparacion = 1002, IdCliente = 2, Estado = EstadoOrdenPreparacion.Pendiente, FechaEntrega = DateTime.Now.AddDays(4), PalletCerrado = false, productosOrden = new List<ProductoOrden> { new ProductoOrden { sku = "PROD003", TipoProducto = "y", Cantidad = 100 } } },
            new OrdenPreparacionEntidad { IdOrdenPreparacion = 1003, IdCliente = 3, Estado = EstadoOrdenPreparacion.Pendiente, FechaEntrega = DateTime.Now.AddDays(1), PalletCerrado = false, productosOrden = new List<ProductoOrden> { new ProductoOrden { sku = "PROD002", TipoProducto = "g", Cantidad = 75 } } } 
       */
        };

        public static IReadOnlyList<OrdenPreparacionEntidad> OrdenesDePreparacion = ordenesDePreparacion.AsReadOnly();
    }
}
