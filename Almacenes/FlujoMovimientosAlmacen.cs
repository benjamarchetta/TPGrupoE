using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal static class FlujoMovimientosAlmacen
    {
        private static List<FlujoMovimientosEntidad> movimientos = new List<FlujoMovimientosEntidad>();

        public static IReadOnlyCollection<FlujoMovimientosEntidad> Movimientos => movimientos.AsReadOnly();


        static FlujoMovimientosAlmacen()
        {

            if (!File.Exists(@"Datos\flujoMovimientos.json"))
            {
                return;
            }

            var datos = File.ReadAllText(@"Datos\flujoMovimientos.json");

            movimientos = JsonSerializer.Deserialize<List<FlujoMovimientosEntidad>>(datos)!;
        }

        public static void RegistrarMovimiento(FlujoMovimientosEntidad nuevoMovimiento)
        {
            movimientos.Add(nuevoMovimiento);
            GrabarMovimiento();
        }

        public static void GrabarMovimiento()
        {
            var datosMovimientos = JsonSerializer.Serialize(movimientos, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(@"Datos\flujoMovimientos.json", datosMovimientos);
        }


        public static List<FlujoMovimientosEntidad> BuscarHistoricoTodasLasOrdenes()
        {
            return movimientos.ToList();
        }

        public static List<FlujoMovimientosEntidad> BuscarHistoricoPorOrden(int id)
        {
            return movimientos.Where(m => m.IdOrdenPreparacion == id).ToList();
        }

        public static List<FlujoMovimientosEntidad> BuscarHistoricoOrdenesPendientes()
        {
            return movimientos.FindAll(m => m.Estado == EstadoOrdenPreparacion.Pendiente);
        }

        public static List<FlujoMovimientosEntidad> BuscarHistoricoOrdenesEnPreparacion()
        {
            return movimientos.FindAll(m => m.Estado == EstadoOrdenPreparacion.EnPreparacion);
        }

        public static List<FlujoMovimientosEntidad> BuscarHistoricoOrdenesSeleccionadas()
        {
            return movimientos.FindAll(m => m.Estado == EstadoOrdenPreparacion.Seleccionada);
        }
        public static List<FlujoMovimientosEntidad> BuscarHistoricoOrdenesEmpaquetadas()
        {
            return movimientos.FindAll(m => m.Estado == EstadoOrdenPreparacion.Empaquetada);
        }

        public static List<FlujoMovimientosEntidad> BuscarHistoricoOrdenesPreparadas()
        {
            return movimientos.FindAll(m => m.Estado == EstadoOrdenPreparacion.Preparada);
        }

        public static List<FlujoMovimientosEntidad> BuscarHistoricoPorCliente(int idCliente)
        {
            return movimientos.Where(m => m.IdCliente == idCliente).ToList();
        }

        public static void InicializarMovimientosDesdeOrdenes()
        {
            foreach (var orden in OrdenPreparacionAlmacen.OrdenesPreparacion)
            {
                bool yaRegistrada = movimientos.Any(m => m.IdOrdenPreparacion == orden.IdOrdenPreparacion);

                if (!yaRegistrada)
                {
                    movimientos.Add(new FlujoMovimientosEntidad
                    {
                        IdOrdenPreparacion = orden.IdOrdenPreparacion,
                        IdCliente = orden.IdCliente,
                        Estado = orden.Estado,
                        FechaEntrega = orden.FechaEntrega,
                        FechaActualizacionEstado = DateTime.Now
                    });
                }
            }

            GrabarMovimiento(); // Persistimos los nuevos registros
        }

    }
}

