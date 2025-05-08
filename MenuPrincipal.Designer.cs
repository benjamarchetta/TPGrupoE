namespace TPGrupoE
{
    partial class MenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonPrototipo = new Button();
            ProcOrdenSeleccionButton = new Button();
            confirmarSeleccionButton = new Button();
            generarOrdenEntregaButton = new Button();
            GenerarOrdenDespachoButton = new Button();
            SuspendLayout();
            // 
            // buttonPrototipo
            // 
            buttonPrototipo.Location = new Point(25, 22);
            buttonPrototipo.Name = "buttonPrototipo";
            buttonPrototipo.Size = new Size(230, 23);
            buttonPrototipo.TabIndex = 0;
            buttonPrototipo.Text = "Cargar orden de preparación";
            buttonPrototipo.UseVisualStyleBackColor = true;
            buttonPrototipo.Click += buttonPrototipo_Click;
            // 
            // ProcOrdenSeleccionButton
            // 
            ProcOrdenSeleccionButton.Location = new Point(25, 57);
            ProcOrdenSeleccionButton.Name = "ProcOrdenSeleccionButton";
            ProcOrdenSeleccionButton.Size = new Size(230, 23);
            ProcOrdenSeleccionButton.TabIndex = 1;
            ProcOrdenSeleccionButton.Text = "Cargar orden de seleccion";
            ProcOrdenSeleccionButton.UseVisualStyleBackColor = true;
            ProcOrdenSeleccionButton.Click += ProcOrdenSeleccionButton_Click;
            // 
            // confirmarSeleccionButton
            // 
            confirmarSeleccionButton.Location = new Point(25, 92);
            confirmarSeleccionButton.Name = "confirmarSeleccionButton";
            confirmarSeleccionButton.Size = new Size(230, 23);
            confirmarSeleccionButton.TabIndex = 2;
            confirmarSeleccionButton.Text = "Cumplir orden de seleccion";
            confirmarSeleccionButton.UseVisualStyleBackColor = true;
            confirmarSeleccionButton.Click += confirmarSeleccionButton_Click;
            // 
            // generarOrdenEntregaButton
            // 
            generarOrdenEntregaButton.Location = new Point(25, 127);
            generarOrdenEntregaButton.Name = "generarOrdenEntregaButton";
            generarOrdenEntregaButton.Size = new Size(230, 23);
            generarOrdenEntregaButton.TabIndex = 3;
            generarOrdenEntregaButton.Text = "Cargar orden de entrega";
            generarOrdenEntregaButton.UseVisualStyleBackColor = true;
            generarOrdenEntregaButton.Click += generarOrdenEntrega_Click;
            // 
            // GenerarOrdenDespachoButton
            // 
            GenerarOrdenDespachoButton.Location = new Point(25, 162);
            GenerarOrdenDespachoButton.Name = "GenerarOrdenDespachoButton";
            GenerarOrdenDespachoButton.Size = new Size(230, 23);
            GenerarOrdenDespachoButton.TabIndex = 4;
            GenerarOrdenDespachoButton.Text = "Cumplir orden de entrega";
            GenerarOrdenDespachoButton.UseVisualStyleBackColor = true;
            GenerarOrdenDespachoButton.Click += GenerarOrdenDespachoButton_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 249);
            Controls.Add(GenerarOrdenDespachoButton);
            Controls.Add(generarOrdenEntregaButton);
            Controls.Add(confirmarSeleccionButton);
            Controls.Add(ProcOrdenSeleccionButton);
            Controls.Add(buttonPrototipo);
            Name = "MenuPrincipal";
            Text = "Menú Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPrototipo;
        private Button ProcOrdenSeleccionButton;
        private Button confirmarSeleccionButton;
        private Button generarOrdenEntregaButton;
        private Button GenerarOrdenDespachoButton;
    }
}
