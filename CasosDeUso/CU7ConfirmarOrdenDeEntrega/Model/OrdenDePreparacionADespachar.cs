
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;

namespace TPGrupoE.CasosDeUso.CU7ConfirmarOrdenDeEntrega.Model
{
    public class OrdenDePreparacionADespachar
    {
        public int IdOrdenPreparacion { get; set; }
        public int IdOrdenEntrega { get; set; }
        public DateTime FechaEntrega { get; set; }
        public List<ProductoOP> ProductosOP { get; set; } = new();
    }
}