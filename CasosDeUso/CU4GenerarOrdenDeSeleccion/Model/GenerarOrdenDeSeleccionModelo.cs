using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using static TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model.OrdenPreparacionModelo;


namespace TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model;
internal class GenerarOrdenDeSeleccionModelo
{
    
        
        public string ObtenerRazonSocialPorCuit(string cuit)
        {
            var cliente = ClienteAlmacen.Clientes.FirstOrDefault(c => c.Cuit == cuit);
            return cliente?.RazonSocial ?? "Cliente no encontrado";
        }
       

    
}
