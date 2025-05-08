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
            ordenesPreparacionEntregaLabel = new Label();
            generarEntregaListView = new ListView();
            fechaColumna = new ColumnHeader();
            idOrdenColumna = new ColumnHeader();
            skuColumna = new ColumnHeader();
            cantidadColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            button1 = new Button();
            SuspendLayout();
            // 
            // ordenesPreparacionEntregaLabel
            // 
            ordenesPreparacionEntregaLabel.AutoSize = true;
            ordenesPreparacionEntregaLabel.Location = new Point(12, 9);
            ordenesPreparacionEntregaLabel.Name = "ordenesPreparacionEntregaLabel";
            ordenesPreparacionEntregaLabel.Size = new Size(133, 15);
            ordenesPreparacionEntregaLabel.TabIndex = 0;
            ordenesPreparacionEntregaLabel.Text = "Ordenes de preparacion";
            // 
            // generarEntregaListView
            // 
            generarEntregaListView.Columns.AddRange(new ColumnHeader[] { fechaColumna, idOrdenColumna, skuColumna, cantidadColumna, idClienteColumna });
            generarEntregaListView.FullRowSelect = true;
            generarEntregaListView.Location = new Point(12, 27);
            generarEntregaListView.Name = "generarEntregaListView";
            generarEntregaListView.Size = new Size(776, 175);
            generarEntregaListView.TabIndex = 2;
            generarEntregaListView.UseCompatibleStateImageBehavior = false;
            generarEntregaListView.View = View.Details;
            // 
            // fechaColumna
            // 
            fechaColumna.Text = "Fecha de despacho";
            fechaColumna.Width = 160;
            // 
            // idOrdenColumna
            // 
            idOrdenColumna.Text = "ID de Orden";
            idOrdenColumna.Width = 160;
            // 
            // skuColumna
            // 
            skuColumna.DisplayIndex = 3;
            skuColumna.Text = "SKU de producto";
            skuColumna.Width = 160;
            // 
            // cantidadColumna
            // 
            cantidadColumna.DisplayIndex = 4;
            cantidadColumna.Text = "Cantidad";
            cantidadColumna.Width = 160;
            // 
            // idClienteColumna
            // 
            idClienteColumna.DisplayIndex = 2;
            idClienteColumna.Text = "ID del Cliente";
            idClienteColumna.Width = 160;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(638, 208);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 3;
            button1.Text = "Cargar orden de entrega";
            button1.UseVisualStyleBackColor = true;
            // 
            // CargarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 239);
            Controls.Add(button1);
            Controls.Add(generarEntregaListView);
            Controls.Add(ordenesPreparacionEntregaLabel);
            Name = "CargarOrdenDeEntregaForm";
            Text = "Cargar orden de entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ordenesPreparacionEntregaLabel;
        private ListView generarEntregaListView;
        private ColumnHeader fechaColumna;
        private ColumnHeader idOrdenColumna;
        private ColumnHeader skuColumna;
        private ColumnHeader cantidadColumna;
        private ColumnHeader idClienteColumna;
        private Button button1;
    }
}