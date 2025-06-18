namespace TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms
{
    partial class MenuPrincipalGeneralForm
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
            CargarOrdenPreparacionButton = new Button();
            SectorPrepatacionGroupBox = new GroupBox();
            CargarOrdenEntregaButton = new Button();
            EmpaquetadoButton = new Button();
            GenerarOrdenSeleccionButton = new Button();
            SectorAlmacenGroupBox = new GroupBox();
            GestionarOrdenSeleccionButton = new Button();
            SectorDespachoGroupBox = new GroupBox();
            EmitirRemitoButton = new Button();
            SectorPrepatacionGroupBox.SuspendLayout();
            SectorAlmacenGroupBox.SuspendLayout();
            SectorDespachoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CargarOrdenPreparacionButton
            // 
            CargarOrdenPreparacionButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CargarOrdenPreparacionButton.Location = new Point(6, 25);
            CargarOrdenPreparacionButton.Name = "CargarOrdenPreparacionButton";
            CargarOrdenPreparacionButton.Size = new Size(406, 65);
            CargarOrdenPreparacionButton.TabIndex = 0;
            CargarOrdenPreparacionButton.Text = "Cargar Órden de Preparación";
            CargarOrdenPreparacionButton.UseVisualStyleBackColor = true;
            CargarOrdenPreparacionButton.Click += CargarOrdenPreparacionButton_Click;
            // 
            // SectorPrepatacionGroupBox
            // 
            SectorPrepatacionGroupBox.BackColor = SystemColors.Control;
            SectorPrepatacionGroupBox.Controls.Add(EmpaquetadoButton);
            SectorPrepatacionGroupBox.Controls.Add(GenerarOrdenSeleccionButton);
            SectorPrepatacionGroupBox.Controls.Add(CargarOrdenPreparacionButton);
            SectorPrepatacionGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            SectorPrepatacionGroupBox.Location = new Point(11, 31);
            SectorPrepatacionGroupBox.Name = "SectorPrepatacionGroupBox";
            SectorPrepatacionGroupBox.Size = new Size(424, 252);
            SectorPrepatacionGroupBox.TabIndex = 1;
            SectorPrepatacionGroupBox.TabStop = false;
            SectorPrepatacionGroupBox.Text = "Sector Preparación";
            // 
            // CargarOrdenEntregaButton
            // 
            CargarOrdenEntregaButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CargarOrdenEntregaButton.Location = new Point(6, 29);
            CargarOrdenEntregaButton.Name = "CargarOrdenEntregaButton";
            CargarOrdenEntregaButton.Size = new Size(406, 65);
            CargarOrdenEntregaButton.TabIndex = 3;
            CargarOrdenEntregaButton.Text = "Confirmar Órden de Entrega";
            CargarOrdenEntregaButton.UseVisualStyleBackColor = true;
            CargarOrdenEntregaButton.Click += ConfirmarOrdenDeEntregaButton_Click;
            // 
            // EmpaquetadoButton
            // 
            EmpaquetadoButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpaquetadoButton.Location = new Point(6, 169);
            EmpaquetadoButton.Name = "EmpaquetadoButton";
            EmpaquetadoButton.Size = new Size(406, 65);
            EmpaquetadoButton.TabIndex = 2;
            EmpaquetadoButton.Text = "Empaquetar";
            EmpaquetadoButton.UseVisualStyleBackColor = true;
            EmpaquetadoButton.Click += EmpaquetadoButton_Click;
            // 
            // GenerarOrdenSeleccionButton
            // 
            GenerarOrdenSeleccionButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenerarOrdenSeleccionButton.Location = new Point(6, 97);
            GenerarOrdenSeleccionButton.Name = "GenerarOrdenSeleccionButton";
            GenerarOrdenSeleccionButton.Size = new Size(406, 65);
            GenerarOrdenSeleccionButton.TabIndex = 1;
            GenerarOrdenSeleccionButton.Text = "Generar Órden de Selección";
            GenerarOrdenSeleccionButton.UseVisualStyleBackColor = true;
            GenerarOrdenSeleccionButton.Click += GenerarOrdenSeleccionButton_Click;
            // 
            // SectorAlmacenGroupBox
            // 
            SectorAlmacenGroupBox.BackColor = SystemColors.Control;
            SectorAlmacenGroupBox.Controls.Add(GestionarOrdenSeleccionButton);
            SectorAlmacenGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            SectorAlmacenGroupBox.Location = new Point(12, 299);
            SectorAlmacenGroupBox.Name = "SectorAlmacenGroupBox";
            SectorAlmacenGroupBox.Size = new Size(424, 104);
            SectorAlmacenGroupBox.TabIndex = 3;
            SectorAlmacenGroupBox.TabStop = false;
            SectorAlmacenGroupBox.Text = "Sector Almacén";
            // 
            // GestionarOrdenSeleccionButton
            // 
            GestionarOrdenSeleccionButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GestionarOrdenSeleccionButton.Location = new Point(6, 25);
            GestionarOrdenSeleccionButton.Name = "GestionarOrdenSeleccionButton";
            GestionarOrdenSeleccionButton.Size = new Size(406, 65);
            GestionarOrdenSeleccionButton.TabIndex = 0;
            GestionarOrdenSeleccionButton.Text = "Gestionar Órden de Selección";
            GestionarOrdenSeleccionButton.UseVisualStyleBackColor = true;
            GestionarOrdenSeleccionButton.Click += GestionarOrdenSeleccionButton_Click;
            // 
            // SectorDespachoGroupBox
            // 
            SectorDespachoGroupBox.BackColor = SystemColors.Control;
            SectorDespachoGroupBox.Controls.Add(CargarOrdenEntregaButton);
            SectorDespachoGroupBox.Controls.Add(EmitirRemitoButton);
            SectorDespachoGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            SectorDespachoGroupBox.Location = new Point(12, 425);
            SectorDespachoGroupBox.Name = "SectorDespachoGroupBox";
            SectorDespachoGroupBox.Size = new Size(424, 181);
            SectorDespachoGroupBox.TabIndex = 4;
            SectorDespachoGroupBox.TabStop = false;
            SectorDespachoGroupBox.Text = "Sector Despacho";
            // 
            // EmitirRemitoButton
            // 
            EmitirRemitoButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmitirRemitoButton.Location = new Point(6, 100);
            EmitirRemitoButton.Name = "EmitirRemitoButton";
            EmitirRemitoButton.Size = new Size(406, 65);
            EmitirRemitoButton.TabIndex = 0;
            EmitirRemitoButton.Text = "Emitir Remito";
            EmitirRemitoButton.UseVisualStyleBackColor = true;
            EmitirRemitoButton.Click += EmitirRemitoButton_Click;
            // 
            // MenuPrincipalGeneralForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 623);
            Controls.Add(SectorDespachoGroupBox);
            Controls.Add(SectorAlmacenGroupBox);
            Controls.Add(SectorPrepatacionGroupBox);
            Name = "MenuPrincipalGeneralForm";
            Text = "Menú principal";
            SectorPrepatacionGroupBox.ResumeLayout(false);
            SectorAlmacenGroupBox.ResumeLayout(false);
            SectorDespachoGroupBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button CargarOrdenPreparacionButton;
        private GroupBox SectorPrepatacionGroupBox;
        private Button EmpaquetadoButton;
        private Button GenerarOrdenSeleccionButton;
        private Button CargarOrdenEntregaButton;
        private GroupBox SectorAlmacenGroupBox;
        private Button GestionarOrdenSeleccionButton;
        private GroupBox SectorDespachoGroupBox;
        private Button EmitirRemitoButton;
    }
}