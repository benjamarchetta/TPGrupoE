using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenSeleccionAlmacen
    {
        
        
     private static List<OrdenSeleccionEntidad> ordenesDeSeleccion = new List<OrdenSeleccionEntidad>
     {
        new OrdenSeleccionEntidad { IdOrdenSeleccion = 1, Estado = "Pendiente", ordenesPreparacion = new List<OrdenPreparacionEntidad>() },
        new OrdenSeleccionEntidad { IdOrdenSeleccion = 2, Estado = "Completada", ordenesPreparacion = new List<OrdenPreparacionEntidad>() },
        // Agregá más si querés
     };

            public static IReadOnlyList<OrdenSeleccionEntidad> OrdenesDeSeleccion = ordenesDeSeleccion.AsReadOnly();
    }


    
}
