using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;
using TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model;
using static TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model.OrdenPreparacionModelo;

namespace TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;

internal partial class OrdenPreparacionModelo
{
    public List<ClienteEntidad> Clientes
    {
        get
        {
            var copia = new List<ClienteEntidad>();
            foreach (var cliente in ClienteAlmacen.Clientes)
            {
                copia.Add(new ClienteEntidad
                {
                    IdCliente = cliente.IdCliente,
                    Cuit = cliente.Cuit,
                    RazonSocial = cliente.RazonSocial,
                    Domicilio = cliente.Domicilio,
                });
            }
            return copia;

        }
    }

    public List<ProductoEntidad> Productos
    {
        get
        {
            var Productos = new List<ProductoEntidad>();
            foreach (var Producto in ProductoAlmacen.Productos)
            {
                Productos.Add(new ProductoEntidad
                {
                    IdProducto = Producto.IdProducto,
                    Sku = Producto.Sku,
                    DescripcionProducto = Producto.DescripcionProducto,
                });
            }
            return Productos;
        }
    }

    public List<StockFisicoEntidad> Stock
    {
        get
        {
            var StockFisico = new List<StockFisicoEntidad>();
            foreach (var stockFisico in StockFisicoAlmacen.Stock)
            {
                StockFisico.Add(new StockFisicoEntidad
                {
                    IdCliente = stockFisico.IdCliente,
                    IdProducto = stockFisico.IdProducto,
                    Posiciones = stockFisico.Posiciones.Select(p => new PosicionesPorDeposito
                    {
                        IdDeposito = p.IdDeposito,
                        Posicion = p.Posicion,
                        PalletCerrado = p.PalletCerrado,
                        Cantidad = p.Cantidad
                    }).ToList()
                });
            }
            // Restar cantidades según las ordenes ya registradas
            foreach (var orden in OrdenPreparacionAlmacen.OrdenesPreparacion)
            {
                foreach (var productoOrden in orden.ProductoOrden)
                {
                    var stockCliente = StockFisico.FirstOrDefault(s =>
                        s.IdCliente == orden.IdCliente &&
                        s.IdProducto == productoOrden.IdProducto);

                    if (stockCliente == null) continue;

                    int cantidadARestar = productoOrden.Cantidad;

                    //FILTRAR POR PALLET CERRADO/ABIERTO ANTES DE RESTAR
                    var posicionesFiltradas = stockCliente.Posiciones
                        .Where(p => p.PalletCerrado == p.PalletCerrado)
                        .OrderByDescending(p => p.Cantidad)
                        .ToList();

                    foreach (var pos in posicionesFiltradas)
                    {
                        if (cantidadARestar <= 0) break;

                        int aDescontar = Math.Min(pos.Cantidad, cantidadARestar);
                        pos.Cantidad -= aDescontar;
                        cantidadARestar -= aDescontar;
                    }
                }
            }

            return StockFisico;
        }
    }

    public List<DepositoEntidad> Depositos
    {
        get
        {
            var depositos = new List<DepositoEntidad>();
            foreach (var deposito in DepositosAlmacen.Depositos)
            {
                depositos.Add(new DepositoEntidad
                {
                    IdDeposito = deposito.IdDeposito,
                    Domicilio = deposito.Domicilio,
                    CapacidadEstimadaPallets = deposito.CapacidadEstimadaPallets,
                });
            }
            return depositos;

        }
    }

    public List<OrdenPreparacionEntidad> OrdenesPreparacion
    {
        get
        {
            var ordenes = new List<OrdenPreparacionEntidad>();
            foreach (var orden in OrdenPreparacionAlmacen.OrdenesPreparacion)
            {
                ordenes.Add(new OrdenPreparacionEntidad
                {
                    IdOrdenPreparacion = orden.IdOrdenPreparacion,
                    IdCliente = orden.IdCliente,
                    IdDeposito = orden.IdDeposito,
                    DniTransportista = orden.DniTransportista,
                    Estado = orden.Estado,
                    FechaEntrega = orden.FechaEntrega,
                    PalletCerrado = orden.PalletCerrado,
                    ProductoOrden = orden.ProductoOrden,
                });
            }
            return ordenes;

        }
    }

    public int GenerarIdOrden()
    {
        return OrdenPreparacionAlmacen.OrdenesPreparacion.Count == 0
            ? 1
            : OrdenPreparacionAlmacen.OrdenesPreparacion.Max(o => o.IdOrdenPreparacion) + 1;
    }

    public List<StockFisicoEntidad> FiltrarPorPalletCerrado(bool palletCerrado)
    {
        return Stock
            .Where(stock => stock.Posiciones.Any(p => p.PalletCerrado == palletCerrado))
            .ToList();
    }

    public string NuevaOrdenPreparacion(OrdenPreparacionEntidad nuevaOrden)
    {
        OrdenPreparacionAlmacen.NuevaOrdenPreparacion(nuevaOrden);
        return null;
    }

    public void GrabarOP()
    {
        OrdenPreparacionAlmacen.GrabarOP();
    }
}
