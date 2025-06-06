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
            detalleProductosListView.Columns.Add("Descripción", 100);
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
                cancelarSeleccionButton.Enabled = ordenesListView.CheckedItems.Count > 0; // Habilitar el botón cancelar
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
                    // Obtener el SKU del producto desde el almacén de productos
                    var productoEntidad = ProductoAlmacen.BuscarProductoPorId(p.IdProducto);  // Buscar el producto por ID
                    string sku = productoEntidad != null ? productoEntidad.Sku : "No disponible"; // Obtener el SKU
                    string descripcion = productoEntidad != null ? productoEntidad.DescripcionProducto : "Sin descripción";

                    var fila = new ListViewItem(sku); // Agregar SKU
                    fila.SubItems.Add(descripcion); // Agregar Descripción (de ProductoEntidad)
                  
                    fila.SubItems.Add(p.Cantidad.ToString()); // Cantidad
                    fila.SubItems.Add(p.PalletCerrado ? "Sí" : "No"); // Pallet Cerrado

                    // Obtener la ubicación del producto (usamos la función `ObtenerUbicacion` para obtener las posiciones desde el stock)
                    var ubicacion = ObtenerUbicacion(p.IdProducto); // Obtener ubicación desde StockFisicoAlmacen
                    fila.SubItems.Add(ubicacion); // Ubicación

                    detalleProductosListView.Items.Add(fila);
                }
            }

            confirmarSeleccionButton.Enabled = true;
            cancelarSeleccionButton.Enabled = true;

        }

        // Función para obtener la ubicación de un producto desde el stock
        private string ObtenerUbicacion(int idProducto)
        {
            var stock = StockFisicoAlmacen.ObtenerStockPorId(idProducto);
            if (stock != null && stock.Posiciones.Count > 0)
            {
                // Unir las posiciones disponibles por ", " si el producto tiene más de una
                return string.Join(", ", stock.Posiciones.Select(p => $"{p.Posicion} (Cantidad: {p.Cantidad})"));
            }
            return "Sin ubicación"; // Si no hay ubicaciones
        }
        private void confirmarSeleccionButton_Click(object sender, EventArgs e)
        {
            if (ordenesListView.CheckedItems.Count == 0) return;

            var ids = new List<int>();
            var detallesOrdenes = new List<string>();
            var totalProductos = 0;

            // Recopilar información sobre las órdenes seleccionadas
            foreach (ListViewItem item in ordenesListView.CheckedItems)
            {
                ids.Add((int)item.Tag);

                var productos = _modelo.ObtenerDetalleProductos((int)item.Tag);
                totalProductos += productos.Count;

                // Mostrar un resumen de las órdenes (hasta 3 por ejemplo)
                if (detallesOrdenes.Count < 3)
                {
                    var orden = $"OS-{item.Tag:D5} - {productos.Count} productos";
                    detallesOrdenes.Add(orden);
                }
            }

            // Si hay más de 3 órdenes seleccionadas, agregar un mensaje diciendo que hay más
            if (detallesOrdenes.Count == 3)
            {
                detallesOrdenes.Add("Y más...");
            }

            // Crear el mensaje con el detalle de las órdenes
            var mensaje = $"¿Desea confirmar el cumplimiento de la/s siguiente/s orden/es?\n\n" +
                          string.Join("\n", detallesOrdenes) + "\n\n" +
                          $"Total de productos seleccionados: {totalProductos}";

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


        private void cancelarSeleccionButton_Click(object sender, EventArgs e)
        {
            // Deseleccionar todos los ítems en ordenesListView
            foreach (ListViewItem item in ordenesListView.CheckedItems)
            {
                item.Checked = false;  // Desmarcar la orden seleccionada
            }

            // Limpiar el detalle de productos en el ListView
            detalleProductosListView.Items.Clear();

            // Deshabilitar el botón "Confirmar selección" y "Cancelar selección"
            confirmarSeleccionButton.Enabled = false;
            cancelarSeleccionButton.Enabled = false;

            // Habilitar el botón "Ver Detalles" si se ha desmarcado alguna orden
            VerDetallesButton.Enabled = ordenesListView.CheckedItems.Count > 0; // Solo habilitar si hay alguna orden seleccionada
        }

    }





}