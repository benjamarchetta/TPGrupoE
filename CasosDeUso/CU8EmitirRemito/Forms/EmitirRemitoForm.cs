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
using TPGrupoE.CasosDeUso.CU6EmitirRemito.Model;

public class ComboBoxItem
{
    public string Text { get; set; }
    public string Value { get; set; }
    public override string ToString() => Text;
}

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
            // Cuando se carga el formulario, leo todos los datos de los almacenes (clientes, OP, remitos y OE).
            ClienteAlmacen.LeerCliente();
            OrdenPreparacionAlmacen.LeerOP();
            RemitoAlmacen.LeerRemito();
            OrdenEntregaAlmacen.LeerOE();

            comboBoxTransportistas.Items.Clear();

            // Uso el modelo para obtener la lista de transportistas que tienen OPs "Preparadas" con OE "Pendiente".
            foreach (var dni in _model.ObtenerTransportistas())
            {
                comboBoxTransportistas.Items.Add(new ComboBoxItem { Text = dni.ToString(), Value = dni.ToString() });
            }

            comboBoxClientes.Items.Clear();
            ListViewOrdenesADespachar.Items.Clear();
        }

        private void comboBoxTransportistas_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Cuando elijo un transportista, limpio el combo de clientes.
            comboBoxClientes.Items.Clear();

            if (comboBoxTransportistas.SelectedItem is ComboBoxItem seleccionado)
            {
                int dni = int.Parse(seleccionado.Value);

                // Uso el modelo para filtrar clientes por transportista.
                foreach (var idCliente in _model.ObtenerClientesPorTransportista(dni))
                {
                    var cliente = ClienteAlmacen.Clientes.FirstOrDefault(c => c.IdCliente == idCliente);
                    if (cliente != null)
                        comboBoxClientes.Items.Add(new ComboBoxItem { Text = cliente.RazonSocial, Value = cliente.IdCliente.ToString() });
                }
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            // Cuando presiono "Seleccionar", limpio la lista de OPs a despachar.
            ListViewOrdenesADespachar.Items.Clear();

            if (comboBoxTransportistas.SelectedItem is ComboBoxItem tSel && comboBoxClientes.SelectedItem is ComboBoxItem cSel)
            {
                int dni = int.Parse(tSel.Value);
                int idCliente = int.Parse(cSel.Value);

                // Uso el modelo para traer las OPs preparadas, de ese transportista y cliente, con OE pendiente.
                var ops = _model.ObtenerOPsParaDespachar(dni, idCliente);

                foreach (var op in ops)
                {
                    var idOE = _model.ObtenerIdOEPorOP(op.IdOrdenPreparacion);
                    var item = new ListViewItem(new[]
                    {
                        op.IdOrdenPreparacion.ToString(),
                        op.FechaEntrega.ToShortDateString(),
                        idOE.HasValue ? idOE.Value.ToString() : "-"
                    });
                    ListViewOrdenesADespachar.Items.Add(item);
                }
            }
        }

        private void btnDespacharYEmitirRemito_Click(object sender, EventArgs e)
        {
            // Verifico que haya al menos una OP seleccionada en la lista.
            if (ListViewOrdenesADespachar.SelectedItems.Count == 0)
            {
                MessageBox.Show("Seleccioná al menos una orden de preparación.");
                return;
            }

            // Armo la lista de IDs de OP seleccionadas para mostrar y confirmar.
            var opsIds = ListViewOrdenesADespachar.SelectedItems
                .Cast<ListViewItem>()
                .Select(item => int.Parse(item.SubItems[0].Text))
                .ToList();

            // Pregunto al usuario si desea emitir el remito de esas OPs.
            string msg = "¿Desea emitir el remito de la/las órdenes de preparación seleccionadas?\n" +
                         string.Join(", ", opsIds);
            var result = MessageBox.Show(msg, "Confirmar", MessageBoxButtons.OKCancel);

            if (result != DialogResult.OK)
                return;

            // Llamo al modelo para despachar y emitir remito, y muestro el mensaje que devuelve.
            var mensaje = _model.DespacharYEmitirRemito(opsIds);
            MessageBox.Show(mensaje);
            ListViewOrdenesADespachar.Items.Clear();
        }
    }
}