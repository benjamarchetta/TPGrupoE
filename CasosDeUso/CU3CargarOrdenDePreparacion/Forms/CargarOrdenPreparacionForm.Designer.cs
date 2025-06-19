namespace TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Forms
{
    partial class CargarOrdenPreparacionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FechaEntregaLabel = new Label();
            despachoDateTimePicker = new DateTimePicker();
            cargarOrdenButton = new Button();
            quitarProductoButton = new Button();
            ordenDePreparacionListView = new ListView();
            skuColumnaSelec = new ColumnHeader();
            cantidadColumnaSelec = new ColumnHeader();
            posicionesColumna = new ColumnHeader();
            razonSocialComboBox = new ComboBox();
            RazonSocialClienteLabel = new Label();
            cuitTextBox = new TextBox();
            productoComboBox = new ComboBox();
            ProductoLabel = new Label();
            SkuProductoLabel = new Label();
            skuTextBox = new TextBox();
            cantidadEnStockTextBox = new TextBox();
            CantidadStockLabel = new Label();
            palletCerradoComboBox = new ComboBox();
            cantidadARetirarLabel = new Label();
            cantidadARetirarTextBox = new TextBox();
            agregarProductoButton = new Button();
            DniTransportistaLabel = new Label();
            CuitClienteLabel = new Label();
            dniTransportistaTextBox = new TextBox();
            depositoComboBox = new ComboBox();
            DepositoLabel = new Label();
            VolverMenuPrincipalButton = new Button();
            DetalleOProupBox = new GroupBox();
            DatosTransportistaGroupBox = new GroupBox();
            label1 = new Label();
            DatosObligatoriosGroupBox = new GroupBox();
            FlagPalletCerradoLabel = new Label();
            ProductosAsociadosOPGroupBox = new GroupBox();
            CargarOPPanel = new Panel();
            DatosTransportistaGroupBox.SuspendLayout();
            DatosObligatoriosGroupBox.SuspendLayout();
            ProductosAsociadosOPGroupBox.SuspendLayout();
            CargarOPPanel.SuspendLayout();
            SuspendLayout();
            // 
            // FechaEntregaLabel
            // 
            FechaEntregaLabel.AutoSize = true;
            FechaEntregaLabel.Location = new Point(23, 23);
            FechaEntregaLabel.Name = "FechaEntregaLabel";
            FechaEntregaLabel.Size = new Size(123, 20);
            FechaEntregaLabel.TabIndex = 2;
            FechaEntregaLabel.Text = "Fecha de entrega";
            // 
            // despachoDateTimePicker
            // 
            despachoDateTimePicker.Location = new Point(23, 47);
            despachoDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            despachoDateTimePicker.MinDate = new DateTime(2025, 6, 4, 0, 0, 0, 0);
            despachoDateTimePicker.Name = "despachoDateTimePicker";
            despachoDateTimePicker.Size = new Size(400, 27);
            despachoDateTimePicker.TabIndex = 3;
            // 
            // cargarOrdenButton
            // 
            cargarOrdenButton.BackColor = SystemColors.Highlight;
            cargarOrdenButton.Enabled = false;
            cargarOrdenButton.Location = new Point(466, 772);
            cargarOrdenButton.Margin = new Padding(3, 4, 3, 4);
            cargarOrdenButton.Name = "cargarOrdenButton";
            cargarOrdenButton.Size = new Size(436, 59);
            cargarOrdenButton.TabIndex = 10;
            cargarOrdenButton.Text = "Cargar órden de preparación";
            cargarOrdenButton.UseVisualStyleBackColor = false;
            cargarOrdenButton.Click += cargarOrdenButton_Click;
            // 
            // quitarProductoButton
            // 
            quitarProductoButton.BackColor = SystemColors.GradientActiveCaption;
            quitarProductoButton.Enabled = false;
            quitarProductoButton.Location = new Point(643, 194);
            quitarProductoButton.Margin = new Padding(3, 4, 3, 4);
            quitarProductoButton.Name = "quitarProductoButton";
            quitarProductoButton.Size = new Size(223, 40);
            quitarProductoButton.TabIndex = 14;
            quitarProductoButton.Text = "Quitar producto";
            quitarProductoButton.UseVisualStyleBackColor = false;
            quitarProductoButton.Click += quitarProductoButton_Click;
            // 
            // ordenDePreparacionListView
            // 
            ordenDePreparacionListView.Columns.AddRange(new ColumnHeader[] { skuColumnaSelec, cantidadColumnaSelec, posicionesColumna });
            ordenDePreparacionListView.Font = new Font("Segoe UI", 9F);
            ordenDePreparacionListView.FullRowSelect = true;
            ordenDePreparacionListView.Location = new Point(21, 27);
            ordenDePreparacionListView.Margin = new Padding(3, 4, 3, 4);
            ordenDePreparacionListView.MultiSelect = false;
            ordenDePreparacionListView.Name = "ordenDePreparacionListView";
            ordenDePreparacionListView.Size = new Size(847, 162);
            ordenDePreparacionListView.TabIndex = 15;
            ordenDePreparacionListView.UseCompatibleStateImageBehavior = false;
            ordenDePreparacionListView.View = View.Details;
            ordenDePreparacionListView.SelectedIndexChanged += ordenDePreparacionListView_SelectedIndexChanged;
            // 
            // skuColumnaSelec
            // 
            skuColumnaSelec.Text = "SKU de producto";
            skuColumnaSelec.Width = 257;
            // 
            // cantidadColumnaSelec
            // 
            cantidadColumnaSelec.Text = "Cantidad a retirar";
            cantidadColumnaSelec.Width = 257;
            // 
            // posicionesColumna
            // 
            posicionesColumna.Text = "Posiciones";
            posicionesColumna.Width = 257;
            // 
            // razonSocialComboBox
            // 
            razonSocialComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            razonSocialComboBox.DropDownWidth = 383;
            razonSocialComboBox.Font = new Font("Segoe UI", 9F);
            razonSocialComboBox.FormattingEnabled = true;
            razonSocialComboBox.Location = new Point(466, 48);
            razonSocialComboBox.Margin = new Padding(3, 4, 3, 4);
            razonSocialComboBox.Name = "razonSocialComboBox";
            razonSocialComboBox.Size = new Size(400, 28);
            razonSocialComboBox.TabIndex = 16;
            razonSocialComboBox.SelectedIndexChanged += razonSocialComboBox_SelectedIndexChanged;
            // 
            // RazonSocialClienteLabel
            // 
            RazonSocialClienteLabel.AutoSize = true;
            RazonSocialClienteLabel.Location = new Point(466, 24);
            RazonSocialClienteLabel.Name = "RazonSocialClienteLabel";
            RazonSocialClienteLabel.Size = new Size(165, 20);
            RazonSocialClienteLabel.TabIndex = 17;
            RazonSocialClienteLabel.Text = "Razón social del cliente";
            // 
            // cuitTextBox
            // 
            cuitTextBox.Enabled = false;
            cuitTextBox.Location = new Point(468, 107);
            cuitTextBox.Margin = new Padding(3, 4, 3, 4);
            cuitTextBox.Name = "cuitTextBox";
            cuitTextBox.Size = new Size(400, 27);
            cuitTextBox.TabIndex = 19;
            cuitTextBox.Text = "-";
            cuitTextBox.TextChanged += cuitTextBox_TextChanged;
            // 
            // productoComboBox
            // 
            productoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productoComboBox.Enabled = false;
            productoComboBox.Font = new Font("Segoe UI", 9F);
            productoComboBox.FormattingEnabled = true;
            productoComboBox.Location = new Point(478, 223);
            productoComboBox.Margin = new Padding(3, 4, 3, 4);
            productoComboBox.Name = "productoComboBox";
            productoComboBox.Size = new Size(400, 28);
            productoComboBox.TabIndex = 20;
            productoComboBox.SelectedIndexChanged += productoComboBox_SelectedIndexChanged;
            // 
            // ProductoLabel
            // 
            ProductoLabel.AutoSize = true;
            ProductoLabel.Location = new Point(478, 199);
            ProductoLabel.Name = "ProductoLabel";
            ProductoLabel.Size = new Size(69, 20);
            ProductoLabel.TabIndex = 21;
            ProductoLabel.Text = "Producto";
            // 
            // SkuProductoLabel
            // 
            SkuProductoLabel.AutoSize = true;
            SkuProductoLabel.Location = new Point(478, 271);
            SkuProductoLabel.Name = "SkuProductoLabel";
            SkuProductoLabel.Size = new Size(126, 20);
            SkuProductoLabel.TabIndex = 22;
            SkuProductoLabel.Text = "SKU del producto";
            // 
            // skuTextBox
            // 
            skuTextBox.Enabled = false;
            skuTextBox.Location = new Point(478, 295);
            skuTextBox.Margin = new Padding(3, 4, 3, 4);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(180, 27);
            skuTextBox.TabIndex = 23;
            skuTextBox.Text = "-";
            skuTextBox.TextChanged += skuTextBox_TextChanged;
            // 
            // cantidadEnStockTextBox
            // 
            cantidadEnStockTextBox.Enabled = false;
            cantidadEnStockTextBox.Location = new Point(698, 295);
            cantidadEnStockTextBox.Margin = new Padding(3, 4, 3, 4);
            cantidadEnStockTextBox.Name = "cantidadEnStockTextBox";
            cantidadEnStockTextBox.Size = new Size(180, 27);
            cantidadEnStockTextBox.TabIndex = 24;
            cantidadEnStockTextBox.Text = "-";
            cantidadEnStockTextBox.TextChanged += cantidadEnStockTextBox_TextChanged;
            // 
            // CantidadStockLabel
            // 
            CantidadStockLabel.AutoSize = true;
            CantidadStockLabel.Location = new Point(698, 271);
            CantidadStockLabel.Name = "CantidadStockLabel";
            CantidadStockLabel.Size = new Size(127, 20);
            CantidadStockLabel.TabIndex = 25;
            CantidadStockLabel.Text = "Cantidad en stock";
            // 
            // palletCerradoComboBox
            // 
            palletCerradoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            palletCerradoComboBox.Font = new Font("Segoe UI", 9F);
            palletCerradoComboBox.FormattingEnabled = true;
            palletCerradoComboBox.Items.AddRange(new object[] { "No", "Sí" });
            palletCerradoComboBox.Location = new Point(23, 107);
            palletCerradoComboBox.Margin = new Padding(3, 4, 3, 4);
            palletCerradoComboBox.Name = "palletCerradoComboBox";
            palletCerradoComboBox.Size = new Size(400, 28);
            palletCerradoComboBox.TabIndex = 26;
            palletCerradoComboBox.SelectedIndexChanged += palletCerradoComboBox_SelectedIndexChanged;
            // 
            // cantidadARetirarLabel
            // 
            cantidadARetirarLabel.AutoSize = true;
            cantidadARetirarLabel.Location = new Point(33, 271);
            cantidadARetirarLabel.Name = "cantidadARetirarLabel";
            cantidadARetirarLabel.Size = new Size(125, 20);
            cantidadARetirarLabel.TabIndex = 28;
            cantidadARetirarLabel.Text = "Cantidad a retirar";
            // 
            // cantidadARetirarTextBox
            // 
            cantidadARetirarTextBox.Enabled = false;
            cantidadARetirarTextBox.Location = new Point(33, 295);
            cantidadARetirarTextBox.Margin = new Padding(3, 4, 3, 4);
            cantidadARetirarTextBox.Name = "cantidadARetirarTextBox";
            cantidadARetirarTextBox.Size = new Size(400, 27);
            cantidadARetirarTextBox.TabIndex = 29;
            cantidadARetirarTextBox.TextChanged += cantidadARetirarTextBox_TextChanged_1;
            cantidadARetirarTextBox.KeyPress += cantidadARetirarTextBox_KeyPress;
            // 
            // agregarProductoButton
            // 
            agregarProductoButton.BackColor = SystemColors.GradientActiveCaption;
            agregarProductoButton.Enabled = false;
            agregarProductoButton.Location = new Point(655, 348);
            agregarProductoButton.Margin = new Padding(3, 4, 3, 4);
            agregarProductoButton.Name = "agregarProductoButton";
            agregarProductoButton.Size = new Size(223, 40);
            agregarProductoButton.TabIndex = 30;
            agregarProductoButton.Text = "Agregar producto";
            agregarProductoButton.UseVisualStyleBackColor = false;
            agregarProductoButton.Click += agregarProductoButton_Click;
            // 
            // DniTransportistaLabel
            // 
            DniTransportistaLabel.AutoSize = true;
            DniTransportistaLabel.Location = new Point(21, 29);
            DniTransportistaLabel.Name = "DniTransportistaLabel";
            DniTransportistaLabel.Size = new Size(277, 20);
            DniTransportistaLabel.TabIndex = 32;
            DniTransportistaLabel.Text = "DNI (sólo números, sin punto ni espacio)";
            // 
            // CuitClienteLabel
            // 
            CuitClienteLabel.AutoSize = true;
            CuitClienteLabel.Location = new Point(468, 84);
            CuitClienteLabel.Name = "CuitClienteLabel";
            CuitClienteLabel.Size = new Size(113, 20);
            CuitClienteLabel.TabIndex = 37;
            CuitClienteLabel.Text = "CUIT del cliente";
            // 
            // dniTransportistaTextBox
            // 
            dniTransportistaTextBox.Enabled = false;
            dniTransportistaTextBox.Location = new Point(21, 53);
            dniTransportistaTextBox.Margin = new Padding(3, 4, 3, 4);
            dniTransportistaTextBox.Name = "dniTransportistaTextBox";
            dniTransportistaTextBox.Size = new Size(845, 27);
            dniTransportistaTextBox.TabIndex = 39;
            dniTransportistaTextBox.TextChanged += dniTransportistaTextBox_TextChanged;
            dniTransportistaTextBox.KeyPress += dniTransportistaTextBox_KeyPress;
            // 
            // depositoComboBox
            // 
            depositoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoComboBox.Enabled = false;
            depositoComboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            depositoComboBox.FormattingEnabled = true;
            depositoComboBox.Location = new Point(33, 223);
            depositoComboBox.Margin = new Padding(3, 4, 3, 4);
            depositoComboBox.Name = "depositoComboBox";
            depositoComboBox.Size = new Size(400, 28);
            depositoComboBox.TabIndex = 40;
            depositoComboBox.SelectedIndexChanged += depositoComboBox_SelectedIndexChanged;
            // 
            // DepositoLabel
            // 
            DepositoLabel.AutoSize = true;
            DepositoLabel.Location = new Point(33, 199);
            DepositoLabel.Name = "DepositoLabel";
            DepositoLabel.Size = new Size(126, 20);
            DepositoLabel.TabIndex = 41;
            DepositoLabel.Text = "Depósito a retirar";
            // 
            // VolverMenuPrincipalButton
            // 
            VolverMenuPrincipalButton.Location = new Point(12, 772);
            VolverMenuPrincipalButton.Margin = new Padding(3, 4, 3, 4);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(436, 59);
            VolverMenuPrincipalButton.TabIndex = 42;
            VolverMenuPrincipalButton.Text = "Volver al menú principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = true;
            VolverMenuPrincipalButton.Click += button1_Click;
            // 
            // DetalleOProupBox
            // 
            DetalleOProupBox.Location = new Point(12, 179);
            DetalleOProupBox.Margin = new Padding(3, 4, 3, 4);
            DetalleOProupBox.Name = "DetalleOProupBox";
            DetalleOProupBox.Padding = new Padding(3, 4, 3, 4);
            DetalleOProupBox.Size = new Size(890, 223);
            DetalleOProupBox.TabIndex = 43;
            DetalleOProupBox.TabStop = false;
            DetalleOProupBox.Text = "Detalle de la mercadería a despachar";
            // 
            // DatosTransportistaGroupBox
            // 
            DatosTransportistaGroupBox.Controls.Add(label1);
            DatosTransportistaGroupBox.Controls.Add(dniTransportistaTextBox);
            DatosTransportistaGroupBox.Controls.Add(DniTransportistaLabel);
            DatosTransportistaGroupBox.Location = new Point(12, 670);
            DatosTransportistaGroupBox.Name = "DatosTransportistaGroupBox";
            DatosTransportistaGroupBox.Size = new Size(890, 95);
            DatosTransportistaGroupBox.TabIndex = 44;
            DatosTransportistaGroupBox.TabStop = false;
            DatosTransportistaGroupBox.Text = "DNI del transportista";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(119, 0);
            label1.Name = "label1";
            label1.Size = new Size(296, 15);
            label1.TabIndex = 47;
            label1.Text = "Ingrese 8 dígitos, sólo números, sin puntos ni espacios.";
            // 
            // DatosObligatoriosGroupBox
            // 
            DatosObligatoriosGroupBox.Controls.Add(razonSocialComboBox);
            DatosObligatoriosGroupBox.Controls.Add(FlagPalletCerradoLabel);
            DatosObligatoriosGroupBox.Controls.Add(RazonSocialClienteLabel);
            DatosObligatoriosGroupBox.Controls.Add(palletCerradoComboBox);
            DatosObligatoriosGroupBox.Controls.Add(cuitTextBox);
            DatosObligatoriosGroupBox.Controls.Add(CuitClienteLabel);
            DatosObligatoriosGroupBox.Controls.Add(despachoDateTimePicker);
            DatosObligatoriosGroupBox.Controls.Add(FechaEntregaLabel);
            DatosObligatoriosGroupBox.Location = new Point(12, 12);
            DatosObligatoriosGroupBox.Name = "DatosObligatoriosGroupBox";
            DatosObligatoriosGroupBox.Size = new Size(890, 152);
            DatosObligatoriosGroupBox.TabIndex = 45;
            DatosObligatoriosGroupBox.TabStop = false;
            DatosObligatoriosGroupBox.Text = "Datos obligatorios";
            DatosObligatoriosGroupBox.Enter += DatosObligatoriosGroupBox_Enter;
            // 
            // FlagPalletCerradoLabel
            // 
            FlagPalletCerradoLabel.AutoSize = true;
            FlagPalletCerradoLabel.Location = new Point(23, 83);
            FlagPalletCerradoLabel.Name = "FlagPalletCerradoLabel";
            FlagPalletCerradoLabel.Size = new Size(134, 20);
            FlagPalletCerradoLabel.TabIndex = 38;
            FlagPalletCerradoLabel.Text = "¿Es pallet cerrado?";
            // 
            // ProductosAsociadosOPGroupBox
            // 
            ProductosAsociadosOPGroupBox.Controls.Add(ordenDePreparacionListView);
            ProductosAsociadosOPGroupBox.Controls.Add(quitarProductoButton);
            ProductosAsociadosOPGroupBox.Location = new Point(12, 416);
            ProductosAsociadosOPGroupBox.Name = "ProductosAsociadosOPGroupBox";
            ProductosAsociadosOPGroupBox.Size = new Size(890, 241);
            ProductosAsociadosOPGroupBox.TabIndex = 46;
            ProductosAsociadosOPGroupBox.TabStop = false;
            ProductosAsociadosOPGroupBox.Text = "Productos asignados a la órden de preparación";
            // 
            // CargarOPPanel
            // 
            CargarOPPanel.AutoScroll = true;
            CargarOPPanel.Controls.Add(VolverMenuPrincipalButton);
            CargarOPPanel.Controls.Add(DepositoLabel);
            CargarOPPanel.Controls.Add(depositoComboBox);
            CargarOPPanel.Controls.Add(agregarProductoButton);
            CargarOPPanel.Controls.Add(cantidadARetirarTextBox);
            CargarOPPanel.Controls.Add(cantidadARetirarLabel);
            CargarOPPanel.Controls.Add(CantidadStockLabel);
            CargarOPPanel.Controls.Add(cantidadEnStockTextBox);
            CargarOPPanel.Controls.Add(skuTextBox);
            CargarOPPanel.Controls.Add(SkuProductoLabel);
            CargarOPPanel.Controls.Add(ProductoLabel);
            CargarOPPanel.Controls.Add(productoComboBox);
            CargarOPPanel.Controls.Add(DetalleOProupBox);
            CargarOPPanel.Controls.Add(ProductosAsociadosOPGroupBox);
            CargarOPPanel.Controls.Add(cargarOrdenButton);
            CargarOPPanel.Controls.Add(DatosObligatoriosGroupBox);
            CargarOPPanel.Controls.Add(DatosTransportistaGroupBox);
            CargarOPPanel.Dock = DockStyle.Fill;
            CargarOPPanel.Location = new Point(0, 0);
            CargarOPPanel.Name = "CargarOPPanel";
            CargarOPPanel.Size = new Size(922, 846);
            CargarOPPanel.TabIndex = 47;
            // 
            // CargarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(922, 846);
            Controls.Add(CargarOPPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CargarOrdenPreparacionForm";
            Text = "Cargar órden de preparación";
            FormClosing += ProcesarOrdenPreparacionForm_FormClosing;
            Load += ProcesarOrdenPreparacion_Load;
            DatosTransportistaGroupBox.ResumeLayout(false);
            DatosTransportistaGroupBox.PerformLayout();
            DatosObligatoriosGroupBox.ResumeLayout(false);
            DatosObligatoriosGroupBox.PerformLayout();
            ProductosAsociadosOPGroupBox.ResumeLayout(false);
            CargarOPPanel.ResumeLayout(false);
            CargarOPPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label FechaEntregaLabel;
        private DateTimePicker despachoDateTimePicker;
        private Button cargarOrdenButton;
        private Button quitarProductoButton;
        private ListView ordenDePreparacionListView;
        private ColumnHeader skuColumnaSelec;
        private ColumnHeader cantidadColumnaSelec;
        private ComboBox razonSocialComboBox;
        private Label RazonSocialClienteLabel;
        private TextBox cuitTextBox;
        private ComboBox productoComboBox;
        private Label ProductoLabel;
        private Label SkuProductoLabel;
        private TextBox skuTextBox;
        private TextBox cantidadEnStockTextBox;
        private Label CantidadStockLabel;
        private ComboBox palletCerradoComboBox;
        private Label cantidadARetirarLabel;
        private TextBox cantidadARetirarTextBox;
        private Button agregarProductoButton;
        private Label DniTransportistaLabel;
        private Label CuitClienteLabel;
        private TextBox dniTransportistaTextBox;
        private ComboBox depositoComboBox;
        private Label DepositoLabel;
        private Button VolverMenuPrincipalButton;
        private ColumnHeader posicionesColumna;
        private GroupBox DetalleOProupBox;
        private GroupBox DatosTransportistaGroupBox;
        private GroupBox DatosObligatoriosGroupBox;
        private GroupBox ProductosAsociadosOPGroupBox;
        private Label FlagPalletCerradoLabel;
        private Panel CargarOPPanel;
    }
}