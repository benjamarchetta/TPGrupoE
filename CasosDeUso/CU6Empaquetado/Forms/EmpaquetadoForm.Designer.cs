
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
            label2 = new Label();
            nroOrden = new TextBox();
            empaquetarButton = new Button();
            productoAEmpaquetarListView = new ListView();
            skuColumnaSelec = new ColumnHeader();
            descripcionColumnaPrep = new ColumnHeader();
            cantidadColumnaSelec = new ColumnHeader();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 22);
            label2.Name = "label2";
            label2.Size = new Size(135, 20);
            label2.TabIndex = 2;
            label2.Text = "Empaquetar Orden";
            // 
            // nroOrden
            // 
            nroOrden.BackColor = SystemColors.InactiveCaption;
            nroOrden.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nroOrden.Location = new Point(171, 12);
            nroOrden.Name = "nroOrden";
            nroOrden.Size = new Size(48, 34);
            nroOrden.TabIndex = 13;
            nroOrden.Text = "000";
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
            Controls.Add(nroOrden);
            Controls.Add(empaquetarButton);
            Controls.Add(productoAEmpaquetarListView);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmpaquetadoForm";
            Text = "Empaquetado";
            Load += Empaquetado_Load;
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private ListView ordenesDePreparacionListView;
        private ColumnHeader IdProducto;
        private ColumnHeader Descripcion;
        private ColumnHeader CantidadProducto;
        private Button empaquetarButton;
        private ListView productoAEmpaquetarListView;
        private ColumnHeader skuColumnaSelec;
        private ColumnHeader descripcionColumnaPrep;
        private ColumnHeader cantidadColumnaSelec;
        private TextBox nroOrden;
        private TextBox textBox1; 
        private Label label2;
    }
}