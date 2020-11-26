using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Reloj
{
    public partial class frmPrincipal : Form
    {
        Timer timer = new Timer();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime datetime = DateTime.Now;
            //datetime = datetime.AddHours(-3);
            txtHoraActual.Text = datetime.ToString("HH:mm:ss");

        }

        private void MenuItemClickHandler(object sender, EventArgs e)
        {
            ToolStripMenuItem clickedItem = (ToolStripMenuItem)sender;
            // Take some action based on the data in clickedItem
            label2.Text = "Hora en " + clickedItem.Text + ":";

            DateTime datetime = DateTime.Now;
            datetime = datetime.AddHours(Double.Parse(clickedItem.Tag.ToString()));
            txtHoraPaisDiferente.Text = datetime.ToString("HH:mm:ss");

            
            
        }
        private void interruptor(object sender, EventArgs e)
        {
            

        }

        private void mnuAnadir_Click(object sender, EventArgs e)
        {
            // Pedimos el nombre del país y la diferencia horaria
            string nombrePais = Interaction.InputBox("Escribe el nombre del país", "Nombre del país");
            int diferenciaHoraria = Int32.Parse(Interaction.InputBox("Escribe la diferencia horaria con respecto a nuesto país", "Cantidad de horas", "Ej: -5"));

            //Creamos el item y le agregamos el nombre y la diferencia horaria
            ToolStripMenuItem nuevoPais = new ToolStripMenuItem();
            nuevoPais.Text = nombrePais;
            nuevoPais.Tag = diferenciaHoraria;
            nuevoPais.Click += new EventHandler(MenuItemClickHandler);

            mnuPais.DropDownItems.Add(nuevoPais);
            timer.Enabled = true;
            timer.Interval = 100;
            timer.Tick += new EventHandler(interruptor);
        }

        private void mnuBorrar_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItemTemporal = new ToolStripMenuItem();
            foreach (object item in mnuPais.DropDownItems)
            {
                if (item.GetType().ToString().Equals("System.Windows.Forms.ToolStripMenuItem"))
                {
                    menuItemTemporal = (ToolStripMenuItem)item;
                    // Si en la label2 aparece el país sobre el que estamos iterando, asignamos ese objeto a un toolStripMenuItem temporal
                    if (label2.Text.Contains(menuItemTemporal.Text))
                    {
                        menuItemTemporal = (ToolStripMenuItem)item;
                    }
                }
            }
            mnuPais.DropDownItems.Remove(menuItemTemporal);
            txtHoraPaisDiferente.Clear();
            label2.Text = "Hora en ?:";
        }
    }
}
