using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;
using static TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model.OrdenPreparacionModelo;
using TPGrupoE.CasosDeUso.CU7CargarOrdenDeEntrega.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Forms
{
    public partial class ProcesarOrdenPreparacionForm : Form
    {
        public ProcesarOrdenPreparacionForm()
        {
            InitializeComponent();
        }

        private int idClienteSeleccionado = -1;
        private int idDepositoSeleccionado;
        bool palletCerrado = false;



        private void ProcesarOrdenPreparacion_Load(object sender, EventArgs e)
        {
            ClienteAlmacen.LeerCliente();
            palletCerradoComboBox.SelectedIndex = 0;
            depositoComboBox.SelectedIndex = -1;

            //Razon Social cmbobox
            razonSocialComboBox.SelectedIndexChanged -= razonSocialComboBox_SelectedIndexChanged;
            razonSocialComboBox.DataSource = OrdenPreparacionModelo.Clientes;
            razonSocialComboBox.DisplayMember = "RazonSocial";
            razonSocialComboBox.ValueMember = "Cuit";
            razonSocialComboBox.SelectedIndex = -1;
            razonSocialComboBox.SelectedIndexChanged += razonSocialComboBox_SelectedIndexChanged;

            palletCerradoComboBox_SelectedIndexChanged(sender, e);
        }

        private void palletCerradoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            palletCerrado = palletCerradoComboBox.SelectedIndex == 1;

            var stockFiltrado = StockFisicoAlmacen.FiltrarPorPalletCerrado(palletCerrado);

            var idsClientesConStock = stockFiltrado
                .Select(s => s.IdCliente)
                .Distinct()
                .ToList();

            var clientesFiltrados = OrdenPreparacionModelo.Clientes
                .Where(c => idsClientesConStock.Contains(c.IdCliente))
                .ToList();

            // Mostrar en razon social combobox
            razonSocialComboBox.DataSource = clientesFiltrados;
            razonSocialComboBox.DisplayMember = "RazonSocial";
            razonSocialComboBox.ValueMember = "IdCliente";
            razonSocialComboBox.SelectedIndex = -1;

            if (palletCerrado)
            {
                cantidadARetirarLabel.Text = "Cantidad de pallets a retirar";
                ordenDePreparacionListView.Columns[1].Text = "Cantidad de pallets";
            }
            else
            {
                cantidadARetirarLabel.Text = "Cantidad a retirar";
                ordenDePreparacionListView.Columns[1].Text = "Cantidad";
            }

            // Limpiar campos 
            razonSocialComboBox.Enabled = true;
            productoComboBox.DataSource = null;
            productoComboBox.Enabled = false;
            cuitTextBox.Text = "-";
        }

        private void razonSocialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Mostrar cuit del cliente elegido
            if (razonSocialComboBox.SelectedItem is ClienteEntidad cliente)
            {
                cuitTextBox.Text = cliente.Cuit;
                //Habilitar producto dsp de elegir cliente
                productoComboBox.Enabled = (razonSocialComboBox.SelectedIndex != -1);
            }

            if (razonSocialComboBox.SelectedIndex != -1)
            {
                if (razonSocialComboBox.SelectedItem is ClienteEntidad Cliente)
                {
                    // Guardar el ID del cliente seleccionado en la variable de clase
                    idClienteSeleccionado = Cliente.IdCliente;
                    cuitTextBox.Text = Cliente.Cuit;

                    // Buscar si tiene productos almacenados
                    var productosDelCliente = OrdenPreparacionModelo.Productos
                        .Where(p => p.IdProducto == idClienteSeleccionado)
                        .ToList();

                    if (productosDelCliente.Count == 0)
                    {
                        MessageBox.Show("El cliente seleccionado no tiene productos almacenados. \n" +
                            "No es posible crear una órden de preparación para este cliente.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        // Reiniciar selección
                        razonSocialComboBox.SelectedIndex = -1;
                        cuitTextBox.Text = "-";
                        productoComboBox.DataSource = null;
                        productoComboBox.Enabled = false;
                        return;
                    }

                    // Si tiene productos
                    productoComboBox.DataSource = productosDelCliente;
                    productoComboBox.DisplayMember = "DescripcionProducto";
                    productoComboBox.ValueMember = "IdProducto";
                    productoComboBox.Enabled = true;
                }
                else
                {
                    productoComboBox.DataSource = null;
                    productoComboBox.Enabled = false;
                }



            }

            // 1. Obtener stock físico del cliente seleccionadoo
            var stockDelCliente = StockFisicoAlmacen.FiltrarPorPalletCerrado(palletCerrado).Where(s => s.IdCliente == idClienteSeleccionado).ToList();

            //stockDelCliente = StockFisicoAlmacen.Stock.Where(s => s.IdCliente == idClienteSeleccionado)
            //.ToList();

            // 2. Obtener los IdDeposito únicos
            var idsDepositos = stockDelCliente
                .SelectMany(s => s.Posiciones)
                .Select(p => p.IdDeposito)
                .Distinct()
                .ToList();

            // 3. Filtrar los depósitos según esos IDs
            var depositosDelCliente = DepositosAlmacen.Depositos
                .Where(d => idsDepositos.Contains(d.IdDeposito))
                .ToList();

            // 4. Asignar como DataSource al ComboBox
            depositoComboBox.DataSource = depositosDelCliente;
            depositoComboBox.DisplayMember = "Domicilio";
            depositoComboBox.ValueMember = "IdDeposito";
            depositoComboBox.SelectedIndex = -1;

        }

        private void productoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            skuTextBox.Text = "-";
            cantidadEnStockTextBox.Text = "-";

            // Mostrar sku de producto y cantidad en stock dsp de elegir el producto
            if (productoComboBox.SelectedItem is ProductoEntidad producto)
            {
                skuTextBox.Text = producto.Sku;
                foreach (StockFisicoEntidad stock in StockFisicoAlmacen.Stock)
                {
                    if (producto.IdProducto == stock.IdProducto)
                    {
                        // Sumar todas las cantidades de las posiciones 0000000000000000000000-------00000000
                        int cantidadTotal = stock.Posiciones.Sum(pos => pos.Cantidad);
                        cantidadEnStockTextBox.Text = cantidadTotal.ToString();
                        break;
                    }
                }

            }


            //Habilitar cantidad al elegir producto
            cantidadARetirarTextBox.Enabled = (productoComboBox.SelectedIndex != -1);


        }

        private void cantidadARetirarTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (productoComboBox.SelectedItem is ProductoEntidad producto && !string.IsNullOrEmpty(cantidadARetirarTextBox.Text) &&
            int.TryParse(cantidadARetirarTextBox.Text, out int cantidadARetirar))
            {
                // Buscar el stock del producto seleccionado
                var stockProducto = StockFisicoAlmacen.Stock
                    .FirstOrDefault(stock => stock.IdProducto == producto.IdProducto);

                if (stockProducto != null)
                {
                    // Sumar todas las cantidades de las posiciones
                    int cantidadEnStock = stockProducto.Posiciones.Sum(p => p.Cantidad);

                    if (cantidadARetirar > cantidadEnStock)
                    {
                        MessageBox.Show(
                            $"La cantidad ingresada supera el stock disponible ({cantidadEnStock}).",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        cantidadARetirarTextBox.Text = "";
                        agregarProductoButton.Enabled = false;
                    }
                    else if (cantidadARetirar == 0)
                    {
                        MessageBox.Show(
                            $"Entrada inválida. Ingrese un número positivo.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        cantidadARetirarTextBox.Text = "";
                        agregarProductoButton.Enabled = false;
                    }
                    else
                    {
                        agregarProductoButton.Enabled = true;
                    }
                }
                else
                {
                    MessageBox.Show(
                        "No se encontró stock para el producto seleccionado.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    cantidadARetirarTextBox.Text = "";
                    agregarProductoButton.Enabled = false;
                }
            }
        }

        private void cantidadARetirarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo numeros y borrar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            agregarProductoButton.Enabled = true;
        }

        private void agregarProductoButton_Click(object sender, EventArgs e)
        {
            if (productoComboBox.SelectedItem is ProductoEntidad producto)
            {
                // Buscar el stock físico del producto seleccionado
                var stockProducto = StockFisicoAlmacen.Stock
                    .FirstOrDefault(stock => stock.IdProducto == producto.IdProducto);

                // Sumar todas las cantidades de las posiciones
                int cantidadEnStock = stockProducto.Posiciones.Sum(p => p.Cantidad);

                //string posicion = stockProducto

                string Sku = producto.Sku;
                //string ubicacion = posicion;
                int CantidadARetirar = int.Parse(cantidadARetirarTextBox.Text);

                // Agregar prod a la lista
                ListViewItem Fila = ordenDePreparacionListView.Items.Add(Sku);
                //Fila.SubItems.Add(ubicacion);
                Fila.SubItems.Add(CantidadARetirar.ToString());

                // Restar stock
                int cantidadRestante = CantidadARetirar;
                foreach (var Posicion in stockProducto.Posiciones)
                {
                    if (cantidadRestante == 0) break;

                    int descontar = Math.Min(Posicion.Cantidad, cantidadRestante);
                    Posicion.Cantidad -= descontar;
                    cantidadRestante -= descontar;
                }

                // Actualizar el textbox con el nuevo stock total
                int nuevoStock = stockProducto.Posiciones.Sum(p => p.Cantidad);
                cantidadEnStockTextBox.Text = nuevoStock.ToString();

                cantidadARetirarTextBox.Text = "";
                depositoComboBox.Enabled = ordenDePreparacionListView.Items.Count > 0;
                agregarProductoButton.Enabled = false;
            }

            razonSocialComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            palletCerradoComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            depositoComboBox.Enabled = ordenDePreparacionListView.Items.Count > 0;


        }

        private void ordenDePreparacionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            quitarProductoButton.Enabled = ordenDePreparacionListView.SelectedItems.Count > 0;
            razonSocialComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            depositoComboBox.Enabled = ordenDePreparacionListView.Items.Count > 0;
        }

        private void quitarProductoButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ordenDePreparacionListView.SelectedItems)
            {
                string sku = item.Text;
                int cantidadARetirada = int.Parse(item.SubItems[1].Text);


                // BUSCAR el producto original por SKU y sumar stock
                var producto = OrdenPreparacionModelo.Productos.FirstOrDefault(p => p.Sku == sku);
                if (producto != null)
                {
                    // Buscar el stock físico del producto
                    var stockProducto = StockFisicoAlmacen.Stock
                        .FirstOrDefault(s => s.IdProducto == producto.IdProducto);

                    if (stockProducto != null)
                    {
                        // Agregar nuevamente el stock a la primera posición (o distribuir si preferís)
                        if (stockProducto.Posiciones.Count > 0)
                        {
                            stockProducto.Posiciones[0].Cantidad += cantidadARetirada;
                        }
                    }

                    // Actualizar cantidadEnStockTextBox si el producto sigue seleccionado
                    if (productoComboBox.SelectedItem is ProductoEntidad ProductoActual &&
                        ProductoActual.Sku == sku)
                    {
                        int nuevoStock = stockProducto.Posiciones.Sum(p => p.Cantidad);
                        cantidadEnStockTextBox.Text = nuevoStock.ToString();
                    }

                    // Eliminar de la lista
                    ordenDePreparacionListView.Items.Remove(item);
                }
            }

            // Habilitar transportista
            depositoComboBox.Enabled = ordenDePreparacionListView.Items.Count > 0;
            dniTransportistaTextBox.Enabled = ordenDePreparacionListView.Items.Count > 0;
            cargarOrdenButton.Enabled = ordenDePreparacionListView.Items.Count > 0;


            foreach (ListViewItem item in ordenDePreparacionListView.SelectedItems)
            {
                ordenDePreparacionListView.Items.Remove(item);
                string cantidad = item.SubItems[2].Text;
                cantidadEnStockTextBox.Text = (int.Parse(cantidadEnStockTextBox.Text) + int.Parse(cantidad)).ToString();
                if (ordenDePreparacionListView.Items.Count > 0)
                {
                    depositoComboBox.Enabled = true;
                }
                else
                {
                    depositoComboBox.Enabled = false;
                }
            }

            razonSocialComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            palletCerradoComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            depositoComboBox.Enabled = ordenDePreparacionListView.Items.Count > 0;
            depositoComboBox.SelectedIndex = -1;

        }

        private void cargarOrdenButton_Click(object sender, EventArgs e)
        {
            int nuevoIdOrden = GenerarIdOrden();

            // Crear lista de productos asociados a la orden
            List<ProductoOrden> productosAsociados = new List<ProductoOrden>();
            bool pallet = false;

            foreach (ListViewItem item in ordenDePreparacionListView.Items)
            {
                string sku = item.SubItems[0].Text;
                string tipoProducto = item.SubItems[1].Text;
                int cantidad = int.Parse(item.SubItems[2].Text);

                if (palletCerradoComboBox.SelectedIndex == 1)
                {
                    pallet = true;
                }

                ProductoOrden productoOrden = new ProductoOrden
                {
                    IdProducto = idClienteSeleccionado,
                    Cantidad = cantidad,
                    PalletCerrado = pallet,
                };

                ProductoOrdenAlmacen.AgregarProductoOrden(productoOrden);
                productosAsociados.Add(productoOrden);
            }

            // Crear la orden de preparación
            OrdenPreparacionEntidad Orden = new OrdenPreparacionEntidad
            {
                IdOrdenPreparacion = nuevoIdOrden,
                IdDeposito = idDepositoSeleccionado, //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
                IdCliente = idClienteSeleccionado,
                DniTransportista = int.Parse(dniTransportistaTextBox.Text),
                Estado = EstadoOrdenPreparacion.EnPreparacion,
                FechaEntrega = DespachoDateTimePicker.Value,
                PalletCerrado = pallet,
                ProductoOrden = productosAsociados,
            };

            // Agregar la orden al almacén
            OrdenPreparacionAlmacen.NuevaOrdenPreparacion(Orden);

            MessageBox.Show("Orden de preparación cargada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar formulario
            ordenDePreparacionListView.Items.Clear();
            cantidadARetirarTextBox.Text = "";
            productoComboBox.SelectedIndex = -1;
            razonSocialComboBox.SelectedIndex = -1;
            cuitTextBox.Text = "-";
            skuTextBox.Text = "-";
            cantidadEnStockTextBox.Text = "-";
            dniTransportistaTextBox.Text = "";
            razonSocialComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            palletCerradoComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            depositoComboBox.Enabled = ordenDePreparacionListView.Items.Count > 0;

        }

        private int GenerarIdOrden()
        {
            return OrdenPreparacionAlmacen.OrdenesPreparacion.Count == 0
                ? 1001
                : OrdenPreparacionAlmacen.OrdenesPreparacion.Max(o => o.IdOrdenPreparacion) + 1;
        }

        private void dniTransportistaTextBox_TextChanged(object sender, EventArgs e)
        {
            string texto = dniTransportistaTextBox.Text;
            if (dniTransportistaTextBox.Text == "0")
            {
                MessageBox.Show(
                            $"Entrada inválida. Ingrese un número positivo.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                dniTransportistaTextBox.Clear();
            }
            cargarOrdenButton.Enabled = dniTransportistaTextBox.Text.Length == 8;
        }
        
        private void dniTransportistaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo numeros y borrar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            
        }





        private void idOrdenTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void cuitTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void cantidadEnStockTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void skuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void depositoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (depositoComboBox.SelectedItem is DepositoEntidad deposito)
            {
                idDepositoSeleccionado = deposito.IdDeposito;
            }
            
                dniTransportistaTextBox.Enabled = depositoComboBox.SelectedIndex != -1;
            if (dniTransportistaTextBox.Text.Length == 8 && depositoComboBox.SelectedIndex != -1)
            {
                cargarOrdenButton.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipalGeneralForm principalGeneralForm = new MenuPrincipalGeneralForm();
            principalGeneralForm.Show();
        }
    }
}
