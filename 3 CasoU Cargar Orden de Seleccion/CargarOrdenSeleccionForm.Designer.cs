namespace TPGrupoE.CasoU_Procesar_Orden_de_Seleccion
{
    partial class CargarOrdenSeleccionForm
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
            orednPreparacionParaSelecListView = new ListView();
            fechaColumna = new ColumnHeader();
            idOrdenColumna = new ColumnHeader();
            skuColumna = new ColumnHeader();
            cantidadColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            button1 = new Button();
            listView2 = new ListView();
            skuColumnaSelec = new ColumnHeader();
            cantidadColumnaSelec = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            button2 = new Button();
            label2 = new Label();
            eliminarDeSeleccionButton = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(133, 15);
            label1.TabIndex = 0;
            label1.Text = "Ordenes de preparacion";
            // 
            // orednPreparacionParaSelecListView
            // 
            orednPreparacionParaSelecListView.Columns.AddRange(new ColumnHeader[] { fechaColumna, idOrdenColumna, skuColumna, cantidadColumna, idClienteColumna, columnHeader1 });
            orednPreparacionParaSelecListView.FullRowSelect = true;
            orednPreparacionParaSelecListView.Location = new Point(12, 27);
            orednPreparacionParaSelecListView.Name = "orednPreparacionParaSelecListView";
            orednPreparacionParaSelecListView.Size = new Size(776, 175);
            orednPreparacionParaSelecListView.TabIndex = 1;
            orednPreparacionParaSelecListView.UseCompatibleStateImageBehavior = false;
            orednPreparacionParaSelecListView.View = View.Details;
            // 
            // fechaColumna
            // 
            fechaColumna.Text = "Fecha de despacho";
            fechaColumna.Width = 135;
            // 
            // idOrdenColumna
            // 
            idOrdenColumna.Text = "ID de Orden";
            idOrdenColumna.Width = 135;
            // 
            // skuColumna
            // 
            skuColumna.DisplayIndex = 3;
            skuColumna.Text = "SKU de producto";
            skuColumna.Width = 135;
            // 
            // cantidadColumna
            // 
            cantidadColumna.DisplayIndex = 4;
            cantidadColumna.Text = "Cantidad";
            cantidadColumna.Width = 135;
            // 
            // idClienteColumna
            // 
            idClienteColumna.DisplayIndex = 2;
            idClienteColumna.Text = "ID del Cliente";
            idClienteColumna.Width = 135;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Palet cerrado";
            columnHeader1.Width = 135;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(620, 208);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 2;
            button1.Text = "Agregar a orden de seleccion";
            button1.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { skuColumnaSelec, cantidadColumnaSelec, columnHeader2 });
            listView2.Location = new Point(12, 268);
            listView2.Name = "listView2";
            listView2.Size = new Size(776, 153);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // skuColumnaSelec
            // 
            skuColumnaSelec.Text = "SKU de producto";
            skuColumnaSelec.Width = 270;
            // 
            // cantidadColumnaSelec
            // 
            cantidadColumnaSelec.Text = "Cantidad a retirar";
            cantidadColumnaSelec.Width = 270;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Palet cerrado";
            columnHeader2.Width = 270;
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(443, 479);
            button2.Name = "button2";
            button2.Size = new Size(155, 23);
            button2.TabIndex = 4;
            button2.Text = "Cargar orden de seleccion";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 250);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 5;
            label2.Text = "Orden de seleccion";
            // 
            // eliminarDeSeleccionButton
            // 
            eliminarDeSeleccionButton.Enabled = false;
            eliminarDeSeleccionButton.Location = new Point(604, 479);
            eliminarDeSeleccionButton.Name = "eliminarDeSeleccionButton";
            eliminarDeSeleccionButton.Size = new Size(184, 23);
            eliminarDeSeleccionButton.TabIndex = 6;
            eliminarDeSeleccionButton.Text = "Eliminar de orden de seleccion";
            eliminarDeSeleccionButton.UseVisualStyleBackColor = true;
            eliminarDeSeleccionButton.Click += eliminarDeSeleccionButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 433);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 7;
            label3.Text = "ID de Orden de seleccion";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 451);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(164, 23);
            textBox1.TabIndex = 8;
            textBox1.Text = "XXXXXX";
            // 
            // CargarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(eliminarDeSeleccionButton);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(listView2);
            Controls.Add(button1);
            Controls.Add(orednPreparacionParaSelecListView);
            Controls.Add(label1);
            Name = "CargarOrdenSeleccionForm";
            Text = "Cargar orden de seleccion";
            Load += ProcesarOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView orednPreparacionParaSelecListView;
        private ColumnHeader fechaColumna;
        private ColumnHeader idOrdenColumna;
        private ColumnHeader idClienteColumna;
        private ColumnHeader skuColumna;
        private ColumnHeader cantidadColumna;
        private Button button1;
        private ListView listView2;
        private Button button2;
        private ColumnHeader skuColumnaSelec;
        private ColumnHeader cantidadColumnaSelec;
        private Label label2;
        private Button eliminarDeSeleccionButton;
        private Label label3;
        private TextBox textBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}