using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class RemitoEntidad
    {
        public int IdRemito { get; set; }
        public DateTime Fecha { get; set; }
        public string CuitCliente { get; set; } = string.Empty;
        public int DniTransportista { get; set; }
        public int IdOrdenEntrega { get; set; } 
        
      
      

    }
}
