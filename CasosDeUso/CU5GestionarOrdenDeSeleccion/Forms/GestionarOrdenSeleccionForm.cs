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
using TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model;

namespace TPGrupoE.CasoU_Confirmar_Seleccion
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
        }

        // --- Configuración inicial ---
        private void ConfigurarControles()
        {
            // Configurar ListView de órdenes pendientes
            verDetallesPreparacionListView.View = View.Details;
            verDetallesPreparacionListView.FullRowSelect = true;
            verDetallesPreparacionListView.MultiSelect = true;
            verDetallesPreparacionListView.Columns.Add("ID Orden", 100);
            verDetallesPreparacionListView.Columns.Add("Fecha Creación", 150);
            verDetallesPreparacionListView.Columns.Add("Cliente", 200);

            // Configurar botones
            VerDetallesButton.Text = "Seleccionar";
            VerDetallesButton.Enabled = false;
        }

        // --- Carga datos iniciales ---
        private void CargarDatosIniciales()
        {
            verDetallesPreparacionListView.Items.Clear();

            if (_modelo.OrdenesPendientes.Count == 0)
            {
                MessageBox.Show("No hay órdenes de selección pendientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var orden in _modelo.OrdenesPendientes)
            {
                var item = new ListViewItem(orden.IDOrdenSeleccion.ToString());
                item.SubItems.Add(orden.FechaCreacion.ToString("dd/MM/yyyy"));
                item.SubItems.Add(OrdenPreparacionAlmacen.ObtenerClientePorOrden(orden.IDsOrdenesPreparacion.First())?.Nombre ?? "N/A");
                item.Tag = orden; // Guardar objeto para referencia
                verDetallesPreparacionListView.Items.Add(item);
            }
        }

        // --- Evento Load (opcional) ---
        private void ConfirmarSeleccionForm_Load(object sender, EventArgs e)
        {
            // Puedes agregar lógica adicional aquí si es necesario
        }

        // --- Botón "Seleccionar" ---
        private void VerDetallesButton_Click(object sender, EventArgs e)
        {
            if (verDetallesPreparacionListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener órdenes seleccionadas
            var ordenesSeleccionadas = verDetallesPreparacionListView.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => (OrdenSeleccionEntidad)item.Tag)
                .ToList();

            _modelo.OrdenesSeleccionadas = ordenesSeleccionadas;
            _modelo.CargarDetalleMercaderia();

            // Mostrar detalles (ejemplo: en un MessageBox o otro ListView)
            var detalles = string.Join("\n", _modelo.DetalleMercaderia.Select(d => $"{d.SKU} - {d.Cantidad}x"));
            MessageBox.Show($"Productos a preparar:\n{detalles}", "Detalle de la Orden", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Habilitar confirmación (podrías agregar un botón "Confirmar")
            // btnConfirmar.Enabled = true;
        }

        // --- Evento cambio de selección ---
        private void verDetallesPreparacionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerDetallesButton.Enabled = verDetallesPreparacionListView.SelectedItems.Count > 0;
        }
    }
}
