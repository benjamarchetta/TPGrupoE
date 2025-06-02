using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.Almacenes
{
    internal class RemitoAlmacen
    {

        private static List<RemitoEntidad> remitos = new List<RemitoEntidad>();

        public static IReadOnlyList<RemitoEntidad> Remitos => remitos.AsReadOnly();

        public static void Grabar()
        {
            var datos = JsonSerializer.Serialize(remitos);
            File.WriteAllText("remitos.json", datos);
        }

        public static void Leer()
        {
            if (!File.Exists("remitos.json"))
                return;

            var datos = File.ReadAllText("remitos.json");
            remitos = JsonSerializer.Deserialize<List<RemitoEntidad>>(datos) ?? new List<RemitoEntidad>();
        }
    }
}