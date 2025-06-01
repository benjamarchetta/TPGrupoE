using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenPreparacionEntidad
    {
        public int Id { get; set; } 
        public string CuitCliente { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public DateTime FechaDespacho { get; set; }
        public bool PalletCerrado { get; set; }
        public List<ProductoOrdenEntidad> productosOrden { get; set; }


        
    }
    public enum EstadoOrdenPreparacion
    {
        Pendiente,
        EnPreparacion,
        Seleccionada, // Nuevo estado para CU5
        Preparada,
        Despachada
    }

}
