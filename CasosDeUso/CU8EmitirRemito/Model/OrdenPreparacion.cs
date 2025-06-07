using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Model
{
    internal partial class EmitirRemitoModel
    {
        public class OrdenPreparacion
        {
            public int Id { get; set; }
            public string DniTransportista { get; set; }
            public EstadoOrdenPreparacion Estado { get; set; }
            public DateTime FechaEntrega { get; set; }
            public int IdOrdenEntrega { get; set; }
            public int IdCliente { get; set; }
            public OrdenPreparacion(int id, string dniTransportista, EstadoOrdenPreparacion estado, int idOrdenEntrega, int idCliente)
            {
                Id = id;
                DniTransportista = dniTransportista;
                Estado = estado;
                FechaEntrega = DateTime.Now;
                IdOrdenEntrega = idOrdenEntrega;
                IdCliente = idCliente;
            }
        }
    }
}