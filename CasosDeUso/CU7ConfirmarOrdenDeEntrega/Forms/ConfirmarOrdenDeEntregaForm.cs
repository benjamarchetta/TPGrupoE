using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using TPGrupoE.CasosDeUso.CU7ConfirmarOrdenDeEntrega.Model;

namespace TPGrupoE.CasosDeUso.CU7ConfirmarOrdenDeEntrega.Forms
{
    public partial class ConfirmarOrdenDeEntregaForm : Form
    {
        private ConfirmarOrdenDeEntregaModelo _ordenDeEntregaModel;
        public ConfirmarOrdenDeEntregaForm()
        {
            InitializeComponent();
            _ordenDeEntregaModel = new ConfirmarOrdenDeEntregaModelo();
        }

        //Es la acción que genera la órden de entrega
        private void LiberarParaDespacho_Click(object sender, EventArgs e)
        {
            string errorOrdenEntrega = _ordenDeEntregaModel.ValidarOrdenEntrega();

            if (errorOrdenEntrega != null)
            {
                MessageBox.Show(errorOrdenEntrega);
                return;
            }

            _ordenDeEntregaModel.ConfirmarOrdenEntrega();
            MessageBox.Show("Las órdenes fueron confirmadas y liberadas para despacho.", "Orden de Entrega Confirmada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            _ordenDeEntregaModel = new ConfirmarOrdenDeEntregaModelo();
            if (!ValidarOrdenesYVolverSiNoHay())
                return;
            ActualizarTabla();
        }

        //Carga la nueva orden de entrega en OrdenEntregaAlmacen
        private void OrdenEntregaForm_Load(object sender, EventArgs e)
        {
            _ordenDeEntregaModel = new ConfirmarOrdenDeEntregaModelo();
            if (!ValidarOrdenesYVolverSiNoHay())
            {
                // Cierra el formulario si no hay órdenes al cargar
                this.Close();
                return;
            }
            ActualizarTabla();
        }


        private void ActualizarTabla()
        {


            List<OrdenDePreparacionADespachar> ordenesPreparacion = _ordenDeEntregaModel.OrdenesDePreparacion;

            OrdenesEmpaquetadasListView.Items.Clear();

            foreach (var orden in ordenesPreparacion)
            {
                var item = new ListViewItem(new[]
                {
                    orden.IdOrdenPreparacion.ToString(),
                    orden.IdOrdenEntrega.ToString(),
                    orden.FechaEntrega.ToShortDateString()
                });

                OrdenesEmpaquetadasListView.Items.Add(item);
            }
        }

        private void VolverAlMenuPrincipal()
        {
            // Solo oculta el formulario actual
            this.Hide();

            // Mostrar el formulario de menú principal
            // Verifica si el formulario principal ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is MenuPrincipalGeneralForm)
                {
                    form.Show(); // Muestra el formulario si está oculto
                    return;
                }
            }

            // Si no está abierto, crea una nueva instancia (solo si es necesario)
            MenuPrincipalGeneralForm menuPrincipalForm = new MenuPrincipalGeneralForm();
            menuPrincipalForm.Show();
        }

        private void VolverMenuPrincipalButton_Click(object sender, EventArgs e)
        {
            VolverAlMenuPrincipal();
        }

        private void ConfirmarOrdenEntregaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenuPrincipal();
        }

        private bool ValidarOrdenesYVolverSiNoHay()
        {
            if (_ordenDeEntregaModel.OrdenesDePreparacion.Count == 0)
            {
                MessageBox.Show(
                    "No hay órdenes empaquetadas disponibles para confirmar.",
                    "Atención",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                VolverAlMenuPrincipal();
                return false;
            }

            return true;
        }
    }

}
