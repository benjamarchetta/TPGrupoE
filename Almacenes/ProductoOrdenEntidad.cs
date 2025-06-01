using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class ProductoOrdenEntidad
    {
        public int Id { get; set; }
        public string sku { get; set; } = string.Empty;
        public string TipoProducto { get; set; } = string.Empty;
        public int Cantidad { get; set; }
    }
}
