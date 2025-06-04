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
            detalleProductosListView.Columns.Add("Tipo", 100);
            detalleProductosListView.Columns.Add("Cantidad", 100);
            detalleProductosListView.Columns.Add("Pallet Cerrado", 120);
            detalleProductosListView.Columns.Add("Ubicación", 100);

            // BOTONES
            VerDetallesButton.Text = "Seleccionar mercadería";
            VerDetallesButton.Enabled = false;
            confirmarSeleccionButton.Enabled = false;

            // EVENTO
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
                string clienteNombre = "N/A";
                DateTime? fechaMasProxima = null;

                // Buscar cliente y la fecha de despacho más próxima
                foreach (var idOP in orden.IdOrdenPreparacion)
                {
                    var ordenPrep = OrdenPreparacionAlmacen.BuscarOrdenesPorId(idOP);
                    if (ordenPrep != null)
                    {
                        var cliente = ClienteAlmacen.BuscarClientePorId(ordenPrep.IdCliente);
                        if (cliente != null) clienteNombre = cliente.RazonSocial;

                        if (fechaMasProxima == null || ordenPrep.FechaEntrega < fechaMasProxima)
                        {
                            fechaMasProxima = ordenPrep.FechaEntrega;
                        }
                    }
                }

                // Si no se encuentra fecha, mostrar "Sin fecha"
                string fechaDespachoTexto = fechaMasProxima?.ToString("dd/MM/yyyy") ?? "Sin fecha";

                var item = new ListViewItem(orden.IdOrdenSeleccion.ToString());
                item.SubItems.Add(clienteNombre);
                item.SubItems.Add(orden.Estado.ToString());
                item.SubItems.Add(fechaDespachoTexto);
                item.Tag = orden.IdOrdenSeleccion;

                ordenesListView.Items.Add(item);
            }
        }
        private void ordenesListView_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Habilitar el botón si hay al menos una orden seleccionada

            BeginInvoke((MethodInvoker)delegate
            {
                VerDetallesButton.Enabled = ordenesListView.CheckedItems.Count > 0;
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
                    var fila = new ListViewItem(p.IdProducto.ToString());
                    fila.SubItems.Add("N/D"); // Si no tienes tipo, ponlo como "N/D"
                    fila.SubItems.Add(p.Cantidad.ToString());
                    fila.SubItems.Add(p.PalletCerrado ? "Sí" : "No");
                    fila.SubItems.Add("Auto"); // Aquí puedes poner la ubicación si la tienes del stock

                    detalleProductosListView.Items.Add(fila);
                }
            }

            confirmarSeleccionButton.Enabled = true;
        }
        private void confirmarSeleccionButton_Click(object sender, EventArgs e)
        {
            if (ordenesListView.CheckedItems.Count == 0) return;

            var ids = new List<int>();
            foreach (ListViewItem item in ordenesListView.CheckedItems)
            {
                ids.Add((int)item.Tag);
            }

            var mensaje = "¿Desea confirmar el cumplimiento de la/s siguiente/s orden/es?\n" +
                          string.Join(", ", ids.Select(id => $"OS-{id:D5}"));

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

        private void GestionarOrdenSeleccionForm_Load(object sender, EventArgs e)
        {

        }

        private void volverAlMenuButton_Click(object sender, EventArgs e)
        {
            var menuForm = new MenuPrincipalGeneralForm();
            menuForm.Show(); // Abre el menú principal
            this.Close(); // Cierra el formulario actual
        }
    }





}