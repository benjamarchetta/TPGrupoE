namespace TPGrupoE.CasosDeUso.CU9ConsultaOrdenes.Forms
{
    partial class ConsultarOrdenesForm
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
            LimpiarBusquedaButton = new Button();
            BuscarOrdenesButton = new Button();
            EstadoOrdenLabel = new Label();
            RazonSocialClienteLabel = new Label();
            EstadoOrdenFiltroComboBox = new ComboBox();
            RazonSocialClienteFiltroComboBox = new ComboBox();
            EstadoActualOrdenesListView = new ListView();
            IdOrdenPreparacion = new ColumnHeader();
            EstadoActualOP = new ColumnHeader();
            FechaEntregaOP = new ColumnHeader();
            UltimoEstadoGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            IdOrdenPreparacionSeleccionadaLabel = new Label();
            HistoricoOrdenesListView = new ListView();
            VolverMenuPrincipalButton = new Button();
            CuitCliente = new ColumnHeader();
            RazonSocialCliente = new ColumnHeader();
            DomicilioDeposito = new ColumnHeader();
            FechaUltimaActualizacionEstado = new ColumnHeader();
            EstadoHist = new ColumnHeader();
            FechaActualizacionEstadoHist = new ColumnHeader();
            FechaEntregaOPSeleccionadaLabel = new Label();
            CuitRazonClienteLabel = new Label();
            DepositoOPSeleccionadaLabel = new Label();
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
            FiltroConsultaOrdenesGroupBox.Controls.Add(EstadoOrdenFiltroComboBox);
            FiltroConsultaOrdenesGroupBox.Controls.Add(RazonSocialClienteFiltroComboBox);
            FiltroConsultaOrdenesGroupBox.Location = new Point(32, 65);
            FiltroConsultaOrdenesGroupBox.Name = "FiltroConsultaOrdenesGroupBox";
            FiltroConsultaOrdenesGroupBox.Size = new Size(981, 125);
            FiltroConsultaOrdenesGroupBox.TabIndex = 1;
            FiltroConsultaOrdenesGroupBox.TabStop = false;
            FiltroConsultaOrdenesGroupBox.Text = "Filtros";
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
            // BuscarOrdenesButton
            // 
            BuscarOrdenesButton.Location = new Point(617, 39);
            BuscarOrdenesButton.Name = "BuscarOrdenesButton";
            BuscarOrdenesButton.Size = new Size(165, 51);
            BuscarOrdenesButton.TabIndex = 4;
            BuscarOrdenesButton.Text = "Buscar";
            BuscarOrdenesButton.UseVisualStyleBackColor = true;
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
            // RazonSocialClienteLabel
            // 
            RazonSocialClienteLabel.AutoSize = true;
            RazonSocialClienteLabel.Location = new Point(20, 39);
            RazonSocialClienteLabel.Name = "RazonSocialClienteLabel";
            RazonSocialClienteLabel.Size = new Size(165, 20);
            RazonSocialClienteLabel.TabIndex = 2;
            RazonSocialClienteLabel.Text = "Razon social del cliente";
            // 
            // EstadoOrdenFiltroComboBox
            // 
            EstadoOrdenFiltroComboBox.FormattingEnabled = true;
            EstadoOrdenFiltroComboBox.Location = new Point(326, 62);
            EstadoOrdenFiltroComboBox.Name = "EstadoOrdenFiltroComboBox";
            EstadoOrdenFiltroComboBox.Size = new Size(264, 28);
            EstadoOrdenFiltroComboBox.TabIndex = 1;
            // 
            // RazonSocialClienteFiltroComboBox
            // 
            RazonSocialClienteFiltroComboBox.FormattingEnabled = true;
            RazonSocialClienteFiltroComboBox.Location = new Point(20, 62);
            RazonSocialClienteFiltroComboBox.Name = "RazonSocialClienteFiltroComboBox";
            RazonSocialClienteFiltroComboBox.Size = new Size(264, 28);
            RazonSocialClienteFiltroComboBox.TabIndex = 0;
            // 
            // EstadoActualOrdenesListView
            // 
            EstadoActualOrdenesListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, EstadoActualOP, FechaEntregaOP, CuitCliente, RazonSocialCliente, DomicilioDeposito, FechaUltimaActualizacionEstado });
            EstadoActualOrdenesListView.Location = new Point(52, 248);
            EstadoActualOrdenesListView.Name = "EstadoActualOrdenesListView";
            EstadoActualOrdenesListView.Size = new Size(944, 249);
            EstadoActualOrdenesListView.TabIndex = 2;
            EstadoActualOrdenesListView.UseCompatibleStateImageBehavior = false;
            EstadoActualOrdenesListView.View = View.Details;
            EstadoActualOrdenesListView.FullRowSelect = true;
            // 
            // IdOrdenPreparacion
            // 
            IdOrdenPreparacion.Text = "N° ó. preparación";
            IdOrdenPreparacion.Width = 130;
            // 
            // EstadoActualOP
            // 
            EstadoActualOP.Text = "Estado actual";
            EstadoActualOP.Width = 130;
            // 
            // FechaEntregaOP
            // 
            FechaEntregaOP.Text = "Fecha de entrega";
            FechaEntregaOP.Width = 140;
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
            groupBox1.Controls.Add(DepositoOPSeleccionadaLabel);
            groupBox1.Controls.Add(CuitRazonClienteLabel);
            groupBox1.Controls.Add(FechaEntregaOPSeleccionadaLabel);
            groupBox1.Controls.Add(IdOrdenPreparacionSeleccionadaLabel);
            groupBox1.Controls.Add(HistoricoOrdenesListView);
            groupBox1.Location = new Point(32, 539);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(981, 228);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historico de la órden";
            // 
            // IdOrdenPreparacionSeleccionadaLabel
            // 
            IdOrdenPreparacionSeleccionadaLabel.AutoSize = true;
            IdOrdenPreparacionSeleccionadaLabel.Location = new Point(20, 30);
            IdOrdenPreparacionSeleccionadaLabel.Name = "IdOrdenPreparacionSeleccionadaLabel";
            IdOrdenPreparacionSeleccionadaLabel.Size = new Size(164, 20);
            IdOrdenPreparacionSeleccionadaLabel.TabIndex = 6;
            IdOrdenPreparacionSeleccionadaLabel.Text = "N° Órden seleccionada:";
            // 
            // HistoricoOrdenesListView
            // 
            HistoricoOrdenesListView.Columns.AddRange(new ColumnHeader[] { EstadoHist, FechaActualizacionEstadoHist });
            HistoricoOrdenesListView.Location = new Point(20, 64);
            HistoricoOrdenesListView.Name = "HistoricoOrdenesListView";
            HistoricoOrdenesListView.Size = new Size(944, 146);
            HistoricoOrdenesListView.TabIndex = 5;
            HistoricoOrdenesListView.UseCompatibleStateImageBehavior = false;
            HistoricoOrdenesListView.View = View.Details;
            HistoricoOrdenesListView.FullRowSelect = true;
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
            // CuitCliente
            // 
            CuitCliente.Text = "CUIT Cliente";
            CuitCliente.Width = 100;
            // 
            // RazonSocialCliente
            // 
            RazonSocialCliente.Text = "Razon social";
            RazonSocialCliente.Width = 150;
            // 
            // DomicilioDeposito
            // 
            DomicilioDeposito.Text = "Deposito";
            DomicilioDeposito.Width = 150;
            // 
            // FechaUltimaActualizacionEstado
            // 
            FechaUltimaActualizacionEstado.Text = "Último estado";
            FechaUltimaActualizacionEstado.Width = 120;
            // 
            // EstadoHist
            // 
            EstadoHist.Text = "Estado";
            EstadoHist.Width = 100;
            // 
            // FechaActualizacionEstadoHist
            // 
            FechaActualizacionEstadoHist.Text = "Fecha de modificación";
            FechaActualizacionEstadoHist.Width = 200;
            // 
            // FechaEntregaOPSeleccionadaLabel
            // 
            FechaEntregaOPSeleccionadaLabel.AutoSize = true;
            FechaEntregaOPSeleccionadaLabel.Location = new Point(296, 30);
            FechaEntregaOPSeleccionadaLabel.Name = "FechaEntregaOPSeleccionadaLabel";
            FechaEntregaOPSeleccionadaLabel.Size = new Size(130, 20);
            FechaEntregaOPSeleccionadaLabel.TabIndex = 7;
            FechaEntregaOPSeleccionadaLabel.Text = "Fecha de entrega: ";
            // 
            // CuitRazonClienteLabel
            // 
            CuitRazonClienteLabel.AutoSize = true;
            CuitRazonClienteLabel.Location = new Point(544, 30);
            CuitRazonClienteLabel.Name = "CuitRazonClienteLabel";
            CuitRazonClienteLabel.Size = new Size(58, 20);
            CuitRazonClienteLabel.TabIndex = 8;
            CuitRazonClienteLabel.Text = "Cliente:";
            // 
            // DepositoOPSeleccionadaLabel
            // 
            DepositoOPSeleccionadaLabel.AutoSize = true;
            DepositoOPSeleccionadaLabel.Location = new Point(746, 30);
            DepositoOPSeleccionadaLabel.Name = "DepositoOPSeleccionadaLabel";
            DepositoOPSeleccionadaLabel.Size = new Size(73, 20);
            DepositoOPSeleccionadaLabel.TabIndex = 9;
            DepositoOPSeleccionadaLabel.Text = "Depósito:";
            // 
            // ConsultarOrdenesForm
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
            Name = "ConsultarOrdenesForm";
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
        private ComboBox EstadoOrdenFiltroComboBox;
        private ComboBox RazonSocialClienteFiltroComboBox;
        private Button LimpiarBusquedaButton;
        private Button BuscarOrdenesButton;
        private ListView EstadoActualOrdenesListView;
        private GroupBox UltimoEstadoGroupBox;
        private GroupBox groupBox1;
        private Label IdOrdenPreparacionSeleccionadaLabel;
        private ListView HistoricoOrdenesListView;
        private Button VolverMenuPrincipalButton;
        private ColumnHeader IdOrdenPreparacion;
        private ColumnHeader EstadoActualOP;
        private ColumnHeader FechaEntregaOP;
        private ColumnHeader CuitCliente;
        private ColumnHeader RazonSocialCliente;
        private ColumnHeader DomicilioDeposito;
        private ColumnHeader FechaUltimaActualizacionEstado;
        private ColumnHeader EstadoHist;
        private ColumnHeader FechaActualizacionEstadoHist;
        private Label FechaEntregaOPSeleccionadaLabel;
        private Label DepositoOPSeleccionadaLabel;
        private Label CuitRazonClienteLabel;
    }
}