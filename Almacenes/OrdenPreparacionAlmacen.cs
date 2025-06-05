using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal static class OrdenPreparacionAlmacen
    {
        private static List<OrdenPreparacionEntidad> ordenesPreparacion = new List<OrdenPreparacionEntidad>();

        public static IReadOnlyCollection<OrdenPreparacionEntidad> OrdenesPreparacion => ordenesPreparacion.AsReadOnly();

        public static void GrabarOP()
        {
            var datosOP = JsonSerializer.Serialize(ordenesPreparacion);

            File.WriteAllText(@"Datos\ordenesPreparacion.json", datosOP);
        }
        

        public static void LeerOP()
        {
            
             if (!File.Exists(@"Datos\ordenesPreparacion.json"))
             {
                 return;
             }

             var datos = File.ReadAllText(@"Datos\ordenesPreparacion.json");

             ordenesPreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEntidad>>(datos)!;
        }

       /* public static int CalcularCantidadReservada(int idDeposito, int idProducto, int idCliente)
        {
            // Buscar las ordenes de preparacion en estado "EnPreparacion" o "Preparada", donde el deposito y el cliente coincidan
            var ordenes = ordenesPreparacion.FindAll(o => (o.Estado == EstadoOrdenPreparacion.Pendiente || o.Estado == EstadoOrdenPreparacion.EnPreparacion) && o.IdDeposito == idDeposito && o.IdCliente == idCliente);

            int cantidadReservada = 0;


            foreach (var o in ordenes)
            {
                // Buscar la mercaderia en la orden de preparacion
                var productosOrden = o.ProductoOrden.Find(prods => prods.IdProducto == idProducto);

                if (productosOrden != null)
                {
                    cantidadReservada += productosOrden.Cantidad;
                }
            }
            return cantidadReservada;
        }*/

        //REVISAR SI NOS SIRVE AHORA
        public static List<OrdenPreparacionEntidad> BuscarTodasLasOrdenes()
        {
            return ordenesPreparacion;
        }

        public static List<OrdenPreparacionEntidad> BuscarOrdenesPendientes()
        {
            return ordenesPreparacion.FindAll(op => op.Estado == EstadoOrdenPreparacion.Pendiente);
        }

        public static List<OrdenPreparacionEntidad> BuscarOrdenesEnPreparacion()
        {
            return ordenesPreparacion.FindAll(op => op.Estado == EstadoOrdenPreparacion.EnPreparacion);
        }

        public static List<OrdenPreparacionEntidad> BuscarOrdenesSeleccionadas()
        {
            return ordenesPreparacion.FindAll(op => op.Estado == EstadoOrdenPreparacion.Seleccionada);
        }
        public static List<OrdenPreparacionEntidad> BuscarOrdenesEmpaquetadas()
        {
            return ordenesPreparacion.FindAll(op => op.Estado == EstadoOrdenPreparacion.Empaquetada);
        }

        public static List<OrdenPreparacionEntidad> BuscarOrdenesPreparadas()
        {
            return ordenesPreparacion.FindAll(op => op.Estado == EstadoOrdenPreparacion.Preparada);
        }

        //VER SI NOS SIRVE AGREGAR BuscarOrdenesDespachadas (yo creo que no)
        public static OrdenPreparacionEntidad BuscarOrdenesPorId(int id)
        {
            return ordenesPreparacion.FirstOrDefault(op => op.IdOrdenPreparacion == id);
        }

        //COMENTO PARA VER MAS ADELANTE....
        /*
        public static List<int> ObtenerTransportistasConOrdenesParaDespacho()
        {

            // Crear un HashSet para almacenar DNI únicos
            HashSet<int> dniTransportistasUnicos = new HashSet<int>();

            var ordenes = ObtenerOrdenesParaDespacho();

            foreach (var o in ordenes)
            {
                dniTransportistasUnicos.Add(o.DNITransportista);
            }

            var transportistas = new List<int>(dniTransportistasUnicos);

            return transportistas;
        }
        */

        //VER SI HAY QUE ADAPTAR ESTA FUNCION
        internal static string NuevaOrdenPreparacion(OrdenPreparacionEntidad nuevaOrden)
        {
            if (OrdenPreparacionAlmacen.ordenesPreparacion.Count == 0)
            {
                nuevaOrden.IdOrdenPreparacion = 1;
            }
            else
            {
                nuevaOrden.IdOrdenPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion.Max(op => op.IdOrdenPreparacion) + 1;
            }


            ordenesPreparacion.Add(nuevaOrden);
            return null; //sin errores.
        }

        //COMENTO POR AHORA PERO SEGURO NOS SIRVE MAS ADELANTE
        /*
        public static int CalcularCantidadReservada(int idDeposito, int idMercaderia, int idCliente)
        {
            // Buscar las ordenes de preparacion en estado "EnPreparacion" o "Preparada", donde el deposito y el cliente coincidan
            var ordenes = ordenesPreparacion.FindAll(o => (o.Estado == EstadoOrdenPreparacion.PendienteDeSeleccion || o.Estado == EstadoOrdenPreparacion.EnPreparacion) && o.IDDeposito == idDeposito && o.IDCliente == idCliente);

            int cantidadReservada = 0;


            foreach (var o in ordenes)
            {
                // Buscar la mercaderia en la orden de preparacion
                var mercaderiaOrden = o.MercaderiaOrden.Find(mo => mo.IDMercaderia == idMercaderia);

                if (mercaderiaOrden != null)
                {
                    cantidadReservada += mercaderiaOrden.Cantidad;
                }
            }


            return cantidadReservada;
        }
        */

        public static void ActualizarOrdenPreparacion(OrdenPreparacionEntidad ordenActualizada)
        {
            var index = ordenesPreparacion.FindIndex(op => op.IdOrdenPreparacion == ordenActualizada.IdOrdenPreparacion);

            if (index != -1)
            {
                ordenesPreparacion[index] = ordenActualizada;
                GrabarOP();
            }
        }
       
        }

    }
