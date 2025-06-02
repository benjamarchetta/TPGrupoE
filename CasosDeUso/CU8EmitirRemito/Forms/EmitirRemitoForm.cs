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
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using TPGrupoE.CasosDeUso.CU8EmitirRemito.Model;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Forms
{
    public partial class EmitirRemitoForm : Form
    {
        private readonly EmitirRemitoModel _model = new();

        public EmitirRemitoForm()
        {
            InitializeComponent();
            _model.CargarDatosIniciales();
            CargarCombos();

            // Eventos
            SeleccionarButton.Click += SeleccionarButton_Click;
            EmitirRemitoButton.Click += EmitirRemitoButton_Click;
            VolverButton.Click += VolverButton_Click;
        }

        private void CargarCombos()
        {
            // Cargar clientes en ComboBox
            ClienteComboBox.DataSource = _model.ObtenerClientes();
            ClienteComboBox.DisplayMember = "RazonSocial";
            ClienteComboBox.ValueMember = "IdCliente";

            // Cargar transportistas en ComboBox
            TransportistaComboBox.DataSource = _model.Transportistas;
            TransportistaComboBox.DisplayMember = "Text";
            TransportistaComboBox.ValueMember = "Value";
        }

        private void SeleccionarButton_Click(object sender, EventArgs e)
        {
            EmitirRemitoListView.Items.Clear();

            if (ClienteComboBox.SelectedItem == null || TransportistaComboBox.SelectedItem == null)
                return;

            int idCliente = ((ClienteEntidad)ClienteComboBox.SelectedItem).IdCliente;
            int dni = (int)TransportistaComboBox.SelectedValue;

            _model.CargarOrdenesPorTransportistaYCliente(dni, idCliente);

            foreach (var op in _model.OrdenesFiltradas)
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

            int idCliente = ((ClienteEntidad)ClienteComboBox.SelectedItem).IdCliente;
            int dni = (int)TransportistaComboBox.SelectedValue;

            var confirmacion = MessageBox.Show(
                "¿Desea emitir el remito para las siguientes OP?\n" + string.Join(", ", seleccionados),
                "Confirmar emisión",
                MessageBoxButtons.OKCancel);

            if (confirmacion == DialogResult.OK)
            {
                var idRemito = _model.EmitirRemito(dni, idCliente, seleccionados);
                MessageBox.Show($"Remito generado con éxito. ID: {idRemito}");
                SeleccionarButton.PerformClick(); // refresco la lista
            }
        }

        private void VolverButton_Click(object sender, EventArgs e)
        {
            this.Close(); // O volver al menú principal
        }
    }
}
