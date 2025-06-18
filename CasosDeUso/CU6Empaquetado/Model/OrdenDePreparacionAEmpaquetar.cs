//using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Model
{
    public class OrdenDePreparacionAEmpaquetar
    {
        public string IdOrdenPreparacion { get; set; }
        public List<ProductoOP> ProductosOP { get; set; }
    }
}
