using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaHerencia
{
    public partial class FrmPadre : Form
    {
        //sortedList <String, Cliente>
        //Internal static SortedList<String, Cliente> listaClientes = new SortedList<string, Cliente>();
        internal static ArrayList clientes = new ArrayList();
        //TODO
        //Aplication.openForms -> sirve para saber que formularios están creados
        public FrmPadre()
        {
            InitializeComponent();
        }

        private void FrmPadre_Load(object sender, EventArgs e)
        {

        }

        private void MnuAlta_Click(object sender, EventArgs e)
        {
            bool encontrado = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType().Name.Equals("FrmAlta"))
                {
                    form.Show();
                    encontrado = true;
                } 
            }
            if (!encontrado)
            {
                FrmAlta f = new FrmAlta();
                f.Show();
                this.Hide();
            }


        }
    }
}
