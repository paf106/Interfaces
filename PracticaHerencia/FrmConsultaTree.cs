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
    public partial class FrmConsultaTree : FrmPadre
    {
        public FrmConsultaTree()
        {
            InitializeComponent();
        }
        public void clearForm()
        {
            txtNombre.Clear();
            txtApellidos.Clear();
            txtCiudad.Clear();
            txtEmail.Clear();
            txtComentario.Clear();
        }

        private void FrmConsultaTree_Load(object sender, EventArgs e)
        {
            tvClientes.Nodes.Clear();
            
            foreach (Cliente c in FrmPadre.clientes)
            {
                TreeNode padre = new TreeNode();

                padre.Text = c.getCiudad();

                
                tvClientes.Nodes.Add(c.getCiudad(),padre.Text,2);
                

                if (c.getVip())
                {
                    tvClientes.Nodes[c.getCiudad()].Nodes.Add(c.getNombre(), c.getNombre(), 1);
                   

                }
                else
                {
                    tvClientes.Nodes[c.getCiudad()].Nodes.Add(c.getNombre(), c.getNombre(), 0);
                }

            }
        }

        private void tvClientes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            clearForm();
            //Evita que se cambie la foto del nodo
            tvClientes.SelectedImageIndex = tvClientes.SelectedNode.ImageIndex;

            // Nombre del cliente seleccionado
            string cli = (String)tvClientes.SelectedNode.Text;

            //Cliente temporal
            Cliente clienteTemp = new Cliente();

            foreach (Cliente c in FrmPadre.clientes)
            {

                if (c.getNombre().Equals(cli))
                {
                    // Asignamos la misma referencia de memoria al cliente temporal 
                    clienteTemp = c;
                }
            }

            txtNombre.Text = clienteTemp.getNombre();
            txtApellidos.Text = clienteTemp.getApellidos();
            txtCiudad.Text = clienteTemp.getCiudad();
            txtComentario.Text = clienteTemp.getComentario();
            txtEmail.Text = clienteTemp.getEmail();
        }
    }
}
