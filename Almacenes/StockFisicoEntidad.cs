using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class StockFisicoEntidad
    {
        public int IdCliente { get; set; }
        public int IdProducto{ get; set; }
        public List<PosicionesPorDeposito> Posiciones { get; set; } = [];
    }
}
