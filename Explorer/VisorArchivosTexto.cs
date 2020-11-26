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


namespace Explorer
{
    public partial class VisorArchivosTexto : Form
    {
        string path;
        public VisorArchivosTexto()
        {
            InitializeComponent();
        }
        public VisorArchivosTexto(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void VisorArchivosTexto_Load(object sender, EventArgs e)
        {
            txtContenido.Width = this.Width;
            txtContenido.Height = Height;

            string textoArchivo = File.ReadAllText(path,Encoding.UTF8);
            txtContenido.Text = textoArchivo;
        }

        private void VisorArchivosTexto_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Quiernes guardar?", "Guardar",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Si pulsa en el botón YES se guarda el contenido
                string contenidoTexto = txtContenido.Text;
                File.WriteAllText(path, contenidoTexto);
            }
            
        }
    }
}
