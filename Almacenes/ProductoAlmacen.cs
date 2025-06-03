using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal static class ProductoAlmacen
    {
        private static List<ProductoEntidad> productos = new List<ProductoEntidad>();

        public static IReadOnlyCollection<ProductoEntidad> Productos => productos.AsReadOnly();

        public static void GrabarProducto()
        {
            var datosProducto = JsonSerializer.Serialize(productos);

            File.WriteAllText(@"Datos\productos.json", datosProducto);
        }

        public static void LeerProducto()
        {
            if (!File.Exists(@"Datos\productos.json"))
            {
                return;
            }

            var datosProducto = File.ReadAllText(@"Datos\productos.json");

            productos = JsonSerializer.Deserialize<List<ProductoEntidad>>(datosProducto)!;
        }

        public static ProductoEntidad BuscarProductoPorId(int id)
        {
            return productos.FirstOrDefault(p => p.IdProducto == id);
        }

    }
}
