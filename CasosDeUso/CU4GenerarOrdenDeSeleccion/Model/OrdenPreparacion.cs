using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;

namespace TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model
{
    public class OrdenPreparacion
    {

        public int IdOrdenPreparacion { get; set; }
        //public int IdDeposito { get; set; }
        public int IdCliente { get; set; }
        public string Cuit { get; set; }
        public string RazonSocial { get; set; }
        public int DniTransportista { get; set; }
        public EstadoOrdenPreparacion Estado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public bool PalletCerrado { get; set; }
        public List<ProductoOP> Productos { get; set; }


        public OrdenPreparacion(int idOrdenPreparacion,int idcliente, string cuit, string razonSocial, int dniTransportista, EstadoOrdenPreparacion estado, DateTime fechaEntrega, List<ProductoOP> productos)
        {
            IdOrdenPreparacion = idOrdenPreparacion;
            Cuit = cuit;
            RazonSocial = razonSocial;
            DniTransportista = dniTransportista;
            Estado = estado;
            FechaEntrega = fechaEntrega;
            IdCliente = idcliente;
            Productos = productos;
           

        }
    }
}
