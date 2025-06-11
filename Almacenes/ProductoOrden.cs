using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    public class ProductoOrden
    {
        public int IdProducto { get; set; }
        //public int IdDeposito { get; set; }
        public int IdCliente { get; set; }
        public int Cantidad { get; set; }
        //public bool PalletCerrado { get; set; } //esto lo agregue para el caso uso 5 , verificar si es correcto o no
    }
}
