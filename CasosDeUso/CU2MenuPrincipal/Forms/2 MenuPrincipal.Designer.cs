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
            empaquetadoButton = new Button();
            emitirRemitoButton = new Button();
            SuspendLayout();
            // 
            // cargarOrdenPreparacionButton
            // 
            cargarOrdenPreparacionButton.Location = new Point(29, 29);
            cargarOrdenPreparacionButton.Margin = new Padding(3, 4, 3, 4);
            cargarOrdenPreparacionButton.Name = "cargarOrdenPreparacionButton";
            cargarOrdenPreparacionButton.Size = new Size(263, 31);
            cargarOrdenPreparacionButton.TabIndex = 0;
            cargarOrdenPreparacionButton.Text = "Cargar orden de preparación";
            cargarOrdenPreparacionButton.UseVisualStyleBackColor = true;
            cargarOrdenPreparacionButton.Click += buttonPrototipo_Click;
            // 
            // generarOrdenSeleccionButton
            // 
            generarOrdenSeleccionButton.Location = new Point(29, 76);
            generarOrdenSeleccionButton.Margin = new Padding(3, 4, 3, 4);
            generarOrdenSeleccionButton.Name = "generarOrdenSeleccionButton";
            generarOrdenSeleccionButton.Size = new Size(263, 31);
            generarOrdenSeleccionButton.TabIndex = 1;
            generarOrdenSeleccionButton.Text = "Generar órden de selección";
            generarOrdenSeleccionButton.UseVisualStyleBackColor = true;
            generarOrdenSeleccionButton.Click += ProcOrdenSeleccionButton_Click;
            // 
            // gestionarOrdenSeleccionButton
            // 
            gestionarOrdenSeleccionButton.Location = new Point(29, 123);
            gestionarOrdenSeleccionButton.Margin = new Padding(3, 4, 3, 4);
            gestionarOrdenSeleccionButton.Name = "gestionarOrdenSeleccionButton";
            gestionarOrdenSeleccionButton.Size = new Size(263, 31);
            gestionarOrdenSeleccionButton.TabIndex = 2;
            gestionarOrdenSeleccionButton.Text = "Gestionar órden de seleccion";
            gestionarOrdenSeleccionButton.UseVisualStyleBackColor = true;
            gestionarOrdenSeleccionButton.Click += confirmarSeleccionButton_Click;
            // 
            // empaquetarButton
            // 
            empaquetadoButton.Location = new Point(29, 170);
            empaquetadoButton.Margin = new Padding(3, 4, 3, 4);
            empaquetadoButton.Name = "empaquetarButton";
            empaquetadoButton.Size = new Size(263, 31);
            empaquetadoButton.TabIndex = 3;
            empaquetadoButton.Text = "Empaquetar";
            empaquetadoButton.UseVisualStyleBackColor = true;
            empaquetadoButton.Click += empaquetarButton_Click;
            // 
            // generarOrdenEntregaButton
            // 
            generarOrdenEntregaButton.Location = new Point(29, 217);
            generarOrdenEntregaButton.Margin = new Padding(3, 4, 3, 4);
            generarOrdenEntregaButton.Name = "generarOrdenEntregaButton";
            generarOrdenEntregaButton.Size = new Size(263, 31);
            generarOrdenEntregaButton.TabIndex = 4;
            generarOrdenEntregaButton.Text = "Generar órden de entrega";
            generarOrdenEntregaButton.UseVisualStyleBackColor = true;
            generarOrdenEntregaButton.Click += generarOrdenEntrega_Click;
            // 
            // emitirRemitoButton
            // 
            emitirRemitoButton.Location = new Point(29, 264);
            emitirRemitoButton.Margin = new Padding(3, 4, 3, 4);
            emitirRemitoButton.Name = "emitirRemitoButton";
            emitirRemitoButton.Size = new Size(263, 31);
            emitirRemitoButton.TabIndex = 5;
            emitirRemitoButton.Text = "Emitir remito";
            emitirRemitoButton.UseVisualStyleBackColor = true;
            emitirRemitoButton.Click += emitirRemitoButton_Click;
            
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(320, 332);
            Controls.Add(emitirRemitoButton);
            Controls.Add(generarOrdenEntregaButton);
            Controls.Add(gestionarOrdenSeleccionButton);
            Controls.Add(generarOrdenSeleccionButton);
            Controls.Add(cargarOrdenPreparacionButton);
            Controls.Add(empaquetadoButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuPrincipal";
            Text = "Menú Principal";
            Load += MenuPrincipal_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button cargarOrdenPreparacionButton;
        private Button generarOrdenSeleccionButton;
        private Button gestionarOrdenSeleccionButton;
        private Button empaquetadoButton;
        private Button generarOrdenEntregaButton;
        private Button emitirRemitoButton;
    }
}
