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
            ordenesListView = new ListView();
            cancelarSeleccionButton = new Button();
            VerDetallesButton = new Button();
            volverAlMenuButton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // confirmarSeleccionButton
            // 
            confirmarSeleccionButton.BackColor = SystemColors.Highlight;
            confirmarSeleccionButton.Enabled = false;
            confirmarSeleccionButton.Location = new Point(419, 430);
            confirmarSeleccionButton.Name = "confirmarSeleccionButton";
            confirmarSeleccionButton.Size = new Size(376, 38);
            confirmarSeleccionButton.TabIndex = 2;
            confirmarSeleccionButton.Text = "Confirmar selección";
            confirmarSeleccionButton.UseVisualStyleBackColor = false;
            // 
            // detalleProductosListView
            // 
            detalleProductosListView.Font = new Font("Segoe UI", 9F);
            detalleProductosListView.FullRowSelect = true;
            detalleProductosListView.Location = new Point(6, 22);
            detalleProductosListView.Name = "detalleProductosListView";
            detalleProductosListView.Size = new Size(769, 126);
            detalleProductosListView.TabIndex = 3;
            detalleProductosListView.UseCompatibleStateImageBehavior = false;
            detalleProductosListView.View = View.Details;
            // 
            // ordenesListView
            // 
            ordenesListView.CheckBoxes = true;
            ordenesListView.Font = new Font("Segoe UI", 9F);
            ordenesListView.Location = new Point(6, 28);
            ordenesListView.MultiSelect = false;
            ordenesListView.Name = "ordenesListView";
            ordenesListView.Size = new Size(769, 129);
            ordenesListView.TabIndex = 0;
            ordenesListView.UseCompatibleStateImageBehavior = false;
            ordenesListView.View = View.Details;
            // 
            // cancelarSeleccionButton
            // 
            cancelarSeleccionButton.BackColor = SystemColors.GradientActiveCaption;
            cancelarSeleccionButton.Enabled = false;
            cancelarSeleccionButton.FlatAppearance.BorderColor = Color.Gray;
            cancelarSeleccionButton.FlatStyle = FlatStyle.Flat;
            cancelarSeleccionButton.Font = new Font("Segoe UI", 9F);
            cancelarSeleccionButton.Location = new Point(545, 154);
            cancelarSeleccionButton.Name = "cancelarSeleccionButton";
            cancelarSeleccionButton.Size = new Size(230, 30);
            cancelarSeleccionButton.TabIndex = 5;
            cancelarSeleccionButton.Text = "Cancelar selección";
            cancelarSeleccionButton.UseVisualStyleBackColor = false;
            // 
            // VerDetallesButton
            // 
            VerDetallesButton.BackColor = SystemColors.GradientActiveCaption;
            VerDetallesButton.FlatAppearance.BorderColor = Color.Gray;
            VerDetallesButton.FlatStyle = FlatStyle.Flat;
            VerDetallesButton.Font = new Font("Segoe UI", 9F);
            VerDetallesButton.Location = new Point(545, 163);
            VerDetallesButton.Name = "VerDetallesButton";
            VerDetallesButton.Size = new Size(230, 30);
            VerDetallesButton.TabIndex = 6;
            VerDetallesButton.Text = "Seleccionar mercadería";
            VerDetallesButton.UseVisualStyleBackColor = false;
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
            groupBox1.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(783, 199);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes de seleccion pendientes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cancelarSeleccionButton);
            groupBox2.Controls.Add(detalleProductosListView);
            groupBox2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 230);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(783, 198);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalle mercaderia a seleccionar";
            // 
            // GestionarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 487);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(volverAlMenuButton);
            Controls.Add(confirmarSeleccionButton);
            Name = "GestionarOrdenSeleccionForm";
            Text = "Gestionar órden de selección";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button confirmarSeleccionButton;
        private ListView detalleProductosListView;
        private ColumnHeader skuColumna;
        private ColumnHeader cantidadColumna;
        private ColumnHeader columnHeader1;
        private ListView ordenesListView;
        private Button cancelarSeleccionButton;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Button VerDetallesButton;
        private Button volverAlMenuButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}