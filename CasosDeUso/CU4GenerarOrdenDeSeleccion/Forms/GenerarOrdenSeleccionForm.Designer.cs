﻿namespace TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Forms
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
            Producto = new ColumnHeader();
            Cantidad = new ColumnHeader();
            agregarAOrdenButton = new Button();
            generarOrdenButton = new Button();
            label2 = new Label();
            eliminarDeSeleccionButton = new Button();
            mercaderiasAPrepList = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            dfgfd = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            menubutton = new Button();
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
            ordenesPendientesListView.Columns.AddRange(new ColumnHeader[] { fechaColumna, idOrdenColumna, idClienteColumna, columnHeader3, Producto, Cantidad });
            ordenesPendientesListView.FullRowSelect = true;
            ordenesPendientesListView.Location = new Point(12, 27);
            ordenesPendientesListView.Name = "ordenesPendientesListView";
            ordenesPendientesListView.Size = new Size(776, 175);
            ordenesPendientesListView.TabIndex = 1;
            ordenesPendientesListView.UseCompatibleStateImageBehavior = false;
            ordenesPendientesListView.View = View.Details;
            ordenesPendientesListView.Click += ordenesPendientesListView_Click;
            // 
            // fechaColumna
            // 
            fechaColumna.Text = "Fecha a despachar";
            fechaColumna.Width = 122;
            // 
            // idOrdenColumna
            // 
            idOrdenColumna.Text = "ID de Orden";
            idOrdenColumna.Width = 122;
            // 
            // idClienteColumna
            // 
            idClienteColumna.Text = "Razón social cliente";
            idClienteColumna.Width = 122;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "CUIT Cliente";
            columnHeader3.Width = 122;
            // 
            // Producto
            // 
            Producto.Text = "Producto";
            Producto.Width = 122;
            // 
            // Cantidad
            // 
            Cantidad.Text = "cantidad";
            Cantidad.Width = 122;
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
            generarOrdenButton.Location = new Point(414, 486);
            generarOrdenButton.Name = "generarOrdenButton";
            generarOrdenButton.Size = new Size(184, 23);
            generarOrdenButton.TabIndex = 4;
            generarOrdenButton.Text = "Generar órden de selección";
            generarOrdenButton.UseVisualStyleBackColor = true;
            generarOrdenButton.Click += generarOrdenButton_Click;
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
            mercaderiasAPrepList.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader4, columnHeader5, dfgfd, columnHeader7 });
            mercaderiasAPrepList.FullRowSelect = true;
            mercaderiasAPrepList.Location = new Point(12, 268);
            mercaderiasAPrepList.Name = "mercaderiasAPrepList";
            mercaderiasAPrepList.Size = new Size(776, 175);
            mercaderiasAPrepList.TabIndex = 9;
            mercaderiasAPrepList.UseCompatibleStateImageBehavior = false;
            mercaderiasAPrepList.View = View.Details;
            mercaderiasAPrepList.Click += mercaderiasAPrepList_Click;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Fecha a despachar";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ID de Orden";
            columnHeader2.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Razón social cliente";
            columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "CUIT Cliente";
            columnHeader5.Width = 100;
            // 
            // dfgfd
            // 
            dfgfd.Text = "Producto";
            dfgfd.Width = 100;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Cantidad";
            columnHeader7.Width = 100;
            // 
            // menubutton
            // 
            menubutton.Location = new Point(604, 486);
            menubutton.Name = "menubutton";
            menubutton.Size = new Size(184, 23);
            menubutton.TabIndex = 10;
            menubutton.Text = "Volver al Menu Principal";
            menubutton.UseVisualStyleBackColor = true;
            menubutton.Click += menubutton_Click;
            // 
            // GenerarOrdenSeleccionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 533);
            Controls.Add(menubutton);
            Controls.Add(mercaderiasAPrepList);
            Controls.Add(eliminarDeSeleccionButton);
            Controls.Add(label2);
            Controls.Add(generarOrdenButton);
            Controls.Add(agregarAOrdenButton);
            Controls.Add(ordenesPendientesListView);
            Controls.Add(label1);
            Name = "GenerarOrdenSeleccionForm";
            Text = "Generar órden de selección";
            Load += GenerarOrdenSeleccionForm_Load;
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
        private Button menubutton;
        private ColumnHeader Producto;
        private ColumnHeader Cantidad;
        private ColumnHeader dfgfd;
        private ColumnHeader columnHeader7;
    }
}