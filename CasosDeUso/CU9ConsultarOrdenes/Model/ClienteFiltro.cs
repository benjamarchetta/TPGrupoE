using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.CasosDeUso.CU9ConsultarOrdenes.Model
{
    public class ClienteFiltro
    {
        public int IdCliente { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }

        public override string ToString()
        {
            return $"{Cuit} - {RazonSocial}";
        }
    }
}
