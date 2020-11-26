using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.VisualBasic;

namespace Explorer
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            // Cargar unidades que tiene el equipo
            String[] unidades = Directory.GetLogicalDrives();
            foreach (string unidad in unidades)
            {
                TreeNode nodo = tvDirectorios.Nodes.Add(unidad);
                nodo.ImageIndex = 0;
                nodo.SelectedImageIndex = 0;
                nodo.Tag = unidad;
            }
        }

        private void tvDirectorios_AfterSelect(object sender, TreeViewEventArgs e)
        {
            lvArchivos.Items.Clear();
            tvDirectorios.SelectedNode.Nodes.Clear();
            try
            {
                foreach (string directorio in Directory.GetDirectories(e.Node.Tag.ToString()))
                {
                    TreeNode nodo = new TreeNode(Path.GetFileName(directorio));
                    e.Node.Nodes.Add(nodo);
                    nodo.ImageIndex = 1;
                    nodo.SelectedImageIndex = 1;
                    // Coje la ruta absoluta
                    nodo.Tag = directorio;
                }
                foreach (string archivo in Directory.GetFiles(e.Node.Tag.ToString()))
                {
                    ListViewItem lvi = new ListViewItem(Path.GetFileName(archivo), 2);
                    lvi.SubItems.Add(File.GetCreationTime(archivo).ToString());
                    lvi.SubItems.Add(File.GetLastWriteTime(archivo).ToString());
                    lvi.SubItems.Add(File.GetLastAccessTime(archivo).ToString());
                    lvArchivos.Items.Add(lvi);
                }
            }
            catch (UnauthorizedAccessException a)
            {
                MessageBox.Show("No tienes permisos para acceder a esa carpeta", "Acceso denegado");
            }
        }

        private void mnuDetalle_Click(object sender, EventArgs e)
        {
            lvArchivos.View = View.Details;
        }

        private void mnuIconosGrandes_Click(object sender, EventArgs e)
        {
            lvArchivos.View = View.LargeIcon;
        }

        private void mnuIconosPequenos_Click(object sender, EventArgs e)
        {
            lvArchivos.View = View.SmallIcon;
        }

        private void lvArchivos_DoubleClick(object sender, EventArgs e)
        {
            string nombreArchivo = Path.GetFileName(lvArchivos.SelectedItems[0].ToString());
            
            // Para coger el nombre del archivo solo
            string nombre = nombreArchivo.Substring(2, nombreArchivo.Length - 3);
            if (lvArchivos.SelectedItems[0].Text.Contains(".txt"))
            {
                VisorArchivosTexto v = new VisorArchivosTexto(tvDirectorios.SelectedNode.Tag.ToString() + "\\" + nombre);
                v.Show();
            }
        }

        private void mnuCarpeta_Click(object sender, EventArgs e)
        {
            string nombreCarpeta = Interaction.InputBox("Nombre de la nueva carpeta", "Nueva carpeta", "Nueva carpeta");

            string path = tvDirectorios.SelectedNode.Tag.ToString();
            Directory.CreateDirectory(path + "\\" + nombreCarpeta + "\\");
        }

        private void mnuFichero_Click(object sender, EventArgs e)
        {
            string fileName = tvDirectorios.SelectedNode.Tag.ToString();

            string nombreArchivo = Interaction.InputBox("Nombre del nuevo archivo", "Nuevo archivo", "Nuevo archivo");

            // Create a new file     
            File.Create(fileName + "\\" + nombreArchivo + ".txt");
        }
    }
}
