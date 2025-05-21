namespace TPGrupoE.CasoU_Generar_Orden_de_Entrega
{
    partial class CargarOrdenDeEntregaForm
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
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "OS25001", "20123456780 - Juan Soto", "SKU12345", "Producto de ejemplo", "8", "aledezma", "11/04/2025", "sdsf" }, -1, SystemColors.WindowText, SystemColors.ControlLightLight, new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0));
            agregarPickingButton = new Button();
            pickingEnPreparacionListView = new ListView();
            idOrdenPicking = new ColumnHeader();
            cuitCliente = new ColumnHeader();
            skuProductoPicking = new ColumnHeader();
            nombreProducto = new ColumnHeader();
            productoCantidad = new ColumnHeader();
            idUsuarioPicking = new ColumnHeader();
            fechaEntrega = new ColumnHeader();
            borrarSelecciónButton = new Button();
            pickingEnPreparacionGroupBox = new GroupBox();
            empaquetadoGroupBox = new GroupBox();
            textBox1 = new TextBox();
            cantidadBultosLabel = new Label();
            numeroOrdenEntregaLabel = new Label();
            numeroOeTextBox = new TextBox();
            pickingPreparadoListView = new ListView();
            pickingNumero = new ColumnHeader();
            cuitClienteName = new ColumnHeader();
            skuProductoName = new ColumnHeader();
            productoName = new ColumnHeader();
            cantidadName = new ColumnHeader();
            fechaEnvio = new ColumnHeader();
            confirmarEmpaquetadoButton = new Button();
            pickingEnPreparacionGroupBox.SuspendLayout();
            empaquetadoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // agregarPickingButton
            // 
            agregarPickingButton.Enabled = false;
            agregarPickingButton.Location = new Point(1167, 234);
            agregarPickingButton.Margin = new Padding(6, 7, 6, 7);
            agregarPickingButton.Name = "agregarPickingButton";
            agregarPickingButton.Size = new Size(230, 67);
            agregarPickingButton.TabIndex = 3;
            agregarPickingButton.Text = "Agregar";
            agregarPickingButton.UseVisualStyleBackColor = true;
            // 
            // pickingEnPreparacionListView
            // 
            pickingEnPreparacionListView.BackColor = SystemColors.ControlLightLight;
            pickingEnPreparacionListView.CheckBoxes = true;
            pickingEnPreparacionListView.Columns.AddRange(new ColumnHeader[] { idOrdenPicking, cuitCliente, skuProductoPicking, nombreProducto, productoCantidad, idUsuarioPicking, fechaEntrega });
            pickingEnPreparacionListView.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pickingEnPreparacionListView.FullRowSelect = true;
            pickingEnPreparacionListView.GridLines = true;
            listViewItem3.Checked = true;
            listViewItem3.StateImageIndex = 1;
            pickingEnPreparacionListView.Items.AddRange(new ListViewItem[] { listViewItem3 });
            pickingEnPreparacionListView.LabelEdit = true;
            pickingEnPreparacionListView.Location = new Point(22, 50);
            pickingEnPreparacionListView.Name = "pickingEnPreparacionListView";
            pickingEnPreparacionListView.OwnerDraw = true;
            pickingEnPreparacionListView.Size = new Size(1375, 174);
            pickingEnPreparacionListView.TabIndex = 6;
            pickingEnPreparacionListView.UseCompatibleStateImageBehavior = false;
            pickingEnPreparacionListView.View = View.Details;
            // 
            // idOrdenPicking
            // 
            idOrdenPicking.Text = "N°";
            idOrdenPicking.Width = 140;
            // 
            // cuitCliente
            // 
            cuitCliente.Text = "CUIT - Cliente";
            cuitCliente.Width = 300;
            // 
            // skuProductoPicking
            // 
            skuProductoPicking.Text = "SKU";
            skuProductoPicking.Width = 160;
            // 
            // nombreProducto
            // 
            nombreProducto.Text = "Tipo producto";
            nombreProducto.Width = 225;
            // 
            // productoCantidad
            // 
            productoCantidad.Text = "Cantidad";
            productoCantidad.Width = 125;
            // 
            // idUsuarioPicking
            // 
            idUsuarioPicking.Text = "Preparada por";
            idUsuarioPicking.Width = 180;
            // 
            // fechaEntrega
            // 
            fechaEntrega.Text = "Fecha de envío";
            fechaEntrega.Width = 225;
            // 
            // borrarSelecciónButton
            // 
            borrarSelecciónButton.Enabled = false;
            borrarSelecciónButton.Location = new Point(914, 234);
            borrarSelecciónButton.Margin = new Padding(6, 7, 6, 7);
            borrarSelecciónButton.Name = "borrarSelecciónButton";
            borrarSelecciónButton.Size = new Size(230, 67);
            borrarSelecciónButton.TabIndex = 7;
            borrarSelecciónButton.Text = "Borrar selección";
            borrarSelecciónButton.UseVisualStyleBackColor = true;
            // 
            // pickingEnPreparacionGroupBox
            // 
            pickingEnPreparacionGroupBox.BackColor = SystemColors.Control;
            pickingEnPreparacionGroupBox.Controls.Add(pickingEnPreparacionListView);
            pickingEnPreparacionGroupBox.Controls.Add(borrarSelecciónButton);
            pickingEnPreparacionGroupBox.Controls.Add(agregarPickingButton);
            pickingEnPreparacionGroupBox.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pickingEnPreparacionGroupBox.Location = new Point(26, 25);
            pickingEnPreparacionGroupBox.Name = "pickingEnPreparacionGroupBox";
            pickingEnPreparacionGroupBox.Size = new Size(1423, 315);
            pickingEnPreparacionGroupBox.TabIndex = 8;
            pickingEnPreparacionGroupBox.TabStop = false;
            pickingEnPreparacionGroupBox.Text = "Órdenes de selección en preparación";
            pickingEnPreparacionGroupBox.Enter += groupBox1_Enter;
            // 
            // empaquetadoGroupBox
            // 
            empaquetadoGroupBox.BackColor = SystemColors.Control;
            empaquetadoGroupBox.Controls.Add(textBox1);
            empaquetadoGroupBox.Controls.Add(cantidadBultosLabel);
            empaquetadoGroupBox.Controls.Add(numeroOrdenEntregaLabel);
            empaquetadoGroupBox.Controls.Add(numeroOeTextBox);
            empaquetadoGroupBox.Controls.Add(pickingPreparadoListView);
            empaquetadoGroupBox.Controls.Add(confirmarEmpaquetadoButton);
            empaquetadoGroupBox.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            empaquetadoGroupBox.Location = new Point(26, 346);
            empaquetadoGroupBox.Name = "empaquetadoGroupBox";
            empaquetadoGroupBox.Size = new Size(1423, 397);
            empaquetadoGroupBox.TabIndex = 9;
            empaquetadoGroupBox.TabStop = false;
            empaquetadoGroupBox.Text = "Mercaderías a empaquetar";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(763, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 39);
            textBox1.TabIndex = 10;
            // 
            // cantidadBultosLabel
            // 
            cantidadBultosLabel.AutoSize = true;
            cantidadBultosLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidadBultosLabel.Location = new Point(536, 55);
            cantidadBultosLabel.Name = "cantidadBultosLabel";
            cantidadBultosLabel.Size = new Size(221, 32);
            cantidadBultosLabel.TabIndex = 9;
            cantidadBultosLabel.Text = "Cantidad de bultos:";
            // 
            // numeroOrdenEntregaLabel
            // 
            numeroOrdenEntregaLabel.AutoSize = true;
            numeroOrdenEntregaLabel.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numeroOrdenEntregaLabel.Location = new Point(22, 55);
            numeroOrdenEntregaLabel.Name = "numeroOrdenEntregaLabel";
            numeroOrdenEntregaLabel.Size = new Size(242, 32);
            numeroOrdenEntregaLabel.TabIndex = 8;
            numeroOrdenEntregaLabel.Text = "N° Orden de Entrega:";
            numeroOrdenEntregaLabel.Click += label1_Click;
            // 
            // numeroOeTextBox
            // 
            numeroOeTextBox.BackColor = SystemColors.ControlLight;
            numeroOeTextBox.Enabled = false;
            numeroOeTextBox.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numeroOeTextBox.ForeColor = SystemColors.ControlDarkDark;
            numeroOeTextBox.Location = new Point(260, 55);
            numeroOeTextBox.Name = "numeroOeTextBox";
            numeroOeTextBox.Size = new Size(225, 39);
            numeroOeTextBox.TabIndex = 7;
            // 
            // pickingPreparadoListView
            // 
            pickingPreparadoListView.BackColor = SystemColors.ControlLightLight;
            pickingPreparadoListView.Columns.AddRange(new ColumnHeader[] { pickingNumero, cuitClienteName, skuProductoName, productoName, cantidadName, fechaEnvio });
            pickingPreparadoListView.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pickingPreparadoListView.FullRowSelect = true;
            pickingPreparadoListView.GridLines = true;
            pickingPreparadoListView.LabelEdit = true;
            pickingPreparadoListView.Location = new Point(22, 116);
            pickingPreparadoListView.Name = "pickingPreparadoListView";
            pickingPreparadoListView.OwnerDraw = true;
            pickingPreparadoListView.Size = new Size(1375, 201);
            pickingPreparadoListView.TabIndex = 6;
            pickingPreparadoListView.UseCompatibleStateImageBehavior = false;
            pickingPreparadoListView.View = View.Details;
            // 
            // pickingNumero
            // 
            pickingNumero.Text = "N° O. Selección";
            pickingNumero.Width = 180;
            // 
            // cuitClienteName
            // 
            cuitClienteName.Text = "CUIT - Cliente";
            cuitClienteName.Width = 300;
            // 
            // skuProductoName
            // 
            skuProductoName.Text = "SKU";
            skuProductoName.Width = 160;
            // 
            // productoName
            // 
            productoName.Text = "Tipo de producto";
            productoName.Width = 225;
            // 
            // cantidadName
            // 
            cantidadName.Text = "Cantidad";
            cantidadName.Width = 125;
            // 
            // fechaEnvio
            // 
            fechaEnvio.Text = "Fecha de envío";
            fechaEnvio.Width = 180;
            // 
            // confirmarEmpaquetadoButton
            // 
            confirmarEmpaquetadoButton.BackColor = SystemColors.InactiveCaption;
            confirmarEmpaquetadoButton.Enabled = false;
            confirmarEmpaquetadoButton.ForeColor = SystemColors.ControlDark;
            confirmarEmpaquetadoButton.Location = new Point(1077, 327);
            confirmarEmpaquetadoButton.Margin = new Padding(6, 7, 6, 7);
            confirmarEmpaquetadoButton.Name = "confirmarEmpaquetadoButton";
            confirmarEmpaquetadoButton.Size = new Size(320, 67);
            confirmarEmpaquetadoButton.TabIndex = 3;
            confirmarEmpaquetadoButton.Text = "Confirmar empaquetado";
            confirmarEmpaquetadoButton.UseVisualStyleBackColor = false;
            // 
            // CargarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1478, 755);
            Controls.Add(empaquetadoGroupBox);
            Controls.Add(pickingEnPreparacionGroupBox);
            Margin = new Padding(6, 7, 6, 7);
            Name = "CargarOrdenDeEntregaForm";
            Text = "Generar - Órden de Entrega";
            pickingEnPreparacionGroupBox.ResumeLayout(false);
            empaquetadoGroupBox.ResumeLayout(false);
            empaquetadoGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        //private Label pickingEnPreparacionGroupBox;
        private Button agregarPickingButton;
        private ListView pickingEnPreparacionListView;
        private ColumnHeader idOrdenPicking;
        private ColumnHeader fechaDespachoOE;
        private ColumnHeader cuitCliente;
        private ColumnHeader skuProductoPicking;
        private ColumnHeader nombreProducto;
        private ColumnHeader productoCantidad;
        private ColumnHeader idUsuarioPicking;
        private ColumnHeader fechaEntrega;
        private Button borrarSelecciónButton;
        private GroupBox pickingEnPreparacionGroupBox;
        private GroupBox empaquetadoGroupBox;
        private ListView pickingPreparadoListView;
        private ColumnHeader pickingNumero;
        private ColumnHeader cuitClienteName;
        private ColumnHeader skuProductoName;
        private ColumnHeader productoName;
        private ColumnHeader cantidadName;
        private Button confirmarEmpaquetadoButton;
        private TextBox numeroOeTextBox;
        private Label numeroOrdenEntregaLabel;
        private Label cantidadBultosLabel;
        private TextBox textBox1;
        private ColumnHeader fechaEnvio;
    }
}