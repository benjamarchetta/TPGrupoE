using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal static class DepositoAlmacen
    {
        private static List<DepositoEntidad> depositos = new List<DepositoEntidad>()
        {
            new DepositoEntidad() { IdDeposito = 100, Capacidad = 10000, Domicilio = "Av. Libertador 1234, CABA" },
            new DepositoEntidad() { IdDeposito = 200, Capacidad = 50000, Domicilio = "Rivadavia 567, Mendoza" },
            new DepositoEntidad() { IdDeposito = 300, Capacidad = 100000, Domicilio = "Belgrano 89, Córdoba" },
        };

        public static IReadOnlyList<DepositoEntidad> Depositos = depositos.AsReadOnly();
    }
}
}
