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
            OrdenesEmpaquetadasALiberarGroupBox = new GroupBox();
            OrdenesEmpaquetadasListView = new ListView();
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
            OrdenesEmpaquetadasALiberarGroupBox.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasALiberarGroupBox.Location = new Point(21, 20);
            OrdenesEmpaquetadasALiberarGroupBox.Margin = new Padding(4, 5, 4, 5);
            OrdenesEmpaquetadasALiberarGroupBox.Name = "OrdenesEmpaquetadasALiberarGroupBox";
            OrdenesEmpaquetadasALiberarGroupBox.Padding = new Padding(4, 5, 4, 5);
            OrdenesEmpaquetadasALiberarGroupBox.Size = new Size(1011, 839);
            OrdenesEmpaquetadasALiberarGroupBox.TabIndex = 9;
            OrdenesEmpaquetadasALiberarGroupBox.TabStop = false;
            OrdenesEmpaquetadasALiberarGroupBox.Text = "Mercaderías a liberar para despacho";
            // 
            // OrdenesEmpaquetadasListView
            // 
            OrdenesEmpaquetadasListView.BackColor = SystemColors.ControlLightLight;
            OrdenesEmpaquetadasListView.CheckBoxes = true;
            OrdenesEmpaquetadasListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, FechaEntrega });
            OrdenesEmpaquetadasListView.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrdenesEmpaquetadasListView.GridLines = true;
            OrdenesEmpaquetadasListView.Location = new Point(21, 69);
            OrdenesEmpaquetadasListView.Margin = new Padding(4, 5, 4, 5);
            OrdenesEmpaquetadasListView.MultiSelect = false;
            OrdenesEmpaquetadasListView.Name = "OrdenesEmpaquetadasListView";
            OrdenesEmpaquetadasListView.Size = new Size(955, 724);
            OrdenesEmpaquetadasListView.TabIndex = 6;
            OrdenesEmpaquetadasListView.UseCompatibleStateImageBehavior = false;
            OrdenesEmpaquetadasListView.View = View.Details;
            // 
            // IdOrdenPreparacion
            // 
            IdOrdenPreparacion.Text = "N° Orden de Preparación";
            IdOrdenPreparacion.Width = 480;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de entrega";
            FechaEntrega.Width = 460;
            // 
            // LiberarParaDespachoButton
            // 
            LiberarParaDespachoButton.BackColor = SystemColors.Highlight;
            LiberarParaDespachoButton.ForeColor = SystemColors.ActiveCaptionText;
            LiberarParaDespachoButton.Location = new Point(544, 895);
            LiberarParaDespachoButton.Margin = new Padding(6, 7, 6, 7);
            LiberarParaDespachoButton.Name = "LiberarParaDespachoButton";
            LiberarParaDespachoButton.Size = new Size(489, 89);
            LiberarParaDespachoButton.TabIndex = 3;
            LiberarParaDespachoButton.Text = "Liberar para despacho";
            LiberarParaDespachoButton.UseVisualStyleBackColor = false;
            LiberarParaDespachoButton.Click += LiberarParaDespacho_Click;
            // 
            // VolverMenuPrincipalButton
            // 
            VolverMenuPrincipalButton.Location = new Point(21, 895);
            VolverMenuPrincipalButton.Margin = new Padding(6, 5, 6, 5);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(489, 89);
            VolverMenuPrincipalButton.TabIndex = 10;
            VolverMenuPrincipalButton.Text = "Volver al Menú Principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = true;
            VolverMenuPrincipalButton.Click += VolverMenuPrincipalButton_Click;
            // 
            // CargarOrdenDeEntregaForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1059, 1006);
            Controls.Add(VolverMenuPrincipalButton);
            Controls.Add(OrdenesEmpaquetadasALiberarGroupBox);
            Controls.Add(LiberarParaDespachoButton);
            Margin = new Padding(6, 7, 6, 7);
            Name = "CargarOrdenDeEntregaForm";
            Text = "Cargar Orden de Entrega";
            FormClosing += CargarOrdenEntregaForm_FormClosing;
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
    }
}