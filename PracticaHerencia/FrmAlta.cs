using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaHerencia
{
    public partial class FrmAlta : FrmPadre
    {
        public FrmAlta()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Limpia los datos del formulario
        /// </summary>
        public void clearForm()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCiudad.Clear();
            txtEmail.Clear();
            txtComentario.Clear();
            chkVip.Checked = false;
            PicFoto.Image = null;
        }
        /// <summary>
        /// Refresca la listbox
        /// </summary>
        public void refreshClients()
        {
            lbClientes.Items.Clear();
            foreach(Cliente c in FrmPadre.clientes)
            {
                lbClientes.Items.Add(c.getNombre());
            }
        }
        private void FrmAlta_Load(object sender, EventArgs e)
        {
            ofdSeleccionarImagen.InitialDirectory = "C:\\";
            ofdSeleccionarImagen.Filter = "Image files (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|All files (*.*)|*.*";
            ofdSeleccionarImagen.FileName = "";
            ofdSeleccionarImagen.FilterIndex = 1;
        }

        private void tSNuevo_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente(txtNombre.Text, txtApellidos.Text, txtCiudad.Text, txtEmail.Text, txtComentario.Text, chkVip.Checked, ofdSeleccionarImagen.FileName);
            FrmPadre.clientes.Add(c);
            MessageBox.Show("Cliente " + c.getNombre()+ " añadido");
            clearForm();
            refreshClients();
        }

        private void tSBorrar_Click(object sender, EventArgs e)
        {
            // Nombre del cliente seleccionado
            string cli = (String)lbClientes.SelectedItem;

            //Cliente temporal para eliminar
            Cliente clienteTemp = new Cliente();

            foreach (Cliente c in FrmPadre.clientes)
            {
                
                if (c.getNombre().Equals(cli))
                {
                    // Asignamos la misma referencia de memoria al cliente temporal para su posterior eliminación
                    clienteTemp = c;
                }
            }
            FrmPadre.clientes.Remove(clienteTemp);
            refreshClients();
            clearForm();
        }

        private void tSGuardar_Click(object sender, EventArgs e)
        {
            // Nombre del cliente seleccionado
            string cli = (String)lbClientes.SelectedItem;

            //Cliente temporal para eliminar
            Cliente clienteTemp = new Cliente();

            foreach (Cliente c in FrmPadre.clientes)
            {

                if (c.getNombre().Equals(cli))
                {
                    // Asignamos la misma referencia de memoria al cliente temporal para su posterior eliminación
                    clienteTemp = c;
                }
            }
            // Creamos y añadimos al array el cliente nuevo
            Cliente nuevoCliente = new Cliente(txtNombre.Text, txtApellidos.Text, txtCiudad.Text, txtEmail.Text, txtComentario.Text, chkVip.Checked,ofdSeleccionarImagen.FileName);
            FrmPadre.clientes.Add(nuevoCliente);
            MessageBox.Show("Cliente " + nuevoCliente.getNombre() + " guardado");

            // Eliminamos el cliente anterior
            FrmPadre.clientes.Remove(clienteTemp);
            refreshClients();
            clearForm();
        }

        private void lbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearForm();

            // Nombre del cliente seleccionado
            string cli = (String)lbClientes.SelectedItem;

            //Cliente temporal
            Cliente clienteTemp = new Cliente();

            foreach (Cliente c in FrmPadre.clientes)
            {

                if (c.getNombre().Equals(cli))
                {
                    // Asignamos la misma referencia de memoria al cliente temporal para su posterior eliminación
                    clienteTemp = c;
                }
            }

            txtNombre.Text = clienteTemp.getNombre();
            txtApellidos.Text = clienteTemp.getApellidos();
            txtCiudad.Text = clienteTemp.getCiudad();
            txtComentario.Text = clienteTemp.getComentario();
            txtEmail.Text = clienteTemp.getEmail();
            chkVip.Checked = clienteTemp.getVip();
            try
            {
                Bitmap imagen = new Bitmap(clienteTemp.getImagen());
                PicFoto.Image = imagen;
            }
            catch(ArgumentException fe)
            {}
            
        }

        private void PicFoto_DoubleClick(object sender, EventArgs e)
        {
            ofdSeleccionarImagen.ShowDialog();
            try {
                Bitmap imagen = new Bitmap(ofdSeleccionarImagen.FileName);
                PicFoto.Image = imagen;
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show("Imagen no seleccionada");
            }
            
        }

        private void btnEliminarFoto_Click(object sender, EventArgs e)
        {
            ofdSeleccionarImagen.FileName = "";
            PicFoto.Image = null;
        }
    }
}
