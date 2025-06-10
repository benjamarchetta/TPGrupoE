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
            label4 = new Label();
            label5 = new Label();
            label13 = new Label();
            dniTransportistaTextBox = new TextBox();
            depositoComboBox = new ComboBox();
            label11 = new Label();
            button1 = new Button();
            groupBox1 = new GroupBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de despacho de orden";
            // 
            // despachoDateTimePicker
            // 
            despachoDateTimePicker.Location = new Point(12, 27);
            despachoDateTimePicker.MinDate = new DateTime(2025, 6, 4, 0, 0, 0, 0);
            despachoDateTimePicker.Name = "despachoDateTimePicker";
            despachoDateTimePicker.Size = new Size(382, 23);
            despachoDateTimePicker.TabIndex = 3;
            // 
            // cargarOrdenButton
            // 
            cargarOrdenButton.Enabled = false;
            cargarOrdenButton.Location = new Point(443, 545);
            cargarOrdenButton.Name = "cargarOrdenButton";
            cargarOrdenButton.Size = new Size(168, 23);
            cargarOrdenButton.TabIndex = 10;
            cargarOrdenButton.Text = "Cargar orden de preparación";
            cargarOrdenButton.UseVisualStyleBackColor = true;
            cargarOrdenButton.Click += cargarOrdenButton_Click;
            // 
            // quitarProductoButton
            // 
            quitarProductoButton.Enabled = false;
            quitarProductoButton.Location = new Point(555, 469);
            quitarProductoButton.Name = "quitarProductoButton";
            quitarProductoButton.Size = new Size(233, 23);
            quitarProductoButton.TabIndex = 14;
            quitarProductoButton.Text = "Quitar producto de órden de preparación";
            quitarProductoButton.UseVisualStyleBackColor = true;
            quitarProductoButton.Click += quitarProductoButton_Click;
            // 
            // ordenDePreparacionListView
            // 
            ordenDePreparacionListView.Columns.AddRange(new ColumnHeader[] { skuColumnaSelec, cantidadColumnaSelec, posicionesColumna });
            ordenDePreparacionListView.FullRowSelect = true;
            ordenDePreparacionListView.Location = new Point(12, 310);
            ordenDePreparacionListView.MultiSelect = false;
            ordenDePreparacionListView.Name = "ordenDePreparacionListView";
            ordenDePreparacionListView.Size = new Size(776, 153);
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
            razonSocialComboBox.FormattingEnabled = true;
            razonSocialComboBox.Location = new Point(12, 79);
            razonSocialComboBox.Name = "razonSocialComboBox";
            razonSocialComboBox.Size = new Size(382, 23);
            razonSocialComboBox.TabIndex = 16;
            razonSocialComboBox.SelectedIndexChanged += razonSocialComboBox_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 61);
            label7.Name = "label7";
            label7.Size = new Size(129, 15);
            label7.TabIndex = 17;
            label7.Text = "Razón social del cliente";
            // 
            // label8
            // 
            label8.Location = new Point(499, 284);
            label8.Name = "label8";
            label8.Size = new Size(28, 23);
            label8.TabIndex = 38;
            // 
            // cuitTextBox
            // 
            cuitTextBox.Enabled = false;
            cuitTextBox.Location = new Point(400, 79);
            cuitTextBox.Name = "cuitTextBox";
            cuitTextBox.Size = new Size(383, 23);
            cuitTextBox.TabIndex = 19;
            cuitTextBox.Text = "-";
            cuitTextBox.TextChanged += cuitTextBox_TextChanged;
            // 
            // productoComboBox
            // 
            productoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            productoComboBox.Enabled = false;
            productoComboBox.FormattingEnabled = true;
            productoComboBox.Location = new Point(400, 184);
            productoComboBox.Name = "productoComboBox";
            productoComboBox.Size = new Size(385, 23);
            productoComboBox.TabIndex = 20;
            productoComboBox.SelectedIndexChanged += productoComboBox_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(400, 166);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 21;
            label3.Text = "Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 210);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 22;
            label6.Text = "SKU del producto";
            // 
            // skuTextBox
            // 
            skuTextBox.Enabled = false;
            skuTextBox.Location = new Point(400, 228);
            skuTextBox.Name = "skuTextBox";
            skuTextBox.Size = new Size(188, 23);
            skuTextBox.TabIndex = 23;
            skuTextBox.Text = "-";
            skuTextBox.TextChanged += skuTextBox_TextChanged;
            // 
            // cantidadEnStockTextBox
            // 
            cantidadEnStockTextBox.Enabled = false;
            cantidadEnStockTextBox.Location = new Point(594, 228);
            cantidadEnStockTextBox.Name = "cantidadEnStockTextBox";
            cantidadEnStockTextBox.Size = new Size(191, 23);
            cantidadEnStockTextBox.TabIndex = 24;
            cantidadEnStockTextBox.Text = "-";
            cantidadEnStockTextBox.TextChanged += cantidadEnStockTextBox_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(589, 210);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 25;
            label9.Text = "Cantidad en stock";
            // 
            // palletCerradoComboBox
            // 
            palletCerradoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            palletCerradoComboBox.FormattingEnabled = true;
            palletCerradoComboBox.Items.AddRange(new object[] { "No", "Sí" });
            palletCerradoComboBox.Location = new Point(12, 137);
            palletCerradoComboBox.Name = "palletCerradoComboBox";
            palletCerradoComboBox.Size = new Size(385, 23);
            palletCerradoComboBox.TabIndex = 26;
            palletCerradoComboBox.SelectedIndexChanged += palletCerradoComboBox_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 119);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 27;
            label10.Text = "Pallet cerrado";
            // 
            // cantidadARetirarLabel
            // 
            cantidadARetirarLabel.AutoSize = true;
            cantidadARetirarLabel.Location = new Point(12, 210);
            cantidadARetirarLabel.Name = "cantidadARetirarLabel";
            cantidadARetirarLabel.Size = new Size(98, 15);
            cantidadARetirarLabel.TabIndex = 28;
            cantidadARetirarLabel.Text = "Cantidad a retirar";
            // 
            // cantidadARetirarTextBox
            // 
            cantidadARetirarTextBox.Enabled = false;
            cantidadARetirarTextBox.Location = new Point(12, 228);
            cantidadARetirarTextBox.Name = "cantidadARetirarTextBox";
            cantidadARetirarTextBox.Size = new Size(382, 23);
            cantidadARetirarTextBox.TabIndex = 29;
            cantidadARetirarTextBox.TextChanged += cantidadARetirarTextBox_TextChanged_1;
            cantidadARetirarTextBox.KeyPress += cantidadARetirarTextBox_KeyPress;
            // 
            // agregarProductoButton
            // 
            agregarProductoButton.Enabled = false;
            agregarProductoButton.Location = new Point(534, 267);
            agregarProductoButton.Name = "agregarProductoButton";
            agregarProductoButton.Size = new Size(251, 26);
            agregarProductoButton.TabIndex = 30;
            agregarProductoButton.Text = "Agregar producto a órden de preparación";
            agregarProductoButton.UseVisualStyleBackColor = true;
            agregarProductoButton.Click += agregarProductoButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 292);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 31;
            label4.Text = "Órden de preparación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 527);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 32;
            label5.Text = "DNI de transportista";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(400, 61);
            label13.Name = "label13";
            label13.Size = new Size(86, 15);
            label13.TabIndex = 37;
            label13.Text = "Cuit del cliente";
            // 
            // dniTransportistaTextBox
            // 
            dniTransportistaTextBox.Enabled = false;
            dniTransportistaTextBox.Location = new Point(12, 545);
            dniTransportistaTextBox.Name = "dniTransportistaTextBox";
            dniTransportistaTextBox.Size = new Size(200, 23);
            dniTransportistaTextBox.TabIndex = 39;
            dniTransportistaTextBox.TextChanged += dniTransportistaTextBox_TextChanged;
            dniTransportistaTextBox.KeyPress += dniTransportistaTextBox_KeyPress;
            // 
            // depositoComboBox
            // 
            depositoComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            depositoComboBox.Enabled = false;
            depositoComboBox.FormattingEnabled = true;
            depositoComboBox.Location = new Point(12, 184);
            depositoComboBox.Name = "depositoComboBox";
            depositoComboBox.Size = new Size(382, 23);
            depositoComboBox.TabIndex = 40;
            depositoComboBox.SelectedIndexChanged += depositoComboBox_SelectedIndexChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(11, 166);
            label11.Name = "label11";
            label11.Size = new Size(97, 15);
            label11.TabIndex = 41;
            label11.Text = "Depósito a retirar";
            // 
            // button1
            // 
            button1.Location = new Point(617, 545);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 42;
            button1.Text = "Volver al menú principal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(7, 119);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(782, 142);
            groupBox1.TabIndex = 43;
            groupBox1.TabStop = false;
            // 
            // ProcesarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 580);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(depositoComboBox);
            Controls.Add(dniTransportistaTextBox);
            Controls.Add(label13);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(agregarProductoButton);
            Controls.Add(cantidadARetirarTextBox);
            Controls.Add(cantidadARetirarLabel);
            Controls.Add(label10);
            Controls.Add(palletCerradoComboBox);
            Controls.Add(label9);
            Controls.Add(cantidadEnStockTextBox);
            Controls.Add(skuTextBox);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(productoComboBox);
            Controls.Add(cuitTextBox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(razonSocialComboBox);
            Controls.Add(ordenDePreparacionListView);
            Controls.Add(quitarProductoButton);
            Controls.Add(cargarOrdenButton);
            Controls.Add(despachoDateTimePicker);
            Controls.Add(label2);
            Name = "ProcesarOrdenPreparacionForm";
            Text = "Cargar órden de preparación";
            FormClosing += ProcesarOrdenPreparacionForm_FormClosing;
            Load += ProcesarOrdenPreparacion_Load;
            ResumeLayout(false);
            PerformLayout();
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
        private Label label4;
        private Label label5;
        private Label label13;
        private TextBox dniTransportistaTextBox;
        private ComboBox depositoComboBox;
        private Label label11;
        private Button button1;
        private ColumnHeader posicionesColumna;
        private GroupBox groupBox1;
    }
}