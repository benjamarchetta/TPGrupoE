using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model
{
    internal partial class GestionOrdenSeleccionModel
    { 
    public class ProductoDetalle
    {
        public string Sku { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int Cantidad { get; set; }
        public string PalletCerrado { get; set; } = "No";
        public string Ubicacion { get; set; } = "Sin ubicación";
    }
    }
}
