using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class ProductoEntidad
    {
        public int IdProducto { get; set; }
        public string Sku { get; set; } = string.Empty;
        public string DescripcionProducto { get; set; } = string.Empty;
    }
}
