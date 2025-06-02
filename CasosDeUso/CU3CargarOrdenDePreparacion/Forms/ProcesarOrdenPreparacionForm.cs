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

namespace TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Forms
{
    public partial class ProcesarOrdenPreparacionForm : Form
    {
        public ProcesarOrdenPreparacionForm()
        {
            ClienteAlmacen.LeerCliente();
            InitializeComponent();
        }

         

       private void ProcesarOrdenPreparacion_Load(object sender, EventArgs e)
        {
            ClienteAlmacen.LeerCliente();
            
            palletCerradoComboBox.SelectedIndex = 0;


            //Razon Social
            razonSocialComboBox.DataSource = OrdenPreparacionModelo.Clientes;
            razonSocialComboBox.DisplayMember = "RazonSocial"; // Lo que se ve en el ComboBox
            razonSocialComboBox.ValueMember = "Cuit"; // Valor asociado
            razonSocialComboBox.SelectedIndex = -1;
            cuitTextBox.Text = "-";
            
            MessageBox.Show("Cantidad de clientes: " + OrdenPreparacionModelo.Clientes.Count);

            //TRANSPORTISTA
            /*dniTransportistaComboBox.DataSource = OrdenPreparacionModelo.Transportistas;
            dniTransportistaComboBox.DisplayMember = "dni"; // Lo que se ve en el ComboBox
            dniTransportistaComboBox.ValueMember = "Nombre"; // Valor asociado
            dniTransportistaComboBox.SelectedIndex = -1;*/


        }


        private void cantidadARetirarTextBox_TextChanged(object sender, EventArgs e)
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

        private void palletCerradoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (palletCerradoComboBox.SelectedIndex == 1)
            {
                cantidadARetirarLabel.Text = "Cantidad de pallets a retirar";
                ordenDePreparacionListView.Columns[1].Text = "Cantidad de pallets";
            }

            else
            {
                cantidadARetirarLabel.Text = "Cantidad a retirar";
                ordenDePreparacionListView.Columns[1].Text = "Cantidad";

            }
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
                // Buscar cliente por id y comprobar si tiene productos almacenados
                int idClienteElegido;
                bool tieneProductos = false;
                string cuitCliente = cuitTextBox.Text;

                foreach (ClienteEntidad Cliente in OrdenPreparacionModelo.Clientes)
                {
                    if (Cliente.Cuit == cuitCliente)
                    {
                        idClienteElegido = Cliente.IdCliente;
                        foreach (ProductoEntidad Producto in OrdenPreparacionModelo.Productos)
                        {
                            if (Producto.IdProducto == idClienteElegido)
                            {
                                tieneProductos = true;
                                var productosDelCliente = OrdenPreparacionModelo.Productos.Where(p => p.IdProducto == idClienteElegido).ToList();

                                productoComboBox.DataSource = productosDelCliente;
                                productoComboBox.DisplayMember = "DescripcionProducto";
                                productoComboBox.ValueMember = "IdCliente";
                                productoComboBox.Enabled = true;
                            }
                        }
                        if (tieneProductos == false)
                        {
                            MessageBox.Show("El cliente seleccionado no tiene productos almacenados. \n" +
                                "No es posible crear una órden de preparación para este cliente.", "Advertencia",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            razonSocialComboBox.SelectedIndex = -1;
                            cuitTextBox.Text = "-";
                            productoComboBox.Enabled = false;
                        }
                    }
                }


            }
            else
            {
                productoComboBox.DataSource = null;
                productoComboBox.Enabled = false;
            }
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

        private void skuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidadARetirarTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (productoComboBox.SelectedItem is ProductoEntidad producto && !string.IsNullOrEmpty(cantidadARetirarTextBox.Text) &&
            int.TryParse(cantidadARetirarTextBox.Text, out int cantidadARetirar))
            {
                // Buscar el stock físico del producto seleccionado
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
                    else if (cantidadARetirar == 0 && cantidadEnStock == 0)
                    {
                        MessageBox.Show(
                            $"No hay stock disponible del producto seleccionado.",
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
            agregarProductoButton.Enabled = true;
        }

        private void cantidadEnStockTextBox_TextChanged(object sender, EventArgs e)
        {

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

                string Sku = producto.Sku;
                string NombreProducto = producto.DescripcionProducto;
                int CantidadARetirar = int.Parse(cantidadARetirarTextBox.Text);

                // Agregar prod a la lista
                ListViewItem Fila = ordenDePreparacionListView.Items.Add(Sku);
                Fila.SubItems.Add(NombreProducto);
                Fila.SubItems.Add(CantidadARetirar.ToString());

                // 🔽 Restar stock
                producto.CantidadEnStock -= CantidadARetirar;
                cantidadEnStockTextBox.Text = producto.CantidadEnStock.ToString();

                cantidadARetirarTextBox.Text = "";

                // Habilitar transportista
                dniTransportistaComboBox.Enabled = ordenDePreparacionListView.Items.Count > 0;

                agregarProductoButton.Enabled = false;
            }

            
            string sku = skuTextBox.Text;
            string nombreProducto = productoComboBox.Text;
            string cantidadARetirar = cantidadARetirarTextBox.Text;

            ListViewItem fila = ordenDePreparacionListView.Items.Add(sku); // primera columna
            fila.SubItems.Add(nombreProducto);     // segunda 
            fila.SubItems.Add(cantidadARetirar); //tercera

            

            //Resta
            int resultado = int.Parse(cantidadEnStockTextBox.Text) - int.Parse(cantidadARetirarTextBox.Text); 
            cantidadEnStockTextBox.Text = resultado.ToString();
            cantidadARetirarTextBox_TextChanged(sender, e);

            cantidadARetirarTextBox.Text = "";

            //Habilitar elegir transportista cuando hay un producto o mas en la orden
            if (ordenDePreparacionListView.Items.Count > 0)
            {
                dniTransportistaComboBox.Enabled = true;
            }
            else
            {
                dniTransportistaComboBox.Enabled = false;
            }
            
        }
       

        
        private void ordenDePreparacionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            quitarProductoButton.Enabled = ordenDePreparacionListView.SelectedItems.Count > 0;
        }

