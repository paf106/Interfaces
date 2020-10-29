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

namespace PracticaHerencia
{
    public partial class FrmConsultaList : FrmPadre
    {
        public FrmConsultaList()
        {
            InitializeComponent();
        }

        private void FrmConsultaList_Load(object sender, EventArgs e)
        {
            cbVista.SelectedIndex = 0;

            foreach (Cliente c in FrmPadre.clientes)
            {
                if (!cbCiudad.Items.Contains(c.getCiudad()))
                {
                    cbCiudad.Items.Add(c.getCiudad());
                }
            }
        }

        private void cbCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvClientes.Items.Clear();
            foreach (Cliente c in FrmPadre.clientes)
            {
                if (c.getCiudad().Equals(cbCiudad.SelectedItem.ToString()))
                {
                    ilImagenes = new ImageList();
                    ListViewItem lv;
                    if (c.getVip())
                    {
                        lv = lvClientes.Items.Add(c.getNombre(), 1);
                        lv.SubItems.Add(c.getApellidos());
                        lv.SubItems.Add(c.getEmail());
                        lv.SubItems.Add(c.getComentario());
                    }
                    else
                    {
                        lv = lvClientes.Items.Add(c.getNombre(), 0);
                        lv.SubItems.Add(c.getApellidos());
                        lv.SubItems.Add(c.getEmail());
                        lv.SubItems.Add(c.getComentario());
                    }
                    
                }
            }
        }

        private void cbVista_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbVista.SelectedItem.ToString())
            {
                case "Detalle":
                    lvClientes.View = View.Details;
                    break;
                case "Iconos grandes":
                    lvClientes.View = View.LargeIcon;
                    break;
                case "Iconos pequeños":
                    lvClientes.View = View.SmallIcon;
                    break;
            }
            
        }
    }
}
