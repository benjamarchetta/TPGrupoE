using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Model;
using TPGrupoE.CasosDeUso.CU6Empaquetado.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static TPGrupoE.CasosDeUso.CU6Empaquetado.Model.EmpaquetadoModelo;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Forms
{
    public partial class EmpaquetadoForm : Form
    {
        private void InitializeComponent()
        {
            MercaderiaAEmpaquetarGroupBox = new GroupBox();
            listView1 = new System.Windows.Forms.ListView();
            IdProducto = new ColumnHeader();
            DescripcionProducto = new ColumnHeader();
            CantidadAEmpaquetar = new ColumnHeader();
            ConfirmarEmpaquetadoButton = new System.Windows.Forms.Button();
            VolverMenuPrincipalButton = new System.Windows.Forms.Button();
            MercaderiaAEmpaquetarGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // MercaderiaAEmpaquetarGroupBox
            // 
            MercaderiaAEmpaquetarGroupBox.Controls.Add(listView1);
            MercaderiaAEmpaquetarGroupBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MercaderiaAEmpaquetarGroupBox.Location = new Point(22, 25);
            MercaderiaAEmpaquetarGroupBox.Name = "MercaderiaAEmpaquetarGroupBox";
            MercaderiaAEmpaquetarGroupBox.Size = new Size(540, 419);
            MercaderiaAEmpaquetarGroupBox.TabIndex = 0;
            MercaderiaAEmpaquetarGroupBox.TabStop = false;
            MercaderiaAEmpaquetarGroupBox.Text = "Mercadería a Empaquetar";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { IdProducto, DescripcionProducto, CantidadAEmpaquetar });
            listView1.GridLines = true;
            listView1.Location = new Point(17, 35);
            listView1.Name = "listView1";
            listView1.Size = new Size(502, 360);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // IdProducto
            // 
            IdProducto.Text = "Id Producto";
            IdProducto.Width = 120;
            // 
            // DescripcionProducto
            // 
            DescripcionProducto.Text = "Descripcion del producto";
            DescripcionProducto.Width = 200;
            // 
            // CantidadAEmpaquetar
            // 
            CantidadAEmpaquetar.Text = "Cantidad a empaquetar";
            CantidadAEmpaquetar.Width = 180;
            // 
            // ConfirmarEmpaquetadoButton
            // 
            ConfirmarEmpaquetadoButton.BackColor = SystemColors.Highlight;
            ConfirmarEmpaquetadoButton.Location = new Point(302, 461);
            ConfirmarEmpaquetadoButton.Name = "ConfirmarEmpaquetadoButton";
            ConfirmarEmpaquetadoButton.Size = new Size(260, 48);
            ConfirmarEmpaquetadoButton.TabIndex = 1;
            ConfirmarEmpaquetadoButton.Text = "Confirmar Empaquetado";
            ConfirmarEmpaquetadoButton.UseVisualStyleBackColor = false;
            // 
            // VolverMenuPrincipalButton
            // 
            VolverMenuPrincipalButton.BackColor = Color.White;
            VolverMenuPrincipalButton.Location = new Point(22, 461);
            VolverMenuPrincipalButton.Name = "VolverMenuPrincipalButton";
            VolverMenuPrincipalButton.Size = new Size(260, 48);
            VolverMenuPrincipalButton.TabIndex = 2;
            VolverMenuPrincipalButton.Text = "Volver al Menú Principal";
            VolverMenuPrincipalButton.UseVisualStyleBackColor = false;
            // 
            // EmpaquetadoForm
            // 
            ClientSize = new Size(606, 521);
            Controls.Add(VolverMenuPrincipalButton);
            Controls.Add(ConfirmarEmpaquetadoButton);
            Controls.Add(MercaderiaAEmpaquetarGroupBox);
            Name = "EmpaquetadoForm";
            Text = "Confirmar Empaquetado";
            MercaderiaAEmpaquetarGroupBox.ResumeLayout(false);
            ResumeLayout(false);

        }
    } 
}
