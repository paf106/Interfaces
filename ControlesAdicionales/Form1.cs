using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesAdicionales
{
    public partial class frmPrincipal : Form
    {
        // atributo para asignar automaticamente el ID a cada cliente y pedido
        private int idClienteActual = 0;
        private int idPedidoActual = 0;

        private SortedList<int, Cliente> clientes = new SortedList<int, Cliente>();
        private SortedList<int, Pedido> pedidos = new SortedList<int, Pedido>();

        public frmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Limpia el formulario
        /// </summary>
        public void clearForm()
        {
            if (tabClientesPedidos.SelectedTab.Text.Equals("Clientes"))
            {
                txtNombre.Clear();
                txtApellidos.Clear();
                txtFechaNacimiento.Clear();
                txtCodigoPostal.Clear();
                txtDireccion.Clear();
                txtNif.Clear();
                errorProvider1.Clear();
            }
            else
            {
                txtPedidosNombre.Clear();
                txtPedidosApellidos.Clear();
                txtPedidosNif.Clear();
                lbPedidos.Items.Clear();
                errorProvider1.Clear();
            }
        }
        public bool checkForm()
        {
            if (tabClientesPedidos.SelectedTab.Text.Equals("Clientes"))
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrEmpty(txtCodigoPostal.Text) || string.IsNullOrEmpty(txtDireccion.Text)
                    || string.IsNullOrEmpty(txtNif.Text) || string.IsNullOrEmpty(txtFechaNacimiento.Text))
                {
                    return false;
                }
                else
                {
                    errorProvider1.Clear();
                    return true;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(txtPedidosNif.Text) || string.IsNullOrEmpty(txtPedidosApellidos.Text) || string.IsNullOrEmpty(txtPedidosNombre.Text))
                {
                    return false;
                }
                else
                {
                    errorProvider1.Clear();
                    return true;
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.trekbikes.com/es/es_ES/");

        }

        private void mnuMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void mnuNormal_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }

        private void mnuMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuLimpiar_Click(object sender, EventArgs e)
        {
            clearForm();
        }

        private void mnuGuardar_Click(object sender, EventArgs e)
        {
            if (tabClientesPedidos.SelectedTab.Text.Equals("Clientes"))
            {
                if (checkForm())
                {
                    // Formulario sin errores
                    idClienteActual++;
                    clientes.Add(idClienteActual, new Cliente(txtNombre.Text, txtApellidos.Text, txtFechaNacimiento.Text, txtNif.Text, txtDireccion.Text, txtCodigoPostal.Text));
                    timer1.Start();
                }
                else
                {
                    // Formulario con algún dato incompleto
                    errorProvider1.SetError(nudCliente, "Hay campos sin rellenar");
                }
                
            }
            else
            {
                if (checkForm())
                {
                    // Formulario sin errores
                    idPedidoActual++;
                    ArrayList arrayTemp = new ArrayList();
                    foreach (string item in lbPedidos.Items)
                    {
                        arrayTemp.Add(item);
                    }
                    pedidos.Add(idPedidoActual, new Pedido(txtPedidosNif.Text,txtPedidosNombre.Text,txtPedidosApellidos.Text,arrayTemp));
                    timer1.Start();
                }
                else
                {
                    // Formulario con algún dato incompleto
                    errorProvider1.SetError(nudPedido, "Hay campos sin rellenar");
                }
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lbPedidos.AllowDrop = true;
            lbBicicletas.AllowDrop = true;
        }
        private void lbBicicletas_MouseDown(object sender, MouseEventArgs e)
        {
            lbPedidos.DoDragDrop(lbBicicletas.SelectedItem.ToString(), DragDropEffects.Copy);
        }
        private void frmPrincipal_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.None;
        }

        private void txtPedidosPedido_DragDrop(object sender, DragEventArgs e)
        {
            lbPedidos.Text = e.Data.GetData(DataFormats.Text).ToString();
        }

        private void txtPedidosPedido_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void nudCliente_ValueChanged(object sender, EventArgs e)
        {
            // Valor del NumericUpDown
            int valorIdCliente = (int)nudCliente.Value;

            try
            {
                txtNombre.Text = clientes[valorIdCliente].getNombre();
                txtApellidos.Text = clientes[valorIdCliente].getApellidos();
                txtFechaNacimiento.Text = clientes[valorIdCliente].getFechaNacimiento();
                txtDireccion.Text = clientes[valorIdCliente].getDireccion();
                txtCodigoPostal.Text = clientes[valorIdCliente].getCodigoPostal();
                txtNif.Text = clientes[valorIdCliente].getNif();
            }
            catch (KeyNotFoundException f)
            {
                clearForm();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (tabClientesPedidos.SelectedTab.Text.Equals("Clientes"))
            {
                if (pbClientes.Value < pbClientes.Maximum)
                {
                    pbClientes.Value += (pbClientes.Maximum / 3);
                }
                else if (pbClientes.Value == pbClientes.Maximum)
                {
                    timer1.Stop();
                    MessageBox.Show("Cliente guardado");
                    clearForm();
                    pbClientes.Value = 0;
                }
            }
            else
            {
                if (pbPedidos.Value < pbPedidos.Maximum)
                {
                    pbPedidos.Value += (pbClientes.Maximum / 3);
                }
                else if (pbPedidos.Value == pbPedidos.Maximum)
                {
                    timer1.Stop();
                    MessageBox.Show("Pedido guardado");
                    clearForm();
                    pbPedidos.Value = 0;
                }
            }
        }

        private void mnuColor_Click(object sender, EventArgs e)
        {
            if (tabClientesPedidos.SelectedTab.Text.Equals("Clientes"))
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    tabClientes.BackColor = colorDialog1.Color;
            }
            else
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                    tabPedidos.BackColor = colorDialog1.Color;
            }

        }
        private void mnuFuente_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
                foreach (Control c in Controls)
                {
                    c.Font =  fontDialog1.Font;
                }
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            // Valor del NumericUpDown
            int valorIdPedido = (int)nudPedido.Value;

            try
            {
                lbPedidos.Items.Clear();
                txtPedidosNif.Text = pedidos[valorIdPedido].getNif();
                txtPedidosApellidos.Text = pedidos[valorIdPedido].getApellidos();
                txtPedidosNombre.Text = pedidos[valorIdPedido].getNombre();
                foreach (string s in pedidos[valorIdPedido].getPedidos())
                {
                    lbPedidos.Items.Add(s);
                }
            }
            catch (KeyNotFoundException f)
            {
                clearForm();
            }
        }

        private void txtPedidosNif_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (KeyValuePair<int, Cliente> client in clientes)
                {
                    if (txtPedidosNif.Text.Equals(client.Value.getNif()))
                    {
                        txtPedidosApellidos.Text = client.Value.getApellidos();
                        txtPedidosNombre.Text = client.Value.getNombre();
                    }
                    else
                    {
                        MessageBox.Show("No se ha encotrado ningun cliente con ID: " + txtPedidosNif.Text);
                    }
                }
            }

        }

        private void lbPedidos_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lbPedidos_DragDrop(object sender, DragEventArgs e)
        {
            lbPedidos.Items.Add(e.Data.GetData(DataFormats.Text));
            lbBicicletas.Items.Remove(e.Data.GetData(DataFormats.Text));
        }
    }
}
