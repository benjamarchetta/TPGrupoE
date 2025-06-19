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
            label2 = new Label();
            despachoDateTimePicker = new DateTimePicker();
            cargarOrdenButton = new Button();
            quitarProductoButton = new Button();
            ordenDePreparacionListView = new ListView();
            skuColumnaSelec = new ColumnHeader();
            cantidadColumnaSelec = new ColumnHeader();
            posicionesColumna = new ColumnHeader();
            razonSocialComboBox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            cuitTextBox = new TextBox();
            productoComboBox = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            skuTextBox = new TextBox();
            cantidadEnStockTextBox = new TextBox();
            label9 = new Label();
            palletCerradoComboBox = new ComboBox();
            label10 = new Label();
            cantidadARetirarLabel = new Label();
            cantidadARetirarTextBox = new TextBox();
            agregarProductoButton = new Button();
            label13 = new Label();
            dniTransportistaTextBox = new TextBox();
            depositoComboBox = new ComboBox();
            label11 = new Label();
            VolverMenuPrincipalButton = new Button();
            groupBox1 = new GroupBox();
            DatosTransportistaGroupBox = new GroupBox();
            label1 = new Label();
            DatosObligatoriosGroupBox = new GroupBox();
            FlagPalletCerradoLabel = new Label();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            DatosTransportistaGroupBox.SuspendLayout();
            DatosObligatoriosGroupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(19, 31);
            label2.Name = "label2";
            label2.Size = new Size(103, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de entrega";
            // 
            // despachoDateTimePicker
            // 
            despachoDateTimePicker.Font = new Font("Segoe UI", 9F);
            despachoDateTimePicker.Location = new Point(20, 49);
            despachoDateTimePicker.MinDate = new DateTime(2025, 6, 4, 0, 0, 0, 0);
            despachoDateTimePicker.Name = "despachoDateTimePicker";
            despachoDateTimePicker.Size = new Size(350, 23);
            despachoDateTimePicker.TabIndex = 3;
            // 
            // cargarOrdenButton
            // 
            cargarOrdenButton.BackColor = SystemColors.Highlight;
            cargarOrdenButton.Enabled = false;
            cargarOrdenButton.Location = new Point(406, 571);
            cargarOrdenButton.Name = "cargarOrdenButton";
            cargarOrdenButton.Size = new Size(383, 44);
            cargarOrdenButton.TabIndex = 10;
            cargarOrdenButton.Text = "Cargar órden de preparación";
            cargarOrdenButton.UseVisualStyleBackColor = false;
            cargarOrdenButton.Click += cargarOrdenButton_Click;
            // 
            // quitarProductoButton
            // 
            quitarProductoButton.BackColor = SystemColors.GradientActiveCaption;
            quitarProductoButton.Enabled = false;
            quitarProductoButton.FlatAppearance.BorderColor = Color.Gray;
            quitarProductoButton.FlatStyle = FlatStyle.Flat;
            quitarProductoButton.Font = new Font("Segoe UI", 9F);
            quitarProductoButton.Location = new Point(563, 146);
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
            ordenDePreparacionListView.Location = new Point(18, 20);
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
            razonSocialComboBox.Location = new Point(408, 49);
            razonSocialComboBox.Name = "razonSocialComboBox";
            razonSocialComboBox.Size = new Size(350, 23);
            razonSocialComboBox.TabIndex = 16;
            razonSocialComboBox.SelectedIndexChanged += razonSocialComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(408, 31);
            label7.Name = "label7";
            label7.Size = new Size(135, 15);
            label7.TabIndex = 17;
            label7.Text = "Razón social del cliente";
            // 
            // label8
            // 
            label8.Location = new Point(489, 261);
            label8.Name = "label8";
            label8.Size = new Size(28, 23);
            label8.TabIndex = 38;
            // 
            // cuitTextBox
            // 
            cuitTextBox.Enabled = false;
            cuitTextBox.Font = new Font("Segoe UI", 9F);
            cuitTextBox.Location = new Point(410, 93);
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
            productoComboBox.Location = new Point(408, 43);
            productoComboBox.Name = "productoComboBox";
            productoComboBox.Size = new Size(350, 23);
            productoComboBox.TabIndex = 20;
            productoComboBox.SelectedIndexChanged += productoComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(410, 25);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 21;
            label3.Text = "Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(408, 73);
            label6.Name = "label6";
            label6.Size = new Size(105, 15);
            label6.TabIndex = 22;
            label6.Text = "SKU del producto";
            // 
            // skuTextBox
            // 
            skuTextBox.Enabled = false;
            skuTextBox.Font = new Font("Segoe UI", 9F);
            skuTextBox.Location = new Point(408, 91);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(158, 23);
            skuTextBox.TabIndex = 23;
            skuTextBox.Text = "-";
            skuTextBox.TextChanged += skuTextBox_TextChanged;
            // 
            // cantidadEnStockTextBox
            // 
            cantidadEnStockTextBox.Enabled = false;
            cantidadEnStockTextBox.Font = new Font("Segoe UI", 9F);
            cantidadEnStockTextBox.Location = new Point(589, 91);
            cantidadEnStockTextBox.Name = "cantidadEnStockTextBox";
            cantidadEnStockTextBox.Size = new Size(158, 23);
            cantidadEnStockTextBox.TabIndex = 24;
            cantidadEnStockTextBox.Text = "-";
            cantidadEnStockTextBox.TextChanged += cantidadEnStockTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label9.Location = new Point(589, 73);
            label9.Name = "label9";
            label9.Size = new Size(105, 15);
            label9.TabIndex = 25;
            label9.Text = "Cantidad en stock";
            // 
            // palletCerradoComboBox
            // 
            palletCerradoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            palletCerradoComboBox.Font = new Font("Segoe UI", 9F);
            palletCerradoComboBox.FormattingEnabled = true;
            palletCerradoComboBox.Items.AddRange(new object[] { "No", "Sí" });
            palletCerradoComboBox.Location = new Point(20, 93);
            palletCerradoComboBox.Name = "palletCerradoComboBox";
            palletCerradoComboBox.Size = new Size(350, 23);
            palletCerradoComboBox.TabIndex = 26;
            palletCerradoComboBox.SelectedIndexChanged += palletCerradoComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, -24);
            label10.Name = "label10";
            label10.Size = new Size(116, 21);
            label10.TabIndex = 27;
            label10.Text = "Pallet cerrado";
            // 
            // cantidadARetirarLabel
            // 
            cantidadARetirarLabel.AutoSize = true;
            cantidadARetirarLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            cantidadARetirarLabel.Location = new Point(20, 72);
            cantidadARetirarLabel.Name = "cantidadARetirarLabel";
            cantidadARetirarLabel.Size = new Size(103, 15);
            cantidadARetirarLabel.TabIndex = 28;
            cantidadARetirarLabel.Text = "Cantidad a retirar";
            // 
            // cantidadARetirarTextBox
            // 
            cantidadARetirarTextBox.Enabled = false;
            cantidadARetirarTextBox.Font = new Font("Segoe UI", 9F);
            cantidadARetirarTextBox.Location = new Point(20, 91);
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
            agregarProductoButton.FlatAppearance.BorderColor = Color.Gray;
            agregarProductoButton.FlatStyle = FlatStyle.Flat;
            agregarProductoButton.Font = new Font("Segoe UI", 9F);
            agregarProductoButton.Location = new Point(563, 131);
            agregarProductoButton.Name = "agregarProductoButton";
            agregarProductoButton.Size = new Size(195, 30);
            agregarProductoButton.TabIndex = 30;
            agregarProductoButton.Text = "Agregar producto";
            agregarProductoButton.UseVisualStyleBackColor = false;
            agregarProductoButton.Click += agregarProductoButton_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(410, 75);
            label13.Name = "label13";
            label13.Size = new Size(95, 15);
            label13.TabIndex = 37;
            label13.Text = "CUIT del cliente";
            // 
            // dniTransportistaTextBox
            // 
            dniTransportistaTextBox.Enabled = false;
            dniTransportistaTextBox.Location = new Point(18, 20);
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
            depositoComboBox.Location = new Point(20, 43);
            depositoComboBox.Name = "depositoComboBox";
            depositoComboBox.Size = new Size(350, 23);
            depositoComboBox.TabIndex = 40;
            depositoComboBox.SelectedIndexChanged += depositoComboBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label11.Location = new Point(19, 25);
            label11.Name = "label11";
            label11.Size = new Size(105, 15);
            label11.TabIndex = 41;
            label11.Text = "Depósito a retirar";
            // 
            // VolverMenuPrincipalButton
            // 
            VolverMenuPrincipalButton.Location = new Point(10, 571);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(382, 44);
            VolverMenuPrincipalButton.TabIndex = 42;
            VolverMenuPrincipalButton.Text = "Volver al menú principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = true;
            VolverMenuPrincipalButton.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(agregarProductoButton);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cantidadARetirarLabel);
            groupBox1.Controls.Add(cantidadEnStockTextBox);
            groupBox1.Controls.Add(cantidadARetirarTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(skuTextBox);
            groupBox1.Controls.Add(depositoComboBox);
            groupBox1.Controls.Add(productoComboBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(10, 135);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 167);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            groupBox1.Text = "Detalle de la mercadería a despachar";
            // 
            // DatosTransportistaGroupBox
            // 
            DatosTransportistaGroupBox.Controls.Add(label1);
            DatosTransportistaGroupBox.Controls.Add(dniTransportistaTextBox);
            DatosTransportistaGroupBox.Location = new Point(10, 501);
            DatosTransportistaGroupBox.Margin = new Padding(3, 2, 3, 2);
            DatosTransportistaGroupBox.Name = "DatosTransportistaGroupBox";
            DatosTransportistaGroupBox.Padding = new Padding(3, 2, 3, 2);
            DatosTransportistaGroupBox.Size = new Size(777, 55);
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
            DatosObligatoriosGroupBox.Controls.Add(label7);
            DatosObligatoriosGroupBox.Controls.Add(palletCerradoComboBox);
            DatosObligatoriosGroupBox.Controls.Add(cuitTextBox);
            DatosObligatoriosGroupBox.Controls.Add(label13);
            DatosObligatoriosGroupBox.Controls.Add(despachoDateTimePicker);
            DatosObligatoriosGroupBox.Controls.Add(label2);
            DatosObligatoriosGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            DatosObligatoriosGroupBox.Location = new Point(10, 2);
            DatosObligatoriosGroupBox.Margin = new Padding(3, 2, 3, 2);
            DatosObligatoriosGroupBox.Name = "DatosObligatoriosGroupBox";
            DatosObligatoriosGroupBox.Padding = new Padding(3, 2, 3, 2);
            DatosObligatoriosGroupBox.Size = new Size(779, 121);
            DatosObligatoriosGroupBox.TabIndex = 45;
            DatosObligatoriosGroupBox.TabStop = false;
            DatosObligatoriosGroupBox.Text = "Datos obligatorios";
            DatosObligatoriosGroupBox.Enter += DatosObligatoriosGroupBox_Enter;
            // 
            // FlagPalletCerradoLabel
            // 
            FlagPalletCerradoLabel.AutoSize = true;
            FlagPalletCerradoLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            FlagPalletCerradoLabel.Location = new Point(20, 75);
            FlagPalletCerradoLabel.Name = "FlagPalletCerradoLabel";
            FlagPalletCerradoLabel.Size = new Size(108, 15);
            FlagPalletCerradoLabel.TabIndex = 38;
            FlagPalletCerradoLabel.Text = "¿Es pallet cerrado?";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ordenDePreparacionListView);
            groupBox2.Controls.Add(quitarProductoButton);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(10, 312);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(779, 181);
            groupBox2.TabIndex = 46;
            groupBox2.TabStop = false;
            groupBox2.Text = "Productos asignados a la órden de preparación";
            // 
            // CargarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 625);
            Controls.Add(VolverMenuPrincipalButton);
            Controls.Add(label8);
            Controls.Add(cargarOrdenButton);
            Controls.Add(DatosTransportistaGroupBox);
            Controls.Add(DatosObligatoriosGroupBox);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "CargarOrdenPreparacionForm";
            Text = "Cargar órden de preparación";
            FormClosing += ProcesarOrdenPreparacionForm_FormClosing;
            Load += ProcesarOrdenPreparacion_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            DatosTransportistaGroupBox.ResumeLayout(false);
            DatosTransportistaGroupBox.PerformLayout();
            DatosObligatoriosGroupBox.ResumeLayout(false);
            DatosObligatoriosGroupBox.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private DateTimePicker despachoDateTimePicker;
        private Button cargarOrdenButton;
        private Button quitarProductoButton;
        private ListView ordenDePreparacionListView;
        private ColumnHeader skuColumnaSelec;
        private ColumnHeader cantidadColumnaSelec;
        private ComboBox razonSocialComboBox;
        private Label label7;
        private Label label8;
        private TextBox cuitTextBox;
        private ComboBox productoComboBox;
        private Label label3;
        private Label label6;
        private TextBox skuTextBox;
        private TextBox cantidadEnStockTextBox;
        private Label label9;
        private ComboBox palletCerradoComboBox;
        private Label label10;
        private Label cantidadARetirarLabel;
        private TextBox cantidadARetirarTextBox;
        private Button agregarProductoButton;
        private Label label13;
        private TextBox dniTransportistaTextBox;
        private ComboBox depositoComboBox;
        private Label label11;
        private Button VolverMenuPrincipalButton;
        private ColumnHeader posicionesColumna;
        private GroupBox groupBox1;
        private GroupBox DatosTransportistaGroupBox;
        private GroupBox DatosObligatoriosGroupBox;
        private GroupBox groupBox2;
        private Label FlagPalletCerradoLabel;
        private Label label1;
    }
}