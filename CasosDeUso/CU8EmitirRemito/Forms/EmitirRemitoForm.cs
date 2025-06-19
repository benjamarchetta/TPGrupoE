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
using TPGrupoE.CasosDeUso.CU8EmitirRemito.Model;
using static TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model.OrdenPreparacionModelo;
using static TPGrupoE.CasosDeUso.CU8EmitirRemito.Model.EmitirRemitoModel;
using OrdenPreparacion = TPGrupoE.CasosDeUso.CU8EmitirRemito.Model.EmitirRemitoModel.OrdenPreparacion;

namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Forms
{
    public partial class EmitirRemitoForm : Form
    {
        private EmitirRemitoModel _emitirRemitoModel;

        public EmitirRemitoForm()
        {
            InitializeComponent();
            _emitirRemitoModel = new EmitirRemitoModel();
        }
        private void DespacharyEmitirRemitoButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se generó correctamente el remito y se registró correctamente el despacho de las órdenes de preparación.");
        }

        private void EmitirRemito_Load(object sender, EventArgs e)
        {
            if (!_emitirRemitoModel.HayOrdenesPreparadas())
            {
                MessageBox.Show("No hay ninguna orden de preparación para despachar.");
                Close(); return;
            }

            var (transportistas, clientes) = _emitirRemitoModel.ObtenerFiltrosDisponibles();

            CargarComboBox(TransportistaComboBox, transportistas, "DisplayText", "Documento");
            CargarComboBox(ClienteComboBox, clientes, "DisplayText", "Cuit");


        }

        private void CargarComboBox(ComboBox combo, object data, string display, string value)
        {
            combo.SelectedIndexChanged -= ComboBox_SelectionChanged;
            combo.DataSource = data;
            combo.DisplayMember = display;
            combo.ValueMember = value;
            combo.SelectedIndex = -1;
            combo.SelectedIndexChanged += ComboBox_SelectionChanged;
        }

        private void ComboBox_SelectionChanged(object sender, EventArgs e)
        {
            // Solo habilitar botón si hay ambos seleccionados
            SeleccionarButton.Enabled =
                TransportistaComboBox.SelectedIndex != -1 &&
                ClienteComboBox.SelectedIndex != -1;
        }

        //private void CargarTransportistaComboBox(List<Transportista> transportistas)
        //{
        //    TransportistaComboBox.DataSource = transportistas;
        //    TransportistaComboBox.DisplayMember = "DisplayText";
        //    TransportistaComboBox.ValueMember = "Documento";
        //    TransportistaComboBox.SelectedIndex = -1;
        //}

        //private void CargarClienteComboBox(List<Cliente> clientes)
        //{
        //    ClienteComboBox.DataSource = clientes;
        //    ClienteComboBox.DisplayMember = "DisplayText";
        //    ClienteComboBox.ValueMember = "Cuit";
        //    ClienteComboBox.SelectedIndex = -1;
        //}

        private void TransportistaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (TransportistaComboBox.SelectedIndex == -1) return;

            if (_emitirRemitoModel.OrdenesSeleccionadas.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Ya hay órdenes seleccionadas. Si cambia el transportista o cliente se perderán los cambios actuales. ¿Desea continuar?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    TransportistaComboBox.SelectedIndexChanged -= TransportistaComboBox_SelectedIndexChanged;
                    TransportistaComboBox.SelectedIndex = -1;
                    TransportistaComboBox.SelectedIndexChanged += TransportistaComboBox_SelectedIndexChanged;
                    return;
                }

                _emitirRemitoModel.OrdenesSeleccionadas.Clear();
                EmitirRemitoListView.Items.Clear();
                ConfirmarDespachoListView.Items.Clear();
            }

            string dni = TransportistaComboBox.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(dni)) return;

            _emitirRemitoModel.CargarClientesPorTransportista(dni);
            var clientes = _emitirRemitoModel.Clientes;

            ClienteComboBox.DataSource = clientes;
            ClienteComboBox.DisplayMember = "DisplayText";
            ClienteComboBox.ValueMember = "Cuit";
            ClienteComboBox.SelectedIndex = -1;
        }

        private void ClienteComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ClienteComboBox.SelectedIndex == -1) return;

            if (_emitirRemitoModel.OrdenesSeleccionadas.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Ya hay órdenes seleccionadas. Si cambia el cliente o transportista se perderán los cambios actuales. ¿Desea continuar?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                {
                    ClienteComboBox.SelectedIndexChanged -= ClienteComboBox_SelectedIndexChanged;
                    ClienteComboBox.SelectedIndex = -1;
                    ClienteComboBox.SelectedIndexChanged += ClienteComboBox_SelectedIndexChanged;
                    return;
                }

                _emitirRemitoModel.OrdenesSeleccionadas.Clear();
                EmitirRemitoListView.Items.Clear();
                ConfirmarDespachoListView.Items.Clear();
            }

            string cuitCliente = ClienteComboBox.SelectedValue?.ToString();
            if (string.IsNullOrEmpty(cuitCliente)) return;

            _emitirRemitoModel.CargarTransportistasPorCliente(cuitCliente);
            var transportistas = _emitirRemitoModel.Transportistas;

            TransportistaComboBox.DataSource = transportistas;
            TransportistaComboBox.DisplayMember = "DisplayText";
            TransportistaComboBox.ValueMember = "Documento";
            TransportistaComboBox.SelectedIndex = -1;
        }

        private void ActualizarTabla()
        {
            List<OrdenPreparacion> ordenesPreparacion = _emitirRemitoModel.OrdenesDePreparacion
                  .Where(o => !_emitirRemitoModel.OrdenesSeleccionadas.Any(s => s.Id == o.Id))
                  .ToList();

            EmitirRemitoListView.Items.Clear();

            if (ordenesPreparacion.Count == 0)
            {
                MessageBox.Show("No hay órdenes a despachar para el transportista y cliente seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var orden in ordenesPreparacion)
            {
                var item = new ListViewItem(new[]
                {
            orden.Id.ToString(),
            orden.FechaEntrega.ToString("dd/MM/yyyy")
        });

                EmitirRemitoListView.Items.Add(item);
            }
        }

        private void SeleccionarTransportistaButton_Click(object sender, EventArgs e)
        {
            if (TransportistaComboBox.SelectedIndex == -1 || ClienteComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un transportista y un cliente.", "Campos obligatorios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_emitirRemitoModel.OrdenesSeleccionadas.Count > 0)
            {
                DialogResult result = MessageBox.Show(
                    "Se perderán las órdenes ya seleccionadas. ¿Desea continuar?",
                    "Aviso",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (result == DialogResult.No)
                    return;

                _emitirRemitoModel.OrdenesSeleccionadas.Clear();
                ConfirmarDespachoListView.Items.Clear();
            }

            EmitirRemitoListView.Items.Clear();

            string documentoTransportista = TransportistaComboBox.SelectedValue?.ToString();
            string cuitCliente = ClienteComboBox.SelectedValue?.ToString();

            if (string.IsNullOrWhiteSpace(documentoTransportista) || string.IsNullOrWhiteSpace(cuitCliente))
            {
                MessageBox.Show("Error en la selección. Verifique los valores.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _emitirRemitoModel.CargarOrdenesPorTransportistaYCliente(documentoTransportista, cuitCliente);
            ActualizarTabla();

        }

        private void MarcarOpDespachadaButton_Click(object sender, EventArgs e)
        {
            if (_emitirRemitoModel.OrdenesSeleccionadas.Count == 0)
            {
                MessageBox.Show("No hay órdenes seleccionadas para despachar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string error = _emitirRemitoModel.MarcarOpDespachada();

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Órdenes despachadas correctamente", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string documentoTransportista = TransportistaComboBox.SelectedValue?.ToString();
            string cuitCliente = ClienteComboBox.SelectedValue?.ToString();

            if (!string.IsNullOrWhiteSpace(documentoTransportista) && !string.IsNullOrWhiteSpace(cuitCliente))
            {
                _emitirRemitoModel.CargarOrdenesPorTransportistaYCliente(documentoTransportista, cuitCliente);
                _emitirRemitoModel.OrdenesSeleccionadas.Clear();
                ActualizarTabla();
                ActualizarListaConfirmar();
            }
        }

        private void AgregarPictureBox_Click(object sender, EventArgs e)
        {
            if (EmitirRemitoListView.SelectedItems.Count == 0) return;

            foreach (ListViewItem item in EmitirRemitoListView.SelectedItems.Cast<ListViewItem>().ToList())
            {
                int idOrden = int.Parse(item.SubItems[0].Text);

                if (!_emitirRemitoModel.OrdenesSeleccionadas.Any(o => o.Id == idOrden))
                {
                    var orden = _emitirRemitoModel.OrdenesDePreparacion.FirstOrDefault(o => o.Id == idOrden);
                    if (orden != null)
                    {
                        _emitirRemitoModel.OrdenesSeleccionadas.Add(orden);
                        EmitirRemitoListView.Items.Remove(item); // Quitar del izquierdo
                    }
                }
            }

            ActualizarListaConfirmar();
        }

        private void EliminarPictureBox_Click(object sender, EventArgs e)
        {
            if (ConfirmarDespachoListView.SelectedItems.Count == 0) return;

            foreach (ListViewItem item in ConfirmarDespachoListView.SelectedItems.Cast<ListViewItem>().ToList())
            {
                int idOrden = int.Parse(item.SubItems[0].Text);

                var orden = _emitirRemitoModel.OrdenesSeleccionadas.FirstOrDefault(o => o.Id == idOrden);
                if (orden != null)
                {
                    _emitirRemitoModel.OrdenesSeleccionadas.Remove(orden);

                    var nuevoItem = new ListViewItem(new[]
                    {
                orden.Id.ToString(),
                orden.FechaEntrega.ToString("dd/MM/yyyy")
            });

                    EmitirRemitoListView.Items.Add(nuevoItem); // Devolver al izquierdo
                }

                ConfirmarDespachoListView.Items.Remove(item);
            }
        }

        private void VolverMenuPrincipalButton_Click(object sender, EventArgs e)
        {
            bool ordenEnProceso = OrdenEnProceso();

            if (!ordenEnProceso)
            {
                VolverAlMenuPrincipal();
                return;
            }
            DialogResult result = MessageBox.Show(
              "Se dispone a cerrar el formulario. ¿Está seguro?",
              "Aviso",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

            // Si 
            if (result == DialogResult.Yes)
            {
                VolverAlMenuPrincipal();
            }

        }

        private void ActualizarListaConfirmar()
        {
            ConfirmarDespachoListView.Items.Clear();

            foreach (var orden in _emitirRemitoModel.OrdenesSeleccionadas)
            {
                var item = new ListViewItem(new[]
                {
            orden.Id.ToString(),
            orden.FechaEntrega.ToString("dd/MM/yyyy")
        });

                ConfirmarDespachoListView.Items.Add(item);
            }
        }

        private bool OrdenEnProceso()
        {
            bool ordenEnProceso = false;

            if (EmitirRemitoListView.Items.Count > 0)
            {
                ordenEnProceso = true;
            }

            return ordenEnProceso;
        }

        private void VolverAlMenuPrincipal()
        {
            this.Close();
        }

        private void EmitirRemitoForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void EmitirRemitogroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}