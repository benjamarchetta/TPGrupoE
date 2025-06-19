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
            confirmarSeleccionButton = new Button();
            detalleProductosListView = new ListView();
            label2 = new Label();
            ordenesListView = new ListView();
            cancelarSeleccionButton = new Button();
            VerDetallesButton = new Button();
            volverAlMenuButton = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // confirmarSeleccionButton
            // 
            confirmarSeleccionButton.BackColor = SystemColors.Highlight;
            confirmarSeleccionButton.Enabled = false;
            confirmarSeleccionButton.Location = new Point(411, 430);
            confirmarSeleccionButton.Name = "confirmarSeleccionButton";
            confirmarSeleccionButton.Size = new Size(376, 38);
            confirmarSeleccionButton.TabIndex = 2;
            confirmarSeleccionButton.Text = "Confirmar selección";
            confirmarSeleccionButton.UseVisualStyleBackColor = false;
            // 
            // detalleProductosListView
            // 
            detalleProductosListView.FullRowSelect = true;
            detalleProductosListView.Location = new Point(12, 232);
            detalleProductosListView.Name = "detalleProductosListView";
            detalleProductosListView.Size = new Size(776, 126);
            detalleProductosListView.TabIndex = 3;
            detalleProductosListView.UseCompatibleStateImageBehavior = false;
            detalleProductosListView.View = View.Details;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 214);
            label2.Name = "label2";
            label2.Size = new Size(192, 15);
            label2.TabIndex = 4;
            label2.Text = "Detalle de mercadería a seleccionar";
            // 
            // ordenesListView
            // 
            ordenesListView.CheckBoxes = true;
            ordenesListView.Location = new Point(1, 16);
            ordenesListView.MultiSelect = false;
            ordenesListView.Name = "ordenesListView";
            ordenesListView.Size = new Size(776, 140);
            ordenesListView.TabIndex = 0;
            ordenesListView.UseCompatibleStateImageBehavior = false;
            ordenesListView.View = View.Details;
            // 
            // cancelarSeleccionButton
            // 
            cancelarSeleccionButton.Enabled = false;
            cancelarSeleccionButton.Location = new Point(557, 363);
            cancelarSeleccionButton.Name = "cancelarSeleccionButton";
            cancelarSeleccionButton.Size = new Size(230, 30);
            cancelarSeleccionButton.TabIndex = 5;
            cancelarSeleccionButton.Text = "Cancelar selección";
            cancelarSeleccionButton.UseVisualStyleBackColor = true;
            // 
            // VerDetallesButton
            // 
            VerDetallesButton.Location = new Point(546, 161);
            VerDetallesButton.Name = "VerDetallesButton";
            VerDetallesButton.Size = new Size(230, 30);
            VerDetallesButton.TabIndex = 6;
            VerDetallesButton.Text = "Seleccionar mercadería";
            VerDetallesButton.UseVisualStyleBackColor = true;
            // 
            // volverAlMenuButton
            // 
            volverAlMenuButton.Location = new Point(12, 430);
            volverAlMenuButton.Name = "volverAlMenuButton";
            volverAlMenuButton.Size = new Size(376, 38);
            volverAlMenuButton.TabIndex = 7;
            volverAlMenuButton.Text = "Volver al menú principal";
            volverAlMenuButton.UseVisualStyleBackColor = true;
            volverAlMenuButton.Click += volverAlMenuButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(VerDetallesButton);
            groupBox1.Controls.Add(ordenesListView);
            groupBox1.Location = new Point(11, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(784, 196);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // GestionarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(groupBox1);
            Controls.Add(volverAlMenuButton);
            Controls.Add(cancelarSeleccionButton);
            Controls.Add(label2);
            Controls.Add(detalleProductosListView);
            Controls.Add(confirmarSeleccionButton);
            Name = "GestionarOrdenSeleccionForm";
            Text = "Gestionar órden de selección";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private GroupBox groupBox1;
    }
}