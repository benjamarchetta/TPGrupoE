using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenPickingEntidad
    {
        public int IdOrdenSeleccion { get; set; }
        public EstadoOrdenSeleccion Estado { get; set; }
       
        public List<int> IdOrdenPreparacion { get; set; } = new();

    }
}
