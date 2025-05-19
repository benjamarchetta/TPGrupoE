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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            ordenesPreparacionEntregaLabel = new Label();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            idOrdenSeleccion = new DataGridViewTextBoxColumn();
            fechaDespacho = new DataGridViewTextBoxColumn();
            idClienteCuit = new DataGridViewTextBoxColumn();
            skuProducto = new DataGridViewTextBoxColumn();
            productoDescripcion = new DataGridViewTextBoxColumn();
            cantidadProducto = new DataGridViewTextBoxColumn();
            idOperadorPicking = new DataGridViewTextBoxColumn();
            fechaPicking = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ordenesPreparacionEntregaLabel
            // 
            ordenesPreparacionEntregaLabel.AutoSize = true;
            ordenesPreparacionEntregaLabel.Location = new Point(26, 22);
            ordenesPreparacionEntregaLabel.Margin = new Padding(6, 0, 6, 0);
            ordenesPreparacionEntregaLabel.Name = "ordenesPreparacionEntregaLabel";
            ordenesPreparacionEntregaLabel.Size = new Size(243, 37);
            ordenesPreparacionEntregaLabel.TabIndex = 0;
            ordenesPreparacionEntregaLabel.Text = "Órden de selección";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(1367, 513);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(321, 57);
            button1.TabIndex = 3;
            button1.Text = "Cargar orden de entrega";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1123, 563);
            button2.Name = "button2";
            button2.Size = new Size(348, 158);
            button2.TabIndex = 4;
            button2.Text = "ESTE ES UN BOTON DE PRUEBA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.AppWorkspace;
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idOrdenSeleccion, fechaDespacho, idClienteCuit, skuProducto, productoDescripcion, cantidadProducto, idOperadorPicking, fechaPicking });
            dataGridView1.Location = new Point(26, 71);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.Size = new Size(1511, 171);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // idOrdenSeleccion
            // 
            dataGridViewCellStyle2.BackColor = Color.White;
            idOrdenSeleccion.DefaultCellStyle = dataGridViewCellStyle2;
            idOrdenSeleccion.HeaderText = "Número";
            idOrdenSeleccion.MinimumWidth = 11;
            idOrdenSeleccion.Name = "idOrdenSeleccion";
            idOrdenSeleccion.Resizable = DataGridViewTriState.False;
            idOrdenSeleccion.Width = 125;
            // 
            // fechaDespacho
            // 
            fechaDespacho.HeaderText = "Fecha de despacho";
            fechaDespacho.MinimumWidth = 11;
            fechaDespacho.Name = "fechaDespacho";
            fechaDespacho.Width = 160;
            // 
            // idClienteCuit
            // 
            idClienteCuit.HeaderText = "CUIT - Cliente";
            idClienteCuit.MinimumWidth = 11;
            idClienteCuit.Name = "idClienteCuit";
            idClienteCuit.Width = 300;
            // 
            // skuProducto
            // 
            skuProducto.HeaderText = "SKU";
            skuProducto.MinimumWidth = 11;
            skuProducto.Name = "skuProducto";
            skuProducto.Width = 160;
            // 
            // productoDescripcion
            // 
            productoDescripcion.HeaderText = "Descripción del producto";
            productoDescripcion.MinimumWidth = 11;
            productoDescripcion.Name = "productoDescripcion";
            productoDescripcion.Width = 225;
            // 
            // cantidadProducto
            // 
            cantidadProducto.HeaderText = "Cantidad";
            cantidadProducto.MinimumWidth = 11;
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.Width = 125;
            // 
            // idOperadorPicking
            // 
            idOperadorPicking.HeaderText = "Preparada por";
            idOperadorPicking.MinimumWidth = 11;
            idOperadorPicking.Name = "idOperadorPicking";
            idOperadorPicking.Width = 160;
            // 
            // fechaPicking
            // 
            fechaPicking.HeaderText = "Fecha";
            fechaPicking.MinimumWidth = 11;
            fechaPicking.Name = "fechaPicking";
            fechaPicking.Width = 160;
            // 
            // CargarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1542, 755);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(ordenesPreparacionEntregaLabel);
            Margin = new Padding(6, 7, 6, 7);
            Name = "CargarOrdenDeEntregaForm";
            Text = "Generar - Órden de Entrega";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ordenesPreparacionEntregaLabel;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idOrdenSeleccion;
        private DataGridViewTextBoxColumn fechaDespacho;
        private DataGridViewTextBoxColumn idClienteCuit;
        private DataGridViewTextBoxColumn skuProducto;
        private DataGridViewTextBoxColumn productoDescripcion;
        private DataGridViewTextBoxColumn cantidadProducto;
        private DataGridViewTextBoxColumn idOperadorPicking;
        private DataGridViewTextBoxColumn fechaPicking;
    }
}