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
            panel1 = new Panel();
            VolverMenuPrincipalButton = new Button();
            OrdenesEmpaquetadasALiberarGroupBox = new GroupBox();
            OrdenesEmpaquetadasListView = new ListView();
            IdOrdenEntrega = new ColumnHeader();
            IdOrdenPreparacion = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            LiberarParaDespachoButton = new Button();
            panel1.SuspendLayout();
            OrdenesEmpaquetadasALiberarGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(VolverMenuPrincipalButton);
            panel1.Controls.Add(OrdenesEmpaquetadasALiberarGroupBox);
            panel1.Controls.Add(LiberarParaDespachoButton);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(565, 544);
            panel1.TabIndex = 11;
            // 
            // VolverMenuPrincipalButton
            // 
            VolverMenuPrincipalButton.Location = new Point(12, 485);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(261, 48);
            VolverMenuPrincipalButton.TabIndex = 13;
            VolverMenuPrincipalButton.Text = "Volver al Menú Principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = true;
            VolverMenuPrincipalButton.Click += VolverMenuPrincipalButton_Click;
            // 
            // OrdenesEmpaquetadasALiberarGroupBox
            // 
            OrdenesEmpaquetadasALiberarGroupBox.BackColor = SystemColors.Control;
            OrdenesEmpaquetadasALiberarGroupBox.Controls.Add(OrdenesEmpaquetadasListView);
            OrdenesEmpaquetadasALiberarGroupBox.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasALiberarGroupBox.Location = new Point(12, 12);
            OrdenesEmpaquetadasALiberarGroupBox.Margin = new Padding(2, 3, 2, 3);
            OrdenesEmpaquetadasALiberarGroupBox.Name = "OrdenesEmpaquetadasALiberarGroupBox";
            OrdenesEmpaquetadasALiberarGroupBox.Padding = new Padding(2, 3, 2, 3);
            OrdenesEmpaquetadasALiberarGroupBox.Size = new Size(539, 454);
            OrdenesEmpaquetadasALiberarGroupBox.TabIndex = 12;
            OrdenesEmpaquetadasALiberarGroupBox.TabStop = false;
            OrdenesEmpaquetadasALiberarGroupBox.Text = "Mercaderías a despachar";
            // 
            // OrdenesEmpaquetadasListView
            // 
            OrdenesEmpaquetadasListView.BackColor = SystemColors.ControlLightLight;
            OrdenesEmpaquetadasListView.Columns.AddRange(new ColumnHeader[] { IdOrdenEntrega, IdOrdenPreparacion, FechaEntrega });
            OrdenesEmpaquetadasListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasListView.GridLines = true;
            OrdenesEmpaquetadasListView.Location = new Point(11, 37);
            OrdenesEmpaquetadasListView.Margin = new Padding(2, 3, 2, 3);
            OrdenesEmpaquetadasListView.MultiSelect = false;
            OrdenesEmpaquetadasListView.Name = "OrdenesEmpaquetadasListView";
            OrdenesEmpaquetadasListView.Size = new Size(511, 393);
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
            LiberarParaDespachoButton.Location = new Point(291, 485);
            LiberarParaDespachoButton.Margin = new Padding(3, 4, 3, 4);
            LiberarParaDespachoButton.Name = "LiberarParaDespachoButton";
            LiberarParaDespachoButton.Size = new Size(261, 48);
            LiberarParaDespachoButton.TabIndex = 11;
            LiberarParaDespachoButton.Text = "Liberar para despacho";
            LiberarParaDespachoButton.UseVisualStyleBackColor = false;
            LiberarParaDespachoButton.Click += LiberarParaDespacho_Click;
            // 
            // ConfirmarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 544);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ConfirmarOrdenDeEntregaForm";
            Text = "Confirmar Órden de Entrega";
            FormClosing += ConfirmarOrdenEntregaForm_FormClosing;
            Load += OrdenEntregaForm_Load;
            panel1.ResumeLayout(false);
            OrdenesEmpaquetadasALiberarGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ColumnHeader fechaDespachoOE;
        private Panel panel1;
        private Button VolverMenuPrincipalButton;
        private GroupBox OrdenesEmpaquetadasALiberarGroupBox;
        private ListView OrdenesEmpaquetadasListView;
        private ColumnHeader IdOrdenEntrega;
        private ColumnHeader IdOrdenPreparacion;
        private ColumnHeader FechaEntrega;
        private Button LiberarParaDespachoButton;
    }
}