using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU9ConsultarOrdenes.Model
{
    internal partial class ConsultarOrdenesModelo
    {

        public List<HistorialDeOrdenesPreparacion> Ordenes { get; private set; }

        public ConsultarOrdenesModelo()
        {
            Ordenes = new List<HistorialDeOrdenesPreparacion>();

            // Traer todos los movimientos registrados
            var movimientos = FlujoMovimientosAlmacen.BuscarHistoricoTodasLasOrdenes();

            // Agrupar por OP y tomar el último cambio de estado
            var ultimosEstados = movimientos
                .GroupBy(m => m.IdOrdenPreparacion)
                .Select(grupo => grupo
                    .OrderByDescending(m => m.FechaActualizacionEstado)
                    .First())
                .ToList();

            foreach (var movimiento in ultimosEstados)
            {
                var cliente = ClienteAlmacen.BuscarClientePorId(movimiento.IdCliente);
                var orden = OrdenPreparacionAlmacen.BuscarOrdenesPorId(movimiento.IdOrdenPreparacion);
                var deposito = orden != null ? DepositosAlmacen.BuscarDepositoPorId(orden.IdDeposito) : null;

                if (cliente == null || deposito == null || orden == null)
                    continue;

                Ordenes.Add(new HistorialDeOrdenesPreparacion
                {
                    IdOrdenPreparacion = movimiento.IdOrdenPreparacion,
                    Estado = movimiento.Estado,
                    FechaEntrega = movimiento.FechaEntrega,
                    ClienteCuit = cliente.Cuit,
                    ClienteRazonSocial = cliente.RazonSocial,
                    DepositoDomicilio = deposito.Domicilio,
                    FechaUltimaActualizacionEstado = movimiento.FechaActualizacionEstado
                });
            }
        }

        public List<FlujoMovimientosEntidad> BuscarHistoricoPorOrden(int idOrdenPreparacion)
        {
            return FlujoMovimientosAlmacen.BuscarHistoricoPorOrden(idOrdenPreparacion);
        }

    }
}
