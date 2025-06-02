using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal static class StockFisicoAlmacen
    {
        private static List<StockFisicoEntidad> stock = new List<StockFisicoEntidad>();

        public static IReadOnlyCollection<StockFisicoEntidad> Stock => stock.AsReadOnly();

        public static void GrabarStock()
        {
            var datosStock = JsonSerializer.Serialize(stock);

            File.WriteAllText(@"Datos\stockFisico.json", datosStock);
        }

        public static void LeerStock()
        {
            if (!File.Exists(@"Datos\stockFisico.json"))
            {
                return;
            }

            var datosStock = File.ReadAllText(@"Datos\stockFisico.json");

            stock = JsonSerializer.Deserialize<List<StockFisicoEntidad>>(datosStock)!;
        }

        public static StockFisicoEntidad ObtenerStockPorId(int idProducto, int idCliente)
        {
            return stock.FirstOrDefault(pc => pc.IdProducto == idProducto && pc.IdCliente == idCliente);
        }

    }

}
