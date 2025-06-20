﻿using System;
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
            var datosOP = JsonSerializer.Serialize(ordenesPreparacion, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(@"Datos\ordenesPreparacion.json", datosOP);
        }
        

        static OrdenPreparacionAlmacen()
        {
            
             if (!File.Exists(@"Datos\ordenesPreparacion.json"))
             {
                 return;
             }

             var datos = File.ReadAllText(@"Datos\ordenesPreparacion.json");

             ordenesPreparacion = JsonSerializer.Deserialize<List<OrdenPreparacionEntidad>>(datos)!;
        }


        public static string NuevaOrdenPreparacion(OrdenPreparacionEntidad nuevaOrden)
        {
            if (OrdenPreparacionAlmacen.OrdenesPreparacion.Count == 0)
            {
                nuevaOrden.IdOrdenPreparacion = 1;
            }
            else
            {
                nuevaOrden.IdOrdenPreparacion = OrdenPreparacionAlmacen.OrdenesPreparacion.Max(op => op.IdOrdenPreparacion) + 1;
            }


            OrdenPreparacionAlmacen.ordenesPreparacion.Add(nuevaOrden);

            nuevaOrden.RegistrarCambioDeEstado();

            return null; //sin errores.
        }

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

        
        public static List<int> BuscarTransportistasConOrdenesParaDespacho()
        {

            HashSet<int> dniTransportistasUnicos = new HashSet<int>();

            var ordenes = BuscarOrdenesPreparadas();

            foreach (var o in ordenes)
            {
                dniTransportistasUnicos.Add(o.DniTransportista);
            }

            var transportistas = new List<int>(dniTransportistasUnicos);

            return transportistas;
        }
        

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
