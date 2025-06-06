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
            CargarOrdenPreparacionButton.Location = new Point(11, 48);
            CargarOrdenPreparacionButton.Margin = new Padding(6, 6, 6, 6);
            CargarOrdenPreparacionButton.Name = "CargarOrdenPreparacionButton";
            CargarOrdenPreparacionButton.Size = new Size(761, 122);
            CargarOrdenPreparacionButton.TabIndex = 0;
            CargarOrdenPreparacionButton.Text = "Cargar Órden de Preparación";
            CargarOrdenPreparacionButton.UseVisualStyleBackColor = true;
            CargarOrdenPreparacionButton.Click += CargarOrdenPreparacionButton_Click;
            // 
            // SectorPrepatacionGroupBox
            // 
            SectorPrepatacionGroupBox.BackColor = SystemColors.Control;
            SectorPrepatacionGroupBox.Controls.Add(CargarOrdenEntregaButton);
            SectorPrepatacionGroupBox.Controls.Add(EmpaquetadoButton);
            SectorPrepatacionGroupBox.Controls.Add(GenerarOrdenSeleccionButton);
            SectorPrepatacionGroupBox.Controls.Add(CargarOrdenPreparacionButton);
            SectorPrepatacionGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            SectorPrepatacionGroupBox.Location = new Point(22, 56);
            SectorPrepatacionGroupBox.Margin = new Padding(6, 6, 6, 6);
            SectorPrepatacionGroupBox.Name = "SectorPrepatacionGroupBox";
            SectorPrepatacionGroupBox.Padding = new Padding(6, 6, 6, 6);
            SectorPrepatacionGroupBox.Size = new Size(795, 601);
            SectorPrepatacionGroupBox.TabIndex = 1;
            SectorPrepatacionGroupBox.TabStop = false;
            SectorPrepatacionGroupBox.Text = "Sector Preparación";
            // 
            // CargarOrdenEntregaButton
            // 
            CargarOrdenEntregaButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CargarOrdenEntregaButton.Location = new Point(11, 453);
            CargarOrdenEntregaButton.Margin = new Padding(6, 6, 6, 6);
            CargarOrdenEntregaButton.Name = "CargarOrdenEntregaButton";
            CargarOrdenEntregaButton.Size = new Size(761, 122);
            CargarOrdenEntregaButton.TabIndex = 3;
            CargarOrdenEntregaButton.Text = "Cargar Órden de Entrega";
            CargarOrdenEntregaButton.UseVisualStyleBackColor = true;
            CargarOrdenEntregaButton.Click += CargarOrdenDeEntregaButton_Click;
            // 
            // EmpaquetadoButton
            // 
            EmpaquetadoButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpaquetadoButton.Location = new Point(11, 314);
            EmpaquetadoButton.Margin = new Padding(6, 6, 6, 6);
            EmpaquetadoButton.Name = "EmpaquetadoButton";
            EmpaquetadoButton.Size = new Size(761, 122);
            EmpaquetadoButton.TabIndex = 2;
            EmpaquetadoButton.Text = "Empaquetar";
            EmpaquetadoButton.UseVisualStyleBackColor = true;
            EmpaquetadoButton.Click += EmpaquetadoButton_Click;
            // 
            // GenerarOrdenSeleccionButton
            // 
            GenerarOrdenSeleccionButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenerarOrdenSeleccionButton.Location = new Point(11, 181);
            GenerarOrdenSeleccionButton.Margin = new Padding(6, 6, 6, 6);
            GenerarOrdenSeleccionButton.Name = "GenerarOrdenSeleccionButton";
            GenerarOrdenSeleccionButton.Size = new Size(761, 122);
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
            SectorAlmacenGroupBox.Location = new Point(22, 727);
            SectorAlmacenGroupBox.Margin = new Padding(6, 6, 6, 6);
            SectorAlmacenGroupBox.Name = "SectorAlmacenGroupBox";
            SectorAlmacenGroupBox.Padding = new Padding(6, 6, 6, 6);
            SectorAlmacenGroupBox.Size = new Size(795, 192);
            SectorAlmacenGroupBox.TabIndex = 3;
            SectorAlmacenGroupBox.TabStop = false;
            SectorAlmacenGroupBox.Text = "Sector Almacén";
            // 
            // GestionarOrdenSeleccionButton
            // 
            GestionarOrdenSeleccionButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GestionarOrdenSeleccionButton.Location = new Point(11, 48);
            GestionarOrdenSeleccionButton.Margin = new Padding(6, 6, 6, 6);
            GestionarOrdenSeleccionButton.Name = "GestionarOrdenSeleccionButton";
            GestionarOrdenSeleccionButton.Size = new Size(761, 122);
            GestionarOrdenSeleccionButton.TabIndex = 0;
            GestionarOrdenSeleccionButton.Text = "Gestionar Órden de Selección";
            GestionarOrdenSeleccionButton.UseVisualStyleBackColor = true;
            GestionarOrdenSeleccionButton.Click += GestionarOrdenSeleccionButton_Click;
            // 
            // SectorDespachoGroupBox
            // 
            SectorDespachoGroupBox.BackColor = SystemColors.Control;
            SectorDespachoGroupBox.Controls.Add(EmitirRemitoButton);
            SectorDespachoGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            SectorDespachoGroupBox.Location = new Point(22, 988);
            SectorDespachoGroupBox.Margin = new Padding(6, 6, 6, 6);
            SectorDespachoGroupBox.Name = "SectorDespachoGroupBox";
            SectorDespachoGroupBox.Padding = new Padding(6, 6, 6, 6);
            SectorDespachoGroupBox.Size = new Size(795, 192);
            SectorDespachoGroupBox.TabIndex = 4;
            SectorDespachoGroupBox.TabStop = false;
            SectorDespachoGroupBox.Text = "Sector Despacho";
            // 
            // EmitirRemitoButton
            // 
            EmitirRemitoButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmitirRemitoButton.Location = new Point(11, 48);
            EmitirRemitoButton.Margin = new Padding(6, 6, 6, 6);
            EmitirRemitoButton.Name = "EmitirRemitoButton";
            EmitirRemitoButton.Size = new Size(761, 122);
            EmitirRemitoButton.TabIndex = 0;
            EmitirRemitoButton.Text = "Emitir Remito";
            EmitirRemitoButton.UseVisualStyleBackColor = true;
            EmitirRemitoButton.Click += EmitirRemitoButton_Click;
            // 
            // MenuPrincipalGeneralForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 1241);
            Controls.Add(SectorDespachoGroupBox);
            Controls.Add(SectorAlmacenGroupBox);
            Controls.Add(SectorPrepatacionGroupBox);
            Margin = new Padding(6, 6, 6, 6);
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