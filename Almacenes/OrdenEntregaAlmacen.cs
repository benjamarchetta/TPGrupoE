using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model;

namespace TPGrupoE.Almacenes
{
    internal static class OrdenEntregaAlmacen
    {
        private static List<OrdenEntregaEntidad> ordenesEntrega = new List<OrdenEntregaEntidad>();

        public static IReadOnlyCollection<OrdenEntregaEntidad> OrdenesEntrega => ordenesEntrega.AsReadOnly();

        public static void GrabarOE()
        {
            var datosOE = JsonSerializer.Serialize(ordenesEntrega, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(@"Datos\ordenesEntrega.json", datosOE);
        }

        static OrdenEntregaAlmacen()
        {
            if (!File.Exists(@"Datos\ordenesEntrega.json"))
            {
                return;
            }

            var datosOE = File.ReadAllText(@"Datos\ordenesEntrega.json");

            ordenesEntrega = JsonSerializer.Deserialize<List<OrdenEntregaEntidad>>(datosOE)!;
        }

        internal static string NuevaOE(OrdenEntregaEntidad nuevaOrden)
        {
            if (OrdenEntregaAlmacen.ordenesEntrega.Count == 0)
            {
                nuevaOrden.IdOrdenEntrega = 1;
            }
            else
            {
                nuevaOrden.IdOrdenEntrega = OrdenEntregaAlmacen.OrdenesEntrega.Max(oe => oe.IdOrdenEntrega) + 1;
            }


            ordenesEntrega.Add(nuevaOrden);
            return null; //sin errores.
        }

        public static List<OrdenEntregaEntidad> BuscarOrdenesParaDespachar()
        {
            return ordenesEntrega.FindAll(o => o.Estado == EstadoOrdenEntrega.Pendiente);
        }

        public static List<OrdenEntregaEntidad> BuscarOrdenesDeEntregaCumplidas()
        {
            return ordenesEntrega.FindAll(o => o.Estado == EstadoOrdenEntrega.Cumplida);
        }

        public static OrdenEntregaEntidad BuscarOrdenPorId(int id)
        {
            return ordenesEntrega.FirstOrDefault(oe => oe.IdOrdenEntrega == id);
        }

        public static OrdenEntregaEntidad BuscarOrdenQueContieneOp(int idOrdenPreparacion)
        {
            return ordenesEntrega.FirstOrDefault(oe => oe.IdOrdenPreparacion.Contains(idOrdenPreparacion));
        }
    }
}
