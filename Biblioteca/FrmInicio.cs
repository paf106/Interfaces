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

namespace Biblioteca
{
    public partial class FrmInicio : Form
    {
        internal static HashSet<Libro> libros = new HashSet<Libro>();
        public FrmInicio()
        {
            InitializeComponent();
            
    }
        /// <summary>
        /// Cierra los hijos mdi del padre FrmInicio
        /// </summary>
        public void closeMdiChilds()
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm != Parent)
                {
                    frm.Close();
                }
            }
        }

        private void MnuFichero_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblTime.Text = "Hora actual: " + DateTime.Now.ToString("hh:mm:ss");

        }

        private void FrmInicio_Load(object sender, EventArgs e)
        {
            IsMdiContainer = false;

        }

        private void StaBarraAbajo_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            
        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuAlta_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            closeMdiChilds();
            FrmAltaLibros f = new FrmAltaLibros();
            f.MdiParent = this;
            f.Show();
        }

        private void MnuConsulta_Click(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            closeMdiChilds();
            FrmConsultaLibros c = new FrmConsultaLibros();
            c.MdiParent = this;
            c.Show();
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Seguro que quieres salir?", "Salir",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
