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
            button1 = new Button();
            button3 = new Button();
            listView2 = new ListView();
            skuColumnaSelec = new ColumnHeader();
            cantidadColumnaSelec = new ColumnHeader();
            palletColumnaPrep = new ColumnHeader();
            ubicacionColumnaPrep = new ColumnHeader();
            comboBox1 = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            comboBox2 = new ComboBox();
            label3 = new Label();
            label6 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label9 = new Label();
            comboBox3 = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            textBox6 = new TextBox();
            button4 = new Button();
            label4 = new Label();
            label5 = new Label();
            comboBox4 = new ComboBox();
            label12 = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 544);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "ID de Orden";
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(12, 562);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 1;
            textBox1.Text = "XX";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(158, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de despacho de orden";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 27);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(382, 23);
            dateTimePicker1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(617, 562);
            button1.Name = "button1";
            button1.Size = new Size(168, 23);
            button1.TabIndex = 10;
            button1.Text = "Cargar orden de preparación";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Enabled = false;
            button3.Location = new Point(555, 469);
            button3.Name = "button3";
            button3.Size = new Size(233, 23);
            button3.TabIndex = 14;
            button3.Text = "Quitar producto de órden de preparación";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { skuColumnaSelec, cantidadColumnaSelec, palletColumnaPrep, ubicacionColumnaPrep });
            listView2.Location = new Point(12, 310);
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
            skuColumnaSelec.Width = 195;
            // 
            // cantidadColumnaSelec
            // 
            cantidadColumnaSelec.Text = "Cantidad a retirar";
            cantidadColumnaSelec.Width = 195;
            // 
            // palletColumnaPrep
            // 
            palletColumnaPrep.Text = "Pallet cerrado";
            palletColumnaPrep.Width = 195;
            // 
            // ubicacionColumnaPrep
            // 
            ubicacionColumnaPrep.Text = "Ubicación";
            ubicacionColumnaPrep.Width = 195;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.DropDownWidth = 383;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(382, 23);
            comboBox1.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 68);
            label7.Name = "label7";
            label7.Size = new Size(129, 15);
            label7.TabIndex = 17;
            label7.Text = "Razón social del cliente";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(400, 68);
            label8.Name = "label8";
            label8.Size = new Size(90, 15);
            label8.TabIndex = 18;
            label8.Text = "CUIT del cliente";
            label8.Click += label8_Click;
            // 
            // textBox5
            // 
            textBox5.Enabled = false;
            textBox5.Location = new Point(400, 86);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(383, 23);
            textBox5.TabIndex = 19;
            textBox5.Text = "00000000000";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 154);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(382, 23);
            comboBox2.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 136);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 21;
            label3.Text = "Producto";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(400, 136);
            label6.Name = "label6";
            label6.Size = new Size(99, 15);
            label6.TabIndex = 22;
            label6.Text = "SKU del producto";
            // 
            // textBox2
            // 
            textBox2.Enabled = false;
            textBox2.Location = new Point(400, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(385, 23);
            textBox2.TabIndex = 23;
            textBox2.Text = "XX-XXX-XXX";
            // 
            // textBox4
            // 
            textBox4.Enabled = false;
            textBox4.Location = new Point(400, 198);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(385, 23);
            textBox4.TabIndex = 24;
            textBox4.Text = "500";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(400, 180);
            label9.Name = "label9";
            label9.Size = new Size(102, 15);
            label9.TabIndex = 25;
            label9.Text = "Cantidad en stock";
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "No", "Sí" });
            comboBox3.Location = new Point(12, 242);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(382, 23);
            comboBox3.TabIndex = 26;
            comboBox3.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 224);
            label10.Name = "label10";
            label10.Size = new Size(79, 15);
            label10.TabIndex = 27;
            label10.Text = "Pallet cerrado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(12, 180);
            label11.Name = "label11";
            label11.Size = new Size(98, 15);
            label11.TabIndex = 28;
            label11.Text = "Cantidad a retirar";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 198);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(382, 23);
            textBox6.TabIndex = 29;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.Location = new Point(534, 242);
            button4.Name = "button4";
            button4.Size = new Size(251, 26);
            button4.TabIndex = 30;
            button4.Text = "Agregar producto a órden de preparación";
            button4.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 292);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 31;
            label4.Text = "Órden de preparación";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 486);
            label5.Name = "label5";
            label5.Size = new Size(112, 15);
            label5.TabIndex = 32;
            label5.Text = "DNI de transportista";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(12, 504);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 33;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(218, 544);
            label12.Name = "label12";
            label12.Size = new Size(92, 15);
            label12.TabIndex = 34;
            label12.Text = "Estado de órden";
            // 
            // textBox3
            // 
            textBox3.Enabled = false;
            textBox3.Location = new Point(218, 563);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 35;
            textBox3.Text = "Pendiente";
            // 
            // ProcesarOrdenPreparacionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(797, 597);
            Controls.Add(textBox3);
            Controls.Add(label12);
            Controls.Add(comboBox4);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(button4);
            Controls.Add(textBox6);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(comboBox3);
            Controls.Add(label9);
            Controls.Add(textBox4);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(comboBox2);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(comboBox1);
            Controls.Add(listView2);
            Controls.Add(button3);
            Controls.Add(button1);
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
        private Button button1;
        private Button button3;
        private ListView listView2;
        private ColumnHeader skuColumnaSelec;
        private ColumnHeader cantidadColumnaSelec;
        private ComboBox comboBox1;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private ComboBox comboBox2;
        private Label label3;
        private Label label6;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label9;
        private ComboBox comboBox3;
        private Label label10;
        private Label label11;
        private TextBox textBox6;
        private Button button4;
        private Label label4;
        private ColumnHeader palletColumnaPrep;
        private ColumnHeader ubicacionColumnaPrep;
        private Label label5;
        private ComboBox comboBox4;
        private Label label12;
        private TextBox textBox3;
    }
}