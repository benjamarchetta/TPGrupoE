using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;

namespace TPGrupoE
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();

                ClienteAlmacen.LeerCliente();
                DepositosAlmacen.LeerDeposito();
                StockFisicoAlmacen.LeerStock();
                OrdenPreparacionAlmacen.LeerOP();
                OrdenPickingAlmacen.LeerOS();
                OrdenEntregaAlmacen.LeerOE();
                ProductoAlmacen.LeerProducto();
                Application.Run(new MenuPrincipalGeneralForm());
                ClienteAlmacen.GrabarCliente();
                DepositosAlmacen.GrabarDeposito();
                StockFisicoAlmacen.GrabarStock();
                OrdenPreparacionAlmacen.GrabarOP();
                OrdenPickingAlmacen.GrabarOS();
                OrdenEntregaAlmacen.GrabarOE();
                ProductoAlmacen.GrabarProducto();
                RemitoAlmacen.GrabarRemito();
        }
        //esto es para hacer un nuevo commit
    }
}