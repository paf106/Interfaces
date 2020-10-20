using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FrmAltaLibros : Form
    {
        public FrmAltaLibros()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Limpia el formulario de creación de libros
        /// </summary>
        public void cleanBookInfo()
        {
            TxtAutor.Clear();
            TxtEditorial.Clear();
            TxtTitulo.Clear();
            ChkNuevo.Checked = false;
            PicImagen.Image = null;
        }
        private void BtnCargarFoto_Click(object sender, EventArgs e)
        {
            OfdCargarFoto.ShowDialog();

          Bitmap imagen = new Bitmap(OfdCargarFoto.FileName);
          PicImagen.Image = imagen;
        }

        private void FrmAltaLibros_Load(object sender, EventArgs e)
        {
           
            OfdCargarFoto.InitialDirectory = "C:\\";
            OfdCargarFoto.Filter = "Image files (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|All files (*.*)|*.*";
            OfdCargarFoto.FileName = "";
            OfdCargarFoto.FilterIndex = 1;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Libro libro = new Libro(TxtTitulo.Text, TxtAutor.Text, TxtEditorial.Text, ChkNuevo.Checked, OfdCargarFoto.FileName);
            FrmInicio.libros.Add(libro);
            MessageBox.Show("Libro guardado");
            cleanBookInfo();

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            cleanBookInfo();
        }
    }
}
