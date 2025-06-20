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
            try
            {
                ApplicationConfiguration.Initialize();

                Application.Run(new MenuPrincipalGeneralForm());

                ClienteAlmacen.GrabarCliente();
                DepositosAlmacen.GrabarDeposito();
                StockFisicoAlmacen.GrabarStock();
                OrdenPreparacionAlmacen.GrabarOP();
                OrdenPickingAlmacen.GrabarOS();
                OrdenEntregaAlmacen.GrabarOE();
                ProductoAlmacen.GrabarProducto();
                RemitoAlmacen.GrabarRemito();
                FlujoMovimientosAlmacen.GrabarMovimiento();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al iniciar la aplicación: " + ex.Message);
            }
        }
        //esto es para hacer un nuevo commit
    }
}