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
            ordenesListView.View = View.Details;
            ordenesListView.FullRowSelect = true;
            ordenesListView.MultiSelect = false;
            ordenesListView.CheckBoxes = true;
            ordenesListView.Columns.Add("ID Orden", 100);
            ordenesListView.Columns.Add("Cliente", 200);
            ordenesListView.Columns.Add("Estado", 100);
            ordenesListView.Columns.Add("Fecha Despacho", 150);

            detalleProductosListView.View = View.Details;
            detalleProductosListView.FullRowSelect = true;
            detalleProductosListView.MultiSelect = false;
            detalleProductosListView.Columns.Add("SKU", 100);
            detalleProductosListView.Columns.Add("Descripción", 100);
            detalleProductosListView.Columns.Add("Cantidad", 100);
            detalleProductosListView.Columns.Add("Pallet Cerrado", 120);
            detalleProductosListView.Columns.Add("Ubicación", 300);
            detalleProductosListView.Columns.Add("Domicilio", 400); // Nueva columna para domicilio

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
                MessageBox.Show("📭 No hay órdenes de selección pendientes.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            detalleProductosListView.Items.Clear(); // Limpiar el ListView de productos

            // Iterar sobre las órdenes seleccionadas
            foreach (ListViewItem item in ordenesListView.CheckedItems)
            {
                int idOrdenSeleccion = (int)item.Tag;
                var productos = _modelo.ObtenerDetalleProductos(idOrdenSeleccion);  // Obtener los productos

                // Agregar los productos al ListView
                foreach (var p in productos)
                {
                    var fila = new ListViewItem(p.Sku); // SKU
                    fila.SubItems.Add(p.Descripcion); // Descripción
                    fila.SubItems.Add(p.Cantidad.ToString()); // Cantidad
                    fila.SubItems.Add(p.PalletCerrado); // Pallet Cerrado
                    fila.SubItems.Add(p.Ubicacion); // Ubicación
                    fila.SubItems.Add(p.Domicilio); // Domicilio del depósito

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

            var mensaje = " ÓRDENES A CONFIRMAR \n\n" +
                  "Se procederá a confirmar el cumplimiento de las siguientes órdenes:\n\n" +
                  string.Join("\n", ids.Select(id => $"• Orden N° {id}")) +
                  "\n\n¿Desea continuar?";

            var result = MessageBox.Show(mensaje, "Confirmar selección", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                foreach (var id in ids)
                {
                    _modelo.ConfirmarSeleccion(id);
                }

                MessageBox.Show(" Órdenes de selección confirmadas correctamente.", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            VolverAlMenuPrincipal();
        }

        private void VolverAlMenuPrincipal()
        {
            this.Close();
        }

        private void GestionarOrdenSeleccionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MenuPrincipalGeneralForm)
                {
                    form.Show();
                    return;
                }
            }

            new MenuPrincipalGeneralForm().Show();
        }
    }
}


