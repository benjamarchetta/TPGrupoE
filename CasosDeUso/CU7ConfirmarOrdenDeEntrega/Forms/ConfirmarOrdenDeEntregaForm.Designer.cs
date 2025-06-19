namespace TPGrupoE.CasosDeUso.CU7ConfirmarOrdenDeEntrega.Forms
{
    partial class ConfirmarOrdenDeEntregaForm
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
            OrdenesEmpaquetadasALiberarGroupBox = new GroupBox();
            OrdenesEmpaquetadasListView = new ListView();
            IdOrdenEntrega = new ColumnHeader();
            IdOrdenPreparacion = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            LiberarParaDespachoButton = new Button();
            VolverMenuPrincipalButton = new Button();
            OrdenesEmpaquetadasALiberarGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // OrdenesEmpaquetadasALiberarGroupBox
            // 
            OrdenesEmpaquetadasALiberarGroupBox.BackColor = SystemColors.Control;
            OrdenesEmpaquetadasALiberarGroupBox.Controls.Add(OrdenesEmpaquetadasListView);
            OrdenesEmpaquetadasALiberarGroupBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasALiberarGroupBox.Location = new Point(10, 8);
            OrdenesEmpaquetadasALiberarGroupBox.Margin = new Padding(2, 2, 2, 2);
            OrdenesEmpaquetadasALiberarGroupBox.Name = "OrdenesEmpaquetadasALiberarGroupBox";
            OrdenesEmpaquetadasALiberarGroupBox.Padding = new Padding(2, 2, 2, 2);
            OrdenesEmpaquetadasALiberarGroupBox.Size = new Size(472, 340);
            OrdenesEmpaquetadasALiberarGroupBox.TabIndex = 9;
            OrdenesEmpaquetadasALiberarGroupBox.TabStop = false;
            OrdenesEmpaquetadasALiberarGroupBox.Text = "Mercaderías a despachar";
            // 
            // OrdenesEmpaquetadasListView
            // 
            OrdenesEmpaquetadasListView.BackColor = SystemColors.ControlLightLight;
            OrdenesEmpaquetadasListView.Columns.AddRange(new ColumnHeader[] { IdOrdenEntrega, IdOrdenPreparacion, FechaEntrega });
            OrdenesEmpaquetadasListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasListView.GridLines = true;
            OrdenesEmpaquetadasListView.Location = new Point(10, 28);
            OrdenesEmpaquetadasListView.Margin = new Padding(2, 2, 2, 2);
            OrdenesEmpaquetadasListView.MultiSelect = false;
            OrdenesEmpaquetadasListView.Name = "OrdenesEmpaquetadasListView";
            OrdenesEmpaquetadasListView.Size = new Size(448, 296);
            OrdenesEmpaquetadasListView.TabIndex = 6;
            OrdenesEmpaquetadasListView.UseCompatibleStateImageBehavior = false;
            OrdenesEmpaquetadasListView.View = View.Details;
            // 
            // IdOrdenEntrega
            // 
            IdOrdenEntrega.Text = "N° Órden de Entrega";
            IdOrdenEntrega.Width = 150;
            // 
            // IdOrdenPreparacion
            // 
            IdOrdenPreparacion.Text = "N° Órden de Preparación";
            IdOrdenPreparacion.Width = 200;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de entrega";
            FechaEntrega.Width = 150;
            // 
            // LiberarParaDespachoButton
            // 
            LiberarParaDespachoButton.BackColor = SystemColors.Highlight;
            LiberarParaDespachoButton.ForeColor = SystemColors.ActiveCaptionText;
            LiberarParaDespachoButton.Location = new Point(254, 363);
            LiberarParaDespachoButton.Name = "LiberarParaDespachoButton";
            LiberarParaDespachoButton.Size = new Size(228, 36);
            LiberarParaDespachoButton.TabIndex = 3;
            LiberarParaDespachoButton.Text = "Liberar para despacho";
            LiberarParaDespachoButton.UseVisualStyleBackColor = false;
            LiberarParaDespachoButton.Click += LiberarParaDespacho_Click;
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
            // ConfirmarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(494, 408);
            Controls.Add(VolverMenuPrincipalButton);
            Controls.Add(OrdenesEmpaquetadasALiberarGroupBox);
            Controls.Add(LiberarParaDespachoButton);
            Name = "ConfirmarOrdenDeEntregaForm";
            Text = "Confirmar Órden de Entrega";
            FormClosing += ConfirmarOrdenEntregaForm_FormClosing;
            Load += OrdenEntregaForm_Load;
            OrdenesEmpaquetadasALiberarGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader fechaDespachoOE;
        private GroupBox OrdenesEmpaquetadasALiberarGroupBox;
        private Button LiberarParaDespachoButton;
        private ListView OrdenesEmpaquetadasListView;
        private ColumnHeader IdOrdenPreparacion;
        private ColumnHeader FechaEntrega;
        private Button VolverMenuPrincipalButton;
        private ColumnHeader IdOrdenEntrega;
    }
}