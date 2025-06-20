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
            OSPendientesGroupBox = new GroupBox();
            DetalleMercaderiasGroupBox = new GroupBox();
            GestionarOSPanel = new Panel();
            OSPendientesGroupBox.SuspendLayout();
            DetalleMercaderiasGroupBox.SuspendLayout();
            GestionarOSPanel.SuspendLayout();
            SuspendLayout();
            // 
            // confirmarSeleccionButton
            // 
            confirmarSeleccionButton.BackColor = SystemColors.Highlight;
            confirmarSeleccionButton.Enabled = false;
            confirmarSeleccionButton.Location = new Point(479, 573);
            confirmarSeleccionButton.Margin = new Padding(3, 4, 3, 4);
            confirmarSeleccionButton.Name = "confirmarSeleccionButton";
            confirmarSeleccionButton.Size = new Size(430, 51);
            confirmarSeleccionButton.TabIndex = 2;
            confirmarSeleccionButton.Text = "Confirmar selección";
            confirmarSeleccionButton.UseVisualStyleBackColor = false;
            // 
            // detalleProductosListView
            // 
            detalleProductosListView.Font = new Font("Segoe UI", 9F);
            detalleProductosListView.FullRowSelect = true;
            detalleProductosListView.Location = new Point(7, 29);
            detalleProductosListView.Margin = new Padding(3, 4, 3, 4);
            detalleProductosListView.Name = "detalleProductosListView";
            detalleProductosListView.Size = new Size(878, 167);
            detalleProductosListView.TabIndex = 3;
            detalleProductosListView.UseCompatibleStateImageBehavior = false;
            detalleProductosListView.View = View.Details;
            // 
            // ordenesListView
            // 
            ordenesListView.CheckBoxes = true;
            ordenesListView.Font = new Font("Segoe UI", 9F);
            ordenesListView.Location = new Point(7, 37);
            ordenesListView.Margin = new Padding(3, 4, 3, 4);
            ordenesListView.MultiSelect = false;
            ordenesListView.Name = "ordenesListView";
            ordenesListView.Size = new Size(878, 171);
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
            cancelarSeleccionButton.Location = new Point(623, 205);
            cancelarSeleccionButton.Margin = new Padding(3, 4, 3, 4);
            cancelarSeleccionButton.Name = "cancelarSeleccionButton";
            cancelarSeleccionButton.Size = new Size(263, 40);
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
            VerDetallesButton.Location = new Point(623, 217);
            VerDetallesButton.Margin = new Padding(3, 4, 3, 4);
            VerDetallesButton.Name = "VerDetallesButton";
            VerDetallesButton.Size = new Size(263, 40);
            VerDetallesButton.TabIndex = 6;
            VerDetallesButton.Text = "Seleccionar mercadería";
            VerDetallesButton.UseVisualStyleBackColor = false;
            // 
            // volverAlMenuButton
            // 
            volverAlMenuButton.Location = new Point(14, 573);
            volverAlMenuButton.Margin = new Padding(3, 4, 3, 4);
            volverAlMenuButton.Name = "volverAlMenuButton";
            volverAlMenuButton.Size = new Size(430, 51);
            volverAlMenuButton.TabIndex = 7;
            volverAlMenuButton.Text = "Volver al menú principal";
            volverAlMenuButton.UseVisualStyleBackColor = true;
            volverAlMenuButton.Click += volverAlMenuButton_Click;
            // 
            // OSPendientesGroupBox
            // 
            OSPendientesGroupBox.Controls.Add(VerDetallesButton);
            OSPendientesGroupBox.Controls.Add(ordenesListView);
            OSPendientesGroupBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            OSPendientesGroupBox.Location = new Point(14, 16);
            OSPendientesGroupBox.Margin = new Padding(3, 4, 3, 4);
            OSPendientesGroupBox.Name = "OSPendientesGroupBox";
            OSPendientesGroupBox.Padding = new Padding(3, 4, 3, 4);
            OSPendientesGroupBox.Size = new Size(895, 265);
            OSPendientesGroupBox.TabIndex = 8;
            OSPendientesGroupBox.TabStop = false;
            OSPendientesGroupBox.Text = "Ordenes de seleccion pendientes";
            // 
            // DetalleMercaderiasGroupBox
            // 
            DetalleMercaderiasGroupBox.Controls.Add(cancelarSeleccionButton);
            DetalleMercaderiasGroupBox.Controls.Add(detalleProductosListView);
            DetalleMercaderiasGroupBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            DetalleMercaderiasGroupBox.Location = new Point(14, 307);
            DetalleMercaderiasGroupBox.Margin = new Padding(3, 4, 3, 4);
            DetalleMercaderiasGroupBox.Name = "DetalleMercaderiasGroupBox";
            DetalleMercaderiasGroupBox.Padding = new Padding(3, 4, 3, 4);
            DetalleMercaderiasGroupBox.Size = new Size(895, 264);
            DetalleMercaderiasGroupBox.TabIndex = 9;
            DetalleMercaderiasGroupBox.TabStop = false;
            DetalleMercaderiasGroupBox.Text = "Detalle mercaderia a seleccionar";
            // 
            // GestionarOSPanel
            // 
            GestionarOSPanel.Controls.Add(confirmarSeleccionButton);
            GestionarOSPanel.Controls.Add(OSPendientesGroupBox);
            GestionarOSPanel.Controls.Add(volverAlMenuButton);
            GestionarOSPanel.Controls.Add(DetalleMercaderiasGroupBox);
            GestionarOSPanel.Location = new Point(4, -1);
            GestionarOSPanel.Name = "GestionarOSPanel";
            GestionarOSPanel.Size = new Size(909, 648);
            GestionarOSPanel.TabIndex = 10;
            // 
            // GestionarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 649);
            Controls.Add(GestionarOSPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionarOrdenSeleccionForm";
            Text = "Gestionar órden de selección";
            FormClosing += GestionarOrdenSeleccionForm_FormClosing;
            OSPendientesGroupBox.ResumeLayout(false);
            DetalleMercaderiasGroupBox.ResumeLayout(false);
            GestionarOSPanel.ResumeLayout(false);
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
        private GroupBox OSPendientesGroupBox;
        private GroupBox DetalleMercaderiasGroupBox;
        private Panel GestionarOSPanel;
    }
}