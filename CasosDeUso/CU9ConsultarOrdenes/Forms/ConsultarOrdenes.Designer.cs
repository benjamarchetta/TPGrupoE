namespace TPGrupoE.CasosDeUso.CU9ConsultaOrdenes.Forms
{
    partial class ConsultarOrdenes
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
            ConsultarOrdenesPreparacionLabel = new Label();
            FiltroConsultaOrdenesGroupBox = new GroupBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            RazonSocialClienteLabel = new Label();
            EstadoOrdenLabel = new Label();
            BuscarOrdenesButton = new Button();
            LimpiarBusquedaButton = new Button();
            EstadoActualOrdenesListView = new ListView();
            UltimoEstadoGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            HistoricoOrdenesListView = new ListView();
            label1 = new Label();
            VolverMenuPrincipalButton = new Button();
            FiltroConsultaOrdenesGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // ConsultarOrdenesPreparacionLabel
            // 
            ConsultarOrdenesPreparacionLabel.AutoSize = true;
            ConsultarOrdenesPreparacionLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ConsultarOrdenesPreparacionLabel.Location = new Point(23, 20);
            ConsultarOrdenesPreparacionLabel.Name = "ConsultarOrdenesPreparacionLabel";
            ConsultarOrdenesPreparacionLabel.Size = new Size(486, 31);
            ConsultarOrdenesPreparacionLabel.TabIndex = 0;
            ConsultarOrdenesPreparacionLabel.Text = "Consultar histórico de órdenes de preparación";
            // 
            // FiltroConsultaOrdenesGroupBox
            // 
            FiltroConsultaOrdenesGroupBox.Controls.Add(LimpiarBusquedaButton);
            FiltroConsultaOrdenesGroupBox.Controls.Add(BuscarOrdenesButton);
            FiltroConsultaOrdenesGroupBox.Controls.Add(EstadoOrdenLabel);
            FiltroConsultaOrdenesGroupBox.Controls.Add(RazonSocialClienteLabel);
            FiltroConsultaOrdenesGroupBox.Controls.Add(comboBox2);
            FiltroConsultaOrdenesGroupBox.Controls.Add(comboBox1);
            FiltroConsultaOrdenesGroupBox.Location = new Point(32, 65);
            FiltroConsultaOrdenesGroupBox.Name = "FiltroConsultaOrdenesGroupBox";
            FiltroConsultaOrdenesGroupBox.Size = new Size(981, 125);
            FiltroConsultaOrdenesGroupBox.TabIndex = 1;
            FiltroConsultaOrdenesGroupBox.TabStop = false;
            FiltroConsultaOrdenesGroupBox.Text = "Filtros";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(20, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 28);
            comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(326, 62);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(264, 28);
            comboBox2.TabIndex = 1;
            // 
            // RazonSocialClienteLabel
            // 
            RazonSocialClienteLabel.AutoSize = true;
            RazonSocialClienteLabel.Location = new Point(20, 39);
            RazonSocialClienteLabel.Name = "RazonSocialClienteLabel";
            RazonSocialClienteLabel.Size = new Size(165, 20);
            RazonSocialClienteLabel.TabIndex = 2;
            RazonSocialClienteLabel.Text = "Razon social del cliente";
            // 
            // EstadoOrdenLabel
            // 
            EstadoOrdenLabel.AutoSize = true;
            EstadoOrdenLabel.Location = new Point(326, 39);
            EstadoOrdenLabel.Name = "EstadoOrdenLabel";
            EstadoOrdenLabel.Size = new Size(134, 20);
            EstadoOrdenLabel.TabIndex = 3;
            EstadoOrdenLabel.Text = "Estado de la órden";
            // 
            // BuscarOrdenesButton
            // 
            BuscarOrdenesButton.Location = new Point(617, 39);
            BuscarOrdenesButton.Name = "BuscarOrdenesButton";
            BuscarOrdenesButton.Size = new Size(165, 51);
            BuscarOrdenesButton.TabIndex = 4;
            BuscarOrdenesButton.Text = "Buscar";
            BuscarOrdenesButton.UseVisualStyleBackColor = true;
            // 
            // LimpiarBusquedaButton
            // 
            LimpiarBusquedaButton.Location = new Point(799, 39);
            LimpiarBusquedaButton.Name = "LimpiarBusquedaButton";
            LimpiarBusquedaButton.Size = new Size(165, 51);
            LimpiarBusquedaButton.TabIndex = 5;
            LimpiarBusquedaButton.Text = "Limpiar búsqueda";
            LimpiarBusquedaButton.UseVisualStyleBackColor = true;
            // 
            // EstadoActualOrdenesListView
            // 
            EstadoActualOrdenesListView.Location = new Point(52, 248);
            EstadoActualOrdenesListView.Name = "EstadoActualOrdenesListView";
            EstadoActualOrdenesListView.Size = new Size(944, 249);
            EstadoActualOrdenesListView.TabIndex = 2;
            EstadoActualOrdenesListView.UseCompatibleStateImageBehavior = false;
            // 
            // UltimoEstadoGroupBox
            // 
            UltimoEstadoGroupBox.Location = new Point(32, 213);
            UltimoEstadoGroupBox.Name = "UltimoEstadoGroupBox";
            UltimoEstadoGroupBox.Size = new Size(981, 304);
            UltimoEstadoGroupBox.TabIndex = 3;
            UltimoEstadoGroupBox.TabStop = false;
            UltimoEstadoGroupBox.Text = "Estado actual";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(HistoricoOrdenesListView);
            groupBox1.Location = new Point(32, 539);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(981, 228);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historico de la órden";
            // 
            // HistoricoOrdenesListView
            // 
            HistoricoOrdenesListView.Location = new Point(20, 62);
            HistoricoOrdenesListView.Name = "HistoricoOrdenesListView";
            HistoricoOrdenesListView.Size = new Size(944, 148);
            HistoricoOrdenesListView.TabIndex = 5;
            HistoricoOrdenesListView.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 30);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 6;
            label1.Text = "N° Órden seleccionada:";
            // 
            // VolverMenuPrincipalButton
            // 
            VolverMenuPrincipalButton.Location = new Point(32, 793);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(981, 58);
            VolverMenuPrincipalButton.TabIndex = 5;
            VolverMenuPrincipalButton.Text = "Volver al Menú Principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = true;
            // 
            // ConsultarOrdenes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 877);
            Controls.Add(VolverMenuPrincipalButton);
            Controls.Add(groupBox1);
            Controls.Add(EstadoActualOrdenesListView);
            Controls.Add(FiltroConsultaOrdenesGroupBox);
            Controls.Add(ConsultarOrdenesPreparacionLabel);
            Controls.Add(UltimoEstadoGroupBox);
            Name = "ConsultarOrdenes";
            Text = "Consultar histórico de órdenes";
            FiltroConsultaOrdenesGroupBox.ResumeLayout(false);
            FiltroConsultaOrdenesGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ConsultarOrdenesPreparacionLabel;
        private GroupBox FiltroConsultaOrdenesGroupBox;
        private Label EstadoOrdenLabel;
        private Label RazonSocialClienteLabel;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Button LimpiarBusquedaButton;
        private Button BuscarOrdenesButton;
        private ListView EstadoActualOrdenesListView;
        private GroupBox UltimoEstadoGroupBox;
        private GroupBox groupBox1;
        private Label label1;
        private ListView HistoricoOrdenesListView;
        private Button VolverMenuPrincipalButton;
    }
}