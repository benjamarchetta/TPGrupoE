using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class ProductoEntidad
    {
        public int Id { get; set; }
        public string CuitCliente { get; set; } = string.Empty;
        public string sku { get; set; } = string.Empty;
        public string TipoProducto { get; set; } = string.Empty;
        public int CantidadEnStock { get; set; }
        public string DescripcionMercaderia { get; set; } = string.Empty;
        public string Ubicacion {  get; set; } = string.Empty; 
    }
}
