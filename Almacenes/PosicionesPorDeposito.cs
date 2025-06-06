using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class PosicionesPorDeposito
    {
        public int IdDeposito { get; set; }
        public string Posicion { get; set; } = string.Empty;
        public bool PalletCerrado { get; set; }
        public int Cantidad { get; set; }
    }
}
