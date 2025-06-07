using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Model
{
    internal partial class EmitirRemitoModel
    {
        public class Transportista
        {
            public string Documento { get; set; }

            public string DisplayText
            {
                get { return $"DNI: {Documento}"; }
            }

            public Transportista(string documento)
            {
                Documento = documento;
            }

        }
    }
}