using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model;
using static TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model.OrdenPreparacionModelo;

namespace TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;

internal class OrdenPreparacionModelo //nota ara: solo lo comente hasta que benja haga un pull
{
    
    

    public static List<ClienteEntidad> Clientes
    {
        get
        {
            ClienteAlmacen.LeerCliente();
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

    public static List<ProductoEntidad> Productos
    {
        get
        {
            var Productos = new List<ProductoEntidad>();
            foreach (var Producto in ProductoAlmacen.Productos)
            {
                Productos.Add(new ProductoEntidad
                {
                    IdProducto = Producto.IdProducto,
                    //CuitCliente = Producto.CuitCliente,
                    Sku = Producto.Sku,
                    //TipoProducto = Producto.TipoProducto,
                    //CantidadEnStock = Producto.CantidadEnStock,
                    DescripcionProducto= Producto.DescripcionProducto,
                    //Ubicacion = Producto.Ubicacion,
                });
            }
            return Productos;
        }
    }

    public static List<StockFisicoEntidad> Stock
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
                    PalletCerrado = stockFisico.PalletCerrado,
                    Posiciones = stockFisico.Posiciones,
                });
            }
            return StockFisico;
        }
    }

    /*public static List<StockFisicoEntidad> StockFisico
    {
        get
        {
            var StocksFisicos = new List<StockFisicoEntidad>();
            foreach (var Stock in StockFisicoAlmacen.Stock)
            {
                Productos.Add(new ProductoEntidad
                {
                    
                });
            }
            return StocksFisicos;
        }
    }*/

    /*public static List<OrdenPreparacionEntidad> OrdenesDePreparacion
    {
        get
        {
            var OrdenesDePreparacion = new List<OrdenPreparacionEntidad>();
            foreach (var OrdenDePreparacion in OrdenPreparacionAlmacen.OrdenesPreparacion)
            {
                OrdenesDePreparacion.Add(new OrdenPreparacionEntidad
                {
                    Id = OrdenDePreparacion.Id,
                    CuitCliente = OrdenDePreparacion.CuitCliente,
                    Estado = OrdenDePreparacion.Estado,
                    FechaDespacho = OrdenDePreparacion.FechaDespacho,
                    PalletCerrado = OrdenDePreparacion.PalletCerrado,
                    productosOrden = OrdenDePreparacion.productosOrden,
                });
            }
            return OrdenesDePreparacion;
        }
    }
    */

    /*public static List<TransportistaEntidad> Transportistas
    {
        get
        {
            var Transportistas = new List<TransportistaEntidad>();
            foreach (var Transportista in TransportistaAlmacen.Transportistas)
            {
                Transportistas.Add(new TransportistaEntidad
                {
                    dni = Transportista.dni,
                    Nombre = Transportista.Nombre,
                });
            }
            return Transportistas;
        }
    }*/
};


    /*
    internal string? Borrar(int personaSeleccionadaId)
    {
        //TODO: validaciones, si son necesarias.

        //no me pongo a validar si el id es válido.
        //si me llega acá un id inválido, el error no está aca.
        Personas.RemoveAll(p => p.Id == personaSeleccionadaId);
        return null;
    }

    internal string ModificarPersona(Persona personaModificada)
    {
        var personaOriginal = ObtenerPersona(personaModificada.Id);

        personaOriginal.TipoDocumento = personaModificada.TipoDocumento;
        personaOriginal.Documento = personaModificada.Documento;
        personaOriginal.Tratamiento = personaModificada.Tratamiento;
        personaOriginal.Apellido = personaModificada.Apellido;
        personaOriginal.Nombre = personaModificada.Nombre;
        personaOriginal.FechaNacimiento = personaModificada.FechaNacimiento;
        personaOriginal.Direccion = personaModificada.Direccion;
        personaOriginal.Telefono = personaModificada.Telefono;

        return null;
    }

    
    internal string? NuevaPersona(Persona persona)
    {
        //validar TODO.

        //if(algo está mal)
        //{
        //  return "Mensaje de error";
        //}

        if (persona.Tratamiento != "Sr." && persona.Tratamiento != "Sra.")
        {
            return "El tratamiento no es válido";
        }

        if (string.IsNullOrWhiteSpace(persona.Apellido))
        {
            return "El apellido no puede estar vacío";
        }

        if (persona.Apellido.Length > 50)
        {
            return "El apellido no puede tener más de 50 caracteres";
        }

        if (string.IsNullOrWhiteSpace(persona.Nombre))
        {
            return "El nombre no puede estar vacío";
        }

        if (persona.Nombre.Length > 50)
        {
            return "El nombre no puede tener más de 50 caracteres";
        }

        if (persona.TipoDocumento != "DNI" || persona.TipoDocumento != "Pasaporte")
        {
            return "El tipo de documento debe ser DNI o Pasaporte";
        }

        if (persona.Documento < 1000000 || persona.Documento > 99999999)
        {
            return "El número de documento no es válido";
        }

        if (persona.FechaNacimiento > DateTime.Now)
        {
            return "La fecha de nacimiento no puede ser mayor a la fecha actual";
        }

        if (persona.FechaNacimiento < DateTime.Now.AddYears(-120))
        {
            return "La fecha de nacimiento no puede ser menor a 120 años atrás";
        }

        if (string.IsNullOrWhiteSpace(persona.Direccion))
        {
            return "La dirección no puede estar vacía";
        }

        if (persona.Telefono < 10_000_000)
        {
            return "El telefono debe tener al menos 8 dígitos";
        }

        //valido que el tipo/numero de documento no exista.            

        foreach (var personaEx in Personas)
        {
            if (personaEx.Documento == persona.Documento && personaEx.TipoDocumento == persona.TipoDocumento)
            {
                return "Ya existe una persona con ese documento y tipo de documento";
            }
        }

        /*
        //Lo mismo pero abreviado. (LINQ)
        if (Personas.Any(p => p.Documento == persona.Documento && p.TipoDocumento == persona.TipoDocumento))
        {
            return "Ya existe una persona con ese documento y tipo de documento";
        }*/


        //hacer lo que haiga que hacer para guardar la persona
        //Personas.Add(persona);


        /*return null; //null indica que no hay errores.
    }

    internal Persona ObtenerPersona(int personaEnEdicionId)
    {
        return Personas.Single(p => p.Id == personaEnEdicionId);
    }
}
}
}
*/