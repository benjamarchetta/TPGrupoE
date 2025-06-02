using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Model
{
    public class OrdenDePreparacionAEmpaquetar
    {
        public string Id { get; set; }
        public List<ProductoAlmacen>? Producto { get; set; }
    }

    public class ProductoAlmacen
    {
        // Fix for CS0102: Removed duplicate definition of 'Productos'.  
        // Fix for CS0052 and CA2211: Changed accessibility to private and added a public getter method.  
        private static List<ProductoEntidad> _productos = new List<ProductoEntidad>();
        internal string IdProducto;
        internal string DescripcionProducto;
        internal int Cantidad;
    }
}
