using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model
{
    internal class Cliente
    {
       
       
            public string Cuit { get; set; }
            public string RazonSocial { get; set; }
            public string DisplayText
            {
                get { return $"CUIT/CUIL: {Cuit}. Nombre: {RazonSocial}"; }
            }
        
    }
}
