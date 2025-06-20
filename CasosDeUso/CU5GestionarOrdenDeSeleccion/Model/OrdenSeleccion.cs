﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model
{
    internal partial class GestionOrdenSeleccionModel
    { 
    public class OrdenSeleccion
    {
        public int IdOrdenSeleccion { get; set; }
        public string Cliente { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string FechaDespacho { get; set; } = "Sin fecha";
    }
   }
}
