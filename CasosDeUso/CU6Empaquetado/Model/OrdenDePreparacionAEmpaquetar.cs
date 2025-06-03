using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Model
{
    public class OrdenDePreparacionAEmpaquetar
    {
        public string IdOrdenPreparacion { get; set; }
        public List<ProductoAlmacen>? Productos { get; set; }
    }
}
