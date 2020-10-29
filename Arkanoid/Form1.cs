using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arkanoid
{
    public partial class FrmPrincipal : Form
    {
        private int direccion = 4;
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Cambia la dirección de la pelota en funcion del número que le pasemos por parámetro
        /// </summary>
        /// <param name="dir"> Numero de la direccion</param>
        public void changeDirection(int dir)
        {
            switch (dir)
            {
                case 1:
                    picPelota.Left = picPelota.Left - 1;
                    picPelota.Top = picPelota.Top - 1;

                    // Choque pared arriba
                    if (picPelota.Top == 0)
                    {
                        direccion=
                    }
                    break;
                case 2:
                    // Para mover la pelota
                    picPelota.Left = picPelota.Left + 1;
                    picPelota.Top = picPelota.Top - 1;
                    break;
                // choque pared derecha
                // si pelota.left
                case 3:
                    // Para mover la pelota
                    picPelota.Left = picPelota.Left + 1;
                    picPelota.Top = picPelota.Top + 1;
                    break;
                // choque pared derecha
                // si pelota.left
                case 4:
                    // Para mover la pelota
                    picPelota.Left = picPelota.Left - 1;
                    picPelota.Top = picPelota.Top + 1;
                    break;
                    // choque pared derecha
                    // si pelota.left
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            changeDirection(direccion);
        }
    }
}
