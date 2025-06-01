using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class TransportistaAlmacen
    {
        private static List<TransportistaEntidad> transportistas = new List<TransportistaEntidad>()
        {
            new TransportistaEntidad { dni = 30123456, Nombre = "Carlos Gutiérrez" },
            new TransportistaEntidad { dni = 25456789, Nombre = "María López" },
            new TransportistaEntidad { dni = 33456789, Nombre = "Juan Pérez" },
            new TransportistaEntidad { dni = 28765432, Nombre = "Ana Rodríguez" },
            new TransportistaEntidad { dni = 35678901, Nombre = "Pedro Martínez" }
        };

        public static IReadOnlyList<TransportistaEntidad> Transportistas = transportistas.AsReadOnly();
    }
}
