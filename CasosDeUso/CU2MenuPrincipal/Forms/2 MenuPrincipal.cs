using TPGrupoE.CasoU_Orden_Preparacion;
using TPGrupoE.CasoU_Procesar_Orden_de_Seleccion;
using TPGrupoE.CasoU_Confirmar_Seleccion;
using TPGrupoE.CasoU_Generar_Orden_de_Entrega;
using TP_Grupo_E._6_CasoU_Cumplir_Orden_de_Entrega;
using TPGrupoE.CasoU_Empaquetado;

namespace TPGrupoE
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        ProcesarOrdenPreparacionForm ProcesarOrdenPreparacion = new ProcesarOrdenPreparacionForm();
        GenerarOrdenSeleccionForm ProcesarOrdenSeleccion = new GenerarOrdenSeleccionForm();
        EmitirRemitoForm EmitirRemito = new EmitirRemitoForm();
        GestionarOrdenSeleccionForm ConfirmarSeleccion = new GestionarOrdenSeleccionForm();
        CumplirOrdenEntregaForm CumplirOrdenEntrega = new CumplirOrdenEntregaForm();
        CumplirOrdenEntregaForm GenerarOrdenDespacho = new CumplirOrdenEntregaForm();
        EmpaquetadoForm Empaquetado = new EmpaquetadoForm();

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
            CumplirOrdenEntrega.ShowDialog();
        }

        private void emitirRemitoButton_Click(object sender, EventArgs e)
        {
            EmitirRemito.ShowDialog();
        }
        private void empaquetarButton_Click(object sender, EventArgs e)
        {
            EmpaquetadoForm empaquetadoForm = new EmpaquetadoForm();
            this.Hide();
            empaquetadoForm.Show();
        }
    }
}
