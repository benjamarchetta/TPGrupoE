namespace TPGrupoE.CasoU_Procesar_Orden_de_Seleccion
{
    partial class GenerarOrdenSeleccionForm
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
            ordenesPendientesListView = new ListView();
            fechaColumna = new ColumnHeader();
            idOrdenColumna = new ColumnHeader();
            idClienteColumna = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            agregarAOrdenButton = new Button();
            generarOrdenButton = new Button();
            label2 = new Label();
            eliminarDeSeleccionButton = new Button();
            mercaderiasAPrepList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            estadoDeOrdenTextBox = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(194, 15);
            label1.TabIndex = 0;
            label1.Text = "Órdenes de preparación pendientes";
            // 
            // ordenesPendientesListView
            // 
            ordenesPendientesListView.CheckBoxes = true;
            ordenesPendientesListView.Columns.AddRange(new ColumnHeader[] { fechaColumna, idOrdenColumna, idClienteColumna, columnHeader3 });
            ordenesPendientesListView.FullRowSelect = true;
            ordenesPendientesListView.Location = new Point(12, 27);
            ordenesPendientesListView.Name = "ordenesPendientesListView";
            ordenesPendientesListView.Size = new Size(776, 175);
            ordenesPendientesListView.TabIndex = 1;
            ordenesPendientesListView.UseCompatibleStateImageBehavior = false;
            ordenesPendientesListView.View = View.Details;
            ordenesPendientesListView.SelectedIndexChanged += ordenesPendientesListView_SelectedIndexChanged;
            // 
            // fechaColumna
            // 
            fechaColumna.Text = "Fecha a despachar";
            fechaColumna.Width = 195;
            // 
            // idOrdenColumna
            // 
            idOrdenColumna.Text = "ID de Orden";
            idOrdenColumna.Width = 195;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "Razón social cliente";
            idClienteColumna.Width = 195;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CUIT Cliente";
            columnHeader3.Width = 195;
            // 
            // agregarAOrdenButton
            // 
            agregarAOrdenButton.Location = new Point(604, 208);
            agregarAOrdenButton.Name = "agregarAOrdenButton";
            agregarAOrdenButton.Size = new Size(184, 23);
            agregarAOrdenButton.TabIndex = 2;
            agregarAOrdenButton.Text = "Agregar a orden de selección";
            agregarAOrdenButton.UseVisualStyleBackColor = true;
            agregarAOrdenButton.Click += agregarAOrdenButton_Click;
            // 
            // generarOrdenButton
            // 
            generarOrdenButton.Enabled = false;
            generarOrdenButton.Location = new Point(604, 498);
            generarOrdenButton.Name = "generarOrdenButton";
            generarOrdenButton.Size = new Size(184, 23);
            generarOrdenButton.TabIndex = 4;
            generarOrdenButton.Text = "Generar órden de selección";
            generarOrdenButton.UseVisualStyleBackColor = true;
            generarOrdenButton.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 250);
            label2.Name = "label2";
            label2.Size = new Size(127, 15);
            label2.TabIndex = 5;
            label2.Text = "Mercaderías a preparar";
            // 
            // eliminarDeSeleccionButton
            // 
            eliminarDeSeleccionButton.Enabled = false;
            eliminarDeSeleccionButton.Location = new Point(604, 449);
            eliminarDeSeleccionButton.Name = "eliminarDeSeleccionButton";
            eliminarDeSeleccionButton.Size = new Size(184, 23);
            eliminarDeSeleccionButton.TabIndex = 6;
            eliminarDeSeleccionButton.Text = "Eliminar de orden de selección";
            eliminarDeSeleccionButton.UseVisualStyleBackColor = true;
            eliminarDeSeleccionButton.Click += eliminarDeSeleccionButton_Click;
            // 
            // mercaderiasAPrepList
            // 
            mercaderiasAPrepList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5 });
            mercaderiasAPrepList.FullRowSelect = true;
            mercaderiasAPrepList.Location = new Point(12, 268);
            mercaderiasAPrepList.Name = "mercaderiasAPrepList";
            mercaderiasAPrepList.Size = new Size(776, 175);
            mercaderiasAPrepList.TabIndex = 9;
            mercaderiasAPrepList.UseCompatibleStateImageBehavior = false;
            mercaderiasAPrepList.View = View.Details;
            mercaderiasAPrepList.SelectedIndexChanged += mercaderiasAPrepList_SelectedIndexChanged_1;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha a despachar";
            columnHeader1.Width = 195;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID de Orden";
            columnHeader2.Width = 195;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Razón social cliente";
            columnHeader4.Width = 195;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "CUIT Cliente";
            columnHeader5.Width = 195;
            // 
            // estadoDeOrdenTextBox
            // 
            estadoDeOrdenTextBox.Enabled = false;
            estadoDeOrdenTextBox.Location = new Point(12, 499);
            estadoDeOrdenTextBox.Name = "estadoDeOrdenTextBox";
            estadoDeOrdenTextBox.Size = new Size(200, 23);
            estadoDeOrdenTextBox.TabIndex = 37;
            estadoDeOrdenTextBox.Text = "En preparación";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(12, 481);
            label12.Name = "label12";
            label12.Size = new Size(92, 15);
            label12.TabIndex = 36;
            label12.Text = "Estado de órden";
            // 
            // GenerarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(estadoDeOrdenTextBox);
            Controls.Add(label12);
            Controls.Add(mercaderiasAPrepList);
            Controls.Add(eliminarDeSeleccionButton);
            Controls.Add(label2);
            Controls.Add(generarOrdenButton);
            Controls.Add(agregarAOrdenButton);
            Controls.Add(ordenesPendientesListView);
            Controls.Add(label1);
            Name = "GenerarOrdenSeleccionForm";
            Text = "Generar órden de selección";
            Load += ProcesarOrdenSeleccionForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListView ordenesPendientesListView;
        private ColumnHeader fechaColumna;
        private ColumnHeader idOrdenColumna;
        private ColumnHeader idClienteColumna;
        private Button agregarAOrdenButton;
        private Button generarOrdenButton;
        private Label label2;
        private Button eliminarDeSeleccionButton;
        private ColumnHeader columnHeader3;
        private ListView mercaderiasAPrepList;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TextBox estadoDeOrdenTextBox;
        private Label label12;
    
    }
}