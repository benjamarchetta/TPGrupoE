namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Forms
{
    partial class EmpaquetadoForm
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
            MercaderiaAEmpaquetarGroupBox = new GroupBox();
            NroOrdenPreparacionTextBox = new TextBox();
            NumeroOrdenPreparacionLabel = new Label();
            MercaderiasALiberarParaDespachoListView = new ListView();
            IdProducto = new ColumnHeader();
            DescripcionProducto = new ColumnHeader();
            CantidadAEmpaquetar = new ColumnHeader();
            ConfirmarEmpaquetadoButton = new Button();
            VolverMenuPrincipalButton = new Button();
            MercaderiaAEmpaquetarGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MercaderiaAEmpaquetarGroupBox
            // 
            MercaderiaAEmpaquetarGroupBox.BackColor = SystemColors.Control;
            MercaderiaAEmpaquetarGroupBox.Controls.Add(NroOrdenPreparacionTextBox);
            MercaderiaAEmpaquetarGroupBox.Controls.Add(NumeroOrdenPreparacionLabel);
            MercaderiaAEmpaquetarGroupBox.Controls.Add(MercaderiasALiberarParaDespachoListView);
            MercaderiaAEmpaquetarGroupBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MercaderiaAEmpaquetarGroupBox.Location = new Point(10, 8);
            MercaderiaAEmpaquetarGroupBox.Margin = new Padding(2, 2, 2, 2);
            MercaderiaAEmpaquetarGroupBox.Name = "MercaderiaAEmpaquetarGroupBox";
            MercaderiaAEmpaquetarGroupBox.Padding = new Padding(2, 2, 2, 2);
            MercaderiaAEmpaquetarGroupBox.Size = new Size(472, 340);
            MercaderiaAEmpaquetarGroupBox.TabIndex = 9;
            MercaderiaAEmpaquetarGroupBox.TabStop = false;
            MercaderiaAEmpaquetarGroupBox.Text = "Mercaderías a liberar para despacho";
            // 
            // NroOrdenPreparacionTextBox
            // 
            NroOrdenPreparacionTextBox.BackColor = SystemColors.Control;
            NroOrdenPreparacionTextBox.BorderStyle = BorderStyle.None;
            NroOrdenPreparacionTextBox.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            NroOrdenPreparacionTextBox.Location = new Point(10, 19);
            NroOrdenPreparacionTextBox.Margin = new Padding(1, 1, 1, 1);
            NroOrdenPreparacionTextBox.Name = "NroOrdenPreparacionTextBox";
            NroOrdenPreparacionTextBox.Size = new Size(137, 18);
            NroOrdenPreparacionTextBox.TabIndex = 8;
            NroOrdenPreparacionTextBox.Text = "N° Orden Preparación:";
            // 
            // NumeroOrdenPreparacionLabel
            // 
            NumeroOrdenPreparacionLabel.AutoSize = true;
            NumeroOrdenPreparacionLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NumeroOrdenPreparacionLabel.Location = new Point(149, 19);
            NumeroOrdenPreparacionLabel.Margin = new Padding(1, 0, 1, 0);
            NumeroOrdenPreparacionLabel.Name = "NumeroOrdenPreparacionLabel";
            NumeroOrdenPreparacionLabel.Size = new Size(47, 19);
            NumeroOrdenPreparacionLabel.TabIndex = 7;
            NumeroOrdenPreparacionLabel.Text = "12345";
            // 
            // MercaderiasALiberarParaDespachoListView
            // 
            MercaderiasALiberarParaDespachoListView.BackColor = SystemColors.ControlLightLight;
            MercaderiasALiberarParaDespachoListView.Columns.AddRange(new ColumnHeader[] { IdProducto, DescripcionProducto, CantidadAEmpaquetar });
            MercaderiasALiberarParaDespachoListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MercaderiasALiberarParaDespachoListView.GridLines = true;
            MercaderiasALiberarParaDespachoListView.Location = new Point(10, 40);
            MercaderiasALiberarParaDespachoListView.Margin = new Padding(2, 2, 2, 2);
            MercaderiasALiberarParaDespachoListView.Name = "MercaderiasALiberarParaDespachoListView";
            MercaderiasALiberarParaDespachoListView.Size = new Size(448, 284);
            MercaderiasALiberarParaDespachoListView.TabIndex = 6;
            MercaderiasALiberarParaDespachoListView.UseCompatibleStateImageBehavior = false;
            MercaderiasALiberarParaDespachoListView.View = View.Details;
            // 
            // IdProducto
            // 
            IdProducto.Text = "Id Producto";
            IdProducto.Width = 100;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Text = "Descripcion del producto";
            DescripcionProducto.Width = 220;
            // 
            // CantidadAEmpaquetar
            // 
            CantidadAEmpaquetar.Text = "Cantidad a empaquetar";
            CantidadAEmpaquetar.Width = 180;
            // 
            // ConfirmarEmpaquetadoButton
            // 
            ConfirmarEmpaquetadoButton.BackColor = SystemColors.Highlight;
            ConfirmarEmpaquetadoButton.ForeColor = SystemColors.ActiveCaptionText;
            ConfirmarEmpaquetadoButton.Location = new Point(254, 363);
            ConfirmarEmpaquetadoButton.Name = "ConfirmarEmpaquetadoButton";
            ConfirmarEmpaquetadoButton.Size = new Size(228, 36);
            ConfirmarEmpaquetadoButton.TabIndex = 3;
            ConfirmarEmpaquetadoButton.Text = "Confirmar Empaquetado";
            ConfirmarEmpaquetadoButton.UseVisualStyleBackColor = false;
            ConfirmarEmpaquetadoButton.Click += ConfirmarEmpaquetadoButton_Click;
            // 
            // VolverMenuPrincipalButton
            // 
            VolverMenuPrincipalButton.Location = new Point(10, 363);
            VolverMenuPrincipalButton.Margin = new Padding(3, 2, 3, 2);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(228, 36);
            VolverMenuPrincipalButton.TabIndex = 10;
            VolverMenuPrincipalButton.Text = "Volver al Menú Principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = true;
            VolverMenuPrincipalButton.Click += VolverMenuPrincipalButton_Click;
            // 
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 418);
            Controls.Add(VolverMenuPrincipalButton);
            Controls.Add(MercaderiaAEmpaquetarGroupBox);
            Controls.Add(ConfirmarEmpaquetadoButton);
            Name = "EmpaquetadoForm";
            Text = "Empaquetado";
            FormClosing += EmpaquetadoForm_FormClosing;
            Load += EmpaquetadoForm_Load;
            MercaderiaAEmpaquetarGroupBox.ResumeLayout(false);
            MercaderiaAEmpaquetarGroupBox.PerformLayout();
            ResumeLayout(false);
        }
        #endregion

        private GroupBox MercaderiaAEmpaquetarGroupBox;
        private ListView MercaderiasALiberarParaDespachoListView;
        private ColumnHeader IdProducto;
        private ColumnHeader DescripcionProducto;
        private ColumnHeader CantidadAEmpaquetar;
        private Button ConfirmarEmpaquetadoButton;
        private Button VolverMenuPrincipalButton;
        private Label NumeroOrdenPreparacionLabel;
        private TextBox NroOrdenPreparacionTextBox;
    }
}