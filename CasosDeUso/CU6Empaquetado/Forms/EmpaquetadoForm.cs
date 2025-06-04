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
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.ProductosOP;
using TPGrupoE.CasosDeUso.CU6Empaquetado.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
                MessageBox.Show("No hay ordenes de preparacion para empaquetar");
                MercaderiasALiberarParaDespachoListView.Items.Clear();
                return;
            }

            //IdOrdenPreparacion.Text = ordenDePreparacionAEmpaquetar.IdOrdenPreparacion;

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
            _empaquetadoModel.MarcarOrdenComoEmpaquetada(ordenDePreparacionAEmpaquetar);
            PasarALaSiguienteOrden();
        }

        private void VolverAlMenuPrincipal()
        {
            // Solo oculta el formulario actual
            this.Hide();

            // Mostrar el formulario de menú principal
            // Verifica si el formulario principal ya está abierto
            foreach (Form form in Application.OpenForms)
            {
                if (form is MenuPrincipalGeneralForm)
                {
                    form.Show(); // Muestra el formulario si está oculto
                    return;
                }
            }

            // Si no está abierto, crea una nueva instancia (solo si es necesario)
            MenuPrincipalGeneralForm pantallaPrincipalForm = new MenuPrincipalGeneralForm();
            pantallaPrincipalForm.Show();
        }

        private void VolverMenuPrincipalButton_Click(object sender, EventArgs e)
        {

            VolverAlMenuPrincipal();
        }



        private void EmpaquetadoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenuPrincipal();
        }

        /*
        public partial class GestionOrdenSeleccionForm : Form
        {
            private GestionOrdenSeleccionModel _gestionOrdenSeleccionModel;
            public GestionOrdenSeleccionForm()
            {
                InitializeComponent();
                _gestionOrdenSeleccionModel = new GestionOrdenSeleccionModel();
            }

            private void GestionOrdenSeleccionForm_Load(object sender, EventArgs e)
            {
                ActualizarOrdenesDeSeleccion();
            }

            private void ActualizarOrdenesDeSeleccion()
            {
                OrdenesSeleccionPendientesListView.Items.Clear();
                List<OrdenSeleccion> ordenes = _gestionOrdenSeleccionModel.OrdenesDeSeleccion;

                if (ordenes.Count == 0)
                {
                    MessageBox.Show("Actualmente no hay ordenes de seleccion pendientes.");
                }

                foreach (var orden in ordenes)
                {
                    var item = new ListViewItem(new[]
                      {
                        orden.Id.ToString(),
                    });

                    OrdenesSeleccionPendientesListView.Items.Add(item);
                }
            }
            private void VerItemsButton_Click(object sender, EventArgs e)
            {
                ItemsASeleccionarListView.Items.Clear();
                int idOrdenSeleccionada = ObtenerIdOrden();

                if (idOrdenSeleccionada == -1)
                {
                    return;
                }

                List<Producto> productos = _gestionOrdenSeleccionModel.ObtenerProductosDeOrden(idOrdenSeleccionada);
                foreach (var producto in productos)
                {
                    var item = new ListViewItem(new[]
                      {
                        producto.Ubicacion,
                        producto.Cantidad.ToString(),
                        producto.IdProducto,
                        producto.DescripcionProducto,
                    });

                    ItemsASeleccionarListView.Items.Add(item);
                }
            }

            private void ResetearFormulario()
            {
                ItemsASeleccionarListView.Items.Clear();
            }

            private int ObtenerIdOrden()
            {
                string idOrdenSeleccionada = "";

                // Verificar si hay elementos seleccionados en el ListView
                if (OrdenesSeleccionPendientesListView.SelectedItems.Count > 0)
                {
                    // Obtener el primer item seleccionado
                    ListViewItem selectedItem = OrdenesSeleccionPendientesListView.SelectedItems[0];

                    // Obtener el valor del ID (en este caso, asumimos que está en la primera columna)
                    idOrdenSeleccionada = selectedItem.SubItems[0].Text;

                }
                else
                {
                    MessageBox.Show("No se ha seleccionado ninguna orden. Por favor seleccione una");
                    return -1;
                }

                return int.Parse(idOrdenSeleccionada);
            }

            private void MarcarComoSeleccionadaButton_Click(object sender, EventArgs e)
            {
                int idOrdenSeleccionada = ObtenerIdOrden();

                if (idOrdenSeleccionada == -1)
                {
                    return;
                }

                _gestionOrdenSeleccionModel.MarcarOrdenComoSeleccionada(idOrdenSeleccionada);
                MessageBox.Show("Se seleccionó correctamente la orden de selección ID " + idOrdenSeleccionada);
                ActualizarOrdenesDeSeleccion();
                ResetearFormulario();
            }

            private void VolverAlMenu()
            {
                // Solo oculta el formulario actual
                this.Hide();

                // Mostrar el formulario de menú principal
                // Verifica si el formulario principal ya está abierto
                foreach (Form form in Application.OpenForms)
                {
                    if (form is PantallaPrincipalForm)
                    {
                        form.Show(); // Muestra el formulario si está oculto
                        return;
                    }
                }

                // Si no está abierto, crea una nueva instancia (solo si es necesario)
                PantallaPrincipalForm pantallaPrincipalForm = new PantallaPrincipalForm();
                pantallaPrincipalForm.Show();
            }

            private void VolverButton_Click(object sender, EventArgs e)
            {
                VolverAlMenu();
            }

            private void GestionOrdenSeleccionForm_FormClosing(object sender, FormClosingEventArgs e)
            {
                VolverAlMenu();
            }
        }*/
    }
}
