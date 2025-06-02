using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class ProductoOrdenAlmacen
    {
        private static List<ProductoOrden> productosOrden = new List<ProductoOrden>()
        {

        };

        public static IReadOnlyList<ProductoOrden> ProductosOrden = productosOrden.AsReadOnly();

        public static void AgregarProductoOrden(ProductoOrden productoOrden)
        {
            productosOrden.Add(productoOrden);
        }
    }
}
