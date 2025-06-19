using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU9ConsultarOrdenes.Model
{
    public class EstadoOrdenFiltro
    {
        public EstadoOrdenPreparacion Estado { get; set; }

        public override string ToString()
        {
            return Estado.ToString();
        }
    }
}
