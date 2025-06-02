using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    public class ClienteEntidad
    {
        public int IdCliente { get; set; }
        public string Cuit { get; set; } = string.Empty;
        public string RazonSocial { get; set; } = string.Empty;
        public string Domicilio { get; set; } = string.Empty;
    }
}