        private void quitarProductoButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ordenDePreparacionListView.SelectedItems)
            {
                string sku = item.Text;
                int cantidadARetirada = int.Parse(item.SubItems[2].Text);

                // BUSCAR el producto original por SKU y sumar stock
                var producto = OrdenPreparacionModelo.Productos.FirstOrDefault(p => p.sku == sku);
                if (producto != null)
                {
                    producto.CantidadEnStock += cantidadARetirada;
                }

                // Eliminar de la lista
                ordenDePreparacionListView.Items.Remove(item);
            }

            // Actualizar textbox de stock si el producto sigue seleccionado
            if (productoComboBox.SelectedItem is ProductoEntidad productoActual)
            {
                cantidadEnStockTextBox.Text = productoActual.CantidadEnStock.ToString();
            }

            // Habilitar/deshabilitar transportista
            dniTransportistaComboBox.Enabled = ordenDePreparacionListView.Items.Count > 0;

            foreach (ListViewItem item in ordenDePreparacionListView.SelectedItems)
            {
                ordenDePreparacionListView.Items.Remove(item);
                string cantidad = item.SubItems[2].Text;
                cantidadEnStockTextBox.Text =  (int.Parse(cantidadEnStockTextBox.Text)+int.Parse(cantidad)).ToString();
                if (ordenDePreparacionListView.Items.Count > 0)
                {
                    dniTransportistaComboBox.Enabled = true;
                }
                else
                {
                    dniTransportistaComboBox.Enabled = false;
                }
            }
        }

        private void dniTransportistaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cargarOrdenButton.Enabled = (dniTransportistaComboBox.SelectedIndex != -1);
        }

        private void idOrdenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cargarOrdenButton_Click(object sender, EventArgs e)
        {
            // Generar nuevo ID de orden
            int nuevoIdOrden = GenerarIdOrden();

            // Crear lista de productos asociados a la orden
            List<ProductoOrden> productosAsociados = new List<ProductoOrden>();

            foreach (ListViewItem item in ordenDePreparacionListView.Items)
            {
                string sku = item.SubItems[0].Text;
                string tipoProducto = item.SubItems[1].Text;
                int cantidad = int.Parse(item.SubItems[2].Text);

                ProductoOrden productoOrden = new ProductoOrden
                {
                    IdProducto = nuevoIdOrden, // Todos los productos comparten el mismo ID de orden
                    Sku = sku,
                    TipoProducto = tipoProducto,
                    Cantidad = cantidad
                };

                // Agregamos al almacén de productos orden
                ProductoOrdenAlmacen.AgregarProductoOrden(productoOrden);

                // Y a la lista local para la orden
                productosAsociados.Add(productoOrden);
            }

            // Crear la orden de preparación
            OrdenPreparacionEntidad Orden = new OrdenPreparacionEntidad
            {
                IdOrdenPreparacion = nuevoIdOrden,
                IdCliente = cuitTextBox.Text,
                Estado = "En preparación",
                FechaDespacho = DespachoDateTimePicker.Value,
                PalletCerrado = palletCerradoComboBox.SelectedIndex == 1,
                productosOrden = productosAsociados
            };

            // Agregar la orden al almacén
            OrdenPreparacionAlmacen.AgregarOrdenDePreparacion(Orden);

            MessageBox.Show("Orden de preparación cargada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Opcional: limpiar formulario
            ordenDePreparacionListView.Items.Clear();
            cantidadARetirarTextBox.Text = "";
            productoComboBox.SelectedIndex = -1;
            razonSocialComboBox.SelectedIndex = -1;
            cuitTextBox.Text = "-";
            skuTextBox.Text = "-";
            cantidadEnStockTextBox.Text = "-";
            dniTransportistaComboBox.SelectedIndex = -1;

        }

        private int GenerarIdOrden()
        {
            return OrdenPreparacionAlmacen.OrdenesDePreparacion.Count == 0
                ? 1001
                : OrdenPreparacionAlmacen.OrdenesDePreparacion.Max(o => o.IdOrdenPreparacion) + 1;
        }*/
    }
}
