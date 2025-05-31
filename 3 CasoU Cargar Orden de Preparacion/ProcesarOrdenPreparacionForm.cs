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

namespace TPGrupoE.CasoU_Orden_Preparacion
{
    public partial class ProcesarOrdenPreparacionForm : Form
    {
        public ProcesarOrdenPreparacionForm()
        {
            InitializeComponent();
        }

        private void ProcesarOrdenPreparacion_Load(object sender, EventArgs e)
        {
            palletCerradoComboBox.SelectedIndex = 0;

            //Razon Social
            razonSocialComboBox.DataSource = OrdenPreparacionModelo.Clientes;
            razonSocialComboBox.DisplayMember = "RazonSocial"; // Lo que se ve en el ComboBox
            razonSocialComboBox.ValueMember = "Cuit"; // Valor asociado
            razonSocialComboBox.SelectedIndex = -1;
            cuitTextBox.Text = "-";



        }

        private void CargarOrdenesALista()
        {
            ordenDePreparacionListView.Items.Clear(); // Limpiar primero por si se vuelve a cargar

            foreach (var orden in OrdenPreparacionModelo.OrdenesDePreparacion) // accedé a tu propiedad
            {
                ListViewItem item = new ListViewItem(orden.Id.ToString());
                item.SubItems.Add(orden.CuitCliente);
                item.SubItems.Add(orden.Estado);
                item.SubItems.Add(orden.FechaDespacho.ToShortDateString()); // o .ToString()
                ordenDePreparacionListView.Items.Add(item);
            }
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

        private void ordenDePreparacionListView_SelectedIndexChanged(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

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

                string cuitCliente = cuitTextBox.Text;

                //Comporbar si el cliente tiene productos almacenados
                bool tieneProductos = false;
                foreach (ProductoEntidad Producto in OrdenPreparacionModelo.Productos)
                {
                    if (Producto.CuitCliente == cuitCliente)
                    {
                        tieneProductos = true;
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

                var productosDelCliente = OrdenPreparacionModelo.Productos.Where(p => p.CuitCliente == cuitCliente).ToList();

                productoComboBox.DataSource = productosDelCliente;
                productoComboBox.DisplayMember = "DescripcionMercaderia";
                productoComboBox.ValueMember = "CuitCliente";
                productoComboBox.Enabled = true;
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
                skuTextBox.Text = producto.sku;
                cantidadEnStockTextBox.Text = producto.CantidadEnStock.ToString();
            }
            

            //Habilitar cantidad al elegir producto
            cantidadARetirarTextBox.Enabled = (productoComboBox.SelectedIndex != -1);


        }

        private void skuTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidadARetirarTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (productoComboBox.SelectedItem is ProductoEntidad producto && !string.IsNullOrEmpty(cantidadARetirarTextBox.Text))
            {
                if (int.TryParse(cantidadARetirarTextBox.Text, out int cantidadARetirar))
                {
                    if (cantidadARetirar > producto.CantidadEnStock)
                    {
                        MessageBox.Show(
                            $"La cantidad ingresada supera el stock disponible ({producto.CantidadEnStock}).",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                        cantidadARetirarTextBox.Text = "";
                    }
                }
            }
        }

        private void cantidadARetirarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo numeros y borrar
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }

        private void cantidadEnStockTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
