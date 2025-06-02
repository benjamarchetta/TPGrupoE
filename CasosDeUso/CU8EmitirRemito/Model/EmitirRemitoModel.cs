using System;
using System.Collections.Generic;
using System.Linq;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU6EmitirRemito.Model
{
    internal class EmitirRemitoModel
    {
        public List<OrdenPreparacionEntidad> OrdenesDePreparacion { get; private set; } = new();
        public List<TransportistaEntidad> Transportistas { get; private set; } = new();

        public EmitirRemitoModel()
        {
            CargarTransportistas();
        }

        public void CargarTransportistas()
        {
            Transportistas = OrdenPreparacionAlmacen.ObtenerTransportistasConOPPreparadasHoy();
        }

        public List<ClienteEntidad> ObtenerClientesParaTransportistaHoy(int dniTransportista)
        {
            return OrdenPreparacionAlmacen.ObtenerClientesConOPPreparadasHoyPorTransportista(dniTransportista);
        }

        public void CargarOrdenesPorTransportistaYCliente(int dniTransportista, string cuitCliente)
        {
            OrdenesDePreparacion = OrdenPreparacionAlmacen.ObtenerOPPreparadasHoyPorTransportistaYCliente(dniTransportista, cuitCliente);
        }

        public string DespacharYEmitirRemito(int dniTransportista, string cuitCliente, List<int> idsOPSeleccionadas)
        {
            if (idsOPSeleccionadas.Count == 0)
                return "Debe seleccionar al menos una orden para despachar.";

            foreach (var idOp in idsOPSeleccionadas)
            {
                var op = OrdenPreparacionAlmacen.ObtenerPorId(idOp);
                if (op != null)
                    op.Estado = "Despachada";
            }

            var remito = new RemitoEntidad
            {
                DNITransportista = dniTransportista,
                IDCliente = cuitCliente,
                IDOrdenPreparacion = idsOPSeleccionadas,
                Fecha = DateTime.Now
            };
            RemitoAlmacen.Agregar(remito);
            RemitoAlmacen.Grabar();
            OrdenPreparacionAlmacen.Grabar();

            return $"Remito generado con éxito. N°{remito.IDRemito}";
        }
    }
}

