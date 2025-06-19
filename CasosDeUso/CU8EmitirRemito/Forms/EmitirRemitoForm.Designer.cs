namespace TPGrupoE.CasosDeUso.CU8EmitirRemito.Forms
{
    partial class EmitirRemitoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmitirRemitoForm));
            EmitirRemitoPanel = new Panel();
            EliminarPictureBox = new PictureBox();
            EmitirRemitoButton = new Button();
            AgregarPictureBox = new PictureBox();
            VolverButton = new Button();
            EmitirRemitogroupBox = new GroupBox();
            EmitirRemitoListView = new ListView();
            IdOrdenPreparacion = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            BuscarDespachoPendienteGroupBox = new GroupBox();
            ClienteComboBox = new ComboBox();
            TransportistaLabel = new Label();
            ClienteLabel = new Label();
            SeleccionarButton = new Button();
            TransportistaComboBox = new ComboBox();
            ConfirmarDespachoGroupBox = new GroupBox();
            ConfirmarDespachoListView = new ListView();
            IdOrdenPreparacionADespachar = new ColumnHeader();
            FechaEntregaADespachar = new ColumnHeader();
            EmitirRemitoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EliminarPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgregarPictureBox).BeginInit();
            EmitirRemitogroupBox.SuspendLayout();
            BuscarDespachoPendienteGroupBox.SuspendLayout();
            ConfirmarDespachoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // EmitirRemitoPanel
            // 
            EmitirRemitoPanel.AutoScroll = true;
            EmitirRemitoPanel.Controls.Add(EliminarPictureBox);
            EmitirRemitoPanel.Controls.Add(EmitirRemitoButton);
            EmitirRemitoPanel.Controls.Add(AgregarPictureBox);
            EmitirRemitoPanel.Controls.Add(VolverButton);
            EmitirRemitoPanel.Controls.Add(EmitirRemitogroupBox);
            EmitirRemitoPanel.Controls.Add(BuscarDespachoPendienteGroupBox);
            EmitirRemitoPanel.Controls.Add(ConfirmarDespachoGroupBox);
            EmitirRemitoPanel.Dock = DockStyle.Fill;
            EmitirRemitoPanel.Location = new Point(0, 0);
            EmitirRemitoPanel.Name = "EmitirRemitoPanel";
            EmitirRemitoPanel.Size = new Size(765, 549);
            EmitirRemitoPanel.TabIndex = 0;
            // 
            // EliminarPictureBox
            // 
            EliminarPictureBox.BackColor = SystemColors.Control;
            EliminarPictureBox.Image = (Image)resources.GetObject("EliminarPictureBox.Image");
            EliminarPictureBox.Location = new Point(363, 314);
            EliminarPictureBox.Margin = new Padding(2);
            EliminarPictureBox.Name = "EliminarPictureBox";
            EliminarPictureBox.Size = new Size(30, 25);
            EliminarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            EliminarPictureBox.TabIndex = 26;
            EliminarPictureBox.TabStop = false;
            EliminarPictureBox.Click += EliminarPictureBox_Click;
            // 
            // EmitirRemitoButton
            // 
            EmitirRemitoButton.BackColor = SystemColors.Highlight;
            EmitirRemitoButton.Location = new Point(387, 482);
            EmitirRemitoButton.Margin = new Padding(3, 4, 3, 4);
            EmitirRemitoButton.Name = "EmitirRemitoButton";
            EmitirRemitoButton.Size = new Size(358, 50);
            EmitirRemitoButton.TabIndex = 21;
            EmitirRemitoButton.Text = "Confirmar Despacho y Emitir Remito";
            EmitirRemitoButton.UseVisualStyleBackColor = false;
            EmitirRemitoButton.Click += MarcarOpDespachadaButton_Click;
            // 
            // AgregarPictureBox
            // 
            AgregarPictureBox.BackColor = SystemColors.Control;
            AgregarPictureBox.Image = (Image)resources.GetObject("AgregarPictureBox.Image");
            AgregarPictureBox.Location = new Point(363, 274);
            AgregarPictureBox.Margin = new Padding(2);
            AgregarPictureBox.Name = "AgregarPictureBox";
            AgregarPictureBox.Size = new Size(30, 26);
            AgregarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AgregarPictureBox.TabIndex = 25;
            AgregarPictureBox.TabStop = false;
            AgregarPictureBox.Click += AgregarPictureBox_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(12, 482);
            VolverButton.Margin = new Padding(3, 4, 3, 4);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(358, 50);
            VolverButton.TabIndex = 22;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverMenuPrincipalButton_Click;
            // 
            // EmitirRemitogroupBox
            // 
            EmitirRemitogroupBox.Controls.Add(EmitirRemitoListView);
            EmitirRemitogroupBox.Font = new Font("Segoe UI Semibold", 10F);
            EmitirRemitogroupBox.Location = new Point(12, 148);
            EmitirRemitogroupBox.Margin = new Padding(3, 4, 3, 4);
            EmitirRemitogroupBox.Name = "EmitirRemitogroupBox";
            EmitirRemitogroupBox.Padding = new Padding(3, 4, 3, 4);
            EmitirRemitogroupBox.Size = new Size(337, 326);
            EmitirRemitogroupBox.TabIndex = 20;
            EmitirRemitogroupBox.TabStop = false;
            EmitirRemitogroupBox.Text = "Órdenes de preparación a despachar";
            EmitirRemitogroupBox.Enter += EmitirRemitogroupBox_Enter;
            // 
            // EmitirRemitoListView
            // 
            EmitirRemitoListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, FechaEntrega });
            EmitirRemitoListView.Font = new Font("Segoe UI", 9F);
            EmitirRemitoListView.FullRowSelect = true;
            EmitirRemitoListView.GridLines = true;
            EmitirRemitoListView.Location = new Point(19, 33);
            EmitirRemitoListView.Margin = new Padding(3, 4, 3, 4);
            EmitirRemitoListView.Name = "EmitirRemitoListView";
            EmitirRemitoListView.Size = new Size(300, 278);
            EmitirRemitoListView.TabIndex = 16;
            EmitirRemitoListView.UseCompatibleStateImageBehavior = false;
            EmitirRemitoListView.View = View.Details;
            // 
            // IdOrdenPreparacion
            // 
            IdOrdenPreparacion.Text = "N° Órden de Preparación";
            IdOrdenPreparacion.Width = 180;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.TextAlign = HorizontalAlignment.Center;
            FechaEntrega.Width = 130;
            // 
            // BuscarDespachoPendienteGroupBox
            // 
            BuscarDespachoPendienteGroupBox.Controls.Add(ClienteComboBox);
            BuscarDespachoPendienteGroupBox.Controls.Add(TransportistaLabel);
            BuscarDespachoPendienteGroupBox.Controls.Add(ClienteLabel);
            BuscarDespachoPendienteGroupBox.Controls.Add(SeleccionarButton);
            BuscarDespachoPendienteGroupBox.Controls.Add(TransportistaComboBox);
            BuscarDespachoPendienteGroupBox.Font = new Font("Segoe UI Semibold", 10F);
            BuscarDespachoPendienteGroupBox.Location = new Point(12, 3);
            BuscarDespachoPendienteGroupBox.Name = "BuscarDespachoPendienteGroupBox";
            BuscarDespachoPendienteGroupBox.Size = new Size(733, 138);
            BuscarDespachoPendienteGroupBox.TabIndex = 23;
            BuscarDespachoPendienteGroupBox.TabStop = false;
            BuscarDespachoPendienteGroupBox.Text = "Buscar órdenes a despachar";
            // 
            // ClienteComboBox
            // 
            ClienteComboBox.Font = new Font("Segoe UI", 9F);
            ClienteComboBox.FormattingEnabled = true;
            ClienteComboBox.Location = new Point(358, 53);
            ClienteComboBox.Margin = new Padding(3, 4, 3, 4);
            ClienteComboBox.Name = "ClienteComboBox";
            ClienteComboBox.Size = new Size(357, 28);
            ClienteComboBox.TabIndex = 3;
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Font = new Font("Segoe UI", 9F);
            TransportistaLabel.Location = new Point(19, 29);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(174, 20);
            TransportistaLabel.TabIndex = 0;
            TransportistaLabel.Text = "Seleccionar Transportista";
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Font = new Font("Segoe UI", 9F);
            ClienteLabel.Location = new Point(358, 29);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(135, 20);
            ClienteLabel.TabIndex = 1;
            ClienteLabel.Text = "Seleccionar Cliente";
            // 
            // SeleccionarButton
            // 
            SeleccionarButton.BackColor = SystemColors.GradientActiveCaption;
            SeleccionarButton.Font = new Font("Segoe UI", 9F);
            SeleccionarButton.Location = new Point(19, 85);
            SeleccionarButton.Margin = new Padding(3, 4, 3, 4);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(696, 38);
            SeleccionarButton.TabIndex = 4;
            SeleccionarButton.Text = "Buscar";
            SeleccionarButton.UseVisualStyleBackColor = false;
            SeleccionarButton.Click += SeleccionarTransportistaButton_Click;
            // 
            // TransportistaComboBox
            // 
            TransportistaComboBox.Font = new Font("Segoe UI", 9F);
            TransportistaComboBox.FormattingEnabled = true;
            TransportistaComboBox.Location = new Point(19, 53);
            TransportistaComboBox.Margin = new Padding(3, 4, 3, 4);
            TransportistaComboBox.Name = "TransportistaComboBox";
            TransportistaComboBox.Size = new Size(320, 28);
            TransportistaComboBox.TabIndex = 2;
            // 
            // ConfirmarDespachoGroupBox
            // 
            ConfirmarDespachoGroupBox.Controls.Add(ConfirmarDespachoListView);
            ConfirmarDespachoGroupBox.Font = new Font("Segoe UI Semibold", 10F);
            ConfirmarDespachoGroupBox.Location = new Point(408, 148);
            ConfirmarDespachoGroupBox.Margin = new Padding(3, 4, 3, 4);
            ConfirmarDespachoGroupBox.Name = "ConfirmarDespachoGroupBox";
            ConfirmarDespachoGroupBox.Padding = new Padding(3, 4, 3, 4);
            ConfirmarDespachoGroupBox.Size = new Size(337, 326);
            ConfirmarDespachoGroupBox.TabIndex = 24;
            ConfirmarDespachoGroupBox.TabStop = false;
            ConfirmarDespachoGroupBox.Text = "Confirmar despacho";
            // 
            // ConfirmarDespachoListView
            // 
            ConfirmarDespachoListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionADespachar, FechaEntregaADespachar });
            ConfirmarDespachoListView.Font = new Font("Segoe UI", 9F);
            ConfirmarDespachoListView.FullRowSelect = true;
            ConfirmarDespachoListView.GridLines = true;
            ConfirmarDespachoListView.Location = new Point(19, 33);
            ConfirmarDespachoListView.Margin = new Padding(3, 4, 3, 4);
            ConfirmarDespachoListView.Name = "ConfirmarDespachoListView";
            ConfirmarDespachoListView.Size = new Size(300, 278);
            ConfirmarDespachoListView.TabIndex = 17;
            ConfirmarDespachoListView.UseCompatibleStateImageBehavior = false;
            ConfirmarDespachoListView.View = View.Details;
            // 
            // IdOrdenPreparacionADespachar
            // 
            IdOrdenPreparacionADespachar.Text = "N° Órden de Preparación";
            IdOrdenPreparacionADespachar.Width = 180;
            // 
            // FechaEntregaADespachar
            // 
            FechaEntregaADespachar.Text = "Fecha de Entrega";
            FechaEntregaADespachar.TextAlign = HorizontalAlignment.Center;
            FechaEntregaADespachar.Width = 130;
            // 
            // EmitirRemitoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 549);
            Controls.Add(EmitirRemitoPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmitirRemitoForm";
            Text = "Emitir Remito";
            FormClosing += EmitirRemitoForm_FormClosing;
            Load += EmitirRemito_Load;
            EmitirRemitoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)EliminarPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgregarPictureBox).EndInit();
            EmitirRemitogroupBox.ResumeLayout(false);
            BuscarDespachoPendienteGroupBox.ResumeLayout(false);
            BuscarDespachoPendienteGroupBox.PerformLayout();
            ConfirmarDespachoGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel EmitirRemitoPanel;
        private PictureBox EliminarPictureBox;
        private Button EmitirRemitoButton;
        private PictureBox AgregarPictureBox;
        private Button VolverButton;
        private GroupBox EmitirRemitogroupBox;
        private ListView EmitirRemitoListView;
        private ColumnHeader IdOrdenPreparacion;
        private ColumnHeader FechaEntrega;
        private GroupBox BuscarDespachoPendienteGroupBox;
        private ComboBox ClienteComboBox;
        private Label TransportistaLabel;
        private Label ClienteLabel;
        private Button SeleccionarButton;
        private ComboBox TransportistaComboBox;
        private GroupBox ConfirmarDespachoGroupBox;
        private ListView ConfirmarDespachoListView;
        private ColumnHeader IdOrdenPreparacionADespachar;
        private ColumnHeader FechaEntregaADespachar;
    }
}