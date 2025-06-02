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
        public DateTime FechaEmision { get; set; }
        public int IDCliente { get; set; }
        public int DNITransportista { get; set; }
        public List<int> IDOrdenPreparacion { get; set; }

    }
}
