using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal static class OrdenPickingAlmacen
    {
        private static List<OrdenPickingEntidad> ordenesPicking= new List<OrdenPickingEntidad>();

        public static IReadOnlyCollection<OrdenPickingEntidad> OrdenesPicking => ordenesPicking.AsReadOnly();
        public static IReadOnlyCollection<OrdenPickingEntidad> ObtenerTodas()
        {
            return ordenesPicking.AsReadOnly();
        }

        public static void GrabarOS()
        {
            var datosOS = JsonSerializer.Serialize(ordenesPicking);

            File.WriteAllText(@"Datos\ordenPicking.json", datosOS);
        }

        public static void LeerOS()
        {
            if (!File.Exists(@"Datos\ordenPicking.json"))
            {
                return;
            }

            var datosOS = File.ReadAllText(@"Datos\ordenPicking.json");

            ordenesPicking = JsonSerializer.Deserialize<List<OrdenPickingEntidad>>(datosOS)!;
        }

        internal static string? NuevaOS(OrdenPickingEntidad nuevaOrden)
        {
            if (OrdenPickingAlmacen.ordenesPicking.Count == 0)
            {
                nuevaOrden.IdOrdenSeleccion = 1;
            }
            else
            {
                nuevaOrden.IdOrdenSeleccion = OrdenPickingAlmacen.OrdenesPicking.Max(os => os.IdOrdenSeleccion) + 1;
            }


            ordenesPicking.Add(nuevaOrden);
            return null; //sin errores.
        }

        public static List<OrdenPickingEntidad> BuscarOrdenesPendientes()
        {
            return ordenesPicking.FindAll(os => os.Estado == EstadoOrdenSeleccion.Pendiente);
        }

        public static OrdenPickingEntidad BuscarOrdenPorId(int id)
        {
            return ordenesPicking.FirstOrDefault(os => os.IdOrdenSeleccion == id);
        }
    }

}
