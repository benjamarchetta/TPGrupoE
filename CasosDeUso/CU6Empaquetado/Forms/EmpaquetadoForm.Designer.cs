
namespace TPGrupoE.CasoU_Empaquetado
{
    partial class EmpaquetadoForm
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
            idOrdenTextBox = new TextBox();
            label2 = new Label();
            empaquetarButton = new Button();
            productoAEmpaquetarListView = new ListView();
            skuColumnaSelec = new ColumnHeader();
            descripcionColumnaPrep = new ColumnHeader();
            cantidadColumnaSelec = new ColumnHeader();
            SuspendLayout();
            // 
            // idOrdenTextBox
            // 
            idOrdenTextBox.BackColor = SystemColors.InactiveCaption;
            idOrdenTextBox.Enabled = false;
            idOrdenTextBox.Location = new Point(176, 24);
            idOrdenTextBox.Margin = new Padding(3, 4, 3, 4);
            idOrdenTextBox.Name = "idOrdenTextBox";
            idOrdenTextBox.Size = new Size(149, 27);
            idOrdenTextBox.TabIndex = 1;
            idOrdenTextBox.Text = "XX";
            idOrdenTextBox.TextChanged += idOrdenTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Control;
            label2.Location = new Point(14, 27);
            label2.Name = "label2";
            label2.Size = new Size(147, 20);
            label2.TabIndex = 2;
            label2.Text = "Orden a Empaquetar";
            label2.Click += label2_Click;
            // 
            // empaquetarButton
            // 
            empaquetarButton.Enabled = false;
            empaquetarButton.Location = new Point(634, 548);
            empaquetarButton.Margin = new Padding(3, 4, 3, 4);
            empaquetarButton.Name = "empaquetarButton";
            empaquetarButton.Size = new Size(266, 31);
            empaquetarButton.TabIndex = 14;
            empaquetarButton.Text = "Empaquetar";
            empaquetarButton.UseVisualStyleBackColor = true;
            empaquetarButton.Click += empaquetarButton_Click;
            // 
            // productoAEmpaquetarListView
            // 
            productoAEmpaquetarListView.Columns.AddRange(new ColumnHeader[] { skuColumnaSelec, descripcionColumnaPrep, cantidadColumnaSelec });
            productoAEmpaquetarListView.FullRowSelect = true;
            productoAEmpaquetarListView.Location = new Point(14, 70);
            productoAEmpaquetarListView.Margin = new Padding(3, 4, 3, 4);
            productoAEmpaquetarListView.Name = "productoAEmpaquetarListView";
            productoAEmpaquetarListView.Size = new Size(886, 452);
            productoAEmpaquetarListView.TabIndex = 15;
            productoAEmpaquetarListView.UseCompatibleStateImageBehavior = false;
            productoAEmpaquetarListView.View = View.Details;
            productoAEmpaquetarListView.SelectedIndexChanged += productoAEmpaquetarListView_SelectedIndexChanged;
            // 
            // skuColumnaSelec
            // 
            skuColumnaSelec.Text = "SKU de producto";
            skuColumnaSelec.Width = 257;
            // 
            // descripcionColumnaPrep
            // 
            descripcionColumnaPrep.Text = "Descripción";
            descripcionColumnaPrep.Width = 257;
            // 
            // cantidadColumnaSelec
            // 
            cantidadColumnaSelec.Text = "Cantidad a retirar";
            cantidadColumnaSelec.Width = 257;
            // 
            // EmpaquetadoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 598);
            Controls.Add(idOrdenTextBox);
            Controls.Add(label2);
            Controls.Add(empaquetarButton);
            Controls.Add(productoAEmpaquetarListView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmpaquetadoForm";
            Text = "Empaquetado";
            Load += Empaquetado_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private TextBox idOrdenTextBox;
        private Label label2;
        private Button empaquetarButton;
        private ListView productoAEmpaquetarListView;
        private ColumnHeader skuColumnaSelec;
        private ColumnHeader descripcionColumnaPrep;
        private ColumnHeader cantidadColumnaSelec;

    }
}