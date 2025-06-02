using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal class OrdenPreparacionEntidad
    {
        public int IdOrdenPreparacion { get; set; } 
        public int IdDeposito { get; set; }
        public int IdCliente { get; set; }
        public int DniTransportista { get; set; }
        public EstadoOrdenPreparacion Estado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool PalletCerrado { get; set; }
        public List<ProductoOrden> ProductoOrden { get; set; } = new();


        
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
