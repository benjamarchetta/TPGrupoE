using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.Almacenes
{
    internal static class RemitoAlmacen
    {
        private static List<RemitoEntidad> remitos = new List<RemitoEntidad>();

        public static IReadOnlyCollection<RemitoEntidad> Remitos => remitos.AsReadOnly();

        public static void GrabarRemito()
        {
            var datosRemito = JsonSerializer.Serialize(remitos, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(@"Datos\remitos.json", datosRemito);
        }

        static RemitoAlmacen()
        {
            if (!File.Exists(@"Datos\remitos.json"))
            {
                return;
            }

            var datosRemito = File.ReadAllText(@"Datos\remitos.json");

            remitos = JsonSerializer.Deserialize<List<RemitoEntidad>>(datosRemito)!;
        }

        internal static string NuevoRemito(RemitoEntidad nuevoRemito)
        {
            if (RemitoAlmacen.remitos.Count == 0)
            {
                nuevoRemito.IdRemito = 1;
            }
            else
            {
                nuevoRemito.IdRemito = RemitoAlmacen.Remitos.Max(o => o.IdRemito) + 1;
            }

            nuevoRemito.FechaEmision = DateTime.Now;
            remitos.Add(nuevoRemito);
            return null; //sin errores.
        }
    }
}
