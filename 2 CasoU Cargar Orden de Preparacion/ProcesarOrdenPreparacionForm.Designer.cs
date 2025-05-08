namespace TPGrupoE.CasoU_Orden_Preparacion
{
    partial class ProcesarOrdenPreparacionForm
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
            textBox1 = new TextBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cantidadARetirarTextBox = new TextBox();
            button1 = new Button();
            textBox4 = new TextBox();
            label6 = new Label();
            button2 = new Button();
            button3 = new Button();
            listView2 = new ListView();
            skuColumnaSelec = new ColumnHeader();
            cantidadColumnaSelec = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "ID de Orden";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(335, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "XXXXXX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 417);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de despacho de orden";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 435);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(335, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 53);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 4;
            label3.Text = "CUIT del cliente";
            label3.Click += label3_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 71);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(335, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 155);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(351, 23);
            textBox3.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 137);
            label4.Name = "label4";
            label4.Size = new Size(96, 15);
            label4.TabIndex = 7;
            label4.Text = "SKU de producto";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(357, 137);
            label5.Name = "label5";
            label5.Size = new Size(98, 15);
            label5.TabIndex = 8;
            label5.Text = "Cantidad a retirar";
            // 
            // cantidadARetirarTextBox
            // 
            cantidadARetirarTextBox.Location = new Point(369, 155);
            cantidadARetirarTextBox.Name = "cantidadARetirarTextBox";
            cantidadARetirarTextBox.Size = new Size(334, 23);
            cantidadARetirarTextBox.TabIndex = 9;
            cantidadARetirarTextBox.TextChanged += cantidadARetirarTextBox_TextChanged;
            cantidadARetirarTextBox.KeyPress += cantidadARetirarTextBox_KeyPress;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(617, 495);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 10;
            button1.Text = "Cargar orden de preparacion";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(357, 71);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(335, 23);
            textBox4.TabIndex = 11;
            textBox4.Text = "Nombre-Apellido";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(357, 53);
            label6.Name = "label6";
            label6.Size = new Size(108, 15);
            label6.TabIndex = 12;
            label6.Text = "Nombre del cliente";
            // 
            // button2
            // 
            button2.Enabled = false;
            button2.Location = new Point(713, 155);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 13;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(713, 380);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 14;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { skuColumnaSelec, cantidadColumnaSelec });
            listView2.Location = new Point(12, 221);
            listView2.Name = "listView2";
            listView2.Size = new Size(776, 153);
            listView2.TabIndex = 15;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // skuColumnaSelec
            // 
            skuColumnaSelec.Text = "SKU de producto";
            skuColumnaSelec.Width = 350;
            // 
            // cantidadColumnaSelec
            // 
            cantidadColumnaSelec.Text = "Cantidad a retirar";
            cantidadColumnaSelec.Width = 350;
            // 
            // ProcesarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 530);
            Controls.Add(listView2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(button1);
            Controls.Add(cantidadARetirarTextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "ProcesarOrdenPreparacionForm";
            Text = "Cargar Orden de Preparacion";
            Load += ProcesarOrdenPreparacion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox cantidadARetirarTextBox;
        private Button button1;
        private TextBox textBox4;
        private Label label6;
        private Button button2;
        private Button button3;
        private ListView listView2;
        private ColumnHeader skuColumnaSelec;
        private ColumnHeader cantidadColumnaSelec;
    }
}