﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using System.IO;
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
            modelo = new GenerarOrdenDeSeleccionModelo();
        }

        // AGREGAR ESTOS MÉTODOS AQUÍ:

        private void GenerarOrdenSeleccionForm_Load(object sender, EventArgs e)
        {
            CargarOrdenesPendientes();
            HabilitarBotones();
        }

        private void CargarOrdenesPendientes()
        {
            try
            {
                var ordenesPendientes = modelo.BuscarOrdenesPendientes();
                ordenesPendientesListView.Items.Clear();
                if (ordenesPendientes.Count == 0)
                {
                    MessageBox.Show("No hay órdenes pendientes para procesar", "Sin órdenes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Volver al menú principal
                    var menuForm = new MenuPrincipalGeneralForm();
                    menuForm.Show();
                    this.Close();
                    return;
                }

                foreach (var orden in ordenesPendientes)
                {
                    bool esPrimeraFila = true;

                    foreach (var producto in orden.Productos)
                    {
                        ListViewItem item = new ListViewItem();

                        if (esPrimeraFila)
                        {
                            //  datos completos
                            item.Text = orden.FechaEntrega.ToString("dd/MM/yyyy");
                            item.SubItems.Add(orden.IdOrdenPreparacion.ToString());
                            item.SubItems.Add(modelo.ObtenerRazonSocialCliente(orden.IdCliente));
                            item.SubItems.Add(modelo.ObtenerCuitCliente(orden.IdCliente));
                            esPrimeraFila = false;
                        }
                        else
                        {
                            // espacios vacíos
                            item.Text = "";
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                            item.SubItems.Add("");
                        }

                        item.SubItems.Add(producto.Descripcion);
                        item.SubItems.Add(producto.Cantidad.ToString());
                        item.Tag = orden;

                        ordenesPendientesListView.Items.Add(item);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AgregarProductosAMercaderias(OrdenPreparacion orden)
        {
            // Verificar si ya existe
            bool yaEsta = false;
            foreach (ListViewItem item in mercaderiasAPrepList.Items)
            {
                OrdenPreparacion ordenExistente = (OrdenPreparacion)item.Tag;
                if (ordenExistente.IdOrdenPreparacion == orden.IdOrdenPreparacion)
                {
                    yaEsta = true;
                    break;
                }
            }

            if (yaEsta == false)
            {
                bool esPrimeraFila = true;

                foreach (var producto in orden.Productos)
                {
                    ListViewItem item = new ListViewItem();

                    if (esPrimeraFila)
                    {
                        item.Text = orden.FechaEntrega.ToString("dd/MM/yyyy");
                        item.SubItems.Add(orden.IdOrdenPreparacion.ToString());
                        item.SubItems.Add(orden.RazonSocial);
                        item.SubItems.Add(orden.Cuit);
                        esPrimeraFila = false;
                    }
                    else
                    {
                        item.Text = "";
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                    }

                    item.SubItems.Add(producto.Descripcion);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    item.Tag = orden;
                    mercaderiasAPrepList.Items.Add(item);
                }
            }
        }

        private void agregarAOrdenButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener órdenes seleccionadas (sin duplicados)
                var ordenesSeleccionadas = new List<OrdenPreparacion>();

                foreach (ListViewItem item in ordenesPendientesListView.SelectedItems)
                {
                    if (item.Tag is OrdenPreparacion orden)
                    {
                        // Solo agregar si no está ya en la lista
                        bool yaEsta = false;
                        foreach (var ordenExistente in ordenesSeleccionadas)
                        {
                            if (ordenExistente.IdOrdenPreparacion == orden.IdOrdenPreparacion)
                            {
                                yaEsta = true;
                                break;
                            }
                        }

                        if (!yaEsta)
                        {
                            ordenesSeleccionadas.Add(orden);
                        }
                    }
                }

                // 2. Validar que haya selecciones
                if (ordenesSeleccionadas.Count == 0)
                {
                    MessageBox.Show("Selecciona al menos una orden", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Solo mover a mercaderías
                foreach (var orden in ordenesSeleccionadas)
                {
                    AgregarProductosAMercaderias(orden);
                }

                // 4. Remover todas las filas de las órdenes seleccionadas
                var itemsARemover = new List<ListViewItem>();
                foreach (ListViewItem item in ordenesPendientesListView.Items)
                {
                    if (item.Tag is OrdenPreparacion orden)
                    {
                        // Verificar si esta orden está en las seleccionadas
                        bool estaSeleccionada = false;
                        foreach (var ordenSeleccionada in ordenesSeleccionadas)
                        {
                            if (ordenSeleccionada.IdOrdenPreparacion == orden.IdOrdenPreparacion)
                            {
                                estaSeleccionada = true;
                                break;
                            }
                        }

                        if (estaSeleccionada)
                        {
                            itemsARemover.Add(item);
                        }
                    }
                }

                foreach (var item in itemsARemover)
                {
                    ordenesPendientesListView.Items.Remove(item);
                }

                // 5. Habilitar botones de eliminar y confirmar
                HabilitarBotones();

                MessageBox.Show($"Se agregaron {ordenesSeleccionadas.Count} órdenes a preparación", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HabilitarBotones()
        {
            // Verificar si hay mercaderías
            if (mercaderiasAPrepList.Items.Count > 0)
            {
                // Si hay mercaderías, habilitar botones
                eliminarDeSeleccionButton.Enabled = true;
                generarOrdenButton.Enabled = true;
            }
            else
            {
                // Si no hay mercaderías, deshabilitar botones
                eliminarDeSeleccionButton.Enabled = false;
                generarOrdenButton.Enabled = false;
            }
        }


        private void eliminarDeSeleccionButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Obtener órdenes seleccionadas (sin duplicados)
                var ordenesSeleccionadas = new List<OrdenPreparacion>();

                foreach (ListViewItem item in mercaderiasAPrepList.SelectedItems)
                {
                    if (item.Tag is OrdenPreparacion orden)
                    {
                        // Solo agregar si no está ya en la lista
                        bool yaEsta = false;
                        foreach (var ordenExistente in ordenesSeleccionadas)
                        {
                            if (ordenExistente.IdOrdenPreparacion == orden.IdOrdenPreparacion)
                            {
                                yaEsta = true;
                                break;
                            }
                        }

                        if (!yaEsta)
                        {
                            ordenesSeleccionadas.Add(orden);
                        }
                    }
                }

                // 2. Validar que haya selecciones
                if (ordenesSeleccionadas.Count == 0)
                {
                    MessageBox.Show("Selecciona al menos una orden para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 3. Eliminar todas las filas de las órdenes seleccionadas
                var itemsARemover = new List<ListViewItem>();
                foreach (ListViewItem item in mercaderiasAPrepList.Items)
                {
                    if (item.Tag is OrdenPreparacion orden)
                    {
                        // Verificar si esta orden está en las seleccionadas
                        bool estaSeleccionada = false;
                        foreach (var ordenSeleccionada in ordenesSeleccionadas)
                        {
                            if (ordenSeleccionada.IdOrdenPreparacion == orden.IdOrdenPreparacion)
                            {
                                estaSeleccionada = true;
                                break;
                            }
                        }

                        if (estaSeleccionada)
                        {
                            itemsARemover.Add(item);
                        }
                    }
                }

                foreach (var item in itemsARemover)
                {
                    mercaderiasAPrepList.Items.Remove(item);
                }

                // 4. Volver órdenes a la lista de arriba
                foreach (var orden in ordenesSeleccionadas)
                {
                    VolverOrdenAPendientes(orden);
                }

                // 5. Actualizar estado de botones
                HabilitarBotones();

                MessageBox.Show($"Se eliminaron {itemsARemover.Count} filas y se devolvieron {ordenesSeleccionadas.Count} órdenes", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VolverOrdenAPendientes(OrdenPreparacion orden)
        {
            // Verificar si ya existe
            bool yaEsta = false;
            foreach (ListViewItem item in ordenesPendientesListView.Items)
            {
                OrdenPreparacion ordenExistente = (OrdenPreparacion)item.Tag;
                if (ordenExistente.IdOrdenPreparacion == orden.IdOrdenPreparacion)
                {
                    yaEsta = true;
                    break;
                }
            }

            if (yaEsta == false)
            {
                bool esPrimeraFila = true;

                foreach (var producto in orden.Productos)
                {
                    ListViewItem item = new ListViewItem();

                    if (esPrimeraFila)
                    {
                        item.Text = orden.FechaEntrega.ToString("dd/MM/yyyy");
                        item.SubItems.Add(orden.IdOrdenPreparacion.ToString());
                        item.SubItems.Add(modelo.ObtenerRazonSocialCliente(orden.IdCliente));
                        item.SubItems.Add(modelo.ObtenerCuitCliente(orden.IdCliente));
                        esPrimeraFila = false;
                    }
                    else
                    {
                        item.Text = "";
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                        item.SubItems.Add("");
                    }

                    item.SubItems.Add(producto.Descripcion);
                    item.SubItems.Add(producto.Cantidad.ToString());
                    item.Tag = orden;
                    ordenesPendientesListView.Items.Add(item);
                }
            }
        }


        private void generarOrdenButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Validar que haya mercaderías para confirmar
                if (mercaderiasAPrepList.Items.Count == 0)
                {
                    MessageBox.Show("No hay mercaderías para confirmar", "Aviso");
                    return;
                }

                // 2. Obtener todas las órdenes únicas de las mercaderías
                var ordenesAConfirmar = new List<OrdenPreparacion>();

                foreach (ListViewItem item in mercaderiasAPrepList.Items)
                {
                    if (item.Tag is OrdenPreparacion orden)
                    {
                        // Solo agregar si no está ya en la lista
                        bool yaEsta = false;
                        foreach (var ordenExistente in ordenesAConfirmar)
                        {
                            if (ordenExistente.IdOrdenPreparacion == orden.IdOrdenPreparacion)
                            {
                                yaEsta = true;
                                break;
                            }
                        }

                        if (!yaEsta)
                        {
                            ordenesAConfirmar.Add(orden);
                        }
                    }
                }

                // 3. Crear nueva Orden de Picking (Selección)
                // 3. Confirmar órdenes a través del modelo
                int idOrdenGenerada = modelo.ConfirmarOrdenesDePreparacion(ordenesAConfirmar);

                // 6. Limpiar listas y recargar
                mercaderiasAPrepList.Items.Clear();
                CargarOrdenesPendientes();
                HabilitarBotones();

                // 7. Mostrar mensaje de éxito
                // 7. Mostrar mensaje de éxito
                MessageBox.Show($"¡Orden de Picking #{idOrdenGenerada} generada exitosamente!\n" +
                $"Estado: Pendiente\n" +
                $"Órdenes de preparación incluidas: {ordenesAConfirmar.Count}\n" +
                $"Estado OP cambiado: Pendiente → En Preparación",
                "Orden Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar orden: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MenuPrincipalGeneralForm principalGeneralForm = new MenuPrincipalGeneralForm();
            principalGeneralForm.Show();

        }

        private void menubutton_Click(object sender, EventArgs e)
        {
            var menuForm = new MenuPrincipalGeneralForm();
            menuForm.Show(); // Abre el menú principal
            this.Close(); // Cierra el formulario actual
        }

        private void ordenesPendientesListView_Click(object sender, EventArgs e)
        {
            if (ordenesPendientesListView.SelectedItems.Count > 0)
            {
                var ordenSeleccionada = (OrdenPreparacion)ordenesPendientesListView.SelectedItems[0].Tag;

                foreach (ListViewItem item in ordenesPendientesListView.Items)
                {
                    if (item.Tag is OrdenPreparacion orden && orden.IdOrdenPreparacion == ordenSeleccionada.IdOrdenPreparacion)
                    {
                        item.Selected = true;
                    }
                }
            }
        }

        private void mercaderiasAPrepList_Click(object sender, EventArgs e)
        {
            if (mercaderiasAPrepList.SelectedItems.Count > 0)
            {
                var ordenSeleccionada = (OrdenPreparacion)mercaderiasAPrepList.SelectedItems[0].Tag;

                foreach (ListViewItem item in mercaderiasAPrepList.Items)
                {
                    if (item.Tag is OrdenPreparacion orden && orden.IdOrdenPreparacion == ordenSeleccionada.IdOrdenPreparacion)
                    {
                        item.Selected = true;
                    }
                }
            }
        }
    }
}
//private void btnRestaurarEstado_Click(object sender, EventArgs e)
//{
//    try
//    {
//        var todasLasOrdenes = OrdenPreparacionAlmacen.BuscarTodasLasOrdenes();

//        // Cambiar todas las órdenes "En Preparación" de vuelta a "Pendiente"
//        int ordenesRestauradas = 0;
//        foreach (var orden in todasLasOrdenes)
//        {
//            if (orden.Estado == EstadoOrdenPreparacion.EnPreparacion)
//            {
//                orden.Estado = EstadoOrdenPreparacion.Pendiente;
//                OrdenPreparacionAlmacen.ActualizarOrdenPreparacion(orden);
//                ordenesRestauradas++;
//            }
//        }

//        // Limpiar órdenes de picking (volver archivo a estado inicial)
//        if (File.Exists(@"Datos\ordenPicking.json"))
//        {
//            File.Delete(@"Datos\ordenPicking.json");
//        }

//        // Recargar lista
//        CargarOrdenesPendientes();
//        HabilitarBotones();

//        MessageBox.Show($"Estado restaurado exitosamente!\n{ordenesRestauradas} órdenes vueltas a Pendiente\nArchivo ordenPicking.json eliminado", "Restaurado", MessageBoxButtons.OK, MessageBoxIcon.Information);
//    }
//    catch (Exception ex)
//    {
//        MessageBox.Show($"Error al restaurar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//    }
//}





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
//        private void mercaderiasAPrepList_SelectedIndexChanged(object sender, EventArgs e)
//        {
//            // Habilita el botón solo si hay elementos seleccionados
//            eliminarDeSeleccionButton.Enabled = mercaderiasAPrepList.SelectedItems.Count > 0;
//        }



//        private void eliminarDeSeleccionButton_Click(object sender, EventArgs e)
//        {
//            if (mercaderiasAPrepList.SelectedItems.Count == 0)
//            {
//                MessageBox.Show("Seleccioná un elemento para eliminar.");
//                return;
//            }
//            List<ListViewItem> itemsAEliminar = new List<ListViewItem>();


//            foreach (ListViewItem itemSeleccionado in mercaderiasAPrepList.SelectedItems)
//            {
//                // Creamos un nuevo item para la lista de arriba
//                ListViewItem Itemeliminar = new ListViewItem(itemSeleccionado.Text); // Fecha
//                Itemeliminar.SubItems.Add(itemSeleccionado.SubItems[1].Text); // ID
//                Itemeliminar.SubItems.Add(itemSeleccionado.SubItems[2].Text); // CUIT
//                Itemeliminar.SubItems.Add(itemSeleccionado.SubItems[3].Text); // Razón Social

//                ordenesPendientesListView.Items.Add(Itemeliminar); // lo agregamos arriba
//                mercaderiasAPrepList.Items.Remove(itemSeleccionado); // lo eliminamos abajo
//            }

//            eliminarDeSeleccionButton.Enabled = false; // deshabilitamos el botón hasta nueva selección
//        }

//        private void button2_Click(object sender, EventArgs e)
//        {
//            // Mostrar mensaje de confirmación
//            DialogResult resultado = MessageBox.Show(
//                "¿Estás seguro de que querés confirmar la orden?",
//                "Confirmar orden",
//                MessageBoxButtons.OKCancel,
//                MessageBoxIcon.Question
//            );

//            if (resultado == DialogResult.OK)
//            {
//                // Ejemplo: generar número aleatorio
//                Random rnd = new Random();
//                int numeroOrden = rnd.Next(10000, 99999);

//                MessageBox.Show($"Orden confirmada con número: {numeroOrden}", "Orden generada");

//                // Acá podrías limpiar la lista de abajo, guardar la orden, etc.
//                mercaderiasAPrepList.Items.Clear();
//                generarOrdenButton.Enabled = false;
//            }
//            else
//            {
//                // Cancelado, no hacés nada
//            }
//        }

//        private void ordenesPendientesListView_SelectedIndexChanged(object sender, EventArgs e)
//        {

//        }

//        private void agregarAOrdenButton_Click(object sender, EventArgs e)
//        {
//            // Verificar que hay elementos seleccionados
//            if (ordenesPendientesListView.SelectedItems.Count == 0)
//            {
//                MessageBox.Show("Selecciona al menos una orden para agregar.");
//                return;
//            }
//            List<ListViewItem> itemsAEliminar = new List<ListViewItem>();

//            // Recorrer los elementos seleccionados
//            foreach (ListViewItem ordenSeleccionada in ordenesPendientesListView.SelectedItems)
//            {
//                string idOrden = ordenSeleccionada.SubItems[1].Text;

//                // Verificar si ya está en la lista de abajo
//                bool yaExiste = mercaderiasAPrepList.Items
//                    .Cast<ListViewItem>()
//                    .Any(item => item.SubItems[1].Text == idOrden);

//                if (!yaExiste)
//                {
//                    // Crear un nuevo item para la lista de abajo (copia los datos)
//                    ListViewItem nuevoItem = new ListViewItem();
//                    nuevoItem.Text = ordenSeleccionada.Text; // Fecha
//                    nuevoItem.SubItems.Add(ordenSeleccionada.SubItems[1].Text); // ID
//                    nuevoItem.SubItems.Add(ordenSeleccionada.SubItems[2].Text); // CUIT
//                    nuevoItem.SubItems.Add(ordenSeleccionada.SubItems[3].Text); // Razón Social

//                    // Agregar a la lista de abajo
//                    mercaderiasAPrepList.Items.Add(nuevoItem);
//                    itemsAEliminar.Add(ordenSeleccionada);
//                }
//            }
//            foreach (var item in itemsAEliminar)
//            {
//                ordenesPendientesListView.Items.Remove(item);
//            }


//            // Limpio la selección de la lista de arriba
//            ordenesPendientesListView.SelectedItems.Clear();

//            // Desactivo el botón de eliminar por si quedó algo seleccionado abajo
//            eliminarDeSeleccionButton.Enabled = false;
//        }


//        private void mercaderiasAPrepList_SelectedIndexChanged_1(object sender, EventArgs e)
//        {
//            eliminarDeSeleccionButton.Enabled = mercaderiasAPrepList.SelectedItems.Count > 0;
//            generarOrdenButton.Enabled = mercaderiasAPrepList.Items.Count > 0;

//        }

//        private void GenerarOrdenSeleccionForm_Load(object sender, EventArgs e)
//        {

//        }

//    }
//}
