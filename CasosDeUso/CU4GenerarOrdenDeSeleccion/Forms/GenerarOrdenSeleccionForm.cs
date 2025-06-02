using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGrupoE.Almacenes;
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model;
using static TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model.GenerarOrdenDeSeleccionModelo;


namespace TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Forms
{
    public partial class GenerarOrdenSeleccionForm : Form
    {
        private GenerarOrdenDeSeleccionModelo modelo;
        public GenerarOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        //private void ProcesarOrdenSeleccionForm_Load(object sender, EventArgs e)
        //{
        //    modelo = new GenerarOrdenDeSeleccionModelo();
        //    ordenesPendientesListView.Items.Clear(); // Limpia la lista visual
        //    // 
        //    foreach (var OrdenDePreparacion in OrdenPreparacionAlmacen.OrdenesDePreparacion)
        //    {
        //        ListViewItem OrdenDePreparacionitem = new ListViewItem();
        //        OrdenDePreparacionitem.Text = OrdenDePreparacion.FechaDespacho.ToString("dd/mm/yyyy");
        //        OrdenDePreparacionitem.SubItems.Add(OrdenDePreparacion.Id.ToString());
        //        OrdenDePreparacionitem.SubItems.Add(OrdenDePreparacion.CuitCliente);
        //        //OrdenDePreparacionitem.Tag = OrdenDePreparacion.Doco;
        //        string razonSocial = modelo.ObtenerRazonSocialPorCuit(OrdenDePreparacion.CuitCliente);
        //        OrdenDePreparacionitem.SubItems.Add(razonSocial); // Razón social cliente

        //        ordenesPendientesListView.Items.Add(OrdenDePreparacionitem);


        //    }
        //}
        private void mercaderiasAPrepList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Habilita el botón solo si hay elementos seleccionados
            eliminarDeSeleccionButton.Enabled = mercaderiasAPrepList.SelectedItems.Count > 0;
        }



        private void eliminarDeSeleccionButton_Click(object sender, EventArgs e)
        {
            if (mercaderiasAPrepList.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná un elemento para eliminar.");
                return;
            }
            List<ListViewItem> itemsAEliminar = new List<ListViewItem>();


            foreach (ListViewItem itemSeleccionado in mercaderiasAPrepList.SelectedItems)
            {
                // Creamos un nuevo item para la lista de arriba
                ListViewItem Itemeliminar = new ListViewItem(itemSeleccionado.Text); // Fecha
                Itemeliminar.SubItems.Add(itemSeleccionado.SubItems[1].Text); // ID
                Itemeliminar.SubItems.Add(itemSeleccionado.SubItems[2].Text); // CUIT
                Itemeliminar.SubItems.Add(itemSeleccionado.SubItems[3].Text); // Razón Social

                ordenesPendientesListView.Items.Add(Itemeliminar ); // lo agregamos arriba
                mercaderiasAPrepList.Items.Remove(itemSeleccionado); // lo eliminamos abajo
            }

            eliminarDeSeleccionButton.Enabled = false; // deshabilitamos el botón hasta nueva selección
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar mensaje de confirmación
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que querés confirmar la orden?",
                "Confirmar orden",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.OK)
            {
                // Ejemplo: generar número aleatorio
                Random rnd = new Random();
                int numeroOrden = rnd.Next(10000, 99999);

                MessageBox.Show($"Orden confirmada con número: {numeroOrden}", "Orden generada");

                // Acá podrías limpiar la lista de abajo, guardar la orden, etc.
                mercaderiasAPrepList.Items.Clear();
                generarOrdenButton.Enabled = false;
            }
            else
            {
                // Cancelado, no hacés nada
            }
        }

        private void ordenesPendientesListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void agregarAOrdenButton_Click(object sender, EventArgs e)
        {
            // Verificar que hay elementos seleccionados
            if (ordenesPendientesListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Selecciona al menos una orden para agregar.");
                return;
            }
            List<ListViewItem> itemsAEliminar = new List<ListViewItem>();

            // Recorrer los elementos seleccionados
            foreach (ListViewItem ordenSeleccionada in ordenesPendientesListView.SelectedItems)
            {
                string idOrden = ordenSeleccionada.SubItems[1].Text;

                // Verificar si ya está en la lista de abajo
                bool yaExiste = mercaderiasAPrepList.Items
                    .Cast<ListViewItem>()
                    .Any(item => item.SubItems[1].Text == idOrden);

                if (!yaExiste)
                {
                    // Crear un nuevo item para la lista de abajo (copia los datos)
                    ListViewItem nuevoItem = new ListViewItem();
                    nuevoItem.Text = ordenSeleccionada.Text; // Fecha
                    nuevoItem.SubItems.Add(ordenSeleccionada.SubItems[1].Text); // ID
                    nuevoItem.SubItems.Add(ordenSeleccionada.SubItems[2].Text); // CUIT
                    nuevoItem.SubItems.Add(ordenSeleccionada.SubItems[3].Text); // Razón Social

                    // Agregar a la lista de abajo
                    mercaderiasAPrepList.Items.Add(nuevoItem);
                    itemsAEliminar.Add(ordenSeleccionada);
                }
            }
            foreach (var item in itemsAEliminar)
            {
                ordenesPendientesListView.Items.Remove(item);
            }


            // Limpio la selección de la lista de arriba
            ordenesPendientesListView.SelectedItems.Clear();

            // Desactivo el botón de eliminar por si quedó algo seleccionado abajo
            eliminarDeSeleccionButton.Enabled = false;
        }


        private void mercaderiasAPrepList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            eliminarDeSeleccionButton.Enabled = mercaderiasAPrepList.SelectedItems.Count > 0;
            generarOrdenButton.Enabled = mercaderiasAPrepList.Items.Count > 0;

        }

     
    }
}
