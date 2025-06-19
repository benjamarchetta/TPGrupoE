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
            TransportistaLabel = new Label();
            ClienteLabel = new Label();
            TransportistaComboBox = new ComboBox();
            ClienteComboBox = new ComboBox();
            SeleccionarButton = new Button();
            EmitirRemitogroupBox = new GroupBox();
            EmitirRemitoListView = new ListView();
            IdOrdenPreparacion = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            ConfirmarDespachoListView = new ListView();
            IdOrdenPreparacionADespachar = new ColumnHeader();
            FechaEntregaADespachar = new ColumnHeader();
            EmitirRemitoButton = new Button();
            VolverButton = new Button();
            BuscarDespachoPendienteGroupBox = new GroupBox();
            ConfirmarDespachoGroupBox = new GroupBox();
            AgregarPictureBox = new PictureBox();
            EliminarPictureBox = new PictureBox();
            EmitirRemitogroupBox.SuspendLayout();
            BuscarDespachoPendienteGroupBox.SuspendLayout();
            ConfirmarDespachoGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AgregarPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EliminarPictureBox).BeginInit();
            SuspendLayout();
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Location = new Point(19, 29);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(174, 20);
            TransportistaLabel.TabIndex = 0;
            TransportistaLabel.Text = "Seleccionar Transportista";
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Location = new Point(358, 29);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(135, 20);
            ClienteLabel.TabIndex = 1;
            ClienteLabel.Text = "Seleccionar Cliente";
            // 
            // TransportistaComboBox
            // 
            TransportistaComboBox.FormattingEnabled = true;
            TransportistaComboBox.Location = new Point(19, 53);
            TransportistaComboBox.Margin = new Padding(3, 4, 3, 4);
            TransportistaComboBox.Name = "TransportistaComboBox";
            TransportistaComboBox.Size = new Size(320, 28);
            TransportistaComboBox.TabIndex = 2;
            // 
            // ClienteComboBox
            // 
            ClienteComboBox.FormattingEnabled = true;
            ClienteComboBox.Location = new Point(358, 53);
            ClienteComboBox.Margin = new Padding(3, 4, 3, 4);
            ClienteComboBox.Name = "ClienteComboBox";
            ClienteComboBox.Size = new Size(357, 28);
            ClienteComboBox.TabIndex = 3;
            // 
            // SeleccionarButton
            // 
            SeleccionarButton.BackColor = SystemColors.InactiveCaption;
            SeleccionarButton.Location = new Point(19, 85);
            SeleccionarButton.Margin = new Padding(3, 4, 3, 4);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(694, 38);
            SeleccionarButton.TabIndex = 4;
            SeleccionarButton.Text = "Buscar";
            SeleccionarButton.UseVisualStyleBackColor = false;
            SeleccionarButton.Click += SeleccionarTransportistaButton_Click;
            // 
            // EmitirRemitogroupBox
            // 
            EmitirRemitogroupBox.Controls.Add(EmitirRemitoListView);
            EmitirRemitogroupBox.Location = new Point(14, 165);
            EmitirRemitogroupBox.Margin = new Padding(3, 4, 3, 4);
            EmitirRemitogroupBox.Name = "EmitirRemitogroupBox";
            EmitirRemitogroupBox.Padding = new Padding(3, 4, 3, 4);
            EmitirRemitogroupBox.Size = new Size(337, 326);
            EmitirRemitogroupBox.TabIndex = 5;
            EmitirRemitogroupBox.TabStop = false;
            EmitirRemitogroupBox.Text = "Órdenes de preparación a despachar";
            // 
            // EmitirRemitoListView
            // 
            EmitirRemitoListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, FechaEntrega });
            EmitirRemitoListView.FullRowSelect = true;
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
            // ConfirmarDespachoListView
            // 
            ConfirmarDespachoListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacionADespachar, FechaEntregaADespachar });
            ConfirmarDespachoListView.FullRowSelect = true;
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
            // EmitirRemitoButton
            // 
            EmitirRemitoButton.BackColor = SystemColors.Highlight;
            EmitirRemitoButton.Location = new Point(389, 511);
            EmitirRemitoButton.Margin = new Padding(3, 4, 3, 4);
            EmitirRemitoButton.Name = "EmitirRemitoButton";
            EmitirRemitoButton.Size = new Size(358, 50);
            EmitirRemitoButton.TabIndex = 6;
            EmitirRemitoButton.Text = "Confirmar Despacho y Emitir Remito";
            EmitirRemitoButton.UseVisualStyleBackColor = false;
            EmitirRemitoButton.Click += MarcarOpDespachadaButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(14, 511);
            VolverButton.Margin = new Padding(3, 4, 3, 4);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(358, 50);
            VolverButton.TabIndex = 7;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            VolverButton.Click += VolverMenuPrincipalButton_Click;
            // 
            // BuscarDespachoPendienteGroupBox
            // 
            BuscarDespachoPendienteGroupBox.Controls.Add(ClienteComboBox);
            BuscarDespachoPendienteGroupBox.Controls.Add(TransportistaLabel);
            BuscarDespachoPendienteGroupBox.Controls.Add(ClienteLabel);
            BuscarDespachoPendienteGroupBox.Controls.Add(SeleccionarButton);
            BuscarDespachoPendienteGroupBox.Controls.Add(TransportistaComboBox);
            BuscarDespachoPendienteGroupBox.Location = new Point(14, 20);
            BuscarDespachoPendienteGroupBox.Name = "BuscarDespachoPendienteGroupBox";
            BuscarDespachoPendienteGroupBox.Size = new Size(733, 138);
            BuscarDespachoPendienteGroupBox.TabIndex = 8;
            BuscarDespachoPendienteGroupBox.TabStop = false;
            BuscarDespachoPendienteGroupBox.Text = "Buscar órdenes a despachar";
            // 
            // ConfirmarDespachoGroupBox
            // 
            ConfirmarDespachoGroupBox.Controls.Add(ConfirmarDespachoListView);
            ConfirmarDespachoGroupBox.Location = new Point(410, 165);
            ConfirmarDespachoGroupBox.Margin = new Padding(3, 4, 3, 4);
            ConfirmarDespachoGroupBox.Name = "ConfirmarDespachoGroupBox";
            ConfirmarDespachoGroupBox.Padding = new Padding(3, 4, 3, 4);
            ConfirmarDespachoGroupBox.Size = new Size(337, 326);
            ConfirmarDespachoGroupBox.TabIndex = 17;
            ConfirmarDespachoGroupBox.TabStop = false;
            ConfirmarDespachoGroupBox.Text = "Confirmar despacho";
            // 
            // AgregarPictureBox
            // 
            AgregarPictureBox.BackColor = SystemColors.Control;
            AgregarPictureBox.Image = (Image)resources.GetObject("AgregarPictureBox.Image");
            AgregarPictureBox.Location = new Point(366, 286);
            AgregarPictureBox.Margin = new Padding(2, 2, 2, 2);
            AgregarPictureBox.Name = "AgregarPictureBox";
            AgregarPictureBox.Size = new Size(30, 26);
            AgregarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            AgregarPictureBox.TabIndex = 18;
            AgregarPictureBox.TabStop = false;
            AgregarPictureBox.Click += AgregarPictureBox_Click;
            // 
            // EliminarPictureBox
            // 
            EliminarPictureBox.BackColor = SystemColors.Control;
            EliminarPictureBox.Image = (Image)resources.GetObject("EliminarPictureBox.Image");
            EliminarPictureBox.Location = new Point(366, 322);
            EliminarPictureBox.Margin = new Padding(2, 2, 2, 2);
            EliminarPictureBox.Name = "EliminarPictureBox";
            EliminarPictureBox.Size = new Size(30, 25);
            EliminarPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            EliminarPictureBox.TabIndex = 19;
            EliminarPictureBox.TabStop = false;
            EliminarPictureBox.Click += EliminarPictureBox_Click;
            // 
            // EmitirRemitoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(765, 570);
            Controls.Add(EliminarPictureBox);
            Controls.Add(EmitirRemitoButton);
            Controls.Add(AgregarPictureBox);
            Controls.Add(VolverButton);
            Controls.Add(EmitirRemitogroupBox);
            Controls.Add(BuscarDespachoPendienteGroupBox);
            Controls.Add(ConfirmarDespachoGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmitirRemitoForm";
            Text = "Emitir Remito";
            FormClosing += EmitirRemitoForm_FormClosing;
            Load += EmitirRemito_Load;
            EmitirRemitogroupBox.ResumeLayout(false);
            BuscarDespachoPendienteGroupBox.ResumeLayout(false);
            BuscarDespachoPendienteGroupBox.PerformLayout();
            ConfirmarDespachoGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)AgregarPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)EliminarPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label TransportistaLabel;
        private Label ClienteLabel;
        private ComboBox TransportistaComboBox;
        private ComboBox ClienteComboBox;
        private Button SeleccionarButton;
        private GroupBox EmitirRemitogroupBox;
        private ListView EmitirRemitoListView;
        private ColumnHeader IdOrdenPreparacion;
        private ColumnHeader FechaEntrega;
        private Button EmitirRemitoButton;
        private Button VolverButton;
        private GroupBox BuscarDespachoPendienteGroupBox;
        private ListView ConfirmarDespachoListView;
        private ColumnHeader IdOrdenPreparacionADespachar;
        private ColumnHeader FechaEntregaADespachar;
        private GroupBox ConfirmarDespachoGroupBox;
        private PictureBox AgregarPictureBox;
        private PictureBox EliminarPictureBox;
    }
}