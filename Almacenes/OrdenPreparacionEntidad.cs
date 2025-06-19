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
            RegistrarCambioDeEstado();
        }
        public void MarcarOpSeleccionada()
        {
            this.Estado = EstadoOrdenPreparacion.Seleccionada;
            RegistrarCambioDeEstado();
        }
        public void MarcarOpEmpaquetada()
        {
            this.Estado = EstadoOrdenPreparacion.Empaquetada;
            RegistrarCambioDeEstado();
        }
        public void MarcarOpPreparada()
        {
            this.Estado = EstadoOrdenPreparacion.Preparada;
            RegistrarCambioDeEstado();
        }
        public void MarcarOpDespachada()
        {
            this.Estado = EstadoOrdenPreparacion.Despachada;
            RegistrarCambioDeEstado();
        }

        public void RegistrarCambioDeEstado()
        {
            FlujoMovimientosAlmacen.RegistrarMovimiento(new FlujoMovimientosEntidad
            {
                IdOrdenPreparacion = this.IdOrdenPreparacion,
                IdCliente = this.IdCliente,
                Estado = this.Estado,
                FechaEntrega = this.FechaEntrega,
                FechaActualizacionEstado = DateTime.Now
            });
        }

    }
}
