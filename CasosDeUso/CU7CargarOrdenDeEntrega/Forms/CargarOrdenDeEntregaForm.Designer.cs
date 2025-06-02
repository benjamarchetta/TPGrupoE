namespace TPGrupoE.CasosDeUso.CU7CargarOrdenDeEntrega.Forms
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
            AgregarOrdenPreparacionButton = new Button();
            OrdenesEmpaquetadasListView = new ListView();
            IdOrdenPreparacion = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            BorrarSelecciónButton = new Button();
            OrdenesEmpaquetadasGroupBox = new GroupBox();
            OrdenesEmpaquetadasALiberarGroupBox = new GroupBox();
            OrdenesEmpaquetadasALiberarListView = new ListView();
            IdOrdenPreparacionALiberar = new ColumnHeader();
            FechaEntregaPlanificada = new ColumnHeader();
            LiberarParaDespachoButton = new Button();
            OrdenesEmpaquetadasGroupBox.SuspendLayout();
            OrdenesEmpaquetadasALiberarGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AgregarOrdenPreparacionButton
            // 
            AgregarOrdenPreparacionButton.Enabled = false;
            AgregarOrdenPreparacionButton.Location = new Point(281, 203);
            AgregarOrdenPreparacionButton.Margin = new Padding(3, 4, 3, 4);
            AgregarOrdenPreparacionButton.Name = "AgregarOrdenPreparacionButton";
            AgregarOrdenPreparacionButton.Size = new Size(260, 36);
            AgregarOrdenPreparacionButton.TabIndex = 3;
            AgregarOrdenPreparacionButton.Text = "Agregar";
            AgregarOrdenPreparacionButton.UseVisualStyleBackColor = true;
            // 
            // OrdenesEmpaquetadasListView
            // 
            OrdenesEmpaquetadasListView.BackColor = SystemColors.ControlLightLight;
            OrdenesEmpaquetadasListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, FechaEntrega });
            OrdenesEmpaquetadasListView.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasListView.FullRowSelect = true;
            OrdenesEmpaquetadasListView.GridLines = true;
            OrdenesEmpaquetadasListView.LabelEdit = true;
            OrdenesEmpaquetadasListView.Location = new Point(12, 27);
            OrdenesEmpaquetadasListView.Margin = new Padding(2);
            OrdenesEmpaquetadasListView.Name = "OrdenesEmpaquetadasListView";
            OrdenesEmpaquetadasListView.Size = new Size(529, 170);
            OrdenesEmpaquetadasListView.TabIndex = 6;
            OrdenesEmpaquetadasListView.UseCompatibleStateImageBehavior = false;
            OrdenesEmpaquetadasListView.View = View.Details;
            // 
            // IdOrdenPreparacion
            // 
            IdOrdenPreparacion.Text = "N° Orden de Preparación";
            IdOrdenPreparacion.Width = 180;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de entrega";
            FechaEntrega.Width = 160;
            // 
            // BorrarSelecciónButton
            // 
            BorrarSelecciónButton.Enabled = false;
            BorrarSelecciónButton.Location = new Point(12, 203);
            BorrarSelecciónButton.Margin = new Padding(3, 4, 3, 4);
            BorrarSelecciónButton.Name = "BorrarSelecciónButton";
            BorrarSelecciónButton.Size = new Size(260, 36);
            BorrarSelecciónButton.TabIndex = 7;
            BorrarSelecciónButton.Text = "Borrar selección";
            BorrarSelecciónButton.UseVisualStyleBackColor = true;
            // 
            // OrdenesEmpaquetadasGroupBox
            // 
            OrdenesEmpaquetadasGroupBox.BackColor = SystemColors.Control;
            OrdenesEmpaquetadasGroupBox.Controls.Add(OrdenesEmpaquetadasListView);
            OrdenesEmpaquetadasGroupBox.Controls.Add(BorrarSelecciónButton);
            OrdenesEmpaquetadasGroupBox.Controls.Add(AgregarOrdenPreparacionButton);
            OrdenesEmpaquetadasGroupBox.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasGroupBox.Location = new Point(11, 11);
            OrdenesEmpaquetadasGroupBox.Margin = new Padding(2);
            OrdenesEmpaquetadasGroupBox.Name = "OrdenesEmpaquetadasGroupBox";
            OrdenesEmpaquetadasGroupBox.Padding = new Padding(2);
            OrdenesEmpaquetadasGroupBox.Size = new Size(554, 255);
            OrdenesEmpaquetadasGroupBox.TabIndex = 8;
            OrdenesEmpaquetadasGroupBox.TabStop = false;
            OrdenesEmpaquetadasGroupBox.Text = "Órdenes de preparación empaquetadas";
            OrdenesEmpaquetadasGroupBox.Enter += pickingEnPreparacionGroupBox_Enter;
            // 
            // OrdenesEmpaquetadasALiberarGroupBox
            // 
            OrdenesEmpaquetadasALiberarGroupBox.BackColor = SystemColors.Control;
            OrdenesEmpaquetadasALiberarGroupBox.Controls.Add(OrdenesEmpaquetadasALiberarListView);
            OrdenesEmpaquetadasALiberarGroupBox.Controls.Add(LiberarParaDespachoButton);
            OrdenesEmpaquetadasALiberarGroupBox.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasALiberarGroupBox.Location = new Point(11, 287);
            OrdenesEmpaquetadasALiberarGroupBox.Margin = new Padding(2);
            OrdenesEmpaquetadasALiberarGroupBox.Name = "OrdenesEmpaquetadasALiberarGroupBox";
            OrdenesEmpaquetadasALiberarGroupBox.Padding = new Padding(2);
            OrdenesEmpaquetadasALiberarGroupBox.Size = new Size(554, 228);
            OrdenesEmpaquetadasALiberarGroupBox.TabIndex = 9;
            OrdenesEmpaquetadasALiberarGroupBox.TabStop = false;
            OrdenesEmpaquetadasALiberarGroupBox.Text = "Mercaderías a liberar";
            // 
            // OrdenesEmpaquetadasALiberarListView
            // 
            OrdenesEmpaquetadasALiberarListView.BackColor = SystemColors.ControlLightLight;
            OrdenesEmpaquetadasALiberarListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionALiberar, FechaEntregaPlanificada });
            OrdenesEmpaquetadasALiberarListView.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasALiberarListView.FullRowSelect = true;
            OrdenesEmpaquetadasALiberarListView.GridLines = true;
            OrdenesEmpaquetadasALiberarListView.LabelEdit = true;
            OrdenesEmpaquetadasALiberarListView.Location = new Point(12, 29);
            OrdenesEmpaquetadasALiberarListView.Margin = new Padding(2);
            OrdenesEmpaquetadasALiberarListView.Name = "OrdenesEmpaquetadasALiberarListView";
            OrdenesEmpaquetadasALiberarListView.Size = new Size(529, 129);
            OrdenesEmpaquetadasALiberarListView.TabIndex = 6;
            OrdenesEmpaquetadasALiberarListView.UseCompatibleStateImageBehavior = false;
            OrdenesEmpaquetadasALiberarListView.View = View.Details;
            OrdenesEmpaquetadasALiberarListView.SelectedIndexChanged += pickingPreparadoListView_SelectedIndexChanged;
            // 
            // IdOrdenPreparacionALiberar
            // 
            IdOrdenPreparacionALiberar.Text = "N° Orden Preparación";
            IdOrdenPreparacionALiberar.Width = 180;
            // 
            // FechaEntregaPlanificada
            // 
            FechaEntregaPlanificada.Text = "Fecha de entrega";
            FechaEntregaPlanificada.Width = 160;
            // 
            // LiberarParaDespachoButton
            // 
            LiberarParaDespachoButton.BackColor = SystemColors.InactiveCaption;
            LiberarParaDespachoButton.Enabled = false;
            LiberarParaDespachoButton.ForeColor = SystemColors.ControlDark;
            LiberarParaDespachoButton.Location = new Point(12, 164);
            LiberarParaDespachoButton.Margin = new Padding(3, 4, 3, 4);
            LiberarParaDespachoButton.Name = "LiberarParaDespachoButton";
            LiberarParaDespachoButton.Size = new Size(529, 48);
            LiberarParaDespachoButton.TabIndex = 3;
            LiberarParaDespachoButton.Text = "Liberar para despacho";
            LiberarParaDespachoButton.UseVisualStyleBackColor = false;
            // 
            // CargarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 582);
            Controls.Add(OrdenesEmpaquetadasALiberarGroupBox);
            Controls.Add(OrdenesEmpaquetadasGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CargarOrdenDeEntregaForm";
            Text = "Cargar Orden de Entrega";
            Load += OrdenEntregaForm_Load;
            OrdenesEmpaquetadasGroupBox.ResumeLayout(false);
            OrdenesEmpaquetadasALiberarGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        //private Label pickingEnPreparacionGroupBox;
        private Button AgregarOrdenPreparacionButton;
        private ListView OrdenesEmpaquetadasListView;
        private ColumnHeader IdOrdenPreparacion;
        private ColumnHeader fechaDespachoOE;
        private ColumnHeader FechaEntrega;
        private Button BorrarSelecciónButton;
        private GroupBox OrdenesEmpaquetadasGroupBox;
        private GroupBox OrdenesEmpaquetadasALiberarGroupBox;
        private ListView OrdenesEmpaquetadasALiberarListView;
        private ColumnHeader IdOrdenPreparacionALiberar;
        private Button LiberarParaDespachoButton;
        private ColumnHeader FechaEntregaPlanificada;
    }
}