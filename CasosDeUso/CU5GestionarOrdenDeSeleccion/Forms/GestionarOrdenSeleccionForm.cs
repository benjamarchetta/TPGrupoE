using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model;
namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Forms
{
    public partial class GestionarOrdenSeleccionForm : Form
    {
        private GestionOrdenSeleccionModel _modelo;

        public GestionarOrdenSeleccionForm()
        {
            InitializeComponent();
            _modelo = new GestionOrdenSeleccionModel();
            ConfigurarControles();
            CargarDatosIniciales();
            VerDetallesButton.Click += VerDetallesButton_Click;
            confirmarSeleccionButton.Click += confirmarSeleccionButton_Click;
            cancelarSeleccionButton.Click += cancelarSeleccionButton_Click;
        }

        private void ConfigurarControles()
        {
            // LISTVIEW DE ÓRDENES
            ordenesListView.View = View.Details;
            ordenesListView.FullRowSelect = true;
            ordenesListView.MultiSelect = false;
            ordenesListView.CheckBoxes = true;
            ordenesListView.Columns.Add("ID Orden", 100);
            ordenesListView.Columns.Add("Cliente", 200);
            ordenesListView.Columns.Add("Estado", 100);
            ordenesListView.Columns.Add("Fecha Despacho", 150);

            // LISTVIEW DE PRODUCTOS
            detalleProductosListView.View = View.Details;
            detalleProductosListView.FullRowSelect = true;
            detalleProductosListView.MultiSelect = false;
            detalleProductosListView.Columns.Add("SKU", 100);
            detalleProductosListView.Columns.Add("Descripción", 100);
            detalleProductosListView.Columns.Add("Cantidad", 100);
            detalleProductosListView.Columns.Add("Pallet Cerrado", 120);
            detalleProductosListView.Columns.Add("Ubicación", 100);

            VerDetallesButton.Text = "Seleccionar mercadería";
            VerDetallesButton.Enabled = false;
            confirmarSeleccionButton.Enabled = false;

            ordenesListView.ItemCheck += ordenesListView_ItemCheck;
        }

        private void CargarDatosIniciales()
        {
            ordenesListView.Items.Clear();

            if (_modelo.OrdenesDeSeleccion.Count == 0)
            {
                MessageBox.Show("No hay órdenes de selección pendientes.");
                return;
            }

            foreach (var orden in _modelo.OrdenesDeSeleccion)
            {
                var item = new ListViewItem(orden.IdOrdenSeleccion.ToString());
                item.SubItems.Add(orden.Cliente);
                item.SubItems.Add(orden.Estado);
                item.SubItems.Add(orden.FechaDespacho);
                item.Tag = orden.IdOrdenSeleccion;

                ordenesListView.Items.Add(item);
            }
        }

        private void ordenesListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            BeginInvoke((MethodInvoker)delegate
            {
                VerDetallesButton.Enabled = ordenesListView.CheckedItems.Count > 0;
                cancelarSeleccionButton.Enabled = ordenesListView.CheckedItems.Count > 0;
            });
        }

        private void VerDetallesButton_Click(object sender, EventArgs e)
        {
            if (ordenesListView.CheckedItems.Count == 0) return;

            detalleProductosListView.Items.Clear();

            foreach (ListViewItem item in ordenesListView.CheckedItems)
            {
                int idOrdenSeleccion = (int)item.Tag;


                    detalleProductosListView.Items.Add(fila);
                }
            }

            confirmarSeleccionButton.Enabled = true;
            cancelarSeleccionButton.Enabled = true;
        }

        private void confirmarSeleccionButton_Click(object sender, EventArgs e)
        {
            if (ordenesListView.CheckedItems.Count == 0) return;

            var ids = new List<int>();
            foreach (ListViewItem item in ordenesListView.CheckedItems)
            {
                ids.Add((int)item.Tag);
            }

            var mensaje = $"¿Desea confirmar el cumplimiento de la/s siguiente/s orden/es?\n\n" +
                          string.Join("\n", ids.Select(id => $"OS-{id:D5}"));

            var result = MessageBox.Show(mensaje, "Confirmar selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (var id in ids)
                {
                    _modelo.ConfirmarSeleccion(id);
                }

                MessageBox.Show("Órdenes de selección confirmadas correctamente.");

                detalleProductosListView.Items.Clear();
                confirmarSeleccionButton.Enabled = false;
                VerDetallesButton.Enabled = false;

                CargarDatosIniciales();
            }
        }

        private void cancelarSeleccionButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ordenesListView.CheckedItems)
            {
                item.Checked = false;
            }

            detalleProductosListView.Items.Clear();
            confirmarSeleccionButton.Enabled = false;
            cancelarSeleccionButton.Enabled = false;
            VerDetallesButton.Enabled = ordenesListView.CheckedItems.Count > 0;
        }

        private void volverAlMenuButton_Click(object sender, EventArgs e)
        {
            var menuForm = new MenuPrincipalGeneralForm();
            menuForm.Show();
            this.Close();
        }
    }
}


