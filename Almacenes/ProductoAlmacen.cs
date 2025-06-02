using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class ProductoAlmacen
    {
        private static List<ProductoEntidad> productos = new List<ProductoEntidad>()
        {
            new ProductoEntidad { IdProducto = 1, Sku = "PROD001", DescripcionProducto = "Teclados mecánicos"},
            new ProductoEntidad { IdProducto = 2, Sku = "PROD002", DescripcionProducto = "Mouse inalámbricos"},
            new ProductoEntidad { IdProducto = 3,  Sku = "PROD003", DescripcionProducto = "Taladros profesionales"},
            new ProductoEntidad { IdProducto = 4,  Sku = "PROD004", DescripcionProducto = "Juegos de llaves"},
    /*
            // Cliente 27-45678901-3 (2 productos)
            new ProductoEntidad { Id = 5, CuitCliente = "27-45678901-3", sku = "PROD005", TipoProducto = "Ferretería", CantidadEnStock = 500, DescripcionMercaderia = "Tornillos galvanizados", Ubicacion = "C3-15" },
            new ProductoEntidad { Id = 6, CuitCliente = "27-45678901-3", sku = "PROD006", TipoProducto = "Ferretería", CantidadEnStock = 120, DescripcionMercaderia = "Bisagras de acero", Ubicacion = "C3-16" },
    
            // Cliente 20-34567890-2 (3 productos)
            new ProductoEntidad { Id = 7, CuitCliente = "20-34567890-2", sku = "PROD007", TipoProducto = "Materiales", CantidadEnStock = 600, DescripcionMercaderia = "Ladrillos huecos", Ubicacion = "D4-20" },
            new ProductoEntidad { Id = 8, CuitCliente = "20-34567890-2", sku = "PROD008", TipoProducto = "Materiales", CantidadEnStock = 300, DescripcionMercaderia = "Bolsas de cemento", Ubicacion = "D4-21" },
            new ProductoEntidad { Id = 9, CuitCliente = "20-34567890-2", sku = "PROD009", TipoProducto = "Materiales", CantidadEnStock = 150, DescripcionMercaderia = "Chapas acanaladas", Ubicacion = "D4-22" },
    
            // Cliente 23-56789012-4 (2 productos)
            new ProductoEntidad { Id = 10, CuitCliente = "23-56789012-4", sku = "PROD010", TipoProducto = "Textil", CantidadEnStock = 400, DescripcionMercaderia = "Telas de algodón", Ubicacion = "E5-30" },
            new ProductoEntidad { Id = 11, CuitCliente = "23-56789012-4", sku = "PROD011", TipoProducto = "Textil", CantidadEnStock = 250, DescripcionMercaderia = "Hilos industriales", Ubicacion = "E5-31" },
    
            // Cliente 24-78901234-5 (3 productos)
            new ProductoEntidad { Id = 12, CuitCliente = "24-78901234-5", sku = "PROD012", TipoProducto = "Muebles", CantidadEnStock = 100, DescripcionMercaderia = "Mesas de oficina", Ubicacion = "F6-40" },
            new ProductoEntidad { Id = 13, CuitCliente = "24-78901234-5", sku = "PROD013", TipoProducto = "Muebles", CantidadEnStock = 75, DescripcionMercaderia = "Sillas ergonómicas", Ubicacion = "F6-41" },
            new ProductoEntidad { Id = 14, CuitCliente = "24-78901234-5", sku = "PROD014", TipoProducto = "Muebles", CantidadEnStock = 50, DescripcionMercaderia = "Estanterías metálicas", Ubicacion = "F6-42" },
    
            // Cliente 30-23456789-0 (2 productos)
            new ProductoEntidad { Id = 15, CuitCliente = "30-23456789-0", sku = "PROD015", TipoProducto = "Iluminación", CantidadEnStock = 180, DescripcionMercaderia = "Lámparas LED", Ubicacion = "G7-50" },
            new ProductoEntidad { Id = 16, CuitCliente = "30-23456789-0", sku = "PROD016", TipoProducto = "Iluminación", CantidadEnStock = 220, DescripcionMercaderia = "Tubos fluorescentes", Ubicacion = "G7-51" },
    
            // Cliente 33-89012345-6 (2 productos)
            new ProductoEntidad { Id = 17, CuitCliente = "33-89012345-6", sku = "PROD017", TipoProducto = "Automotriz", CantidadEnStock = 90, DescripcionMercaderia = "Neumáticos", Ubicacion = "H8-60" },
            new ProductoEntidad { Id = 18, CuitCliente = "33-89012345-6", sku = "PROD018", TipoProducto = "Automotriz", CantidadEnStock = 120, DescripcionMercaderia = "Baterías", Ubicacion = "H8-61" },
    
            // Cliente 27-67890123-7 (2 productos)
            new ProductoEntidad { Id = 19, CuitCliente = "27-67890123-7", sku = "PROD019", TipoProducto = "Papelería", CantidadEnStock = 300, DescripcionMercaderia = "Resmas de papel", Ubicacion = "I9-70" },
            new ProductoEntidad { Id = 20, CuitCliente = "27-67890123-7", sku = "PROD020", TipoProducto = "Papelería", CantidadEnStock = 500, DescripcionMercaderia = "Cajas de folios", Ubicacion = "I9-71" }
    
            // Cliente 20-90123456-8 (0 productos)
    */
        };

        public static IReadOnlyList<ProductoEntidad> Productos = productos.AsReadOnly();
    }
}
