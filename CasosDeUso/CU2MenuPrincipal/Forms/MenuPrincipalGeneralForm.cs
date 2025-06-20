﻿using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGrupoE.CasosDeUso.CU3CargarOrdenDePreparacion.Forms;
using TPGrupoE.CasosDeUso.CU4GenerarOrdenDeSeleccion.Forms;
using TPGrupoE.CasosDeUso.CU5GestionarOrdenDeSeleccion.Forms;
using TPGrupoE.CasosDeUso.CU6Empaquetado.Forms;
using TPGrupoE.CasosDeUso.CU7ConfirmarOrdenDeEntrega.Forms;
using TPGrupoE.CasosDeUso.CU8EmitirRemito.Forms;
using TPGrupoE.CasosDeUso.CU9ConsultaOrdenes.Forms;

namespace TPGrupoE.CasosDeUso.CU2MenuPrincipal.Forms
{
    public partial class MenuPrincipalGeneralForm : Form
    {
        public MenuPrincipalGeneralForm()
        {
            InitializeComponent();
        }
        private void CargarOrdenPreparacionButton_Click(object sender, EventArgs e)
        {
            CargarOrdenPreparacionForm cargaOrdenDePreparacionForm = new CargarOrdenPreparacionForm();
            this.Hide();
            cargaOrdenDePreparacionForm.Show();
        }

        private void GenerarOrdenSeleccionButton_Click(object sender, EventArgs e)
        {
            GenerarOrdenSeleccionForm generaOrdenDeSeleccionForm = new GenerarOrdenSeleccionForm();
            this.Hide();
            generaOrdenDeSeleccionForm.Show();
        }

        private void GestionarOrdenSeleccionButton_Click(object sender, EventArgs e)
        {
            GestionarOrdenSeleccionForm gestionOrdenSeleccionForm = new GestionarOrdenSeleccionForm();
            this.Hide();
            gestionOrdenSeleccionForm.Show();
        }

        private void EmpaquetadoButton_Click(object sender, EventArgs e)
        {
            EmpaquetadoForm empaquetadoForm = new EmpaquetadoForm();
            this.Hide();
            empaquetadoForm.Show();
        }
        private void ConfirmarOrdenDeEntregaButton_Click(object sender, EventArgs e)
        {
            ConfirmarOrdenDeEntregaForm cargaOrdenDeEntregaForm = new ConfirmarOrdenDeEntregaForm();
            this.Hide();
            cargaOrdenDeEntregaForm.Show();
        }

        private void EmitirRemitoButton_Click(object sender, EventArgs e)
        {
            EmitirRemitoForm emiteRemitoForm = new EmitirRemitoForm();
            this.Hide();
            emiteRemitoForm.Show();
        }

        private void ConsultarEstadoOrdenesButton_Click(object sender, EventArgs e)
        {
            ConsultarOrdenesForm consultaEstadoOrdenForm = new ConsultarOrdenesForm();
            this.Hide();
            consultaEstadoOrdenForm.Show();
        }

        private void MenuPrincipalGeneralForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
