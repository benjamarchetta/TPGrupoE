#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU8EmitirRemito.Model;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Forms
{
    public partial class EmitirRemitoForm : Form
    {
        private EmitirRemitoModel _model = new();

        public EmitirRemitoForm()
        {
            InitializeComponent();
            _model.CargarDatosIniciales();
            CargarCombos();
            // Asocio eventos a botones
            Seleccionarbutton.Click += Seleccionarbutton_Click;
            EmitirRemitoButton.Click += EmitirRemitoButton_Click;
            VolverButton.Click += VolverButton_Click;
        }

        private void CargarCombos()
        {
            // Cargo clientes
            ClienteComboBox.DataSource = _model.ObtenerClientes();
            ClienteComboBox.DisplayMember = "RazonSocial";
            ClienteComboBox.ValueMember = "IdCliente";

            // Cargo transportistas
            TransportistaComboBox.DataSource = _model.ObtenerTransportistas();
        }

        private void Seleccionarbutton_Click(object sender, EventArgs e)
        {
            EmitirRemitoListView.Items.Clear();

            if (TransportistaComboBox.SelectedItem == null || ClienteComboBox.SelectedItem == null)
                return;

            int dni = (int)TransportistaComboBox.SelectedItem;
            int idCliente = ((ClienteEntidad)ClienteComboBox.SelectedItem).IdCliente;

            var ordenes = _model.BuscarOrdenesFiltradas(dni, idCliente);

            foreach (var op in ordenes)
            {
                var oe = OrdenEntregaAlmacen.OrdenesEntrega.FirstOrDefault(o => o.IdOrdenPreparacion.Contains(op.IdOrdenPreparacion));
                if (oe != null)
                {
                    var item = new ListViewItem(op.IdOrdenPreparacion.ToString());
                    item.SubItems.Add(oe.IdOrdenEntrega.ToString());
                    item.SubItems.Add(op.FechaEntrega.ToShortDateString());
                    EmitirRemitoListView.Items.Add(item);
                }
            }
        }

        private void EmitirRemitoButton_Click(object sender, EventArgs e)
        {
            if (EmitirRemitoListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos una orden de preparación.");
                return;
            }

            var seleccionados = EmitirRemitoListView.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => int.Parse(item.SubItems[0].Text))
                .ToList();

            var idCliente = ((ClienteEntidad)ClienteComboBox.SelectedItem).IdCliente;
            var dni = (int)TransportistaComboBox.SelectedItem;

            var confirmacion = MessageBox.Show(
                "¿Desea emitir el remito de las siguientes OP?\n" + string.Join(", ", seleccionados),
                "Confirmar emisión",
                MessageBoxButtons.OKCancel);

            if (confirmacion == DialogResult.OK)
            {
                var idRemito = _model.EmitirRemito(idCliente, dni, seleccionados);
                MessageBox.Show($"Remito generado con éxito. ID: {idRemito}");

                // Recargo la lista para que desaparezcan las OP despachadas
                Seleccionarbutton.PerformClick();
            }
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close(); // o ir al menú principal si tienen otro form
        }
    }
}