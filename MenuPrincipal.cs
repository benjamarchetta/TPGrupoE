using TPGrupoE.CasoU_Orden_Preparacion;
using TPGrupoE.CasoU_Procesar_Orden_de_Seleccion;
using TPGrupoE.CasoU_Confirmar_Seleccion;
using TPGrupoE.CasoU_Generar_Orden_de_Entrega;
using TPGrupoE.CasoU_Generar_Orden_de_Despacho;

namespace TPGrupoE
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        ProcesarOrdenPreparacionForm ProcesarOrdenPreparacion = new ProcesarOrdenPreparacionForm();
        CargarOrdenSeleccionForm ProcesarOrdenSeleccion = new CargarOrdenSeleccionForm();
        CargarOrdenDeEntregaForm GenerarOrdenDeEntrega = new CargarOrdenDeEntregaForm();
        CumplirOrdenSeleccionForm ConfirmarSeleccion = new CumplirOrdenSeleccionForm();
        CumplirOrdenEntregaForm GenerarOrdenDespacho = new CumplirOrdenEntregaForm();

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void buttonPrototipo_Click(object sender, EventArgs e)
        {
            ProcesarOrdenPreparacion.ShowDialog();
        }

        private void ProcOrdenSeleccionButton_Click(object sender, EventArgs e)
        {
            ProcesarOrdenSeleccion.ShowDialog();
        }

        private void confirmarSeleccionButton_Click(object sender, EventArgs e)
        {
            ConfirmarSeleccion.ShowDialog();
        }

        private void generarOrdenEntrega_Click(object sender, EventArgs e)
        {
            GenerarOrdenDeEntrega.ShowDialog();
        }

        private void GenerarOrdenDespachoButton_Click(object sender, EventArgs e)
        {
            GenerarOrdenDespacho.ShowDialog();
        }
    }
}
