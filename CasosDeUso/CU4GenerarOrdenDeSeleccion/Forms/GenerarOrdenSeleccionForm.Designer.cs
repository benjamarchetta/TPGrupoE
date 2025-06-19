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
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            prod = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            menubutton = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // ordenesPendientesListView
            // 
            ordenesPendientesListView.Columns.AddRange(new ColumnHeader[] { fechaColumna, idOrdenColumna, idClienteColumna, columnHeader3, Producto, Cantidad });
            ordenesPendientesListView.Font = new Font("Segoe UI", 9F);
            ordenesPendientesListView.FullRowSelect = true;
            ordenesPendientesListView.Location = new Point(6, 22);
            ordenesPendientesListView.Name = "ordenesPendientesListView";
            ordenesPendientesListView.Size = new Size(776, 165);
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
            agregarAOrdenButton.Location = new Point(530, 193);
            agregarAOrdenButton.Name = "agregarAOrdenButton";
            agregarAOrdenButton.Size = new Size(251, 30);
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
            generarOrdenButton.Location = new Point(420, 515);
            generarOrdenButton.Name = "generarOrdenButton";
            generarOrdenButton.Size = new Size(376, 38);
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
            eliminarDeSeleccionButton.Location = new Point(534, 202);
            eliminarDeSeleccionButton.Name = "eliminarDeSeleccionButton";
            eliminarDeSeleccionButton.Size = new Size(251, 30);
            eliminarDeSeleccionButton.TabIndex = 6;
            eliminarDeSeleccionButton.Text = "Eliminar de orden de selección";
            eliminarDeSeleccionButton.UseVisualStyleBackColor = false;
            eliminarDeSeleccionButton.Click += eliminarDeSeleccionButton_Click;
            // 
            // mercaderiasAPrepList
            // 
            mercaderiasAPrepList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, prod, columnHeader7 });
            mercaderiasAPrepList.Font = new Font("Segoe UI", 9F);
            mercaderiasAPrepList.FullRowSelect = true;
            mercaderiasAPrepList.Location = new Point(8, 21);
            mercaderiasAPrepList.Name = "mercaderiasAPrepList";
            mercaderiasAPrepList.Size = new Size(776, 175);
            mercaderiasAPrepList.TabIndex = 9;
            mercaderiasAPrepList.UseCompatibleStateImageBehavior = false;
            mercaderiasAPrepList.View = View.Details;
            mercaderiasAPrepList.Click += mercaderiasAPrepList_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha de entrega";
            columnHeader1.Width = 129;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "N° O. Preparación";
            columnHeader2.Width = 129;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Razón social";
            columnHeader4.Width = 129;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "CUIT Cliente";
            columnHeader5.Width = 129;
            // 
            // prod
            // 
            prod.Text = "Producto";
            prod.Width = 129;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Cantidad";
            columnHeader7.Width = 129;
            // 
            // menubutton
            // 
            menubutton.BackColor = Color.Silver;
            menubutton.FlatAppearance.BorderColor = Color.Gray;
            menubutton.FlatStyle = FlatStyle.Flat;
            menubutton.Location = new Point(12, 515);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(376, 38);
            menubutton.TabIndex = 10;
            menubutton.Text = "Volver al Menu Principal";
            menubutton.UseVisualStyleBackColor = false;
            menubutton.Click += menubutton_Click;
            // 
            // groupBox1
            // 
            groupBox1.AccessibleRole = AccessibleRole.OutlineButton;
            groupBox1.Controls.Add(agregarAOrdenButton);
            groupBox1.Controls.Add(ordenesPendientesListView);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(790, 232);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ordenes de preparacion pendientes";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(mercaderiasAPrepList);
            groupBox2.Controls.Add(eliminarDeSeleccionButton);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox2.Location = new Point(12, 253);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(790, 242);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Mercaderias a preparar";
            // 
            // GenerarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 562);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(menubutton);
            Controls.Add(generarOrdenButton);
            Name = "GenerarOrdenSeleccionForm";
            Text = "Generar órden de selección";
            Load += GenerarOrdenSeleccionForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
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
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Button menubutton;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader prod;
        private ColumnHeader columnHeader7;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
    }
}