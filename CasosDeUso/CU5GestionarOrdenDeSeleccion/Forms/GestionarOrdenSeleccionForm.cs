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
using TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model;
using static TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model.GestionOrdenSeleccionModel;

namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Forms

{
    public partial class GestionarOrdenSeleccionForm : Form
    {
        private GestionOrdenSeleccionModel _modelo;
        private int idOrdenSeleccionActiva;
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
            detalleMercaderiaDataGridView.View = View.Details;
            detalleMercaderiaDataGridView.FullRowSelect = true;
            detalleMercaderiaDataGridView.MultiSelect = true;
            detalleMercaderiaDataGridView.Columns.Add("ID Orden", 100);
            detalleMercaderiaDataGridView.Columns.Add("Estado", 100);
            detalleMercaderiaDataGridView.Columns.Add("Fecha Creación", 150);
            detalleMercaderiaDataGridView.Columns.Add("Cliente", 200);

            // Configurar botones
            VerDetallesButton.Text = "Seleccionar mercadería";
            VerDetallesButton.Enabled = false;
            confirmarSeleccionButton.Enabled = false;
        }

        // --- Carga datos iniciales ---
        private void CargarDatosIniciales()
        {
            detalleMercaderiaDataGridView.Items.Clear();

            if (_modelo.OrdenesDeSeleccion.Count == 0)
            {
                MessageBox.Show("No hay órdenes de selección pendientes.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var orden in _modelo.OrdenesDeSeleccion)
            {
                var item = new ListViewItem(orden.IdOrdenSeleccion.ToString());
                //  item.SubItems.Add(orden.FechaCreacion.ToString("dd/MM/yyyy"));
                var primeraOrdenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(orden.IdOrdenPreparacion.First());
                var RazonSocial = "N/A";

                if (primeraOrdenPrep != null)
                {
                    var cliente = ClienteAlmacen.BuscarClientePorId(primeraOrdenPrep.IdCliente);
                    if (cliente != null)
                        RazonSocial = cliente.RazonSocial;
                }

                item.SubItems.Add(RazonSocial);

                item.Tag = orden.IdOrdenSeleccion; // Guardar objeto para referencia
                detalleMercaderiaDataGridView.Items.Add(item);
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
            if (detalleMercaderiaDataGridView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione al menos una orden.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener órdenes seleccionadas
            if (detalleMercaderiaDataGridView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccione una orden.");
                return;
            }

            var item = detalleMercaderiaDataGridView.SelectedItems[0];
            idOrdenSeleccionActiva = (int)item.Tag;

            var productos = _modelo.ObtenerDetalleProductos(idOrdenSeleccionActiva);
            if (productos.Count == 0)
            {
                MessageBox.Show("No se encontraron productos para esta orden.");
                return;
            }

            var detalles = string.Join("\n", productos.Select(p =>
                $"- SKU: {p.IdProducto}, Cantidad: {p.Cantidad}, Pallet: {(p.PalletCerrado ? "Sí" : "No")}"));

          //  MessageBox.Show($"Productos a seleccionar:\n\n{detalles}", "Detalle de la Orden");
            confirmarSeleccionButton.Enabled = true;

            detalleMercaderiaDataGridView.Clear();
/*
            foreach (var p in productos)
            {
                detalleMercaderiaDataGridView.Rows.Add(
                    p.IdProducto,

                    p.PalletCerrado ? "Sí" : "No"

                );
            }

  */
            // Habilitar confirmación (podrías agregar un botón "Confirmar")
            // btnConfirmar.Enabled = true;
        }

        // --- Evento cambio de selección ---
        private void verDetallesPreparacionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerDetallesButton.Enabled = detalleMercaderiaDataGridView.SelectedItems.Count > 0;
        }

        private void confirmarSeleccionButton_Click(object sender, EventArgs e)
        {
            _modelo.ConfirmarSeleccion(idOrdenSeleccionActiva);
            MessageBox.Show("Orden de selección confirmada exitosamente.");

            confirmarSeleccionButton.Enabled = false;
            VerDetallesButton.Enabled = false;

            CargarDatosIniciales();
        }








    }
}
