namespace TPGrupoE.CasoU_Generar_Orden_de_Entrega
{
    partial class EmitirRemitoForm
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
            ordenesPreparacionEntregaLabel = new Label();
            despacharButton = new Button();
            comboBoxTransportistas = new ComboBox();
            label2 = new Label();
            SeleccionarTransportistaButton = new Button();
            label3 = new Label();
            comboBoxClientes = new ComboBox();
            button1 = new Button();
            ListViewOrdenesADespachar = new ListView();
            IdOrden = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            SuspendLayout();
            // 
            // ordenesPreparacionEntregaLabel
            // 
            ordenesPreparacionEntregaLabel.AutoSize = true;
            ordenesPreparacionEntregaLabel.Location = new Point(12, 125);
            ordenesPreparacionEntregaLabel.Name = "ordenesPreparacionEntregaLabel";
            ordenesPreparacionEntregaLabel.Size = new Size(199, 15);
            ordenesPreparacionEntregaLabel.TabIndex = 0;
            ordenesPreparacionEntregaLabel.Text = "Ordenes de preparación a despachar";
            // 
            // despacharButton
            // 
            despacharButton.Enabled = false;
            despacharButton.Location = new Point(754, 395);
            despacharButton.Name = "despacharButton";
            despacharButton.Size = new Size(150, 23);
            despacharButton.TabIndex = 7;
            despacharButton.Text = "Despachar";
            despacharButton.UseVisualStyleBackColor = true;
            // 
            // comboBoxTransportistas
            // 
            comboBoxTransportistas.DropDownHeight = 150;
            comboBoxTransportistas.FormattingEnabled = true;
            comboBoxTransportistas.IntegralHeight = false;
            comboBoxTransportistas.Items.AddRange(new object[] { "DNI 39456294", "DNI 65320644", "DNI 21245675", "DNI 95435677" });
            comboBoxTransportistas.Location = new Point(12, 27);
            comboBoxTransportistas.Name = "comboBoxTransportistas";
            comboBoxTransportistas.Size = new Size(233, 23);
            comboBoxTransportistas.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(219, 15);
            label2.TabIndex = 10;
            label2.Text = "Transportistas con Ordenes a Despachar:";
            // 
            // SeleccionarTransportistaButton
            // 
            SeleccionarTransportistaButton.Location = new Point(293, 80);
            SeleccionarTransportistaButton.Name = "SeleccionarTransportistaButton";
            SeleccionarTransportistaButton.Size = new Size(126, 23);
            SeleccionarTransportistaButton.TabIndex = 11;
            SeleccionarTransportistaButton.Text = "Seleccionar";
            SeleccionarTransportistaButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 12;
            label3.Text = "Cliente";
           
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.DropDownHeight = 150;
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.IntegralHeight = false;
            comboBoxClientes.Items.AddRange(new object[] { "DNI 39456294", "DNI 65320644", "DNI 21245675", "DNI 95435677" });
            comboBoxClientes.Location = new Point(12, 80);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(233, 23);
            comboBoxClientes.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(206, 414);
            button1.Name = "button1";
            button1.Size = new Size(213, 23);
            button1.TabIndex = 14;
            button1.Text = "Despachar y Emitir Remito";
            button1.UseVisualStyleBackColor = true;
           
            // 
            // ListViewOrdenesADespachar
            // 
            ListViewOrdenesADespachar.Columns.AddRange(new ColumnHeader[] { IdOrden, FechaEntrega });
            ListViewOrdenesADespachar.Location = new Point(12, 143);
            ListViewOrdenesADespachar.Name = "ListViewOrdenesADespachar";
            ListViewOrdenesADespachar.Size = new Size(407, 248);
            ListViewOrdenesADespachar.TabIndex = 15;
            ListViewOrdenesADespachar.UseCompatibleStateImageBehavior = false;
            ListViewOrdenesADespachar.View = View.Details;
            // 
            // IdOrden
            // 
            IdOrden.Text = "ID Orden Preparación";
            IdOrden.Width = 190;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 150;
            // 
            // EmitirRemitoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(431, 449);
            Controls.Add(ListViewOrdenesADespachar);
            Controls.Add(button1);
            Controls.Add(comboBoxClientes);
            Controls.Add(label3);
            Controls.Add(SeleccionarTransportistaButton);
            Controls.Add(label2);
            Controls.Add(comboBoxTransportistas);
            Controls.Add(despacharButton);
            Controls.Add(ordenesPreparacionEntregaLabel);
            Name = "EmitirRemitoForm";
            Text = "Emitir remito";
            Load += EmitirRemitoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ordenesPreparacionEntregaLabel;
        private Button despacharButton;
        private ComboBox comboBoxTransportistas;
        private Label label2;
        private Button SeleccionarTransportistaButton;
        private Label label3;
        private ComboBox comboBoxClientes;
        private Button button1;
        private ListView ListViewOrdenesADespachar;
        private ColumnHeader IdOrden;
        private ColumnHeader FechaEntrega;
    }
}