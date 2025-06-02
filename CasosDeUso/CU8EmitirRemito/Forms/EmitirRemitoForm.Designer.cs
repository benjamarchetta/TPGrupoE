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
            Seleccionarbutton = new Button();
            EmitirRemitogroupBox = new GroupBox();
            EmitirRemitoListView = new ListView();
            IdOrdenPreparacion = new ColumnHeader();
            IdOrdenEntrega = new ColumnHeader();
            FechaEntrega = new ColumnHeader();
            EmitirRemitoButton = new Button();
            VolverButton = new Button();
            EmitirRemitogroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // TransportistaLabel
            // 
            TransportistaLabel.AutoSize = true;
            TransportistaLabel.Location = new Point(12, 9);
            TransportistaLabel.Name = "TransportistaLabel";
            TransportistaLabel.Size = new Size(216, 15);
            TransportistaLabel.TabIndex = 0;
            TransportistaLabel.Text = "Transportistas con Ordenes a Despachar";
            // 
            // ClienteLabel
            // 
            ClienteLabel.AutoSize = true;
            ClienteLabel.Location = new Point(12, 64);
            ClienteLabel.Name = "ClienteLabel";
            ClienteLabel.Size = new Size(44, 15);
            ClienteLabel.TabIndex = 1;
            ClienteLabel.Text = "Cliente";
            // 
            // TransportistaComboBox
            // 
            TransportistaComboBox.FormattingEnabled = true;
            TransportistaComboBox.Location = new Point(12, 27);
            TransportistaComboBox.Name = "TransportistaComboBox";
            TransportistaComboBox.Size = new Size(254, 23);
            TransportistaComboBox.TabIndex = 2;
            // 
            // ClienteComboBox
            // 
            ClienteComboBox.FormattingEnabled = true;
            ClienteComboBox.Location = new Point(12, 82);
            ClienteComboBox.Name = "ClienteComboBox";
            ClienteComboBox.Size = new Size(254, 23);
            ClienteComboBox.TabIndex = 3;
            // 
            // Seleccionarbutton
            // 
            Seleccionarbutton.Location = new Point(285, 64);
            Seleccionarbutton.Name = "Seleccionarbutton";
            Seleccionarbutton.Size = new Size(164, 41);
            Seleccionarbutton.TabIndex = 4;
            Seleccionarbutton.Text = "Seleccionar";
            Seleccionarbutton.UseVisualStyleBackColor = true;
            // 
            // EmitirRemitogroupBox
            // 
            EmitirRemitogroupBox.Controls.Add(EmitirRemitoListView);
            EmitirRemitogroupBox.Location = new Point(12, 129);
            EmitirRemitogroupBox.Name = "EmitirRemitogroupBox";
            EmitirRemitogroupBox.Size = new Size(447, 293);
            EmitirRemitogroupBox.TabIndex = 5;
            EmitirRemitogroupBox.TabStop = false;
            EmitirRemitogroupBox.Text = "Ordenes de Preparación a Despachar";
            // 
            // EmitirRemitoListView
            // 
            EmitirRemitoListView.Columns.AddRange(new ColumnHeader[] { IdOrdenPreparacion, IdOrdenEntrega, FechaEntrega });
            EmitirRemitoListView.FullRowSelect = true;
            EmitirRemitoListView.Location = new Point(6, 32);
            EmitirRemitoListView.Name = "EmitirRemitoListView";
            EmitirRemitoListView.Size = new Size(431, 255);
            EmitirRemitoListView.TabIndex = 16;
            EmitirRemitoListView.UseCompatibleStateImageBehavior = false;
            EmitirRemitoListView.View = View.Details;
            // 
            // IdOrdenPreparacion
            // 
            IdOrdenPreparacion.Text = "Id Orden de Preparacion";
            IdOrdenPreparacion.Width = 140;
            // 
            // IdOrdenEntrega
            // 
            IdOrdenEntrega.Text = "Id Orden de Entrega";
            IdOrdenEntrega.Width = 140;
            // 
            // FechaEntrega
            // 
            FechaEntrega.Text = "Fecha de Entrega";
            FechaEntrega.Width = 130;
            // 
            // EmitirRemitoButton
            // 
            EmitirRemitoButton.Location = new Point(18, 428);
            EmitirRemitoButton.Name = "EmitirRemitoButton";
            EmitirRemitoButton.Size = new Size(210, 44);
            EmitirRemitoButton.TabIndex = 6;
            EmitirRemitoButton.Text = "Despachar y Emitir Remito";
            EmitirRemitoButton.UseVisualStyleBackColor = true;
            // 
            // VolverButton
            // 
            VolverButton.Location = new Point(234, 428);
            VolverButton.Name = "VolverButton";
            VolverButton.Size = new Size(215, 44);
            VolverButton.TabIndex = 7;
            VolverButton.Text = "Volver al Menú Principal";
            VolverButton.UseVisualStyleBackColor = true;
            // 
            // EmitirRemitoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 484);
            Controls.Add(VolverButton);
            Controls.Add(EmitirRemitoButton);
            Controls.Add(EmitirRemitogroupBox);
            Controls.Add(Seleccionarbutton);
            Controls.Add(ClienteComboBox);
            Controls.Add(TransportistaComboBox);
            Controls.Add(ClienteLabel);
            Controls.Add(TransportistaLabel);
            Name = "EmitirRemitoForm";
            Text = "Emitir Remito";
            EmitirRemitogroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TransportistaLabel;
        private Label ClienteLabel;
        private ComboBox TransportistaComboBox;
        private ComboBox ClienteComboBox;
        private Button Seleccionarbutton;
        private GroupBox EmitirRemitogroupBox;
        private ListView EmitirRemitoListView;
        private ColumnHeader IdOrdenPreparacion;
        private ColumnHeader IdOrdenEntrega;
        private ColumnHeader FechaEntrega;
        private Button EmitirRemitoButton;
        private Button VolverButton;
    }
}