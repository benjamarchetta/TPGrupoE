namespace TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Forms
{
    partial class GestionarOrdenSeleccionForm
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
            ListViewItem listViewItem1 = new ListViewItem(new string[] { "XY-CCCDD", "TipoX", "150", "No", "XYZ" }, -1);
            ListViewItem listViewItem2 = new ListViewItem(new string[] { "2025/05/25", "XX" }, -1);
            ListViewItem listViewItem3 = new ListViewItem(new string[] { "2025/05/26", "XX" }, -1);
            label1 = new Label();
            seleccionarMercaderiaButton = new Button();
            confirmarSeleccionButton = new Button();
            verDetallesPreparacionListView = new ListView();
            skuColumna = new ColumnHeader();
            cantidadColumna = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            label2 = new Label();
            fechaRecepcioncolumnHeader2 = new ColumnHeader();
            idOrdenColumnHeader1 = new ColumnHeader();
            ordenesSeleccionPendientesListView = new ListView();
            cancelarSeleccionButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(180, 15);
            label1.TabIndex = 0;
            label1.Text = "Órdenes de selección pendientes";
            // 
            // seleccionarMercaderiaButton
            // 
            seleccionarMercaderiaButton.Enabled = false;
            seleccionarMercaderiaButton.Location = new Point(458, 173);
            seleccionarMercaderiaButton.Name = "seleccionarMercaderiaButton";
            seleccionarMercaderiaButton.Size = new Size(162, 23);
            seleccionarMercaderiaButton.TabIndex = 1;
            seleccionarMercaderiaButton.Text = "Seleccionar mercadería";
            seleccionarMercaderiaButton.UseVisualStyleBackColor = true;
            seleccionarMercaderiaButton.Click += VerDetallesButton_Click;
            // 
            // confirmarSeleccionButton
            // 
            confirmarSeleccionButton.Enabled = false;
            confirmarSeleccionButton.Location = new Point(626, 398);
            confirmarSeleccionButton.Name = "confirmarSeleccionButton";
            confirmarSeleccionButton.Size = new Size(162, 23);
            confirmarSeleccionButton.TabIndex = 2;
            confirmarSeleccionButton.Text = "Confirmar selección";
            confirmarSeleccionButton.UseVisualStyleBackColor = true;
            // 
            // verDetallesPreparacionListView
            // 
            verDetallesPreparacionListView.Columns.AddRange(new ColumnHeader[] { skuColumna, columnHeader2, cantidadColumna, columnHeader1, columnHeader3 });
            verDetallesPreparacionListView.FullRowSelect = true;
            verDetallesPreparacionListView.Items.AddRange(new ListViewItem[] { listViewItem1 });
            verDetallesPreparacionListView.Location = new Point(12, 217);
            verDetallesPreparacionListView.Name = "verDetallesPreparacionListView";
            verDetallesPreparacionListView.Size = new Size(776, 175);
            verDetallesPreparacionListView.TabIndex = 3;
            verDetallesPreparacionListView.UseCompatibleStateImageBehavior = false;
            verDetallesPreparacionListView.View = View.Details;
            verDetallesPreparacionListView.SelectedIndexChanged += verDetallesPreparacionListView_SelectedIndexChanged;
            // 
            // skuColumna
            // 
            skuColumna.Text = "SKU de producto";
            skuColumna.Width = 155;
            // 
            // cantidadColumna
            // 
            cantidadColumna.Text = "Cantidad";
            cantidadColumna.Width = 155;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Palet cerrado";
            columnHeader1.Width = 155;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tipo de producto";
            columnHeader2.Width = 155;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Posición";
            columnHeader3.Width = 155;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 199);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 4;
            label2.Text = "Detalle de mercadería a seleccionar";
            // 
            // fechaRecepcioncolumnHeader2
            // 
            fechaRecepcioncolumnHeader2.Text = "Fecha a despachar";
            fechaRecepcioncolumnHeader2.Width = 388;
            // 
            // idOrdenColumnHeader1
            // 
            idOrdenColumnHeader1.Text = "ID de Orden";
            idOrdenColumnHeader1.Width = 388;
            // 
            // ordenesSeleccionPendientesListView
            // 
            ordenesSeleccionPendientesListView.CheckBoxes = true;
            ordenesSeleccionPendientesListView.Columns.AddRange(new ColumnHeader[] { fechaRecepcioncolumnHeader2, idOrdenColumnHeader1 });
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            ordenesSeleccionPendientesListView.Items.AddRange(new ListViewItem[] { listViewItem2, listViewItem3 });
            ordenesSeleccionPendientesListView.Location = new Point(12, 27);
            ordenesSeleccionPendientesListView.MultiSelect = false;
            ordenesSeleccionPendientesListView.Name = "ordenesSeleccionPendientesListView";
            ordenesSeleccionPendientesListView.Size = new Size(776, 140);
            ordenesSeleccionPendientesListView.TabIndex = 0;
            ordenesSeleccionPendientesListView.UseCompatibleStateImageBehavior = false;
            ordenesSeleccionPendientesListView.View = View.Details;
            // 
            // cancelarSeleccionButton
            // 
            cancelarSeleccionButton.Enabled = false;
            cancelarSeleccionButton.Location = new Point(626, 173);
            cancelarSeleccionButton.Name = "cancelarSeleccionButton";
            cancelarSeleccionButton.Size = new Size(162, 23);
            cancelarSeleccionButton.TabIndex = 5;
            cancelarSeleccionButton.Text = "Cancelar selección";
            cancelarSeleccionButton.UseVisualStyleBackColor = true;
            // 
            // GestionarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 444);
            Controls.Add(cancelarSeleccionButton);
            Controls.Add(label2);
            Controls.Add(verDetallesPreparacionListView);
            Controls.Add(confirmarSeleccionButton);
            Controls.Add(seleccionarMercaderiaButton);
            Controls.Add(ordenesSeleccionPendientesListView);
            Controls.Add(label1);
            Name = "GestionarOrdenSeleccionForm";
            Text = "Gestionar órden de selección";
            Load += ConfirmarSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button seleccionarMercaderiaButton;
        private Button confirmarSeleccionButton;
        private ListView verDetallesPreparacionListView;
        private ColumnHeader skuColumna;
        private ColumnHeader cantidadColumna;
        private Label label2;
        private ColumnHeader columnHeader1;
        private ColumnHeader fechaRecepcioncolumnHeader2;
        private ColumnHeader idOrdenColumnHeader1;
        private ListView ordenesSeleccionPendientesListView;
        private Button cancelarSeleccionButton;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
    }
}