using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class ProductoOrdenAlmacen
    {
        private static List<ProductoOrdenEntidad> productosOrden = new List<ProductoOrdenEntidad>()
        {

        };

        public static IReadOnlyList<ProductoOrdenEntidad> ProductosOrden = productosOrden.AsReadOnly();

        public static void AgregarProductoOrden(ProductoOrdenEntidad productoOrden)
        {
            productosOrden.Add(productoOrden);
        }
    }
}
