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
            TransportistasCombobox = new ComboBox();
            label2 = new Label();
            SeleccionarTransportistaButton = new Button();
            label3 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            OrdenesADespacharListView = new ListView();
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
            // TransportistasCombobox
            // 
            TransportistasCombobox.DropDownHeight = 150;
            TransportistasCombobox.FormattingEnabled = true;
            TransportistasCombobox.IntegralHeight = false;
            TransportistasCombobox.Items.AddRange(new object[] { "DNI 39456294", "DNI 65320644", "DNI 21245675", "DNI 95435677" });
            TransportistasCombobox.Location = new Point(12, 27);
            TransportistasCombobox.Name = "TransportistasCombobox";
            TransportistasCombobox.Size = new Size(233, 23);
            TransportistasCombobox.TabIndex = 9;
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
            label3.Click += label3_Click;
            // 
            // comboBox1
            // 
            comboBox1.DropDownHeight = 150;
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Items.AddRange(new object[] { "DNI 39456294", "DNI 65320644", "DNI 21245675", "DNI 95435677" });
            comboBox1.Location = new Point(12, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(233, 23);
            comboBox1.TabIndex = 13;
            // 
            // button1
            // 
            button1.Location = new Point(206, 414);
            button1.Name = "button1";
            button1.Size = new Size(213, 23);
            button1.TabIndex = 14;
            button1.Text = "Despachar y Emitir Remito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // OrdenesADespacharListView
            // 
            OrdenesADespacharListView.Columns.AddRange(new ColumnHeader[] { IdOrden, FechaEntrega });
            OrdenesADespacharListView.Location = new Point(12, 143);
            OrdenesADespacharListView.Name = "OrdenesADespacharListView";
            OrdenesADespacharListView.Size = new Size(407, 248);
            OrdenesADespacharListView.TabIndex = 15;
            OrdenesADespacharListView.UseCompatibleStateImageBehavior = false;
            OrdenesADespacharListView.View = View.Details;
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
            Controls.Add(OrdenesADespacharListView);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(SeleccionarTransportistaButton);
            Controls.Add(label2);
            Controls.Add(TransportistasCombobox);
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
        private ComboBox TransportistasCombobox;
        private Label label2;
        private Button SeleccionarTransportistaButton;
        private Label label3;
        private ComboBox comboBox1;
        private Button button1;
        private ListView OrdenesADespacharListView;
        private ColumnHeader IdOrden;
        private ColumnHeader FechaEntrega;
    }
}