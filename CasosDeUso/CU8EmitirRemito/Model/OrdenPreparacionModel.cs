using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Model
{
    public class OrdenPreparacionModel
    {
        // Devuelve las órdenes que están listas para ser despachadas
        public List<OrdenPreparacionEntidad> ObtenerOrdenesFiltradas(int dniTransportista, int idCliente)
        {
            return OrdenPreparacionAlmacen.BuscarOrdenesPreparadas()
                .Where(op => op.DniTransportista == dniTransportista && op.IdCliente == idCliente)
                .ToList();
        }

        // Marca un conjunto de órdenes como despachadas
        public void MarcarOrdenesComoDespachadas(List<int> ids)
        {
            foreach (var orden in OrdenPreparacionAlmacen.BuscarTodasLasOrdenes())
            {
                if (ids.Contains(orden.IdOrdenPreparacion))
                {
                    orden.MarcarOpDespachada(); 
                }
            }

            OrdenPreparacionAlmacen.GrabarOP(); // Guarda cambios
        }
    }
}