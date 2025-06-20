using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU9ConsultarOrdenes.Model
{
    public class HistorialDeOrdenesPreparacion
    {
        public int IdOrdenPreparacion { get; set; }
        public EstadoOrdenPreparacion Estado { get; set; }
        public DateTime FechaUltimaActualizacionEstado { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int IdCliente { get; set; }
        public string ClienteCuit { get; set; } = string.Empty;
        public string ClienteRazonSocial { get; set; } = string.Empty;
        public string DepositoDomicilio{ get; set; } = string.Empty;

    }
}
