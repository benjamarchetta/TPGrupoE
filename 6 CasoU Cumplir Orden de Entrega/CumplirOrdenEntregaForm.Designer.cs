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
            generarEntregaListView = new ListView();
            fechaColumna = new ColumnHeader();
            idOrdenColumna = new ColumnHeader();
            skuColumna = new ColumnHeader();
            cantidadColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // generarEntregaListView
            // 
            generarEntregaListView.Columns.AddRange(new ColumnHeader[] { fechaColumna, idOrdenColumna, skuColumna, cantidadColumna, idClienteColumna });
            generarEntregaListView.FullRowSelect = true;
            generarEntregaListView.Location = new Point(12, 30);
            generarEntregaListView.Name = "generarEntregaListView";
            generarEntregaListView.Size = new Size(776, 175);
            generarEntregaListView.TabIndex = 3;
            generarEntregaListView.UseCompatibleStateImageBehavior = false;
            generarEntregaListView.View = View.Details;
            generarEntregaListView.SelectedIndexChanged += generarEntregaListView_SelectedIndexChanged;
            // 
            // fechaColumna
            // 
            fechaColumna.Text = "Fecha de despacho";
            fechaColumna.Width = 160;
            // 
            // idOrdenColumna
            // 
            idOrdenColumna.Text = "ID de Orden";
            idOrdenColumna.Width = 160;
            // 
            // skuColumna
            // 
            skuColumna.DisplayIndex = 3;
            skuColumna.Text = "SKU de producto";
            skuColumna.Width = 160;
            // 
            // cantidadColumna
            // 
            cantidadColumna.DisplayIndex = 4;
            cantidadColumna.Text = "Cantidad";
            cantidadColumna.Width = 160;
            // 
            // idClienteColumna
            // 
            idClienteColumna.DisplayIndex = 2;
            idClienteColumna.Text = "ID del Cliente";
            idClienteColumna.Width = 160;
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
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 286);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 23);
            textBox1.TabIndex = 5;
            textBox1.Text = "Nombre-Apellido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 268);
            label2.Name = "label2";
            label2.Size = new Size(193, 15);
            label2.TabIndex = 6;
            label2.Text = "Nombre y apellido del transportista";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 224);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 7;
            label3.Text = "DNI del transportista";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 242);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 23);
            textBox2.TabIndex = 8;
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
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(generarEntregaListView);
            Name = "CumplirOrdenEntregaForm";
            Text = "Cumplir Orden de Entrega";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView generarEntregaListView;
        private ColumnHeader fechaColumna;
        private ColumnHeader idOrdenColumna;
        private ColumnHeader skuColumna;
        private ColumnHeader cantidadColumna;
        private ColumnHeader idClienteColumna;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
    }
}