using System;
using System.Collections.Generic;
using System.Linq;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU6EmitirRemito.Model
{
    internal class EmitirRemitoModel
    {
        // Obtengo transportistas que tienen al menos una OP "Preparada" y OE "Pendiente"
        public List<int> ObtenerTransportistas()
        {
            return OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(op => op.Estado == EstadoOrdenPreparacion.Preparada &&
                    OrdenEntregaAlmacen.OrdenesEntrega.Any(
                        oe => oe.Estado == EstadoOrdenEntrega.Pendiente &&
                              oe.IdOrdenPreparacion.Contains(op.IdOrdenPreparacion)))
                .Select(op => op.DniTransportista)
                .Distinct()
                .ToList();
        }

        // Obtengo los clientes para ese transportista con OP "Preparada" y OE "Pendiente"
        public List<int> ObtenerClientesPorTransportista(int dniTransportista)
        {
            return OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(op => op.Estado == EstadoOrdenPreparacion.Preparada &&
                             op.DniTransportista == dniTransportista &&
                             OrdenEntregaAlmacen.OrdenesEntrega.Any(
                                 oe => oe.Estado == EstadoOrdenEntrega.Pendiente &&
                                       oe.IdOrdenPreparacion.Contains(op.IdOrdenPreparacion)))
                .Select(op => op.IdCliente)
                .Distinct()
                .ToList();
        }

        // Obtengo las OP para ese transportista y cliente con OE pendiente
        public List<OrdenPreparacionEntidad> ObtenerOPsParaDespachar(int dniTransportista, int idCliente)
        {
            return OrdenPreparacionAlmacen.OrdenesPreparacion
                .Where(op => op.Estado == EstadoOrdenPreparacion.Preparada &&
                             op.DniTransportista == dniTransportista &&
                             op.IdCliente == idCliente &&
                             OrdenEntregaAlmacen.OrdenesEntrega.Any(
                                 oe => oe.Estado == EstadoOrdenEntrega.Pendiente &&
                                       oe.IdOrdenPreparacion.Contains(op.IdOrdenPreparacion)))
                .ToList();
        }

        // Obtengo el id de orden de entrega asociada a una OP
        public int? ObtenerIdOEPorOP(int idOP)
        {
            var oe = OrdenEntregaAlmacen.OrdenesEntrega.FirstOrDefault(x => x.IdOrdenPreparacion.Contains(idOP));
            return oe?.IdOrdenEntrega;
        }

        // Genera y guarda el remito, y actualiza los estados
        public string DespacharYEmitirRemito(List<int> opsIds)
        {
            if (opsIds == null || opsIds.Count == 0)
                return "Debe seleccionar al menos una orden de preparación.";

            foreach (var idOp in opsIds)
            {
                // Cambio el estado de la OP a "Despachada"
                var op = OrdenPreparacionAlmacen.OrdenesPreparacion.FirstOrDefault(x => x.IdOrdenPreparacion == idOp);
                if (op != null)
                    op.Estado = EstadoOrdenPreparacion.Despachada;

                // Busco la OE asociada y la marco como "Cumplida"
                var oe = OrdenEntregaAlmacen.OrdenesEntrega.FirstOrDefault(
                    x => x.Estado == EstadoOrdenEntrega.Pendiente &&
                         x.IdOrdenPreparacion.Contains(idOp));
                if (oe != null)
                    oe.Estado = EstadoOrdenEntrega.Cumplida;
            }

            var nuevoRemito = new RemitoEntidad
            {
                FechaEmision = DateTime.Now,
                IDOrdenPreparacion = opsIds
                // Podés completar otros campos si hace falta
            };
            RemitoAlmacen.NuevoRemito(nuevoRemito);
            RemitoAlmacen.GrabarRemito();

            OrdenPreparacionAlmacen.GrabarOP();
            OrdenEntregaAlmacen.GrabarOE();

            return "Remito generado con éxito.";
        }
    }
}
