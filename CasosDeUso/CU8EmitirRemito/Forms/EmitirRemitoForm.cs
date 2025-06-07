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
using static TPGrupoE.CasosDeUso.CU8EmitirRemito.Model.EmitirRemitoModel;
using static TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model.OrdenPreparacionModelo;
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
            CargarTransportistaComboBox();
            TransportistaComboBox.SelectedIndexChanged += TransportistaComboBox_SelectedIndexChanged;
        }
        private static string ConvertirEstadoEnumAString(EstadoOrdenPreparacion estado)
        {
            return estado switch
            {
                EstadoOrdenPreparacion.Preparada => "Lista para Despachar",
                //EstadoOrdenPreparacion.PendienteDeDespacho => "Pendiente de Despacho",
                _ => estado.ToString()
            };
        }
        private void CargarTransportistaComboBox()
        {
            List<Transportista> transportistas = _emitirRemitoModel.Transportistas;

            if (transportistas.Count == 0)
            {
                MessageBox.Show("No hay transportistas con ordenes de preparacion pendientes de despacho");
            }

            TransportistaComboBox.DataSource = transportistas;
            TransportistaComboBox.DisplayMember = "DisplayText";
            TransportistaComboBox.ValueMember = "Documento";

            TransportistaComboBox.SelectedIndex = -1;
        }
        private void TransportistaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (TransportistaComboBox.SelectedIndex == -1)
                return;

            CargarClienteComboBox();
        }
        private string BuscarDocumentoTransportista()
        {
            string documentoTransportista = "";

            if (TransportistaComboBox.SelectedValue != null)
            {
                documentoTransportista = TransportistaComboBox.SelectedValue.ToString();
            }

            string errorDocumentoTransportistaSeleccionado = _emitirRemitoModel.ValidarTransportista(documentoTransportista);

            if (errorDocumentoTransportistaSeleccionado != null)
            {
                MessageBox.Show(errorDocumentoTransportistaSeleccionado);
                return null;
            }

            return documentoTransportista;
        }
        private void CargarClienteComboBox()
        {
            string documentoTransportista = BuscarDocumentoTransportista();
            if (documentoTransportista == null) return;

            _emitirRemitoModel.CargarClientesPorTransportista(documentoTransportista);
            List<Cliente> clientes = _emitirRemitoModel.Clientes;

            if (clientes.Count == 0)
            {
                MessageBox.Show("No hay clientes con órdenes de preparación preparadas para este transportista.");
            }

            ClienteComboBox.DataSource = clientes;
            ClienteComboBox.DisplayMember = "DisplayText"; 
            ClienteComboBox.ValueMember = "Cuit";          

            ClienteComboBox.SelectedIndex = -1;
        }
        private void ActualizarTabla()
        {
            string documentoTransportista = BuscarDocumentoTransportista();

            List<OrdenPreparacion> ordenesPreparacion = _emitirRemitoModel.OrdenesDePreparacion;

            EmitirRemitoListView.Items.Clear();

            if (ordenesPreparacion.Count == 0)
            {
                MessageBox.Show("No hay ordenes de preparacion pendientes de despacho para el transportista seleccionado");
                return;
            }

            foreach (var orden in ordenesPreparacion)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.Id.ToString(),
                        ConvertirEstadoEnumAString(orden.Estado),
                        orden.IdOrdenEntrega.ToString(),
                        orden.FechaEntrega.ToString("dd/MM/yyyy"),
            });

                EmitirRemitoListView.Items.Add(item);
            }
        }
        private void SeleccionarTransportistaButton_Click(object sender, EventArgs e)
        {
            string documentoTransportista = BuscarDocumentoTransportista();
            if (documentoTransportista == null)
            {
                return;
            }
            _emitirRemitoModel.CargarOrdenesPorTransportista(documentoTransportista);
            CargarClienteComboBox();
            ActualizarTabla();
        }
        private void MarcarOpDespachadaButton_Click(object sender, EventArgs e)
        {
            BuscarDocumentoTransportista();
            string error = _emitirRemitoModel.MarcarOpDespachada();

            if (error != null)
            {
                MessageBox.Show(error);
                return;
            }

            MessageBox.Show("Ordenes despachadas correctamente");
            ActualizarTabla();
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
            this.Hide();

            foreach (Form form in Application.OpenForms)
            {
                if (form is MenuPrincipalGeneralForm)
                {
                    form.Show();
                    return;
                }
            }

            MenuPrincipalGeneralForm menuPrincipalForm = new MenuPrincipalGeneralForm();
            menuPrincipalForm.Show();
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
              "Advertencia",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Warning);

            // Si 
            if (result == DialogResult.Yes)
            {
                VolverAlMenuPrincipal();
            }

        }
        private void EmitirRemitoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenuPrincipal();
        }
    }
}