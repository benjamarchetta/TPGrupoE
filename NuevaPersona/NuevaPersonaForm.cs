using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPGrupoE.NuevaPersona
{
    //Presentador - Codigo del formulario
    public partial class NuevaPersonaForm : Form
    {
        private NuevaPersonaModelo modelo;
        
        public NuevaPersonaForm()
        {
            InitializeComponent();
        }

        private void NuevaPersonaForm_Load(object sender, EventArgs e)
        {
            //Lo primero que se ejecuta
            modelo = new NuevaPersonaModelo();
        }
    }
}
