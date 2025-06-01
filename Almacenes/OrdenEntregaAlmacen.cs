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
                IdOrdenEntrega = "ENT001",
                IdsOrdenesPreparacion = new List<int> { 1001, 1002 },
                Estado = "Pendiente",
                DniTransportista = 40111222
            },
            new OrdenEntregaEntidad
            {
                IdOrdenEntrega = "ENT002",
                IdsOrdenesPreparacion = new List<int> { 1003 },
                Estado = "En proceso",
                DniTransportista = 40222333
            },
            new OrdenEntregaEntidad
            {
                IdOrdenEntrega = "ENT003",
                IdsOrdenesPreparacion = new List<int> { 1002, 1003 },
                Estado = "Entregada",
                DniTransportista = 40333444
            },
            new OrdenEntregaEntidad
            {
                IdOrdenEntrega = "ENT004",
                IdsOrdenesPreparacion = new List<int> { 1001 },
                Estado = "Pendiente",
                DniTransportista = 40444555
            },
            new OrdenEntregaEntidad
            {
                IdOrdenEntrega = "ENT005",
                IdsOrdenesPreparacion = new List<int> { 1001, 1003 },
                Estado = "Cancelada",
                DniTransportista = 40555666
            }
        };

        public static IReadOnlyList<OrdenEntregaEntidad> OrdenesEntrega => ordenesEntrega.AsReadOnly();
    }
}
