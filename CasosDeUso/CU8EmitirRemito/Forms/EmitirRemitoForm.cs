using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPGrupoE.CasosDeUso.CU6EmitirRemito.Model;

namespace TPGrupoE.CasoU_Generar_Orden_de_Entrega
{
    public partial class EmitirRemitoForm : Form
    {
        private EmitirRemitoModel _model;
        public EmitirRemitoForm()
        {
            InitializeComponent();
            _model = new EmitirRemitoModel();

        }

        private void EmitirRemitoForm_Load(object sender, EventArgs e)
        {
            comboBoxTransportistas.Items.Clear();
            foreach (var t in _model.Transportistas)
            {
                comboBoxTransportistas.Items.Add(new ComboBoxItem { Text = t.Nombre, Value = t.DNI.ToString() });
            }
            comboBoxClientes.Items.Clear();
            dataGridViewOPs.DataSource = null;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
