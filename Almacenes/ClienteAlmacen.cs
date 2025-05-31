using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPGrupoE.Almacenes
{
    internal static class ClienteAlmacen
    {
        private static List<ClienteEntidad> clientes = new List<ClienteEntidad>()
        {
            new ClienteEntidad() { Cuit = "30-12345678-9", RazonSocial = "Tecnología Avanzada S.A.", Domicilio = "Av. Libertador 1234, CABA" },
            new ClienteEntidad() { Cuit = "33-98765432-1", RazonSocial = "Distribuidora Norte S.R.L.", Domicilio = "Rivadavia 567, Mendoza" },
            new ClienteEntidad() { Cuit = "27-45678901-3", RazonSocial = "Farmacia del Pueblo", Domicilio = "Belgrano 89, Córdoba" },
            new ClienteEntidad() { Cuit = "20-34567890-2", RazonSocial = "Constructora Edificar S.A.", Domicilio = "San Martín 2345, Rosario" },
            new ClienteEntidad() { Cuit = "23-56789012-4", RazonSocial = "Alimentos Naturales S.A.", Domicilio = "Corrientes 123, Buenos Aires" },
            new ClienteEntidad() { Cuit = "24-78901234-5", RazonSocial = "Textiles del Sur S.R.L.", Domicilio = "Mitre 876, Bahía Blanca" },
            new ClienteEntidad() { Cuit = "30-23456789-0", RazonSocial = "Electrodomésticos Modernos", Domicilio = "Sarmiento 543, Mar del Plata" },
            new ClienteEntidad() { Cuit = "33-89012345-6", RazonSocial = "Logística Integral S.A.", Domicilio = "Av. Colón 321, Tucumán" },
            new ClienteEntidad() { Cuit = "27-67890123-7", RazonSocial = "Consultoría Profesional S.R.L.", Domicilio = "Lavalle 765, Salta" },
            new ClienteEntidad() { Cuit = "20-90123456-8", RazonSocial = "Importadora Exportadora S.A.", Domicilio = "Av. Santa Fe 987, CABA" }
        };

        public static IReadOnlyList<ClienteEntidad> Clientes = clientes.AsReadOnly(); 
    }
}
