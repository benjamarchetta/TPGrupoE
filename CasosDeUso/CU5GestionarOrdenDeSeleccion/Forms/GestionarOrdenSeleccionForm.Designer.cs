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
            label1 = new Label();
            confirmarSeleccionButton = new Button();
            detalleProductosListView = new ListView();
            label2 = new Label();
            ordenesListView = new ListView();
            cancelarSeleccionButton = new Button();
            VerDetallesButton = new Button();
            volverAlMenuButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(227, 20);
            label1.TabIndex = 0;
            label1.Text = "Órdenes de selección pendientes";
            // 
            // confirmarSeleccionButton
            // 
            confirmarSeleccionButton.BackColor = SystemColors.Highlight;
            confirmarSeleccionButton.Enabled = false;
            confirmarSeleccionButton.Location = new Point(470, 574);
            confirmarSeleccionButton.Margin = new Padding(3, 4, 3, 4);
            confirmarSeleccionButton.Name = "confirmarSeleccionButton";
            confirmarSeleccionButton.Size = new Size(430, 50);
            confirmarSeleccionButton.TabIndex = 2;
            confirmarSeleccionButton.Text = "Confirmar selección";
            confirmarSeleccionButton.UseVisualStyleBackColor = false;
            // 
            // detalleProductosListView
            // 
            detalleProductosListView.FullRowSelect = true;
            detalleProductosListView.Location = new Point(14, 309);
            detalleProductosListView.Margin = new Padding(3, 4, 3, 4);
            detalleProductosListView.Name = "detalleProductosListView";
            detalleProductosListView.Size = new Size(886, 167);
            detalleProductosListView.TabIndex = 3;
            detalleProductosListView.UseCompatibleStateImageBehavior = false;
            detalleProductosListView.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 285);
            label2.Name = "label2";
            label2.Size = new Size(247, 20);
            label2.TabIndex = 4;
            label2.Text = "Detalle de mercadería a seleccionar";
            // 
            // ordenesListView
            // 
            ordenesListView.CheckBoxes = true;
            ordenesListView.Location = new Point(14, 36);
            ordenesListView.Margin = new Padding(3, 4, 3, 4);
            ordenesListView.MultiSelect = false;
            ordenesListView.Name = "ordenesListView";
            ordenesListView.Size = new Size(886, 185);
            ordenesListView.TabIndex = 0;
            ordenesListView.UseCompatibleStateImageBehavior = false;
            ordenesListView.View = View.Details;
            // 
            // cancelarSeleccionButton
            // 
            cancelarSeleccionButton.Enabled = false;
            cancelarSeleccionButton.Location = new Point(637, 484);
            cancelarSeleccionButton.Margin = new Padding(3, 4, 3, 4);
            cancelarSeleccionButton.Name = "cancelarSeleccionButton";
            cancelarSeleccionButton.Size = new Size(263, 40);
            cancelarSeleccionButton.TabIndex = 5;
            cancelarSeleccionButton.Text = "Cancelar selección";
            cancelarSeleccionButton.UseVisualStyleBackColor = true;
            // 
            // VerDetallesButton
            // 
            VerDetallesButton.Location = new Point(637, 229);
            VerDetallesButton.Margin = new Padding(3, 4, 3, 4);
            VerDetallesButton.Name = "VerDetallesButton";
            VerDetallesButton.Size = new Size(263, 40);
            VerDetallesButton.TabIndex = 6;
            VerDetallesButton.Text = "Seleccionar mercadería";
            VerDetallesButton.UseVisualStyleBackColor = true;
            // 
            // volverAlMenuButton
            // 
            volverAlMenuButton.Location = new Point(14, 574);
            volverAlMenuButton.Margin = new Padding(3, 4, 3, 4);
            volverAlMenuButton.Name = "volverAlMenuButton";
            volverAlMenuButton.Size = new Size(430, 50);
            volverAlMenuButton.TabIndex = 7;
            volverAlMenuButton.Text = "Volver al menú principal";
            volverAlMenuButton.UseVisualStyleBackColor = true;
            volverAlMenuButton.Click += volverAlMenuButton_Click;
            // 
            // GestionarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 649);
            Controls.Add(volverAlMenuButton);
            Controls.Add(VerDetallesButton);
            Controls.Add(cancelarSeleccionButton);
            Controls.Add(label2);
            Controls.Add(detalleProductosListView);
            Controls.Add(confirmarSeleccionButton);
            Controls.Add(ordenesListView);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionarOrdenSeleccionForm";
            Text = "Gestionar órden de selección";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button confirmarSeleccionButton;
        private ListView detalleProductosListView;
        private ColumnHeader skuColumna;
        private ColumnHeader cantidadColumna;
        private Label label2;
        private ColumnHeader columnHeader1;
        private ListView ordenesListView;
        private Button cancelarSeleccionButton;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button VerDetallesButton;
        private Button volverAlMenuButton;
    }
}