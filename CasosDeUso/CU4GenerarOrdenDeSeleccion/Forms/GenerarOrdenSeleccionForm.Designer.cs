namespace TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Forms
{
    partial class GenerarOrdenSeleccionForm
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
            ordenesPendientesListView = new ListView();
            fechaColumna = new ColumnHeader();
            idOrdenColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            agregarAOrdenButton = new Button();
            generarOrdenButton = new Button();
            eliminarDeSeleccionButton = new Button();
            mercaderiasAPrepList = new ListView();
            FechaEntregaAPreparar = new ColumnHeader();
            IdOrdenPreparacionAPreparar = new ColumnHeader();
            RazonSocialClienteAPreparar = new ColumnHeader();
            CuitClienteAPreparar = new ColumnHeader();
            ProductoAPreparar = new ColumnHeader();
            CantidadAPreparar = new ColumnHeader();
            menubutton = new Button();
            OrdenesPendientesGroupBox = new GroupBox();
            MercaderiasAPrepararGroupBox = new GroupBox();
            GenerarOSPanel = new Panel();
            OrdenesPendientesGroupBox.SuspendLayout();
            MercaderiasAPrepararGroupBox.SuspendLayout();
            GenerarOSPanel.SuspendLayout();
            SuspendLayout();
            // 
            // ordenesPendientesListView
            // 
            ordenesPendientesListView.Columns.AddRange(new ColumnHeader[] { fechaColumna, idOrdenColumna, idClienteColumna, columnHeader3, Producto, Cantidad });
            ordenesPendientesListView.Font = new Font("Segoe UI", 9F);
            ordenesPendientesListView.FullRowSelect = true;
            ordenesPendientesListView.Location = new Point(9, 35);
            ordenesPendientesListView.Margin = new Padding(3, 4, 3, 4);
            ordenesPendientesListView.Name = "ordenesPendientesListView";
            ordenesPendientesListView.Size = new Size(884, 213);
            ordenesPendientesListView.TabIndex = 1;
            ordenesPendientesListView.UseCompatibleStateImageBehavior = false;
            ordenesPendientesListView.View = View.Details;
            ordenesPendientesListView.Click += ordenesPendientesListView_Click;
            // 
            // fechaColumna
            // 
            fechaColumna.Text = "Fecha de entrega";
            fechaColumna.Width = 129;
            // 
            // idOrdenColumna
            // 
            idOrdenColumna.Text = "N° O. Preparación";
            idOrdenColumna.Width = 129;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "Razón social";
            idClienteColumna.Width = 129;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CUIT Cliente";
            columnHeader3.Width = 129;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 129;
            // 
            // Cantidad
            // 
            Cantidad.Text = "Cantidad";
            Cantidad.Width = 129;
            // 
            // agregarAOrdenButton
            // 
            agregarAOrdenButton.BackColor = SystemColors.GradientActiveCaption;
            agregarAOrdenButton.FlatAppearance.BorderColor = Color.DarkGray;
            agregarAOrdenButton.FlatStyle = FlatStyle.Flat;
            agregarAOrdenButton.Font = new Font("Segoe UI", 9F);
            agregarAOrdenButton.Location = new Point(606, 257);
            agregarAOrdenButton.Margin = new Padding(3, 4, 3, 4);
            agregarAOrdenButton.Name = "agregarAOrdenButton";
            agregarAOrdenButton.Size = new Size(287, 40);
            agregarAOrdenButton.TabIndex = 2;
            agregarAOrdenButton.Text = "Agregar a orden de selección";
            agregarAOrdenButton.UseVisualStyleBackColor = false;
            agregarAOrdenButton.Click += agregarAOrdenButton_Click;
            // 
            // generarOrdenButton
            // 
            generarOrdenButton.BackColor = SystemColors.Highlight;
            generarOrdenButton.Enabled = false;
            generarOrdenButton.FlatAppearance.BorderColor = Color.Gray;
            generarOrdenButton.FlatStyle = FlatStyle.Flat;
            generarOrdenButton.Location = new Point(467, 668);
            generarOrdenButton.Margin = new Padding(3, 4, 3, 4);
            generarOrdenButton.Name = "generarOrdenButton";
            generarOrdenButton.Size = new Size(450, 51);
            generarOrdenButton.TabIndex = 4;
            generarOrdenButton.Text = "Generar órden de selección";
            generarOrdenButton.UseVisualStyleBackColor = false;
            generarOrdenButton.Click += generarOrdenButton_Click;
            // 
            // eliminarDeSeleccionButton
            // 
            eliminarDeSeleccionButton.BackColor = SystemColors.GradientActiveCaption;
            eliminarDeSeleccionButton.Enabled = false;
            eliminarDeSeleccionButton.FlatAppearance.BorderColor = Color.Gray;
            eliminarDeSeleccionButton.FlatStyle = FlatStyle.Flat;
            eliminarDeSeleccionButton.Font = new Font("Segoe UI", 9F);
            eliminarDeSeleccionButton.Location = new Point(606, 268);
            eliminarDeSeleccionButton.Margin = new Padding(3, 4, 3, 4);
            eliminarDeSeleccionButton.Name = "eliminarDeSeleccionButton";
            eliminarDeSeleccionButton.Size = new Size(287, 40);
            eliminarDeSeleccionButton.TabIndex = 6;
            eliminarDeSeleccionButton.Text = "Eliminar de orden de selección";
            eliminarDeSeleccionButton.UseVisualStyleBackColor = false;
            eliminarDeSeleccionButton.Click += eliminarDeSeleccionButton_Click;
            // 
            // mercaderiasAPrepList
            // 
            mercaderiasAPrepList.Columns.AddRange(new ColumnHeader[] { FechaEntregaAPreparar, IdOrdenPreparacionAPreparar, RazonSocialClienteAPreparar, CuitClienteAPreparar, ProductoAPreparar, CantidadAPreparar });
            mercaderiasAPrepList.Font = new Font("Segoe UI", 9F);
            mercaderiasAPrepList.FullRowSelect = true;
            mercaderiasAPrepList.Location = new Point(9, 35);
            mercaderiasAPrepList.Margin = new Padding(3, 4, 3, 4);
            mercaderiasAPrepList.Name = "mercaderiasAPrepList";
            mercaderiasAPrepList.Size = new Size(884, 225);
            mercaderiasAPrepList.TabIndex = 9;
            mercaderiasAPrepList.UseCompatibleStateImageBehavior = false;
            mercaderiasAPrepList.View = View.Details;
            mercaderiasAPrepList.Click += mercaderiasAPrepList_Click;
            // 
            // FechaEntregaAPreparar
            // 
            FechaEntregaAPreparar.Text = "Fecha de entrega";
            FechaEntregaAPreparar.Width = 129;
            // 
            // IdOrdenPreparacionAPreparar
            // 
            IdOrdenPreparacionAPreparar.Text = "N° O. Preparación";
            IdOrdenPreparacionAPreparar.Width = 129;
            // 
            // RazonSocialClienteAPreparar
            // 
            RazonSocialClienteAPreparar.Text = "Razón social";
            RazonSocialClienteAPreparar.Width = 129;
            // 
            // CuitClienteAPreparar
            // 
            CuitClienteAPreparar.Text = "CUIT Cliente";
            CuitClienteAPreparar.Width = 129;
            // 
            // ProductoAPreparar
            // 
            ProductoAPreparar.Text = "Producto";
            ProductoAPreparar.Width = 129;
            // 
            // CantidadAPreparar
            // 
            CantidadAPreparar.Text = "Cantidad";
            CantidadAPreparar.Width = 129;
            // 
            // menubutton
            // 
            menubutton.BackColor = Color.Silver;
            menubutton.FlatAppearance.BorderColor = Color.Gray;
            menubutton.FlatStyle = FlatStyle.Flat;
            menubutton.Location = new Point(14, 668);
            menubutton.Margin = new Padding(3, 4, 3, 4);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(450, 51);
            menubutton.TabIndex = 10;
            menubutton.Text = "Volver al Menu Principal";
            menubutton.UseVisualStyleBackColor = false;
            menubutton.Click += menubutton_Click;
            // 
            // OrdenesPendientesGroupBox
            // 
            OrdenesPendientesGroupBox.AccessibleRole = AccessibleRole.OutlineButton;
            OrdenesPendientesGroupBox.Controls.Add(agregarAOrdenButton);
            OrdenesPendientesGroupBox.Controls.Add(ordenesPendientesListView);
            OrdenesPendientesGroupBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            OrdenesPendientesGroupBox.Location = new Point(14, 20);
            OrdenesPendientesGroupBox.Margin = new Padding(3, 4, 3, 4);
            OrdenesPendientesGroupBox.Name = "OrdenesPendientesGroupBox";
            OrdenesPendientesGroupBox.Padding = new Padding(3, 4, 3, 4);
            OrdenesPendientesGroupBox.Size = new Size(903, 309);
            OrdenesPendientesGroupBox.TabIndex = 11;
            OrdenesPendientesGroupBox.TabStop = false;
            OrdenesPendientesGroupBox.Text = "Ordenes de preparacion pendientes";
            // 
            // MercaderiasAPrepararGroupBox
            // 
            MercaderiasAPrepararGroupBox.Controls.Add(mercaderiasAPrepList);
            MercaderiasAPrepararGroupBox.Controls.Add(eliminarDeSeleccionButton);
            MercaderiasAPrepararGroupBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            MercaderiasAPrepararGroupBox.Location = new Point(14, 337);
            MercaderiasAPrepararGroupBox.Margin = new Padding(3, 4, 3, 4);
            MercaderiasAPrepararGroupBox.Name = "MercaderiasAPrepararGroupBox";
            MercaderiasAPrepararGroupBox.Padding = new Padding(3, 4, 3, 4);
            MercaderiasAPrepararGroupBox.Size = new Size(903, 323);
            MercaderiasAPrepararGroupBox.TabIndex = 12;
            MercaderiasAPrepararGroupBox.TabStop = false;
            MercaderiasAPrepararGroupBox.Text = "Mercaderias a preparar";
            // 
            // GenerarOSPanel
            // 
            GenerarOSPanel.AutoScroll = true;
            GenerarOSPanel.Controls.Add(generarOrdenButton);
            GenerarOSPanel.Controls.Add(OrdenesPendientesGroupBox);
            GenerarOSPanel.Controls.Add(menubutton);
            GenerarOSPanel.Controls.Add(MercaderiasAPrepararGroupBox);
            GenerarOSPanel.Dock = DockStyle.Fill;
            GenerarOSPanel.Location = new Point(0, 0);
            GenerarOSPanel.Name = "GenerarOSPanel";
            GenerarOSPanel.Size = new Size(930, 741);
            GenerarOSPanel.TabIndex = 13;
            // 
            // GenerarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(930, 741);
            Controls.Add(GenerarOSPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "GenerarOrdenSeleccionForm";
            Text = "Generar órden de selección";
            Load += GenerarOrdenSeleccionForm_Load;
            OrdenesPendientesGroupBox.ResumeLayout(false);
            MercaderiasAPrepararGroupBox.ResumeLayout(false);
            GenerarOSPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListView ordenesPendientesListView;
        private ColumnHeader fechaColumna;
        private ColumnHeader idOrdenColumna;
        private ColumnHeader idClienteColumna;
        private Button agregarAOrdenButton;
        private Button generarOrdenButton;
        private Button eliminarDeSeleccionButton;
        private ColumnHeader columnHeader3;
        private ListView mercaderiasAPrepList;
        private ColumnHeader FechaEntregaAPreparar;
        private ColumnHeader IdOrdenPreparacionAPreparar;
        private ColumnHeader RazonSocialClienteAPreparar;
        private ColumnHeader CuitClienteAPreparar;
        private Button menubutton;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader ProductoAPreparar;
        private ColumnHeader CantidadAPreparar;
        private GroupBox OrdenesPendientesGroupBox;
        private GroupBox MercaderiasAPrepararGroupBox;
        private Panel GenerarOSPanel;
    }
}