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
            ConsultarOrdenesPreparacionLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ConsultarOrdenesPreparacionLabel.Location = new Point(20, 15);
            ConsultarOrdenesPreparacionLabel.Name = "ConsultarOrdenesPreparacionLabel";
            ConsultarOrdenesPreparacionLabel.Size = new Size(361, 21);
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
            FiltroConsultaOrdenesGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            FiltroConsultaOrdenesGroupBox.Location = new Point(28, 49);
            FiltroConsultaOrdenesGroupBox.Margin = new Padding(3, 2, 3, 2);
            FiltroConsultaOrdenesGroupBox.Name = "FiltroConsultaOrdenesGroupBox";
            FiltroConsultaOrdenesGroupBox.Padding = new Padding(3, 2, 3, 2);
            FiltroConsultaOrdenesGroupBox.Size = new Size(858, 80);
            FiltroConsultaOrdenesGroupBox.TabIndex = 1;
            FiltroConsultaOrdenesGroupBox.TabStop = false;
            FiltroConsultaOrdenesGroupBox.Text = "Filtros";
            // 
            // LimpiarBusquedaButton
            // 
            LimpiarBusquedaButton.BackColor = SystemColors.GradientActiveCaption;
            LimpiarBusquedaButton.FlatAppearance.BorderColor = Color.Gray;
            LimpiarBusquedaButton.FlatStyle = FlatStyle.Flat;
            LimpiarBusquedaButton.Font = new Font("Segoe UI", 9F);
            LimpiarBusquedaButton.Location = new Point(699, 29);
            LimpiarBusquedaButton.Margin = new Padding(3, 2, 3, 2);
            LimpiarBusquedaButton.Name = "LimpiarBusquedaButton";
            LimpiarBusquedaButton.Size = new Size(144, 38);
            LimpiarBusquedaButton.TabIndex = 5;
            LimpiarBusquedaButton.Text = "Limpiar búsqueda";
            LimpiarBusquedaButton.UseVisualStyleBackColor = false;
            LimpiarBusquedaButton.Click += LimpiarBusquedaButton_Click;
            // 
            // BuscarOrdenesButton
            // 
            BuscarOrdenesButton.BackColor = SystemColors.GradientActiveCaption;
            BuscarOrdenesButton.FlatAppearance.BorderColor = Color.Gray;
            BuscarOrdenesButton.FlatStyle = FlatStyle.Flat;
            BuscarOrdenesButton.Font = new Font("Segoe UI", 9F);
            BuscarOrdenesButton.Location = new Point(540, 29);
            BuscarOrdenesButton.Margin = new Padding(3, 2, 3, 2);
            BuscarOrdenesButton.Name = "BuscarOrdenesButton";
            BuscarOrdenesButton.Size = new Size(144, 38);
            BuscarOrdenesButton.TabIndex = 4;
            BuscarOrdenesButton.Text = "Buscar";
            BuscarOrdenesButton.UseVisualStyleBackColor = false;
            BuscarOrdenesButton.Click += BuscarOrdenesButton_Click;
            // 
            // EstadoOrdenLabel
            // 
            EstadoOrdenLabel.AutoSize = true;
            EstadoOrdenLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            EstadoOrdenLabel.Location = new Point(285, 29);
            EstadoOrdenLabel.Name = "EstadoOrdenLabel";
            EstadoOrdenLabel.Size = new Size(108, 15);
            EstadoOrdenLabel.TabIndex = 3;
            EstadoOrdenLabel.Text = "Estado de la órden";
            // 
            // RazonSocialClienteLabel
            // 
            RazonSocialClienteLabel.AutoSize = true;
            RazonSocialClienteLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RazonSocialClienteLabel.Location = new Point(18, 29);
            RazonSocialClienteLabel.Name = "RazonSocialClienteLabel";
            RazonSocialClienteLabel.Size = new Size(135, 15);
            RazonSocialClienteLabel.TabIndex = 2;
            RazonSocialClienteLabel.Text = "Razon social del cliente";
            // 
            // EstadoOrdenFiltroComboBox
            // 
            EstadoOrdenFiltroComboBox.Font = new Font("Segoe UI", 9F);
            EstadoOrdenFiltroComboBox.FormattingEnabled = true;
            EstadoOrdenFiltroComboBox.Location = new Point(285, 46);
            EstadoOrdenFiltroComboBox.Margin = new Padding(3, 2, 3, 2);
            EstadoOrdenFiltroComboBox.Name = "EstadoOrdenFiltroComboBox";
            EstadoOrdenFiltroComboBox.Size = new Size(232, 23);
            EstadoOrdenFiltroComboBox.TabIndex = 1;
            // 
            // RazonSocialClienteFiltroComboBox
            // 
            RazonSocialClienteFiltroComboBox.Font = new Font("Segoe UI", 9F);
            RazonSocialClienteFiltroComboBox.FormattingEnabled = true;
            RazonSocialClienteFiltroComboBox.Location = new Point(18, 46);
            RazonSocialClienteFiltroComboBox.Margin = new Padding(3, 2, 3, 2);
            RazonSocialClienteFiltroComboBox.Name = "RazonSocialClienteFiltroComboBox";
            RazonSocialClienteFiltroComboBox.Size = new Size(232, 23);
            RazonSocialClienteFiltroComboBox.TabIndex = 0;
            // 
            // EstadoActualOrdenesListView
            // 
            EstadoActualOrdenesListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, EstadoActualOP, FechaUltimaActualizacionEstado, FechaEntregaOP, CuitCliente, RazonSocialCliente, DomicilioDeposito });
            EstadoActualOrdenesListView.Font = new Font("Segoe UI", 9F);
            EstadoActualOrdenesListView.FullRowSelect = true;
            EstadoActualOrdenesListView.Location = new Point(18, 20);
            EstadoActualOrdenesListView.Margin = new Padding(3, 2, 3, 2);
            EstadoActualOrdenesListView.Name = "EstadoActualOrdenesListView";
            EstadoActualOrdenesListView.Size = new Size(834, 170);
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
            UltimoEstadoGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            UltimoEstadoGroupBox.Location = new Point(28, 140);
            UltimoEstadoGroupBox.Margin = new Padding(3, 2, 3, 2);
            UltimoEstadoGroupBox.Name = "UltimoEstadoGroupBox";
            UltimoEstadoGroupBox.Padding = new Padding(3, 2, 3, 2);
            UltimoEstadoGroupBox.Size = new Size(858, 200);
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
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            groupBox1.Location = new Point(28, 352);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(858, 193);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Historico de la órden";
            // 
            // DepositoOPSeleccionadaLabel
            // 
            DepositoOPSeleccionadaLabel.AutoSize = true;
            DepositoOPSeleccionadaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DepositoOPSeleccionadaLabel.Location = new Point(367, 44);
            DepositoOPSeleccionadaLabel.Name = "DepositoOPSeleccionadaLabel";
            DepositoOPSeleccionadaLabel.Size = new Size(58, 15);
            DepositoOPSeleccionadaLabel.TabIndex = 9;
            DepositoOPSeleccionadaLabel.Text = "Depósito:";
            // 
            // CuitRazonClienteLabel
            // 
            CuitRazonClienteLabel.AutoSize = true;
            CuitRazonClienteLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CuitRazonClienteLabel.Location = new Point(367, 22);
            CuitRazonClienteLabel.Name = "CuitRazonClienteLabel";
            CuitRazonClienteLabel.Size = new Size(46, 15);
            CuitRazonClienteLabel.TabIndex = 8;
            CuitRazonClienteLabel.Text = "Cliente:";
            // 
            // FechaEntregaOPSeleccionadaLabel
            // 
            FechaEntregaOPSeleccionadaLabel.AutoSize = true;
            FechaEntregaOPSeleccionadaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FechaEntregaOPSeleccionadaLabel.Location = new Point(18, 44);
            FechaEntregaOPSeleccionadaLabel.Name = "FechaEntregaOPSeleccionadaLabel";
            FechaEntregaOPSeleccionadaLabel.Size = new Size(103, 15);
            FechaEntregaOPSeleccionadaLabel.TabIndex = 7;
            FechaEntregaOPSeleccionadaLabel.Text = "Fecha de entrega: ";
            // 
            // IdOrdenPreparacionSeleccionadaLabel
            // 
            IdOrdenPreparacionSeleccionadaLabel.AutoSize = true;
            IdOrdenPreparacionSeleccionadaLabel.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IdOrdenPreparacionSeleccionadaLabel.Location = new Point(18, 22);
            IdOrdenPreparacionSeleccionadaLabel.Name = "IdOrdenPreparacionSeleccionadaLabel";
            IdOrdenPreparacionSeleccionadaLabel.Size = new Size(131, 15);
            IdOrdenPreparacionSeleccionadaLabel.TabIndex = 6;
            IdOrdenPreparacionSeleccionadaLabel.Text = "N° Órden seleccionada:";
            // 
            // HistoricoOrdenesListView
            // 
            HistoricoOrdenesListView.Columns.AddRange(new ColumnHeader[] { EstadoHist, FechaActualizacionEstadoHist });
            HistoricoOrdenesListView.Font = new Font("Segoe UI", 9F);
            HistoricoOrdenesListView.FullRowSelect = true;
            HistoricoOrdenesListView.Location = new Point(18, 69);
            HistoricoOrdenesListView.Margin = new Padding(3, 2, 3, 2);
            HistoricoOrdenesListView.Name = "HistoricoOrdenesListView";
            HistoricoOrdenesListView.Size = new Size(826, 110);
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
            VolverMenuPrincipalButton.Location = new Point(20, 549);
            VolverMenuPrincipalButton.Margin = new Padding(3, 2, 3, 2);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(858, 44);
            VolverMenuPrincipalButton.TabIndex = 5;
            VolverMenuPrincipalButton.Text = "Volver al Menú Principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = true;
            // 
            // ConsultarOrdenesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 607);
            Controls.Add(VolverMenuPrincipalButton);
            Controls.Add(groupBox1);
            Controls.Add(FiltroConsultaOrdenesGroupBox);
            Controls.Add(ConsultarOrdenesPreparacionLabel);
            Controls.Add(UltimoEstadoGroupBox);
            Margin = new Padding(3, 2, 3, 2);
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