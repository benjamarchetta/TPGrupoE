using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU7CargarOrdenDeEntrega.Model
{
    // Clase que representa una orden de preparación REVISAR! ARA
    public class OrdenPreparacion
    {
        public int IdOrdenPreparacion { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public int DniTransportista { get; set; }
        public EstadoOrdenPreparacion Estado { get; set; }
        public DateTime FechaEmision { get; set; }
        public DateTime FechaEntrega { get; set; }

        public OrdenPreparacion(int id, string documentoCliente, string nombreCliente, int dniTransportista, EstadoOrdenPreparacion estado, DateTime fechaEntrega)
        {
            IdOrdenPreparacion = id;
            DocumentoCliente = documentoCliente;
            NombreCliente = nombreCliente;
            DniTransportista = dniTransportista;
            Estado = estado;
            FechaEmision = DateTime.Now;
            FechaEntrega = fechaEntrega;
        }
    }
}
