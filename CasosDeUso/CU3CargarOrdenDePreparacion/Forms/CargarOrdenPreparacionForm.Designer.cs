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
            FechaEntregaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FechaEntregaLabel.Location = new Point(20, 17);
            FechaEntregaLabel.Name = "FechaEntregaLabel";
            FechaEntregaLabel.Size = new Size(97, 15);
            FechaEntregaLabel.TabIndex = 2;
            FechaEntregaLabel.Text = "Fecha de entrega";
            // 
            // despachoDateTimePicker
            // 
            despachoDateTimePicker.Font = new Font("Segoe UI", 9F);
            despachoDateTimePicker.Location = new Point(20, 35);
            despachoDateTimePicker.MinDate = new DateTime(2025, 6, 4, 0, 0, 0, 0);
            despachoDateTimePicker.Name = "despachoDateTimePicker";
            despachoDateTimePicker.Size = new Size(350, 23);
            despachoDateTimePicker.TabIndex = 3;
            // 
            // cargarOrdenButton
            // 
            cargarOrdenButton.BackColor = SystemColors.Highlight;
            cargarOrdenButton.Enabled = false;
            cargarOrdenButton.Location = new Point(408, 579);
            cargarOrdenButton.Name = "cargarOrdenButton";
            cargarOrdenButton.Size = new Size(382, 44);
            cargarOrdenButton.TabIndex = 10;
            cargarOrdenButton.Text = "Cargar órden de preparación";
            cargarOrdenButton.UseVisualStyleBackColor = false;
            cargarOrdenButton.Click += cargarOrdenButton_Click;
            // 
            // quitarProductoButton
            // 
            quitarProductoButton.BackColor = SystemColors.GradientActiveCaption;
            quitarProductoButton.Enabled = false;
            quitarProductoButton.Font = new Font("Segoe UI", 9F);
            quitarProductoButton.Location = new Point(564, 150);
            quitarProductoButton.Name = "quitarProductoButton";
            quitarProductoButton.Size = new Size(195, 30);
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
            ordenDePreparacionListView.Location = new Point(17, 22);
            ordenDePreparacionListView.MultiSelect = false;
            ordenDePreparacionListView.Name = "ordenDePreparacionListView";
            ordenDePreparacionListView.Size = new Size(742, 122);
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
            razonSocialComboBox.Location = new Point(408, 36);
            razonSocialComboBox.Name = "razonSocialComboBox";
            razonSocialComboBox.Size = new Size(350, 23);
            razonSocialComboBox.TabIndex = 16;
            razonSocialComboBox.SelectedIndexChanged += razonSocialComboBox_SelectedIndexChanged;
            // 
            // RazonSocialClienteLabel
            // 
            RazonSocialClienteLabel.AutoSize = true;
            RazonSocialClienteLabel.Font = new Font("Segoe UI Semibold", 9F);
            RazonSocialClienteLabel.Location = new Point(408, 18);
            RazonSocialClienteLabel.Name = "RazonSocialClienteLabel";
            RazonSocialClienteLabel.Size = new Size(130, 15);
            RazonSocialClienteLabel.TabIndex = 17;
            RazonSocialClienteLabel.Text = "Razón social del cliente";
            // 
            // cuitTextBox
            // 
            cuitTextBox.Enabled = false;
            cuitTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cuitTextBox.Location = new Point(410, 80);
            cuitTextBox.Name = "cuitTextBox";
            cuitTextBox.Size = new Size(350, 23);
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
            productoComboBox.Location = new Point(418, 167);
            productoComboBox.Name = "productoComboBox";
            productoComboBox.Size = new Size(350, 23);
            productoComboBox.TabIndex = 20;
            productoComboBox.SelectedIndexChanged += productoComboBox_SelectedIndexChanged;
            // 
            // ProductoLabel
            // 
            ProductoLabel.AutoSize = true;
            ProductoLabel.Font = new Font("Segoe UI Semibold", 9F);
            ProductoLabel.Location = new Point(418, 149);
            ProductoLabel.Name = "ProductoLabel";
            ProductoLabel.Size = new Size(56, 15);
            ProductoLabel.TabIndex = 21;
            ProductoLabel.Text = "Producto";
            // 
            // SkuProductoLabel
            // 
            SkuProductoLabel.AutoSize = true;
            SkuProductoLabel.Font = new Font("Segoe UI Semibold", 9F);
            SkuProductoLabel.Location = new Point(418, 203);
            SkuProductoLabel.Name = "SkuProductoLabel";
            SkuProductoLabel.Size = new Size(100, 15);
            SkuProductoLabel.TabIndex = 22;
            SkuProductoLabel.Text = "SKU del producto";
            // 
            // skuTextBox
            // 
            skuTextBox.Enabled = false;
            skuTextBox.Location = new Point(418, 221);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(158, 23);
            skuTextBox.TabIndex = 23;
            skuTextBox.Text = "-";
            skuTextBox.TextChanged += skuTextBox_TextChanged;
            // 
            // cantidadEnStockTextBox
            // 
            cantidadEnStockTextBox.Enabled = false;
            cantidadEnStockTextBox.Location = new Point(611, 221);
            cantidadEnStockTextBox.Name = "cantidadEnStockTextBox";
            cantidadEnStockTextBox.Size = new Size(158, 23);
            cantidadEnStockTextBox.TabIndex = 24;
            cantidadEnStockTextBox.Text = "-";
            cantidadEnStockTextBox.TextChanged += cantidadEnStockTextBox_TextChanged;
            // 
            // CantidadStockLabel
            // 
            CantidadStockLabel.AutoSize = true;
            CantidadStockLabel.Font = new Font("Segoe UI Semibold", 9F);
            CantidadStockLabel.Location = new Point(611, 203);
            CantidadStockLabel.Name = "CantidadStockLabel";
            CantidadStockLabel.Size = new Size(101, 15);
            CantidadStockLabel.TabIndex = 25;
            CantidadStockLabel.Text = "Cantidad en stock";
            // 
            // palletCerradoComboBox
            // 
            palletCerradoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            palletCerradoComboBox.Font = new Font("Segoe UI", 9F);
            palletCerradoComboBox.FormattingEnabled = true;
            palletCerradoComboBox.Items.AddRange(new object[] { "No", "Sí" });
            palletCerradoComboBox.Location = new Point(20, 80);
            palletCerradoComboBox.Name = "palletCerradoComboBox";
            palletCerradoComboBox.Size = new Size(350, 23);
            palletCerradoComboBox.TabIndex = 26;
            palletCerradoComboBox.SelectedIndexChanged += palletCerradoComboBox_SelectedIndexChanged;
            // 
            // cantidadARetirarLabel
            // 
            cantidadARetirarLabel.AutoSize = true;
            cantidadARetirarLabel.Font = new Font("Segoe UI Semibold", 9F);
            cantidadARetirarLabel.Location = new Point(29, 203);
            cantidadARetirarLabel.Name = "cantidadARetirarLabel";
            cantidadARetirarLabel.Size = new Size(97, 15);
            cantidadARetirarLabel.TabIndex = 28;
            cantidadARetirarLabel.Text = "Cantidad a retirar";
            // 
            // cantidadARetirarTextBox
            // 
            cantidadARetirarTextBox.Enabled = false;
            cantidadARetirarTextBox.Location = new Point(29, 221);
            cantidadARetirarTextBox.Name = "cantidadARetirarTextBox";
            cantidadARetirarTextBox.Size = new Size(350, 23);
            cantidadARetirarTextBox.TabIndex = 29;
            cantidadARetirarTextBox.TextChanged += cantidadARetirarTextBox_TextChanged_1;
            cantidadARetirarTextBox.KeyPress += cantidadARetirarTextBox_KeyPress;
            // 
            // agregarProductoButton
            // 
            agregarProductoButton.BackColor = SystemColors.GradientActiveCaption;
            agregarProductoButton.Enabled = false;
            agregarProductoButton.Location = new Point(573, 261);
            agregarProductoButton.Name = "agregarProductoButton";
            agregarProductoButton.Size = new Size(195, 30);
            agregarProductoButton.TabIndex = 30;
            agregarProductoButton.Text = "Agregar producto";
            agregarProductoButton.UseVisualStyleBackColor = false;
            agregarProductoButton.Click += agregarProductoButton_Click;
            // 
            // DniTransportistaLabel
            // 
            DniTransportistaLabel.AutoSize = true;
            DniTransportistaLabel.Font = new Font("Segoe UI", 9F);
            DniTransportistaLabel.Location = new Point(18, 22);
            DniTransportistaLabel.Name = "DniTransportistaLabel";
            DniTransportistaLabel.Size = new Size(246, 15);
            DniTransportistaLabel.TabIndex = 32;
            DniTransportistaLabel.Text = "DNI (ingrese 8 dígitos, sin puntos ni espacios)";
            // 
            // CuitClienteLabel
            // 
            CuitClienteLabel.AutoSize = true;
            CuitClienteLabel.Font = new Font("Segoe UI Semibold", 9F);
            CuitClienteLabel.Location = new Point(410, 63);
            CuitClienteLabel.Name = "CuitClienteLabel";
            CuitClienteLabel.Size = new Size(90, 15);
            CuitClienteLabel.TabIndex = 37;
            CuitClienteLabel.Text = "CUIT del cliente";
            // 
            // dniTransportistaTextBox
            // 
            dniTransportistaTextBox.Enabled = false;
            dniTransportistaTextBox.Font = new Font("Segoe UI", 9F);
            dniTransportistaTextBox.Location = new Point(18, 40);
            dniTransportistaTextBox.Name = "dniTransportistaTextBox";
            dniTransportistaTextBox.Size = new Size(740, 23);
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
            depositoComboBox.Location = new Point(29, 167);
            depositoComboBox.Name = "depositoComboBox";
            depositoComboBox.Size = new Size(350, 23);
            depositoComboBox.TabIndex = 40;
            depositoComboBox.SelectedIndexChanged += depositoComboBox_SelectedIndexChanged;
            // 
            // DepositoLabel
            // 
            DepositoLabel.AutoSize = true;
            DepositoLabel.Font = new Font("Segoe UI Semibold", 9F);
            DepositoLabel.Location = new Point(29, 149);
            DepositoLabel.Name = "DepositoLabel";
            DepositoLabel.Size = new Size(98, 15);
            DepositoLabel.TabIndex = 41;
            DepositoLabel.Text = "Depósito a retirar";
            // 
            // VolverMenuPrincipalButton
            // 
            VolverMenuPrincipalButton.Location = new Point(10, 579);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(382, 44);
            VolverMenuPrincipalButton.TabIndex = 42;
            VolverMenuPrincipalButton.Text = "Volver al menú principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = true;
            VolverMenuPrincipalButton.Click += button1_Click;
            // 
            // DetalleOProupBox
            // 
            DetalleOProupBox.Font = new Font("Segoe UI Semibold", 10F);
            DetalleOProupBox.Location = new Point(10, 128);
            DetalleOProupBox.Name = "DetalleOProupBox";
            DetalleOProupBox.Size = new Size(779, 173);
            DetalleOProupBox.TabIndex = 43;
            DetalleOProupBox.TabStop = false;
            DetalleOProupBox.Text = "Detalle de la mercadería a despachar";
            // 
            // DatosTransportistaGroupBox
            // 
            DatosTransportistaGroupBox.Controls.Add(dniTransportistaTextBox);
            DatosTransportistaGroupBox.Controls.Add(DniTransportistaLabel);
            DatosTransportistaGroupBox.Font = new Font("Segoe UI Semibold", 10F);
            DatosTransportistaGroupBox.Location = new Point(10, 502);
            DatosTransportistaGroupBox.Margin = new Padding(3, 2, 3, 2);
            DatosTransportistaGroupBox.Name = "DatosTransportistaGroupBox";
            DatosTransportistaGroupBox.Padding = new Padding(3, 2, 3, 2);
            DatosTransportistaGroupBox.Size = new Size(779, 71);
            DatosTransportistaGroupBox.TabIndex = 44;
            DatosTransportistaGroupBox.TabStop = false;
            DatosTransportistaGroupBox.Text = "DNI del transportista";
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
            DatosObligatoriosGroupBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DatosObligatoriosGroupBox.Location = new Point(10, 9);
            DatosObligatoriosGroupBox.Margin = new Padding(3, 2, 3, 2);
            DatosObligatoriosGroupBox.Name = "DatosObligatoriosGroupBox";
            DatosObligatoriosGroupBox.Padding = new Padding(3, 2, 3, 2);
            DatosObligatoriosGroupBox.Size = new Size(779, 114);
            DatosObligatoriosGroupBox.TabIndex = 45;
            DatosObligatoriosGroupBox.TabStop = false;
            DatosObligatoriosGroupBox.Text = "Datos obligatorios";
            DatosObligatoriosGroupBox.Enter += DatosObligatoriosGroupBox_Enter;
            // 
            // FlagPalletCerradoLabel
            // 
            FlagPalletCerradoLabel.AutoSize = true;
            FlagPalletCerradoLabel.Font = new Font("Segoe UI Semibold", 9F);
            FlagPalletCerradoLabel.Location = new Point(20, 62);
            FlagPalletCerradoLabel.Name = "FlagPalletCerradoLabel";
            FlagPalletCerradoLabel.Size = new Size(103, 15);
            FlagPalletCerradoLabel.TabIndex = 38;
            FlagPalletCerradoLabel.Text = "¿Es pallet cerrado?";
            // 
            // ProductosAsociadosOPGroupBox
            // 
            ProductosAsociadosOPGroupBox.Controls.Add(ordenDePreparacionListView);
            ProductosAsociadosOPGroupBox.Controls.Add(quitarProductoButton);
            ProductosAsociadosOPGroupBox.Font = new Font("Segoe UI Semibold", 10F);
            ProductosAsociadosOPGroupBox.Location = new Point(10, 307);
            ProductosAsociadosOPGroupBox.Margin = new Padding(3, 2, 3, 2);
            ProductosAsociadosOPGroupBox.Name = "ProductosAsociadosOPGroupBox";
            ProductosAsociadosOPGroupBox.Padding = new Padding(3, 2, 3, 2);
            ProductosAsociadosOPGroupBox.Size = new Size(779, 186);
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
            CargarOPPanel.Margin = new Padding(3, 2, 3, 2);
            CargarOPPanel.Name = "CargarOPPanel";
            CargarOPPanel.Size = new Size(807, 562);
            CargarOPPanel.TabIndex = 47;
            // 
            // CargarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 562);
            Controls.Add(CargarOPPanel);
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