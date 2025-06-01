using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenEntregaEntidad
    {
        public string IdOrdenEntrega { get; set; } = string.Empty;
        public List<int> IdsOrdenesPreparacion { get; set; } = new List<int>();
        public string  Estado { get; set; } = string.Empty;
        public int DniTransportista { get; set; }
    }
}
