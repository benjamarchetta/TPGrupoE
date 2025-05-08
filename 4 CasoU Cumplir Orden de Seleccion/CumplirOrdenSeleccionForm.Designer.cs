namespace TPGrupoE.CasoU_Confirmar_Seleccion
{
    partial class CumplirOrdenSeleccionForm
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
            label1 = new Label();
            ordenesSeleccionPendientesListView = new ListView();
            fechaRecepcioncolumnHeader2 = new ColumnHeader();
            idOrdenColumnHeader1 = new ColumnHeader();
            VerDetallesButton = new Button();
            button2 = new Button();
            verDetallesPreparacionListView = new ListView();
            fechaColumna = new ColumnHeader();
            idOrdenColumna = new ColumnHeader();
            skuColumna = new ColumnHeader();
            cantidadColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 0;
            label1.Text = "Ordenes de seleccion pendientes";
            // 
            // ordenesSeleccionPendientesListView
            // 
            ordenesSeleccionPendientesListView.Columns.AddRange(new ColumnHeader[] { fechaRecepcioncolumnHeader2, idOrdenColumnHeader1 });
            ordenesSeleccionPendientesListView.Location = new Point(12, 27);
            ordenesSeleccionPendientesListView.MultiSelect = false;
            ordenesSeleccionPendientesListView.Name = "ordenesSeleccionPendientesListView";
            ordenesSeleccionPendientesListView.Size = new Size(776, 140);
            ordenesSeleccionPendientesListView.TabIndex = 0;
            ordenesSeleccionPendientesListView.UseCompatibleStateImageBehavior = false;
            ordenesSeleccionPendientesListView.View = View.Details;
            // 
            // fechaRecepcioncolumnHeader2
            // 
            fechaRecepcioncolumnHeader2.Text = "Fecha de carga";
            fechaRecepcioncolumnHeader2.Width = 388;
            // 
            // idOrdenColumnHeader1
            // 
            idOrdenColumnHeader1.Text = "ID de Orden";
            idOrdenColumnHeader1.Width = 388;
            // 
            // VerDetallesButton
            // 
            VerDetallesButton.Location = new Point(657, 173);
            VerDetallesButton.Name = "VerDetallesButton";
            VerDetallesButton.Size = new Size(131, 23);
            VerDetallesButton.TabIndex = 1;
            VerDetallesButton.Text = "Ver detalles de orden";
            VerDetallesButton.UseVisualStyleBackColor = true;
            VerDetallesButton.Click += VerDetallesButton_Click;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(489, 173);
            button2.Name = "button2";
            button2.Size = new Size(162, 23);
            button2.TabIndex = 2;
            button2.Text = "Cumplir orden de seleccion";
            button2.UseVisualStyleBackColor = true;
            // 
            // verDetallesPreparacionListView
            // 
            verDetallesPreparacionListView.Columns.AddRange(new ColumnHeader[] { fechaColumna, idOrdenColumna, skuColumna, cantidadColumna, idClienteColumna, columnHeader1 });
            verDetallesPreparacionListView.FullRowSelect = true;
            verDetallesPreparacionListView.Location = new Point(12, 217);
            verDetallesPreparacionListView.Name = "verDetallesPreparacionListView";
            verDetallesPreparacionListView.Size = new Size(776, 175);
            verDetallesPreparacionListView.TabIndex = 3;
            verDetallesPreparacionListView.UseCompatibleStateImageBehavior = false;
            verDetallesPreparacionListView.View = View.Details;
            verDetallesPreparacionListView.Visible = false;
            verDetallesPreparacionListView.SelectedIndexChanged += verDetallesPreparacionListView_SelectedIndexChanged;
            // 
            // fechaColumna
            // 
            fechaColumna.Text = "Fecha de despacho";
            fechaColumna.Width = 130;
            // 
            // idOrdenColumna
            // 
            idOrdenColumna.Text = "ID de Orden";
            idOrdenColumna.Width = 130;
            // 
            // skuColumna
            // 
            skuColumna.DisplayIndex = 3;
            skuColumna.Text = "SKU de producto";
            skuColumna.Width = 130;
            // 
            // cantidadColumna
            // 
            cantidadColumna.DisplayIndex = 4;
            cantidadColumna.Text = "Cantidad";
            cantidadColumna.Width = 130;
            // 
            // idClienteColumna
            // 
            idClienteColumna.DisplayIndex = 2;
            idClienteColumna.Text = "ID del Cliente";
            idClienteColumna.Width = 130;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Palet cerrado";
            columnHeader1.Width = 130;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 199);
            label2.Name = "label2";
            label2.Size = new Size(133, 15);
            label2.TabIndex = 4;
            label2.Text = "Ordenes de preparacion";
            // 
            // CumplirOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 202);
            Controls.Add(label2);
            Controls.Add(verDetallesPreparacionListView);
            Controls.Add(button2);
            Controls.Add(VerDetallesButton);
            Controls.Add(ordenesSeleccionPendientesListView);
            Controls.Add(label1);
            Name = "CumplirOrdenSeleccionForm";
            Text = "Cumplir orden de seleccion";
            Load += ConfirmarSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView ordenesSeleccionPendientesListView;
        private ColumnHeader fechaRecepcioncolumnHeader2;
        private ColumnHeader idOrdenColumnHeader1;
        private Button VerDetallesButton;
        private Button button2;
        private ListView verDetallesPreparacionListView;
        private ColumnHeader fechaColumna;
        private ColumnHeader idOrdenColumna;
        private ColumnHeader skuColumna;
        private ColumnHeader cantidadColumna;
        private ColumnHeader idClienteColumna;
        private Label label2;
        private ColumnHeader columnHeader1;
    }
}