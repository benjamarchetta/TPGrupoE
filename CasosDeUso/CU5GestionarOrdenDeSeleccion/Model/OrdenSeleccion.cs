using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model
{
    public class OrdenSeleccion
    {
        public int Id { get; set; }
        public EstadoOrdenSeleccion Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public List<int> IdsOrdenesPreparacion { get; set; }

        public OrdenSeleccion(int id, List<int> idsOrdenesPreparacion = null, EstadoOrdenSeleccion estado = EstadoOrdenSeleccion.Pendiente)
        {
            Id = id;
            Estado = estado;
            FechaEmision = DateTime.Now;
            IdsOrdenesPreparacion = idsOrdenesPreparacion ?? new List<int>();
        }
    }
}
