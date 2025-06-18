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
            TransportistaLabel = new Label();
            ClienteLabel = new Label();
            TransportistaComboBox = new ComboBox();
            ClienteComboBox = new ComboBox();
            SeleccionarButton = new Button();
            EmitirRemitogroupBox = new GroupBox();
            EmitirRemitoListView = new ListView();
            IdOrdenPreparacion = new ColumnHeader();
            Estado = new ColumnHeader();
            IdOrdenEntrega = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            EmitirRemitoButton = new Button();
            VolverButton = new Button();
            BuscarDespachoPendienteGroupBox = new GroupBox();
            EmitirRemitogroupBox.SuspendLayout();
            BuscarDespachoPendienteGroupBox.SuspendLayout();
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
            ClienteLabel.Location = new Point(397, 29);
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
            TransportistaComboBox.Size = new Size(357, 28);
            TransportistaComboBox.TabIndex = 2;
            // 
            // ClienteComboBox
            // 
            ClienteComboBox.FormattingEnabled = true;
            ClienteComboBox.Location = new Point(397, 53);
            ClienteComboBox.Margin = new Padding(3, 4, 3, 4);
            ClienteComboBox.Name = "ClienteComboBox";
            ClienteComboBox.Size = new Size(357, 28);
            ClienteComboBox.TabIndex = 3;
            // 
            // SeleccionarButton
            // 
            SeleccionarButton.BackColor = SystemColors.InactiveCaption;
            SeleccionarButton.Location = new Point(19, 93);
            SeleccionarButton.Margin = new Padding(3, 4, 3, 4);
            SeleccionarButton.Name = "SeleccionarButton";
            SeleccionarButton.Size = new Size(735, 40);
            SeleccionarButton.TabIndex = 4;
            SeleccionarButton.Text = "Buscar";
            SeleccionarButton.UseVisualStyleBackColor = false;
            SeleccionarButton.Click += SeleccionarTransportistaButton_Click;
            // 
            // EmitirRemitogroupBox
            // 
            EmitirRemitogroupBox.Controls.Add(EmitirRemitoListView);
            EmitirRemitogroupBox.Location = new Point(14, 195);
            EmitirRemitogroupBox.Margin = new Padding(3, 4, 3, 4);
            EmitirRemitogroupBox.Name = "EmitirRemitogroupBox";
            EmitirRemitogroupBox.Padding = new Padding(3, 4, 3, 4);
            EmitirRemitogroupBox.Size = new Size(774, 350);
            EmitirRemitogroupBox.TabIndex = 5;
            EmitirRemitogroupBox.TabStop = false;
            EmitirRemitogroupBox.Text = "Órdenes de preparación a despachar";
            // 
            // EmitirRemitoListView
            // 
            EmitirRemitoListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, Estado, IdOrdenEntrega, FechaEntrega });
            EmitirRemitoListView.FullRowSelect = true;
            EmitirRemitoListView.Location = new Point(19, 37);
            EmitirRemitoListView.Margin = new Padding(3, 4, 3, 4);
            EmitirRemitoListView.Name = "EmitirRemitoListView";
            EmitirRemitoListView.Size = new Size(735, 286);
            EmitirRemitoListView.TabIndex = 16;
            EmitirRemitoListView.UseCompatibleStateImageBehavior = false;
            EmitirRemitoListView.View = View.Details;
            // 
            // IdOrdenPreparacion
            // 
            IdOrdenPreparacion.Text = "N° Órden de Preparación";
            IdOrdenPreparacion.Width = 140;
            // 
            // Estado
            // 
            Estado.Text = "Estado";
            Estado.TextAlign = HorizontalAlignment.Center;
            Estado.Width = 140;
            // 
            // IdOrdenEntrega
            // 
            IdOrdenEntrega.Text = "N° Órden de Entrega";
            IdOrdenEntrega.TextAlign = HorizontalAlignment.Center;
            IdOrdenEntrega.Width = 140;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.TextAlign = HorizontalAlignment.Center;
            FechaEntrega.Width = 130;
            // 
            // EmitirRemitoButton
            // 
            EmitirRemitoButton.BackColor = SystemColors.Highlight;
            EmitirRemitoButton.Location = new Point(411, 572);
            EmitirRemitoButton.Margin = new Padding(3, 4, 3, 4);
            EmitirRemitoButton.Name = "EmitirRemitoButton";
            EmitirRemitoButton.Size = new Size(377, 50);
            EmitirRemitoButton.TabIndex = 6;
            EmitirRemitoButton.Text = "Despachar y Emitir Remito";
            EmitirRemitoButton.UseVisualStyleBackColor = false;
            EmitirRemitoButton.Click += MarcarOpDespachadaButton_Click;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(14, 572);
            VolverButton.Margin = new Padding(3, 4, 3, 4);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(377, 50);
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
            BuscarDespachoPendienteGroupBox.Size = new Size(774, 152);
            BuscarDespachoPendienteGroupBox.TabIndex = 8;
            BuscarDespachoPendienteGroupBox.TabStop = false;
            BuscarDespachoPendienteGroupBox.Text = "Buscar órdenes a despachar";
            // 
            // EmitirRemitoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 645);
            Controls.Add(VolverButton);
            Controls.Add(EmitirRemitoButton);
            Controls.Add(EmitirRemitogroupBox);
            Controls.Add(BuscarDespachoPendienteGroupBox);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmitirRemitoForm";
            Text = "Emitir Remito";
            FormClosing += EmitirRemitoForm_FormClosing;
            Load += EmitirRemito_Load;
            EmitirRemitogroupBox.ResumeLayout(false);
            BuscarDespachoPendienteGroupBox.ResumeLayout(false);
            BuscarDespachoPendienteGroupBox.PerformLayout();
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
        private ColumnHeader IdOrdenEntrega;
        private ColumnHeader FechaEntrega;
        private Button EmitirRemitoButton;
        private Button VolverButton;
        private ColumnHeader Estado;
        private GroupBox BuscarDespachoPendienteGroupBox;
    }
}