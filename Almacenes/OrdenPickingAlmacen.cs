using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenPickingAlmacen
    {
        private static List<OrdenPickingEntidad> ordenesSeleccion = new List<OrdenPickingEntidad>();

        public static IReadOnlyCollection<OrdenPickingEntidad> OrdenesSeleccion => ordenesSeleccion.AsReadOnly();
    }


    
}
