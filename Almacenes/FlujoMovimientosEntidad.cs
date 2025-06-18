using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    public class FlujoMovimientosEntidad
    {
        public int IdOrdenPreparacion { get; set; }
        public DateTime FechaEntrega { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaActualizacionEstado { get; set; }
        public EstadoOrdenPreparacion Estado { get; set; }

        //public override string ToString()
        //{
        //    return $"OP: {IdOrdenPreparacion} | Cliente: {IdCliente} | Estado: {Estado} | Fecha Estado: {FechaActualizacionEstado:dd/MM/yyyy HH:mm} | Entrega: {FechaEntrega:dd/MM/yyyy}";
        //}
    }


}
