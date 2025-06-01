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
            cargarOrdenPreparacionButton = new Button();
            generarOrdenSeleccionButton = new Button();
            gestionarOrdenSeleccionButton = new Button();
            generarOrdenEntregaButton = new Button();
            emitirRemitoButton = new Button();
            SuspendLayout();
            // 
            // cargarOrdenPreparacionButton
            // 
            cargarOrdenPreparacionButton.Location = new Point(25, 22);
            cargarOrdenPreparacionButton.Name = "cargarOrdenPreparacionButton";
            cargarOrdenPreparacionButton.Size = new Size(230, 23);
            cargarOrdenPreparacionButton.TabIndex = 0;
            cargarOrdenPreparacionButton.Text = "Cargar orden de preparación";
            cargarOrdenPreparacionButton.UseVisualStyleBackColor = true;
            cargarOrdenPreparacionButton.Click += buttonPrototipo_Click;
            // 
            // generarOrdenSeleccionButton
            // 
            generarOrdenSeleccionButton.Location = new Point(25, 57);
            generarOrdenSeleccionButton.Name = "generarOrdenSeleccionButton";
            generarOrdenSeleccionButton.Size = new Size(230, 23);
            generarOrdenSeleccionButton.TabIndex = 1;
            generarOrdenSeleccionButton.Text = "Generar órden de selección";
            generarOrdenSeleccionButton.UseVisualStyleBackColor = true;
            generarOrdenSeleccionButton.Click += ProcOrdenSeleccionButton_Click;
            // 
            // gestionarOrdenSeleccionButton
            // 
            gestionarOrdenSeleccionButton.Location = new Point(25, 92);
            gestionarOrdenSeleccionButton.Name = "gestionarOrdenSeleccionButton";
            gestionarOrdenSeleccionButton.Size = new Size(230, 23);
            gestionarOrdenSeleccionButton.TabIndex = 2;
            gestionarOrdenSeleccionButton.Text = "Gestionar órden de seleccion";
            gestionarOrdenSeleccionButton.UseVisualStyleBackColor = true;
            gestionarOrdenSeleccionButton.Click += confirmarSeleccionButton_Click;
            // 
            // generarOrdenEntregaButton
            // 
            generarOrdenEntregaButton.Location = new Point(25, 127);
            generarOrdenEntregaButton.Name = "generarOrdenEntregaButton";
            generarOrdenEntregaButton.Size = new Size(230, 23);
            generarOrdenEntregaButton.TabIndex = 3;
            generarOrdenEntregaButton.Text = "Generar órden de entrega";
            generarOrdenEntregaButton.UseVisualStyleBackColor = true;
            generarOrdenEntregaButton.Click += generarOrdenEntrega_Click;
            // 
            // emitirRemitoButton
            // 
            emitirRemitoButton.Location = new Point(25, 162);
            emitirRemitoButton.Name = "emitirRemitoButton";
            emitirRemitoButton.Size = new Size(230, 23);
            emitirRemitoButton.TabIndex = 4;
            emitirRemitoButton.Text = "Emitir remito";
            emitirRemitoButton.UseVisualStyleBackColor = true;
            emitirRemitoButton.Click += EmitirRemitoButton_Click;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 249);
            Controls.Add(emitirRemitoButton);
            Controls.Add(generarOrdenEntregaButton);
            Controls.Add(gestionarOrdenSeleccionButton);
            Controls.Add(generarOrdenSeleccionButton);
            Controls.Add(cargarOrdenPreparacionButton);
            Name = "MenuPrincipal";
            Text = "Menú Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button cargarOrdenPreparacionButton;
        private Button generarOrdenSeleccionButton;
        private Button gestionarOrdenSeleccionButton;
        private Button generarOrdenEntregaButton;
        private Button emitirRemitoButton;
    }
}
