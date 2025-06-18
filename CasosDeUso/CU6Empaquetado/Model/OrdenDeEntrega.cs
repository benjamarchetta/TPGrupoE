using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using static TPGrupoE.CasosDeUso.CU6Empaquetado.Model.OrdenDeEntrega;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Model
{
    internal partial class OrdenDeEntrega
    {

        public class OrdenEntrega
        {
            public int IdOrdenEntrega { get; set; }
            public string DocumentoTransportista { get; set; }
            public EstadoOrdenEntrega Estado { get; set; }

            public OrdenEntrega(int id)
            {
                IdOrdenEntrega = id;
                Estado = EstadoOrdenEntrega.Pendiente;
            }
        }
    }

}
