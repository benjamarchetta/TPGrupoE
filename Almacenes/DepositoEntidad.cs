using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class DepositoEntidad
    {
        public int IdDeposito { get; set; }
        public int Capacidad { get; set; }
        public string Domicilio { get; set; } = string.Empty;
    }
}
