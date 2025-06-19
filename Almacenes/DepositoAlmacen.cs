using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal static class DepositosAlmacen
    {
        private static List<DepositoEntidad> depositos = new List<DepositoEntidad>();

        public static IReadOnlyCollection<DepositoEntidad> Depositos => depositos.AsReadOnly();

        public static void GrabarDeposito()
        {
            var datosDeposito = JsonSerializer.Serialize(depositos, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\depositos.json", datosDeposito);
        }

        static DepositosAlmacen()
        {
            if (!File.Exists(@"Datos\depositos.json"))
            {
                return;
            }

            var datosDeposito = File.ReadAllText(@"Datos\depositos.json");

            depositos = JsonSerializer.Deserialize<List<DepositoEntidad>>(datosDeposito)!;
        }

        public static DepositoEntidad BuscarDepositoPorId(int id)
        {
            return depositos.FirstOrDefault(c => c.IdDeposito == id);
        }
    }
}
