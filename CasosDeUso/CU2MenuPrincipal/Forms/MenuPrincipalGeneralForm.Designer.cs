﻿namespace TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms
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
            CargarOrdenPreparacionButton.Location = new Point(5, 19);
            CargarOrdenPreparacionButton.Margin = new Padding(3, 2, 3, 2);
            CargarOrdenPreparacionButton.Name = "CargarOrdenPreparacionButton";
            CargarOrdenPreparacionButton.Size = new Size(355, 49);
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
            SectorPrepatacionGroupBox.Location = new Point(10, 23);
            SectorPrepatacionGroupBox.Margin = new Padding(3, 2, 3, 2);
            SectorPrepatacionGroupBox.Name = "SectorPrepatacionGroupBox";
            SectorPrepatacionGroupBox.Padding = new Padding(3, 2, 3, 2);
            SectorPrepatacionGroupBox.Size = new Size(371, 244);
            SectorPrepatacionGroupBox.TabIndex = 1;
            SectorPrepatacionGroupBox.TabStop = false;
            SectorPrepatacionGroupBox.Text = "Sector Preparación";
            // 
            // CargarOrdenEntregaButton
            // 
            CargarOrdenEntregaButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CargarOrdenEntregaButton.Location = new Point(5, 184);
            CargarOrdenEntregaButton.Margin = new Padding(3, 2, 3, 2);
            CargarOrdenEntregaButton.Name = "CargarOrdenEntregaButton";
            CargarOrdenEntregaButton.Size = new Size(355, 49);
            CargarOrdenEntregaButton.TabIndex = 3;
            CargarOrdenEntregaButton.Text = "Cargar Órden de Entrega";
            CargarOrdenEntregaButton.UseVisualStyleBackColor = true;
            CargarOrdenEntregaButton.Click += CargarOrdenDeEntregaButton_Click;
            // 
            // EmpaquetadoButton
            // 
            EmpaquetadoButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmpaquetadoButton.Location = new Point(5, 127);
            EmpaquetadoButton.Margin = new Padding(3, 2, 3, 2);
            EmpaquetadoButton.Name = "EmpaquetadoButton";
            EmpaquetadoButton.Size = new Size(355, 49);
            EmpaquetadoButton.TabIndex = 2;
            EmpaquetadoButton.Text = "Empaquetar";
            EmpaquetadoButton.UseVisualStyleBackColor = true;
            EmpaquetadoButton.Click += EmpaquetadoButton_Click;
            // 
            // GenerarOrdenSeleccionButton
            // 
            GenerarOrdenSeleccionButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GenerarOrdenSeleccionButton.Location = new Point(5, 73);
            GenerarOrdenSeleccionButton.Margin = new Padding(3, 2, 3, 2);
            GenerarOrdenSeleccionButton.Name = "GenerarOrdenSeleccionButton";
            GenerarOrdenSeleccionButton.Size = new Size(355, 49);
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
            SectorAlmacenGroupBox.Location = new Point(10, 295);
            SectorAlmacenGroupBox.Margin = new Padding(3, 2, 3, 2);
            SectorAlmacenGroupBox.Name = "SectorAlmacenGroupBox";
            SectorAlmacenGroupBox.Padding = new Padding(3, 2, 3, 2);
            SectorAlmacenGroupBox.Size = new Size(371, 78);
            SectorAlmacenGroupBox.TabIndex = 3;
            SectorAlmacenGroupBox.TabStop = false;
            SectorAlmacenGroupBox.Text = "Sector Almacén";
            // 
            // GestionarOrdenSeleccionButton
            // 
            GestionarOrdenSeleccionButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            GestionarOrdenSeleccionButton.Location = new Point(5, 19);
            GestionarOrdenSeleccionButton.Margin = new Padding(3, 2, 3, 2);
            GestionarOrdenSeleccionButton.Name = "GestionarOrdenSeleccionButton";
            GestionarOrdenSeleccionButton.Size = new Size(355, 49);
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
            SectorDespachoGroupBox.Location = new Point(10, 401);
            SectorDespachoGroupBox.Margin = new Padding(3, 2, 3, 2);
            SectorDespachoGroupBox.Name = "SectorDespachoGroupBox";
            SectorDespachoGroupBox.Padding = new Padding(3, 2, 3, 2);
            SectorDespachoGroupBox.Size = new Size(371, 78);
            SectorDespachoGroupBox.TabIndex = 4;
            SectorDespachoGroupBox.TabStop = false;
            SectorDespachoGroupBox.Text = "Sector Despacho";
            // 
            // EmitirRemitoButton
            // 
            EmitirRemitoButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EmitirRemitoButton.Location = new Point(5, 19);
            EmitirRemitoButton.Margin = new Padding(3, 2, 3, 2);
            EmitirRemitoButton.Name = "EmitirRemitoButton";
            EmitirRemitoButton.Size = new Size(355, 49);
            EmitirRemitoButton.TabIndex = 0;
            EmitirRemitoButton.Text = "Emitir Remito";
            EmitirRemitoButton.UseVisualStyleBackColor = true;
            EmitirRemitoButton.Click += EmitirRemitoButton_Click;
            // 
            // MenuPrincipalGeneralForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(392, 517);
            Controls.Add(SectorDespachoGroupBox);
            Controls.Add(SectorAlmacenGroupBox);
            Controls.Add(SectorPrepatacionGroupBox);
            Margin = new Padding(3, 2, 3, 2);
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