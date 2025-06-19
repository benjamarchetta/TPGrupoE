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
            FechaUltimaActualizacionEstado = new ColumnHeader();
            FechaEntregaOP = new ColumnHeader();
            CuitCliente = new ColumnHeader();
            RazonSocialCliente = new ColumnHeader();
            DomicilioDeposito = new ColumnHeader();
            UltimoEstadoGroupBox = new GroupBox();
            groupBox1 = new GroupBox();
            DepositoOPSeleccionadaLabel = new Label();
            CuitRazonClienteLabel = new Label();
            FechaEntregaOPSeleccionadaLabel = new Label();
            IdOrdenPreparacionSeleccionadaLabel = new Label();
            HistoricoOrdenesListView = new ListView();
            EstadoHist = new ColumnHeader();
            FechaActualizacionEstadoHist = new ColumnHeader();
            VolverMenuPrincipalButton = new Button();
            FiltroConsultaOrdenesGroupBox.SuspendLayout();
            UltimoEstadoGroupBox.SuspendLayout();
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
            FiltroConsultaOrdenesGroupBox.Size = new Size(981, 106);
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
            LimpiarBusquedaButton.Click += LimpiarBusquedaButton_Click;
            // 
            // BuscarOrdenesButton
            // 
            BuscarOrdenesButton.Location = new Point(617, 39);
            BuscarOrdenesButton.Name = "BuscarOrdenesButton";
            BuscarOrdenesButton.Size = new Size(165, 51);
            BuscarOrdenesButton.TabIndex = 4;
            BuscarOrdenesButton.Text = "Buscar";
            BuscarOrdenesButton.UseVisualStyleBackColor = true;
            BuscarOrdenesButton.Click += BuscarOrdenesButton_Click;
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
            EstadoActualOrdenesListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, EstadoActualOP, FechaUltimaActualizacionEstado, FechaEntregaOP, CuitCliente, RazonSocialCliente, DomicilioDeposito });
            EstadoActualOrdenesListView.FullRowSelect = true;
            EstadoActualOrdenesListView.Location = new Point(20, 26);
            EstadoActualOrdenesListView.Name = "EstadoActualOrdenesListView";
            EstadoActualOrdenesListView.Size = new Size(944, 225);
            EstadoActualOrdenesListView.TabIndex = 2;
            EstadoActualOrdenesListView.UseCompatibleStateImageBehavior = false;
            EstadoActualOrdenesListView.View = View.Details;
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
            // FechaUltimaActualizacionEstado
            // 
            FechaUltimaActualizacionEstado.Text = "Último estado";
            FechaUltimaActualizacionEstado.Width = 120;
            // 
            // FechaEntregaOP
            // 
            FechaEntregaOP.Text = "Fecha de entrega";
            FechaEntregaOP.Width = 140;
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
            // UltimoEstadoGroupBox
            // 
            UltimoEstadoGroupBox.Controls.Add(EstadoActualOrdenesListView);
            UltimoEstadoGroupBox.Location = new Point(32, 186);
            UltimoEstadoGroupBox.Name = "UltimoEstadoGroupBox";
            UltimoEstadoGroupBox.Size = new Size(981, 267);
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
            groupBox1.Location = new Point(32, 469);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(981, 257);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historico de la órden";
            // 
            // DepositoOPSeleccionadaLabel
            // 
            DepositoOPSeleccionadaLabel.AutoSize = true;
            DepositoOPSeleccionadaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepositoOPSeleccionadaLabel.Location = new Point(419, 58);
            DepositoOPSeleccionadaLabel.Name = "DepositoOPSeleccionadaLabel";
            DepositoOPSeleccionadaLabel.Size = new Size(74, 20);
            DepositoOPSeleccionadaLabel.TabIndex = 9;
            DepositoOPSeleccionadaLabel.Text = "Depósito:";
            // 
            // CuitRazonClienteLabel
            // 
            CuitRazonClienteLabel.AutoSize = true;
            CuitRazonClienteLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CuitRazonClienteLabel.Location = new Point(419, 30);
            CuitRazonClienteLabel.Name = "CuitRazonClienteLabel";
            CuitRazonClienteLabel.Size = new Size(60, 20);
            CuitRazonClienteLabel.TabIndex = 8;
            CuitRazonClienteLabel.Text = "Cliente:";
            // 
            // FechaEntregaOPSeleccionadaLabel
            // 
            FechaEntregaOPSeleccionadaLabel.AutoSize = true;
            FechaEntregaOPSeleccionadaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FechaEntregaOPSeleccionadaLabel.Location = new Point(20, 58);
            FechaEntregaOPSeleccionadaLabel.Name = "FechaEntregaOPSeleccionadaLabel";
            FechaEntregaOPSeleccionadaLabel.Size = new Size(135, 20);
            FechaEntregaOPSeleccionadaLabel.TabIndex = 7;
            FechaEntregaOPSeleccionadaLabel.Text = "Fecha de entrega: ";
            // 
            // IdOrdenPreparacionSeleccionadaLabel
            // 
            IdOrdenPreparacionSeleccionadaLabel.AutoSize = true;
            IdOrdenPreparacionSeleccionadaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdOrdenPreparacionSeleccionadaLabel.Location = new Point(20, 30);
            IdOrdenPreparacionSeleccionadaLabel.Name = "IdOrdenPreparacionSeleccionadaLabel";
            IdOrdenPreparacionSeleccionadaLabel.Size = new Size(169, 20);
            IdOrdenPreparacionSeleccionadaLabel.TabIndex = 6;
            IdOrdenPreparacionSeleccionadaLabel.Text = "N° Órden seleccionada:";
            // 
            // HistoricoOrdenesListView
            // 
            HistoricoOrdenesListView.Columns.AddRange(new ColumnHeader[] { EstadoHist, FechaActualizacionEstadoHist });
            HistoricoOrdenesListView.FullRowSelect = true;
            HistoricoOrdenesListView.Location = new Point(20, 92);
            HistoricoOrdenesListView.Name = "HistoricoOrdenesListView";
            HistoricoOrdenesListView.Size = new Size(944, 146);
            HistoricoOrdenesListView.TabIndex = 5;
            HistoricoOrdenesListView.UseCompatibleStateImageBehavior = false;
            HistoricoOrdenesListView.View = View.Details;
            // 
            // EstadoHist
            // 
            EstadoHist.Text = "Estado";
            EstadoHist.Width = 100;
            // 
            // FechaActualizacionEstadoHist
            // 
            FechaActualizacionEstadoHist.Text = "Fecha de modificación";
            FechaActualizacionEstadoHist.Width = 300;
            // 
            // VolverMenuPrincipalButton
            // 
            VolverMenuPrincipalButton.Location = new Point(23, 732);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(981, 58);
            VolverMenuPrincipalButton.TabIndex = 5;
            VolverMenuPrincipalButton.Text = "Volver al Menú Principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = true;
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 808);
            Controls.Add(VolverMenuPrincipalButton);
            Controls.Add(groupBox1);
            Controls.Add(FiltroConsultaOrdenesGroupBox);
            Controls.Add(ConsultarOrdenesPreparacionLabel);
            Controls.Add(UltimoEstadoGroupBox);
            Name = "ConsultarOrdenesForm";
            Text = "Consultar histórico de órdenes";
            FormClosing += ConsultarOrdenesForm_FormClosing;
            FiltroConsultaOrdenesGroupBox.ResumeLayout(false);
            FiltroConsultaOrdenesGroupBox.PerformLayout();
            UltimoEstadoGroupBox.ResumeLayout(false);
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