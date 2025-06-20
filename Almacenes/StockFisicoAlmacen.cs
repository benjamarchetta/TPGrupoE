﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;

namespace TPGrupoE.Almacenes
{
    internal static class StockFisicoAlmacen
    {
        private static List<StockFisicoEntidad> stock = new List<StockFisicoEntidad>();

        public static IReadOnlyCollection<StockFisicoEntidad> Stock => stock.AsReadOnly();


        public static void GrabarStock()
        {
            var datosStock = JsonSerializer.Serialize(stock, new JsonSerializerOptions { WriteIndented = true });

            File.WriteAllText(@"Datos\stockFisico.json", datosStock);
        }

        static StockFisicoAlmacen()
        {
            if (!File.Exists(@"Datos\stockFisico.json"))
            {
                return;
            }

            var datosStock = File.ReadAllText(@"Datos\stockFisico.json");

            stock = JsonSerializer.Deserialize<List<StockFisicoEntidad>>(datosStock)!;
        }

        public static StockFisicoEntidad ObtenerStockPorId(int idProducto)
        {
            return stock.FirstOrDefault(pc => pc.IdProducto == idProducto);
        }
        /// Descuenta cantidad de producto desde sus posiciones (FIFO simple).
        public static void DescontarProductoPorPosicion(int idProducto, int idCliente, int cantidadADescontar)
        {
            var stock = ObtenerStockPorId(idProducto);
            if (stock == null) return;

            int cantidadRestante = cantidadADescontar;

            var posicionesOrdenadas = stock.Posiciones
                .Where(p => p.Cantidad > 0)
                .OrderBy(p => p.Cantidad)
                .ToList();

            foreach (var posicion in posicionesOrdenadas)
            {
                if (cantidadRestante <= 0) break;

                int cantidadTomada = Math.Min(posicion.Cantidad, cantidadRestante);
                posicion.Cantidad -= cantidadTomada;
                cantidadRestante -= cantidadTomada;
            }
        }
        
    }
}


