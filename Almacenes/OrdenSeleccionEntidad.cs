using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenSeleccionEntidad
    {
        public int IdOrdenSeleccion { get; set; }
       
        public string Estado { get; set; } = string.Empty;
        public List<OrdenPreparacionEntidad> ordenesPreparacion { get; set; }
       
    }
}
