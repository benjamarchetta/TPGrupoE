using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Model
{
    internal partial class EmitirRemitoModel
    {
        internal partial class Cliente
        {
            public string Cuit { get; set; }
            public string RazonSocial { get; set; }

            public string DisplayText => RazonSocial;

            public Cliente(string cuit, string razonSocial)
            {
                Cuit = cuit;
                RazonSocial = razonSocial;
            }
        }
    }
}