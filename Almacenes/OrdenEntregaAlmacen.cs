using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenEntregaAlmacen
    {
        private static List<OrdenEntregaEntidad> ordenesEntrega = new List<OrdenEntregaEntidad>
        {
            new OrdenEntregaEntidad
            {
                IdOrdenEntrega = 1,
                IdOrdenPreparacion = new List<int> { 1001, 1002 },
                Estado = EstadoOrdenEntrega.Pendiente,
            }
        };

        public static IReadOnlyList<OrdenEntregaEntidad> OrdenesEntrega => ordenesEntrega.AsReadOnly();
    }
}
