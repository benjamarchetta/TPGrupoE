using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPGrupoE.CasoU_Confirmar_Seleccion
{
    public partial class CumplirOrdenSeleccionForm : Form
    {
        public CumplirOrdenSeleccionForm()
        {
            InitializeComponent();
        }

        private int alturaOriginal;
        private bool detallesVisibles = false;

        private void ConfirmarSeleccionForm_Load(object sender, EventArgs e)
        {
            // Guardamos las alturas para después
            alturaOriginal = 816;


            // Ocultamos el ListView al iniciar
            //listView1.Visible = false;
        }


        private void VerDetallesButton_Click(object sender, EventArgs e)
        {
            if (!detallesVisibles)
            {
                this.Height = 440;;
                verDetallesPreparacionListView.Visible = true;
                VerDetallesButton.Text = "Ocultar detalles";
                detallesVisibles = true;
            }
            else
            {
                this.Height = 241;
                verDetallesPreparacionListView.Visible = false;
                VerDetallesButton.Text = "Ver detalles";
                detallesVisibles = false;

            }
        }

        private void verDetallesPreparacionListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
