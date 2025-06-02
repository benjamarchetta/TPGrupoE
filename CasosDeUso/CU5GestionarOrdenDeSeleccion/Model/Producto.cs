using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model
{
    public class Producto
    {
        public string Ubicacion { get; set; }
        public int Cantidad { get; set; }
        public string IdProducto { get; set; }
        public string DescripcionProducto { get; set; }

        public Producto(string ubicacion, int cantidad, string idProducto, string descripcionProducto)
        {
            Ubicacion = ubicacion;
            Cantidad = cantidad;
            IdProducto = idProducto;
            DescripcionProducto = descripcionProducto;
        }
    }
}
