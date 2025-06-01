using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenEntregaEntidad
    {
        public int IdOrdenEntrega { get; set; }
        public EstadoOrdenEntrega Estado { get; set; }
        public List<int> IdOrdenPreparacion { get; set; } = new ();
        
    }
}
