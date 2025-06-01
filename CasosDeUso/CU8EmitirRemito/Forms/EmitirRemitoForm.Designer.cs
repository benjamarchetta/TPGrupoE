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
            mercaderiasADespacharListView = new ListView();
            fechaColumna = new ColumnHeader();
            idOrdenColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            cantidadColumna = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            borrarSeleccionButton = new Button();
            label1 = new Label();
            agregarButton = new Button();
            despacharButton = new Button();
            ordenesPreparadasListView = new ListView();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            columnHeader13 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // ordenesPreparacionEntregaLabel
            // 
            ordenesPreparacionEntregaLabel.AutoSize = true;
            ordenesPreparacionEntregaLabel.Location = new Point(12, 9);
            ordenesPreparacionEntregaLabel.Name = "ordenesPreparacionEntregaLabel";
            ordenesPreparacionEntregaLabel.Size = new Size(194, 15);
            ordenesPreparacionEntregaLabel.TabIndex = 0;
            ordenesPreparacionEntregaLabel.Text = "Ordenes de preparación preparadas";
            // 
            // mercaderiasADespacharListView
            // 
            mercaderiasADespacharListView.Columns.AddRange(new ColumnHeader[] { columnHeader7, fechaColumna, idOrdenColumna, idClienteColumna, columnHeader3, columnHeader6, cantidadColumna });
            mercaderiasADespacharListView.FullRowSelect = true;
            mercaderiasADespacharListView.Location = new Point(12, 234);
            mercaderiasADespacharListView.Name = "mercaderiasADespacharListView";
            mercaderiasADespacharListView.Size = new Size(892, 155);
            mercaderiasADespacharListView.TabIndex = 2;
            mercaderiasADespacharListView.UseCompatibleStateImageBehavior = false;
            mercaderiasADespacharListView.View = View.Details;
            // 
            // fechaColumna
            // 
            fechaColumna.Text = "Fecha de despacho";
            fechaColumna.Width = 150;
            // 
            // idOrdenColumna
            // 
            idOrdenColumna.Text = "ID de Orden";
            idOrdenColumna.Width = 150;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "CUIT cliente";
            idClienteColumna.Width = 150;
            // 
            // columnHeader6
            // 
            columnHeader6.DisplayIndex = 4;
            columnHeader6.Text = "Razón social";
            columnHeader6.Width = 150;
            // 
            // cantidadColumna
            // 
            cantidadColumna.DisplayIndex = 5;
            cantidadColumna.Text = "Cantidad de bultos";
            cantidadColumna.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Destino";
            columnHeader7.Width = 150;
            // 
            // borrarSeleccionButton
            // 
            borrarSeleccionButton.Enabled = false;
            borrarSeleccionButton.Location = new Point(754, 188);
            borrarSeleccionButton.Name = "borrarSeleccionButton";
            borrarSeleccionButton.Size = new Size(150, 23);
            borrarSeleccionButton.TabIndex = 3;
            borrarSeleccionButton.Text = "Borrar selección";
            borrarSeleccionButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 216);
            label1.Name = "label1";
            label1.Size = new Size(137, 15);
            label1.TabIndex = 5;
            label1.Text = "Mercaderías a despachar";
            // 
            // agregarButton
            // 
            agregarButton.Enabled = false;
            agregarButton.Location = new Point(598, 188);
            agregarButton.Name = "agregarButton";
            agregarButton.Size = new Size(150, 23);
            agregarButton.TabIndex = 6;
            agregarButton.Text = "Agregar";
            agregarButton.UseVisualStyleBackColor = true;
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
            // ordenesPreparadasListView
            // 
            ordenesPreparadasListView.Columns.AddRange(new ColumnHeader[] { columnHeader8, columnHeader9, columnHeader10, columnHeader11, columnHeader12, columnHeader13, columnHeader2, columnHeader1 });
            ordenesPreparadasListView.FullRowSelect = true;
            ordenesPreparadasListView.Location = new Point(12, 27);
            ordenesPreparadasListView.Name = "ordenesPreparadasListView";
            ordenesPreparadasListView.Size = new Size(892, 155);
            ordenesPreparadasListView.TabIndex = 8;
            ordenesPreparadasListView.UseCompatibleStateImageBehavior = false;
            ordenesPreparadasListView.View = View.Details;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Fecha de despacho";
            columnHeader8.Width = 115;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "ID de Orden";
            columnHeader9.Width = 85;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "CUIT cliente";
            columnHeader10.Width = 115;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Razón social";
            columnHeader11.Width = 115;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "SKU de producto";
            columnHeader12.Width = 115;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Tipo de producto";
            columnHeader13.Width = 115;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Pallet cerrado";
            columnHeader2.Width = 115;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Cantidad";
            columnHeader1.Width = 115;
            // 
            // columnHeader3
            // 
            columnHeader3.DisplayIndex = 6;
            columnHeader3.Text = "ColumnPrueba";
            // 
            // EmitirRemitoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 426);
            Controls.Add(ordenesPreparadasListView);
            Controls.Add(despacharButton);
            Controls.Add(agregarButton);
            Controls.Add(label1);
            Controls.Add(borrarSeleccionButton);
            Controls.Add(mercaderiasADespacharListView);
            Controls.Add(ordenesPreparacionEntregaLabel);
            Name = "EmitirRemitoForm";
            Text = "Emitir remito";
            Load += EmitirRemitoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ordenesPreparacionEntregaLabel;
        private ListView mercaderiasADespacharListView;
        private ColumnHeader fechaColumna;
        private ColumnHeader idOrdenColumna;
        private ColumnHeader cantidadColumna;
        private ColumnHeader idClienteColumna;
        private Button borrarSeleccionButton;
        private Label label1;
        private Button agregarButton;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private Button despacharButton;
        private ListView ordenesPreparadasListView;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
    }
}