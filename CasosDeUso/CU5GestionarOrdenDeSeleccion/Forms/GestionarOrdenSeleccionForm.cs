using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model;

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

        private void ConfigurarControles()
        {
            // LISTVIEW DE ÓRDENES
            ordenesListView.View = View.Details;
            ordenesListView.FullRowSelect = true;
            ordenesListView.MultiSelect = false;
            ordenesListView.Columns.Add("ID Orden", 100);
            ordenesListView.Columns.Add("Cliente", 200);
            ordenesListView.Columns.Add("Estado", 100);

            // LISTVIEW DE PRODUCTOS
            detalleProductosListView.View = View.Details;
            detalleProductosListView.FullRowSelect = true;
            detalleProductosListView.MultiSelect = false;
            detalleProductosListView.Columns.Add("SKU", 100);
            detalleProductosListView.Columns.Add("Tipo", 100);
            detalleProductosListView.Columns.Add("Cantidad", 100);
            detalleProductosListView.Columns.Add("Pallet Cerrado", 120);
            detalleProductosListView.Columns.Add("Ubicación", 100);

            // BOTONES
            VerDetallesButton.Text = "Seleccionar mercadería";
            VerDetallesButton.Enabled = false;
            confirmarSeleccionButton.Enabled = false;
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
                var clienteNombre = "N/A";
                var primerIdPrep = orden.IdOrdenPreparacion.FirstOrDefault();
                var ordenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(primerIdPrep);

                if (ordenPrep != null)
                {
                    var cliente = ClienteAlmacen.BuscarClientePorId(ordenPrep.IdCliente);
                    if (cliente != null) clienteNombre = cliente.RazonSocial;
                }

                var item = new ListViewItem(orden.IdOrdenSeleccion.ToString());
                item.SubItems.Add(clienteNombre);
                item.SubItems.Add(orden.Estado.ToString());
                item.Tag = orden.IdOrdenSeleccion;

                ordenesListView.Items.Add(item);
            }
        }

        private void ordenesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            VerDetallesButton.Enabled = ordenesListView.SelectedItems.Count > 0;
        }

        private void VerDetallesButton_Click(object sender, EventArgs e)
        {
            if (ordenesListView.SelectedItems.Count == 0) return;

            var item = ordenesListView.SelectedItems[0];
            idOrdenSeleccionActiva = (int)item.Tag;

            var productos = _modelo.ObtenerDetalleProductos(idOrdenSeleccionActiva);
            if (productos.Count == 0)
            {
                MessageBox.Show("No se encontraron productos para esta orden.");
                return;
            }

            detalleProductosListView.Items.Clear();

            foreach (var p in productos)
            {
                var fila = new ListViewItem(p.IdProducto.ToString());
               // fila.SubItems.Add(p.Tipo);
                fila.SubItems.Add(p.Cantidad.ToString());
                fila.SubItems.Add(p.PalletCerrado ? "Sí" : "No");
               // fila.SubItems.Add(p.Posicion ?? "N/A");

                detalleProductosListView.Items.Add(fila);
            }

            confirmarSeleccionButton.Enabled = true;
        }

        private void confirmarSeleccionButton_Click(object sender, EventArgs e)
        {
            _modelo.ConfirmarSeleccion(idOrdenSeleccionActiva);
            MessageBox.Show("Orden de selección confirmada correctamente.");

            detalleProductosListView.Items.Clear();
            confirmarSeleccionButton.Enabled = false;
            VerDetallesButton.Enabled = false;

            CargarDatosIniciales();
        }
    }
}
