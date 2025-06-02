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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using TPGrupoE.CasosDeUso.CU6Empaquetado.Model;
using static TPGrupoE.CasosDeUso.CU6Empaquetado.Model.EmpaquetadoModelo;

namespace TPGrupoE.CasosDeUso.CU6Empaquetado.Forms
{
    public partial class EmpaquetadoForm : Form
    {
        /*
        public EmpaquetadoForm()
        {
            InitializeComponent();
        }

        private EmpaquetadoModel _empaquetadoModel;
        private OrdenDePreparacionAEmpaquetar ordenDePreparacionAEmpaquetar;

        private void Empaquetado_Load(object sender, EventArgs e)
        {
            PasarALaSiguienteOrden();
        }

        private void PasarALaSiguienteOrden()
        {
            List<OrdenDePreparacionAEmpaquetar> ordenes = _empaquetadoModel.OrdenesDePreparacionAEmpaquetar;
            ordenDePreparacionAEmpaquetar = ordenes.FirstOrDefault();

            if (ordenDePreparacionAEmpaquetar == null)
            {
                MessageBox.Show("No hay ordenes de preparacion para empaquetar");
                ordenesDePreparacionListView.Items.Clear();
                nroOrden.Text = "N/A";
                return;
            }

            nroOrden.Text = ordenDePreparacionAEmpaquetar.Id;

            List<CasoU_EmpaquetadoOrdenes.ProductoAlmacen> productosOrden = ordenDePreparacionAEmpaquetar.Producto;

            ordenesDePreparacionListView.Items.Clear();
            foreach (var producto in productosOrden)
            {
                var item = new ListViewItem(new[]
                {
                    producto.IdProducto.ToString(),
                    producto.DescripcionProducto,
                    producto.Cantidad.ToString(),
                });

                // Agregar el item al ListView
                ordenesDePreparacionListView.Items.Add(item);
            }
        }

        private void GenerarOrdenButton_Click(object sender, EventArgs e)
        {
            _empaquetadoModel.MarcarOrdenComoEmpaquetada(ordenDePreparacionAEmpaquetar);
            PasarALaSiguienteOrden();
        }

        private void VolverAlMenu()
        {
            // Solo oculta el formulario actual
            this.Hide();

            // Mostrar el formulario de menú principal
            // Verifica si el formulario principal ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is MenuPrincipal)
                {
                    form.Show(); // Muestra el formulario si está oculto
                    return;
                }
            }

            // Si no está abierto, crea una nueva instancia (solo si es necesario)
            MenuPrincipal pantallaPrincipalForm = new MenuPrincipal();
            pantallaPrincipalForm.Show(); // Cambiar a usar la instancia creada
        }

        private void empaquetarButton_Click(object sender, EventArgs e)
        {

        }

        private void idOrdenTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void productoAEmpaquetarListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }*/
    }
}
