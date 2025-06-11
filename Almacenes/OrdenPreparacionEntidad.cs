using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    public class OrdenPreparacionEntidad
    {
        public int IdOrdenPreparacion { get; set; } 
        public int IdDeposito { get; set; }
        public int IdCliente { get; set; }
        public int DniTransportista { get; set; }
        public EstadoOrdenPreparacion Estado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool PalletCerrado { get; set; }
        public List<ProductoOrden> ProductoOrden { get; set; } = new();
        


        public void MarcarOpEnPreparacion()
        {
            this.Estado = EstadoOrdenPreparacion.EnPreparacion;
        }
        public void MarcarOpSeleccionada()
        {
            this.Estado = EstadoOrdenPreparacion.Seleccionada;
        }
        public void MarcarOpEmpaquetada()
        {
            this.Estado = EstadoOrdenPreparacion.Empaquetada;
        }
        public void MarcarOpPreparada()
        {
            this.Estado = EstadoOrdenPreparacion.Preparada;
        }
        public void MarcarOpDespachada()
        {
            this.Estado = EstadoOrdenPreparacion.Despachada;
        }

    }
}
