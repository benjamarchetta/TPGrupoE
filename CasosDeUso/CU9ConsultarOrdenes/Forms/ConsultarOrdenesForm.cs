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
using TPGrupoE.CasosDeUso.CU9ConsultarOrdenes.Model;

namespace TPGrupoE.CasosDeUso.CU9ConsultaOrdenes.Forms
{
    public partial class ConsultarOrdenesForm : Form
    {
        private ConsultarOrdenesModelo _consultarOrdenesModel;

        public ConsultarOrdenesForm()
        {
            InitializeComponent();
            _consultarOrdenesModel = new ConsultarOrdenesModelo();

            EstadoActualOrdenesListView.FullRowSelect = true;
            EstadoActualOrdenesListView.View = View.Details;
            HistoricoOrdenesListView.View = View.Details;

            EstadoActualOrdenesListView.SelectedIndexChanged += EstadoActualOrdenesListView_SelectedIndexChanged;
            VolverMenuPrincipalButton.Click += VolverMenuPrincipalButton_Click;
            
            InicializarFiltros();
          
            CargarOrdenesActuales();
        }

        private void CargarOrdenesActuales()
        {
            EstadoActualOrdenesListView.Items.Clear();

            foreach (var orden in _consultarOrdenesModel.Ordenes)
            {
                var item = new ListViewItem(new[]
                {
                    orden.IdOrdenPreparacion.ToString(),
                    orden.Estado.ToString(),
                    orden.FechaEntrega.ToShortDateString(),
                    orden.ClienteCuit,
                    orden.ClienteRazonSocial,
                    orden.DepositoDomicilio,
                    orden.FechaUltimaActualizacionEstado.ToString("g")
                });

                item.Tag = orden.IdOrdenPreparacion;
                EstadoActualOrdenesListView.Items.Add(item);
            }

            EstadoActualOrdenesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            EstadoActualOrdenesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void EstadoActualOrdenesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EstadoActualOrdenesListView.SelectedItems.Count == 0)
                return;

            int idOrden = (int)EstadoActualOrdenesListView.SelectedItems[0].Tag;
            var orden = _consultarOrdenesModel.Ordenes.FirstOrDefault(o => o.IdOrdenPreparacion == idOrden);

            if (orden == null) return;

            // Labels
            IdOrdenPreparacionSeleccionadaLabel.Text = $"N° Órden seleccionada: {orden.IdOrdenPreparacion}";
            FechaEntregaOPSeleccionadaLabel.Text = $"Fecha de entrega: {orden.FechaEntrega.ToShortDateString()}";
            CuitRazonClienteLabel.Text = $"Cliente: {orden.ClienteCuit} - {orden.ClienteRazonSocial}";
            DepositoOPSeleccionadaLabel.Text = $"Depósito: {orden.DepositoDomicilio}";

            // Historico (delegado al modelo en una futura mejora si querés desacoplar más)
            var historico = _consultarOrdenesModel.BuscarHistoricoPorOrden(idOrden).OrderBy(m => m.FechaActualizacionEstado).ToList();

            HistoricoOrdenesListView.Items.Clear();

            foreach (var m in historico)
            {
                var item = new ListViewItem(new[]
                {
                    m.Estado.ToString(),
                    m.FechaActualizacionEstado.ToString("g")
                });

                HistoricoOrdenesListView.Items.Add(item);
            }

            HistoricoOrdenesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            HistoricoOrdenesListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void VolverMenuPrincipalButton_Click(object sender, EventArgs e)
        {
            VolverAlMenuPrincipal();
        }

        private void LimpiarBusquedaButton_Click(object sender, EventArgs e)
        {
            RazonSocialClienteFiltroComboBox.SelectedIndex = 0;
            EstadoOrdenFiltroComboBox.SelectedIndex = 0;
            CargarOrdenesFiltradas(_consultarOrdenesModel.Ordenes);
        }

        private void BuscarOrdenesButton_Click(object sender, EventArgs e)
        {
            int? idCliente = null;
            if (RazonSocialClienteFiltroComboBox.SelectedIndex > 0)
                idCliente = ((ClienteFiltro)RazonSocialClienteFiltroComboBox.SelectedItem).IdCliente;

            EstadoOrdenPreparacion? estado = null;
            if (EstadoOrdenFiltroComboBox.SelectedIndex > 0)
                estado = ((EstadoOrdenFiltro)EstadoOrdenFiltroComboBox.SelectedItem).Estado;

            var filtradas = _consultarOrdenesModel.Ordenes
                .Where(o => (!idCliente.HasValue || o.IdCliente == idCliente.Value) &&
                            (!estado.HasValue || o.Estado == estado.Value))
                .ToList();

            CargarOrdenesFiltradas(filtradas);
        }

        private void CargarOrdenesFiltradas(List<HistorialDeOrdenesPreparacion> ordenes)
        {
            EstadoActualOrdenesListView.Items.Clear();

            foreach (var orden in ordenes)
            {
                var item = new ListViewItem
                (new[]
                {
                    orden.IdOrdenPreparacion.ToString(),
                    orden.Estado.ToString(),
                    orden.FechaEntrega.ToShortDateString(),
                    orden.ClienteCuit,
                    orden.ClienteRazonSocial,
                    orden.DepositoDomicilio,
                    orden.FechaUltimaActualizacionEstado.ToString("g")
                }
                );

                item.Tag = orden.IdOrdenPreparacion;
                EstadoActualOrdenesListView.Items.Add(item);
            }

            HistoricoOrdenesListView.Items.Clear();
            IdOrdenPreparacionSeleccionadaLabel.Text = "N° Órden seleccionada:";
            FechaEntregaOPSeleccionadaLabel.Text = "Fecha de entrega:";
            CuitRazonClienteLabel.Text = "Cliente:";
            DepositoOPSeleccionadaLabel.Text = "Depósito:";
        }

        private void InicializarFiltros()
        {
            // Clientes
            RazonSocialClienteFiltroComboBox.Items.Clear();
            RazonSocialClienteFiltroComboBox.Items.Add("(Todos)");
            RazonSocialClienteFiltroComboBox.DisplayMember = "ToString";

            var clientes = _consultarOrdenesModel.ObtenerClientesParaFiltro()
                .GroupBy(c => c.IdCliente)
                .Select(g => g.First())
                .OrderBy(c => c.RazonSocial)
                .ToList();

            foreach (var cliente in clientes)
                RazonSocialClienteFiltroComboBox.Items.Add(cliente);

            RazonSocialClienteFiltroComboBox.SelectedIndex = 0;

            // Estados
            EstadoOrdenFiltroComboBox.Items.Clear();
            EstadoOrdenFiltroComboBox.Items.Add("(Todos)");

            foreach (var estado in _consultarOrdenesModel.ObtenerEstadosParaFiltro())
                EstadoOrdenFiltroComboBox.Items.Add(estado);

            EstadoOrdenFiltroComboBox.SelectedIndex = 0;
        }

        private void VolverAlMenuPrincipal()
        {
            this.Close();

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

        private void ConsultarOrdenesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenuPrincipal();
        }



    }
}
