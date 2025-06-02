using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Model
{
    public class TransportistaModel
    {
        public string Documento { get; set; }

        public string DisplayText => $"DNI: {Documento}";

        public TransportistaModel(string documento)
        {
            Documento = documento;
        }

        public override string ToString() => DisplayText;
    }
}
