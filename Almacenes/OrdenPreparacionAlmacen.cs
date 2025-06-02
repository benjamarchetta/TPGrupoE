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
            new OrdenPreparacionEntidad { Id = 1001, CuitCliente = "30-12345678-9", Estado = "Pendiente", FechaDespacho = DateTime.Now.AddDays(5), PalletCerrado = false, productosOrden = new List<ProductoOrdenEntidad> { new ProductoOrdenEntidad { sku = "PROD001", TipoProducto = "x", Cantidad = 50 } } },
            new OrdenPreparacionEntidad { Id = 1002, CuitCliente = "33-98765432-1", Estado = "Pendiente", FechaDespacho = DateTime.Now.AddDays(4), PalletCerrado = false, productosOrden = new List<ProductoOrdenEntidad> { new ProductoOrdenEntidad { sku = "PROD003", TipoProducto = "y", Cantidad = 100 } } },
            new OrdenPreparacionEntidad { Id = 1003, CuitCliente = "27-45678901-3", Estado = "Pendiente", FechaDespacho = DateTime.Now.AddDays(1), PalletCerrado = false, productosOrden = new List<ProductoOrdenEntidad> { new ProductoOrdenEntidad { sku = "PROD002", TipoProducto = "g", Cantidad = 75 } } } 
        };

        public static IReadOnlyList<OrdenPreparacionEntidad> OrdenesDePreparacion = ordenesDePreparacion.AsReadOnly();

        public static void AgregarOrdenDePreparacion (OrdenPreparacionEntidad ordenPreparacion)
        {
            ordenesDePreparacion.Add(ordenPreparacion);
        }
    }
}
