namespace TPGrupoE.CasoU_Generar_Orden_de_Despacho
{
    partial class CumplirOrdenEntregaForm
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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 4;
            label1.Text = "Ordenes de entrega";
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(634, 337);
            button1.Name = "button1";
            button1.Size = new Size(154, 23);
            button1.TabIndex = 9;
            button1.Text = "Cumplir orden de entrega";
            button1.UseVisualStyleBackColor = true;
            // 
            // CumplirOrdenEntregaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 372);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "CumplirOrdenEntregaForm";
            Text = "Cumplir Orden de Entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button button1;
    }
}