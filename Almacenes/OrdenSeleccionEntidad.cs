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
        public List<int> IDsOrdenesPreparacion { get; set; } = new List<int>();
        public EstadoOrdenSeleccion Estado { get; set; }

        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaConfirmacion { get; set; }
        public string UsuarioConfirmacion { get; set; }

      //  public string Estado { get; set; } = string.Empty;
        public List<OrdenPreparacionEntidad> ordenesPreparacion { get; set; }
      
    }
    public enum EstadoOrdenSeleccion
    {
        Pendiente,
        Cumplida
    }


}
