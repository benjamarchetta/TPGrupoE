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
            ListViewItem listViewItem3 = new ListViewItem(new ListViewItem.ListViewSubItem[] { new ListViewItem.ListViewSubItem(null, "OS25001", SystemColors.WindowText, SystemColors.ControlLightLight, new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0)), new ListViewItem.ListViewSubItem(null, "18/05/2025", SystemColors.WindowText, SystemColors.ControlLightLight, new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0)), new ListViewItem.ListViewSubItem(null, "20123456780 - Juan Soto"), new ListViewItem.ListViewSubItem(null, "SKU12345"), new ListViewItem.ListViewSubItem(null, "Producto de ejemplo"), new ListViewItem.ListViewSubItem(null, "8"), new ListViewItem.ListViewSubItem(null, "aledezma"), new ListViewItem.ListViewSubItem(null, "11/04/2025") }, -1);
            ordenesPreparacionEntregaLabel = new Label();
            agregarOS = new Button();
            ordenesPickingCumplidas = new ListView();
            idOrdenPicking = new ColumnHeader();
            fechaDespachoOE = new ColumnHeader();
            cuitCliente = new ColumnHeader();
            skuProductoPicking = new ColumnHeader();
            nombreProducto = new ColumnHeader();
            productoCantidad = new ColumnHeader();
            idUsuarioPicking = new ColumnHeader();
            fechaPickingCumplida = new ColumnHeader();
            borrarSelección = new Button();
            SuspendLayout();
            // 
            // ordenesPreparacionEntregaLabel
            // 
            ordenesPreparacionEntregaLabel.AutoSize = true;
            ordenesPreparacionEntregaLabel.Location = new Point(26, 22);
            ordenesPreparacionEntregaLabel.Margin = new Padding(6, 0, 6, 0);
            ordenesPreparacionEntregaLabel.Name = "ordenesPreparacionEntregaLabel";
            ordenesPreparacionEntregaLabel.Size = new Size(387, 37);
            ordenesPreparacionEntregaLabel.TabIndex = 0;
            ordenesPreparacionEntregaLabel.Text = "Órdenes de selección validadas";
            // 
            // agregarOS
            // 
            agregarOS.Enabled = false;
            agregarOS.Location = new Point(1270, 286);
            agregarOS.Margin = new Padding(6, 7, 6, 7);
            agregarOS.Name = "agregarOS";
            agregarOS.Size = new Size(230, 67);
            agregarOS.TabIndex = 3;
            agregarOS.Text = "Agregar";
            agregarOS.UseVisualStyleBackColor = true;
            // 
            // ordenesPickingCumplidas
            // 
            ordenesPickingCumplidas.BackColor = SystemColors.ControlLightLight;
            ordenesPickingCumplidas.CheckBoxes = true;
            ordenesPickingCumplidas.Columns.AddRange(new ColumnHeader[] { idOrdenPicking, fechaDespachoOE, cuitCliente, skuProductoPicking, nombreProducto, productoCantidad, idUsuarioPicking, fechaPickingCumplida });
            ordenesPickingCumplidas.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordenesPickingCumplidas.FullRowSelect = true;
            ordenesPickingCumplidas.GridLines = true;
            listViewItem3.StateImageIndex = 0;
            ordenesPickingCumplidas.Items.AddRange(new ListViewItem[] { listViewItem3 });
            ordenesPickingCumplidas.LabelEdit = true;
            ordenesPickingCumplidas.Location = new Point(26, 75);
            ordenesPickingCumplidas.Name = "ordenesPickingCumplidas";
            ordenesPickingCumplidas.OwnerDraw = true;
            ordenesPickingCumplidas.Size = new Size(1474, 201);
            ordenesPickingCumplidas.TabIndex = 6;
            ordenesPickingCumplidas.UseCompatibleStateImageBehavior = false;
            ordenesPickingCumplidas.View = View.Details;
            // 
            // idOrdenPicking
            // 
            idOrdenPicking.Text = "Número";
            idOrdenPicking.Width = 150;
            // 
            // fechaDespachoOE
            // 
            fechaDespachoOE.Text = "Fecha de despacho";
            fechaDespachoOE.Width = 160;
            // 
            // cuitCliente
            // 
            cuitCliente.Text = "CUIT - Cliente";
            cuitCliente.Width = 300;
            // 
            // skuProductoPicking
            // 
            skuProductoPicking.Text = "SKU";
            skuProductoPicking.Width = 160;
            // 
            // nombreProducto
            // 
            nombreProducto.Text = "Producto";
            nombreProducto.Width = 225;
            // 
            // productoCantidad
            // 
            productoCantidad.Text = "Cantidad";
            productoCantidad.Width = 125;
            // 
            // idUsuarioPicking
            // 
            idUsuarioPicking.Text = "Preparada por";
            idUsuarioPicking.Width = 180;
            // 
            // fechaPickingCumplida
            // 
            fechaPickingCumplida.Text = "Fecha de picking";
            fechaPickingCumplida.Width = 160;
            // 
            // borrarSelección
            // 
            borrarSelección.Enabled = false;
            borrarSelección.Location = new Point(1028, 286);
            borrarSelección.Margin = new Padding(6, 7, 6, 7);
            borrarSelección.Name = "borrarSelección";
            borrarSelección.Size = new Size(230, 67);
            borrarSelección.TabIndex = 7;
            borrarSelección.Text = "Borrar selección";
            borrarSelección.UseVisualStyleBackColor = true;
            // 
            // CargarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1526, 755);
            Controls.Add(borrarSelección);
            Controls.Add(ordenesPickingCumplidas);
            Controls.Add(agregarOS);
            Controls.Add(ordenesPreparacionEntregaLabel);
            Margin = new Padding(6, 7, 6, 7);
            Name = "CargarOrdenDeEntregaForm";
            Text = "Generar - Órden de Entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ordenesPreparacionEntregaLabel;
        private Button agregarOS;
        private ListView ordenesPickingCumplidas;
        private ColumnHeader idOrdenPicking;
        private ColumnHeader fechaDespachoOE;
        private ColumnHeader cuitCliente;
        private ColumnHeader skuProductoPicking;
        private ColumnHeader nombreProducto;
        private ColumnHeader productoCantidad;
        private ColumnHeader idUsuarioPicking;
        private ColumnHeader fechaPickingCumplida;
        private Button borrarSelección;
    }
}