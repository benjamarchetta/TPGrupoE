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

namespace TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Forms
{
    public partial class CargarOrdenPreparacionForm : Form
    {
        public CargarOrdenPreparacionForm()
        {
            InitializeComponent();
        }
        OrdenPreparacionModelo Modelo = new OrdenPreparacionModelo();

        private int idClienteSeleccionado = -1;
        private int idDepositoSeleccionado;
        bool palletCerrado = false;
        int id;

        private void ProcesarOrdenPreparacion_Load(object sender, EventArgs e)
        {
            groupBox1.SendToBack();
            id = Modelo.GenerarIdOrden();
            palletCerradoComboBox.SelectedIndex = -1;
            palletCerradoComboBox.Enabled = false;
            depositoComboBox.SelectedIndex = -1;
            productoComboBox.SelectedIndex = -1;
            despachoDateTimePicker.MinDate = DateTime.Now;

            //Razon Social cmbobox
            razonSocialComboBox.SelectedIndexChanged -= razonSocialComboBox_SelectedIndexChanged;
            razonSocialComboBox.DataSource = Modelo.Clientes;
            razonSocialComboBox.DisplayMember = "RazonSocial";
            razonSocialComboBox.ValueMember = "Cuit";
            razonSocialComboBox.SelectedIndex = -1;
            razonSocialComboBox.SelectedIndexChanged += razonSocialComboBox_SelectedIndexChanged;
        }

        private void palletCerradoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            palletCerrado = palletCerradoComboBox.SelectedIndex == 1;

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

            if (razonSocialComboBox.SelectedItem is ClienteEntidad Cliente && razonSocialComboBox.SelectedIndex != -1)
            {
                // Mostrar CUIT
                cuitTextBox.Text = Cliente.Cuit;
                idClienteSeleccionado = Cliente.IdCliente;


                // Filtrar el stock del cliente según si tiene posiciones con el palletCerrado elegido
                var depositosFiltrados = Modelo.Stock
                    .Where(s => s.IdCliente == Cliente.IdCliente)
                    .SelectMany(s => s.Posiciones)
                    .Where(p => p.PalletCerrado == palletCerrado) // 🔴 filtro por PalletCerrado
                    .Select(p => p.IdDeposito)
                    .Distinct()
                    .ToList();

                // Obtener los depósitos válidos con esa condición
                var depositosAMostrar = Modelo.Depositos
                    .Where(d => depositosFiltrados.Contains(d.IdDeposito))
                    .ToList();

                // Asignar al ComboBox
                depositoComboBox.DataSource = depositosAMostrar;
                depositoComboBox.DisplayMember = "Domicilio";
                depositoComboBox.ValueMember = "IdDeposito";
                depositoComboBox.SelectedIndex = -1;
                depositoComboBox.Enabled = true;

                // Asegurarse de que productoComboBox esté deshabilitado inicialmente
                productoComboBox.DataSource = null;
                productoComboBox.Enabled = false;
                ActualizarDepositosYProductos();
            }

        }

