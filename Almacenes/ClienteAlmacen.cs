using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal static class ClienteAlmacen
    {
        private static List<ClienteEntidad> clientes = new List<ClienteEntidad>();

        public static IReadOnlyCollection<ClienteEntidad> Clientes => clientes.AsReadOnly();

        static ClienteAlmacen()
        {

            if (!File.Exists(@"Datos\clientes.json"))
            {
                return;
            }

            var datosCliente = File.ReadAllText(@"Datos\clientes.json");

            clientes = JsonSerializer.Deserialize<List<ClienteEntidad>>(datosCliente)!;
        }

        public static void GrabarCliente()
        {
            var datosCliente = JsonSerializer.Serialize(clientes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(@"Datos\clientes.json", datosCliente);
        }



        public static ClienteEntidad BuscarClientePorId(int id)
        {
            return clientes.FirstOrDefault(c => c.IdCliente == id);
        }

        public static ClienteEntidad BuscarClientePorCuit(string cuit)
        {
            return clientes.FirstOrDefault(c => c.Cuit == cuit);
        }
    };



}
