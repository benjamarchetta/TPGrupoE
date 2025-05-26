using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPGrupoE.CasoU_Orden_Preparacion
{
    public partial class ProcesarOrdenPreparacionForm : Form
    {
        public ProcesarOrdenPreparacionForm()
        {
            InitializeComponent();
        }

        private void ProcesarOrdenPreparacion_Load(object sender, EventArgs e)
        {
            palletCerradoComboBox.SelectedIndex = 0;
        }

        private void cantidadARetirarTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cantidadARetirarTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo dígitos y tecla de borrado (Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // bloquea la tecla
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