        private void razonSocialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (razonSocialComboBox.SelectedItem is ClienteEntidad cliente)
            {
                cuitTextBox.Text = cliente.Cuit;
                palletCerradoComboBox.Enabled = (razonSocialComboBox.SelectedIndex != -1);
                ActualizarDepositosYProductos();
            }

        }

        private void ActualizarDepositosYProductos()
{
            if (palletCerrado)
            {
                palletCerradoComboBox.SelectedIndex = 1;
            }
            else
            {
                palletCerradoComboBox.SelectedIndex = 0;
            }
    if (razonSocialComboBox.SelectedItem is ClienteEntidad Cliente)
            {
                idClienteSeleccionado = Cliente.IdCliente;

                var depositosFiltrados = Modelo.Stock
                    .Where(s => s.IdCliente == Cliente.IdCliente)
                    .SelectMany(s => s.Posiciones)
                    .Where(p => p.PalletCerrado == palletCerrado)
                    .Select(p => p.IdDeposito)
                    .Distinct()
                    .ToList();

                var depositosAMostrar = Modelo.Depositos
                    .Where(d => depositosFiltrados.Contains(d.IdDeposito))
                    .ToList();

                if (depositosAMostrar.Count == 0)
                {
                    MessageBox.Show(
                            $"El cliente no tiene productos disponibles.",
                            "Advertencia",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning
                        );
                }

                depositoComboBox.DataSource = depositosAMostrar;
                depositoComboBox.DisplayMember = "Domicilio";
                depositoComboBox.ValueMember = "IdDeposito";
                depositoComboBox.SelectedIndex = -1;
                depositoComboBox.Enabled = true;

                productoComboBox.DataSource = null;
                productoComboBox.Enabled = false;
            }
}


        private void depositoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (depositoComboBox.SelectedItem is DepositoEntidad deposito)
            {
                idDepositoSeleccionado = deposito.IdDeposito;

                // Obtener los IDs de producto filtrados por pallet, cliente y depósito
                var idsProductosFiltrados = Modelo
                    .FiltrarPorPalletCerrado(palletCerrado)
                    .Where(stock =>
                        stock.IdCliente == idClienteSeleccionado &&
                        stock.Posiciones.Any(pos => pos.IdDeposito == idDepositoSeleccionado)
                    )
                    .Select(stock => stock.IdProducto)
                    .Distinct()
                    .ToList();

                // Obtener las entidades ProductoEntidad correspondientes
                var productosFiltrados = Modelo.Productos
                    .Where(p => idsProductosFiltrados.Contains(p.IdProducto))
                    .ToList();

                // Asignar como fuente del ComboBox
                productoComboBox.DataSource = productosFiltrados;
                productoComboBox.DisplayMember = "DescripcionProducto";
                productoComboBox.ValueMember = "IdProducto";
                productoComboBox.SelectedIndex = -1; 
                productoComboBox.Enabled = depositoComboBox.SelectedIndex != -1;

            }

            dniTransportistaTextBox.Enabled = ordenDePreparacionListView.Items.Count > 0;
        }


        private void productoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            palletCerrado = palletCerradoComboBox.SelectedIndex == 1;

            if (productoComboBox.SelectedItem is ProductoEntidad productoSeleccionado)
            {
                // Mostrar el SKU
                skuTextBox.Text = productoSeleccionado.Sku;

                // Buscar TODAS las entradas de stock para ese cliente y producto
                var stockDelProducto = Modelo.Stock
                    .Where(s =>
                        s.IdCliente == idClienteSeleccionado &&
                        s.IdProducto == productoSeleccionado.IdProducto
                    ).SelectMany(s => s.Posiciones)
                    .Where(p => p.IdDeposito == idDepositoSeleccionado &&
                       p.PalletCerrado == palletCerrado)
                    .Sum(p => p.Cantidad);

                // 2. Calcular cantidad ya reservada en la orden actual
                int cantidadReservada = 0;
                foreach (ListViewItem item in ordenDePreparacionListView.Items)
                {
                    if (item.Text == productoSeleccionado.Sku) // Comparar por SKU
                    {
                        cantidadReservada += int.Parse(item.SubItems[1].Text);
                    }
                }

                // 3. Calcular stock realmente disponible
                int stockDisponible = stockDelProducto - cantidadReservada;

                // Mostrar el stock disponible (nunca menor que 0)
                cantidadEnStockTextBox.Text = Math.Max(stockDisponible, 0).ToString();
            }
            else
            {
                skuTextBox.Text = string.Empty;
                cantidadEnStockTextBox.Text = string.Empty;
            }

            cantidadARetirarTextBox.Enabled = productoComboBox.SelectedIndex != -1;
        }

        private void cantidadARetirarTextBox_TextChanged_1(object sender, EventArgs e)
        {
            if (productoComboBox.SelectedItem is ProductoEntidad producto && !string.IsNullOrEmpty(cantidadARetirarTextBox.Text) &&
            int.TryParse(cantidadARetirarTextBox.Text, out int cantidadARetirar))
            {
                // Buscar TODAS las entradas de stock para ese cliente y producto
                var stockDelProducto = Modelo.Stock
                    .Where(s =>
                        s.IdCliente == idClienteSeleccionado &&
                        s.IdProducto == producto.IdProducto
                    )
                    .ToList();

                // Sumar cantidades disponibles filtrando por depósito y palletCerrado
                var cantidadDisponible = stockDelProducto
                    .SelectMany(s => s.Posiciones)
                    .Where(p =>
                        p.IdDeposito == idDepositoSeleccionado &&
                        p.PalletCerrado == palletCerrado
                    )
                    .Sum(p => p.Cantidad);

                    if (cantidadARetirar > cantidadDisponible)
                    {
                        MessageBox.Show(
                            $"La cantidad ingresada supera el stock disponible ({cantidadDisponible}).",
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
                // 🔴 Obtener el stock FÍSICO REAL (no el del modelo ya descontado)
                var stockReal = Modelo.Stock
                    .FirstOrDefault(s =>
                    s.IdCliente == idClienteSeleccionado &&
                    s.IdProducto == producto.IdProducto);

                if (stockReal == null)
                {
                    MessageBox.Show("No hay stock disponible con ese filtro.");
                    return;
                }

                // Filtrar por depósito y tipo de pallet
                var posicionesDisponibles = stockReal.Posiciones
                    .Where(p =>
                        p.IdDeposito == idDepositoSeleccionado &&
                        p.PalletCerrado == palletCerrado)
                    .OrderByDescending(p => p.Cantidad)
                    .ToList();

                if (!posicionesDisponibles.Any())
                {
                    MessageBox.Show("No hay stock disponible con ese filtro.");
                    return;
                }

                // Calcular stock disponible REAL (considerando órdenes existentes)
                int stockDisponible = posicionesDisponibles.Sum(p => p.Cantidad);
                int cantidadReservada = ObtenerCantidadReservada(producto.IdProducto);
                int cantidadRealDisponible = stockDisponible - cantidadReservada;

                string Sku = producto.Sku;
                int CantidadARetirar = int.Parse(cantidadARetirarTextBox.Text);

                // Validar contra stock REAL disponible
                if (CantidadARetirar > cantidadRealDisponible)
                {
                    MessageBox.Show($"No hay suficiente stock disponible. Máximo: {cantidadRealDisponible}");
                    return;
                }

                // Buscar/crear item en ListView
                ListViewItem filaExistente = ordenDePreparacionListView.Items
                    .Cast<ListViewItem>()
                    .FirstOrDefault(item => item.Text == Sku)!;

                if (filaExistente != null)
                {
                    int cantidadAnterior = int.Parse(filaExistente.SubItems[1].Text);
                    filaExistente.SubItems[1].Text = (cantidadAnterior + CantidadARetirar).ToString();
                }
                else
                {
                    filaExistente = ordenDePreparacionListView.Items.Add(Sku);
                    filaExistente.SubItems.Add(CantidadARetirar.ToString());
                    filaExistente.SubItems.Add(string.Join(", ", posicionesDisponibles.Select(p => p.Posicion)));
                }

                // Restar de las posiciones físicas (simulación)
                int cantidadRestante = CantidadARetirar;
                var posicionesUtilizadas = new List<(string posicion, int cantidad, bool pallet)>();

                foreach (var posicion in posicionesDisponibles)
                {
                    if (cantidadRestante <= 0) break;

                    int aDescontar = Math.Min(posicion.Cantidad, cantidadRestante);
                    cantidadRestante -= aDescontar;
                    posicionesUtilizadas.Add((posicion.Posicion, aDescontar, palletCerrado));
                }

                // Actualizar Tag
                if (filaExistente.Tag is List<(string, int, bool)> existentes)
                {
                    existentes.AddRange(posicionesUtilizadas);
                }
                else
                {
                    filaExistente.Tag = posicionesUtilizadas;
                }

                // Actualizar con el nuevo cálculo
                cantidadEnStockTextBox.Text = (cantidadRealDisponible - CantidadARetirar).ToString();

                // Limpiar controles
                cantidadARetirarTextBox.Text = "";
                agregarProductoButton.Enabled = false;

                // Actualizar estados
                bool listaVacia = ordenDePreparacionListView.Items.Count == 0;
                depositoComboBox.Enabled = listaVacia;
                razonSocialComboBox.Enabled = listaVacia;
                palletCerradoComboBox.Enabled = listaVacia;
                dniTransportistaTextBox.Enabled = !listaVacia;
            }
        }

        private int ObtenerCantidadReservada(int idProducto)
        {
            return ordenDePreparacionListView.Items
                .Cast<ListViewItem>()
                .Where(item =>
                {
                    var prod = Modelo.Productos.FirstOrDefault(p => p.Sku == item.Text);
                    return prod != null && prod.IdProducto == idProducto;
                })
                .Sum(item => int.Parse(item.SubItems[1].Text));
        }

        private void quitarProductoButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in ordenDePreparacionListView.SelectedItems)
            {
                string sku = item.Text;
                int cantidadARetirada = int.Parse(item.SubItems[1].Text);

                // Buscar el producto que se está quitando
                var producto = Modelo.Productos.FirstOrDefault(p => p.Sku == sku);
                if (producto == null) continue;

                // Seleccionar este producto en el ComboBox
                productoComboBox.SelectedItem = productoComboBox.Items
                    .Cast<ProductoEntidad>()
                    .FirstOrDefault(p => p.IdProducto == producto.IdProducto);

                // Buscar el stock físico específico (cliente + producto)
                var stockProducto = Modelo.Stock
                    .FirstOrDefault(s =>
                        s.IdProducto == producto.IdProducto &&
                        s.IdCliente == idClienteSeleccionado);

                if (stockProducto != null)
                {
                    // Recuperar las posiciones originales desde el Tag del item
                    if (item.Tag is List<(string posicion, int cantidad, bool palletCerrado)> posicionesUsadas)
                    {
                        // Restaurar stock a las posiciones originales
                        foreach (var (posicion, cantidad, palletCerradoUsado) in posicionesUsadas)
                        {
                            var posicionOriginal = stockProducto.Posiciones.FirstOrDefault(p =>
                                p.Posicion == posicion &&
                                p.PalletCerrado == palletCerradoUsado);

                            if (posicionOriginal != null)
                            {
                                posicionOriginal.Cantidad += cantidad;
                            }
                        }
                    }

                    // CALCULAR EL STOCK DISPONIBLE CORRECTAMENTE (considerando órdenes existentes)
                    var stockDisponible = CalcularStockDisponibleReal(
                        producto.IdProducto,
                        idClienteSeleccionado,
                        idDepositoSeleccionado,
                        palletCerrado);

                    cantidadEnStockTextBox.Text = stockDisponible.ToString();
                }

                ordenDePreparacionListView.Items.Remove(item);
            }

            // Actualizar estados de controles
            bool hayItems = ordenDePreparacionListView.Items.Count > 0;
            depositoComboBox.Enabled = !hayItems;
            dniTransportistaTextBox.Enabled = hayItems;
            cargarOrdenButton.Enabled = hayItems;
            razonSocialComboBox.Enabled = !hayItems;
            palletCerradoComboBox.Enabled = !hayItems;
        }

        private int CalcularStockDisponibleReal(int idProducto, int idCliente, int idDeposito, bool palletCerrado)
        {
            // 1. Obtener stock físico base
            var stockFisico = Modelo.Stock
                .FirstOrDefault(s =>
                    s.IdProducto == idProducto &&
                    s.IdCliente == idCliente)?
                .Posiciones
                .Where(p =>
                    p.IdDeposito == idDeposito &&
                    p.PalletCerrado == palletCerrado)
                .Sum(p => p.Cantidad) ?? 0;

            // 2. Obtener cantidades reservadas en órdenes (excepto la actual)
            int cantidadReservada = Modelo.OrdenesPreparacion
                .Where(o =>
                    o.IdCliente == idCliente &&
                    o.Estado == 0 && o.PalletCerrado == palletCerrado) // Solo órdenes activas
                .SelectMany(o => o.ProductoOrden)
                .Where(po =>
                    po.IdProducto == idProducto)
                .Sum(po => po.Cantidad);

            // 3. Calcular stock realmente disponible
            return stockFisico - cantidadReservada;
        }
        private void ordenDePreparacionListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            quitarProductoButton.Enabled = ordenDePreparacionListView.SelectedItems.Count > 0;
            razonSocialComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            depositoComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
        }

        private void cargarOrdenButton_Click(object sender, EventArgs e)
        {
            int nuevoIdOrden = id;

            // Crear lista de productos asociados a la orden
            List<ProductoOrden> productosAsociados = new List<ProductoOrden>();
            bool pallet = false;

            foreach (ListViewItem item in ordenDePreparacionListView.Items)
            {
                string sku = item.SubItems[0].Text;
                int cantidad = int.Parse(item.SubItems[1].Text);

                if (palletCerradoComboBox.SelectedIndex == 1)
                {
                    pallet = true;
                }

                // Buscar el producto por SKU en la lista de productos
                ProductoEntidad productoACargar = Modelo.Productos.FirstOrDefault(p => p.Sku == sku);

                ProductoOrden productoOrden = new ProductoOrden
                {
                    IdProducto = productoACargar.IdProducto,
                    IdCliente = idClienteSeleccionado,
                    Cantidad = cantidad,
                };

                productosAsociados.Add(productoOrden);               
            }

            // Crear la orden de preparación
            OrdenPreparacionEntidad Orden = new OrdenPreparacionEntidad
            {
                IdOrdenPreparacion = id,
                IdDeposito = idDepositoSeleccionado,
                IdCliente = idClienteSeleccionado,
                DniTransportista = int.Parse(dniTransportistaTextBox.Text),
                Estado = EstadoOrdenPreparacion.Pendiente,
                FechaEntrega = despachoDateTimePicker.Value,
                PalletCerrado = pallet,
                ProductoOrden = productosAsociados
            };

            // Agregar la orden al almacén
            Modelo.NuevaOrdenPreparacion(Orden);
            string Pallet;
            if (palletCerrado)
            {
                Pallet = "Si";
            }
            else
            {
                Pallet = "No";
            }
            MessageBox.Show("Orden de preparación " + id + " cargada correctamente."// \nID de órden: " + id + "\nID de depósito: " + idDepositoSeleccionado + "\nID de cliente: " + idClienteSeleccionado +
              /* "\nPallet cerrado: " + Pallet + "\nFecha de entrega: " + despachoDateTimePicker.Value + "\nDNI de transportista: " + dniTransportistaTextBox.Text + "\nEstado: Pendiente"*/, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Limpiar formulario
            ordenDePreparacionListView.Items.Clear();
            cantidadARetirarTextBox.Text = "";
            productoComboBox.SelectedIndex = -1;
            razonSocialComboBox.SelectedIndex = -1;
            depositoComboBox.SelectedIndex = -1;
            palletCerradoComboBox.SelectedIndex = -1;
            palletCerradoComboBox.Enabled = false;
            depositoComboBox.Enabled = false;
            productoComboBox.Enabled = false;
            cuitTextBox.Text = "-";
            skuTextBox.Text = "-";
            cantidadEnStockTextBox.Text = "-";
            dniTransportistaTextBox.Text = "";
            razonSocialComboBox.Enabled = true;
            /*razonSocialComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            palletCerradoComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            depositoComboBox.Enabled = ordenDePreparacionListView.Items.Count == 0;
            */
           Modelo.GrabarOP();
           
           id = Modelo.GenerarIdOrden();


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

            if (dniTransportistaTextBox.Text.Length == 8)
            {
                cargarOrdenButton.Enabled = true;
            }
            else
            {
                cargarOrdenButton.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProcesarOrdenPreparacionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ordenDePreparacionListView.Items.Count > 0)
            {
                DialogResult resultado = MessageBox.Show(
                    "Si sale se eliminarán los productos ingresados. \n ¿Salir?",
                    "Advertencia",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    MenuPrincipalGeneralForm principalGeneralForm = new MenuPrincipalGeneralForm();
                    principalGeneralForm.Show();
                }
            }
            else
            {
                MenuPrincipalGeneralForm principalGeneralForm = new MenuPrincipalGeneralForm();
                principalGeneralForm.Show();
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
    }
}
