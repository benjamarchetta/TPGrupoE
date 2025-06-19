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
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Model;
using TPGrupoE.CasosDeUso.CU6Empaquetado.Model;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Forms
{
    public partial class EmpaquetadoForm : Form
    {
        private EmpaquetadoModel _empaquetadoModel;
        
        private OrdenDePreparacionAEmpaquetar ordenDePreparacionAEmpaquetar;

        public EmpaquetadoForm()
        {
            InitializeComponent();
            _empaquetadoModel = new EmpaquetadoModel();
        }

        private void EmpaquetadoForm_Load(object sender, EventArgs e)
        {
            PasarALaSiguienteOrden();
        }

        private void PasarALaSiguienteOrden()
        {
            List<OrdenDePreparacionAEmpaquetar> ordenes = _empaquetadoModel.OrdenesDePreparacionAEmpaquetar;
            ordenDePreparacionAEmpaquetar = ordenes.FirstOrDefault();

            if (ordenDePreparacionAEmpaquetar == null)
            {
                DialogResult resultado = MessageBox.Show("No hay órdenes de preparación para empaquetar","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                Form menuPrincipal = Application.OpenForms["MenuPrincipalGeneralForm"];
                
                if (menuPrincipal != null)
                {
                    menuPrincipal.Show(); // por si estuviera minimizado u oculto
                }
                
                else
                {
                    // Como fallback, lo abrís nuevo
                    menuPrincipal = new MenuPrincipalGeneralForm();
                    menuPrincipal.Show();
                }

                this.Close(); // cerrás el form actual

                MercaderiasALiberarParaDespachoListView.Items.Clear();
                return;
            }

            NumeroOrdenPreparacionLabel.Text = ordenDePreparacionAEmpaquetar.IdOrdenPreparacion;

            List<ProductoOP> productosOP = ordenDePreparacionAEmpaquetar.ProductosOP;

            MercaderiasALiberarParaDespachoListView.Items.Clear();
            foreach (var producto in productosOP)
            {
                var item = new ListViewItem(new[]
                  {
                        producto.Id.ToString(),
                        producto.Descripcion,
                        producto.Cantidad.ToString(),
                    });

                // Agregar el item al ListView
                MercaderiasALiberarParaDespachoListView.Items.Add(item);
            }
        }

        private void ConfirmarEmpaquetadoButton_Click(object sender, EventArgs e)
        {
            _empaquetadoModel.CrearOrdenEntrega(ordenDePreparacionAEmpaquetar);
            PasarALaSiguienteOrden();
        }
        
        private void VolverMenuPrincipalButton_Click(object sender, EventArgs e)
        {

            VolverAlMenuPrincipal();
        }

        private void VolverAlMenuPrincipal()
        {
            this.Close();
        }

        private void EmpaquetadoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MenuPrincipalGeneralForm)
                {
                    form.Show();
                    return;
                }
            }

            new MenuPrincipalGeneralForm().Show();
        }

    }
}
