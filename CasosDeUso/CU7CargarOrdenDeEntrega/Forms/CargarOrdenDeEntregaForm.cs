﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms;
using TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Model;
using TPGrupoE.CasosDeUso.CU7CargarOrdenDeEntrega.Model;
using static TPGrupoE.CasosDeUso.CU7CargarOrdenDeEntrega.Model.OrdenDeEntregaModelo;

namespace TPGrupoE.CasosDeUso.CU7CargarOrdenDeEntrega.Forms
{
    public partial class CargarOrdenDeEntregaForm : Form
    {
        private OrdenDeEntregaModelo _ordenDeEntregaModel;
        public CargarOrdenDeEntregaForm()
        {
            InitializeComponent();
            _ordenDeEntregaModel = new OrdenDeEntregaModelo();
        }

        //Es la acción que genera la órden de entrega
        private void LiberarParaDespacho_Click(object sender, EventArgs e)
        {
            string errorOrdenEntrega = _ordenDeEntregaModel.ValidarOrdenEntrega();

            if (errorOrdenEntrega != null)
            {
                MessageBox.Show(errorOrdenEntrega);
                return;
            }

            _ordenDeEntregaModel.CrearOrdenEntrega();
            MessageBox.Show("Se registró correctamente la orden de entrega.");
            ActualizarTabla();
        }

        //Carga la nueva orden de entrega en OrdenEntregaAlmacen
        private void OrdenEntregaForm_Load(object sender, EventArgs e)
        {
            ActualizarTabla();
        }

        private void ActualizarTabla()
        {

            List<OrdenPreparacion> ordenesPreparacion = _ordenDeEntregaModel.OrdenesDePreparacion;

            OrdenesEmpaquetadasListView.Items.Clear();

            if (ordenesPreparacion.Count == 0)
            {
                MessageBox.Show("No hay ordenes de preparacion empaquetadas para agregar a la orden de entrega");
            }

            foreach (var orden in ordenesPreparacion)
            {
                var item = new ListViewItem(new[]
                  {
                        orden.IdOrdenPreparacion.ToString(),
                        orden.FechaEntrega.ToShortDateString(),
                    });

                // Agregar el item al ListView
                OrdenesEmpaquetadasListView.Items.Add(item);
            }
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
            MenuPrincipalGeneralForm menuPrincipalForm = new MenuPrincipalGeneralForm();
            menuPrincipalForm.Show();
        }

        private void VolverMenuPrincipalButton_Click(object sender, EventArgs e)
        {
            VolverAlMenuPrincipal();
        }

        private void CargarOrdenEntregaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            VolverAlMenuPrincipal();
        }
    }

}
