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
                        direccion = 4;
                    }
                    // Choque pared izquierda
                    if (picPelota.Left == 0)
                    {
                        direccion = 2;
                    }
                    break;
                case 2:
                    // Para mover la pelota
                    picPelota.Left = picPelota.Left + 1;
                    picPelota.Top = picPelota.Top - 1;

                    // Choque pared arriba
                    if (picPelota.Top == 0)
                    {
                        direccion = 3;
                    }
                    // Choque pared derecha
                    if (picPelota.Location.X == 727)
                    {
                        direccion = 1;
                    }
                    break;
                case 3:

                    // Para mover la pelota
                    picPelota.Left = picPelota.Left + 1;
                    picPelota.Top = picPelota.Top + 1;

                    // Choque pared derecha
                    if (picPelota.Location.X == 727)
                    {
                        direccion = 4;
                    }
                    // Choque pared bottom
                    if (picPelota.Location.Y == 386)
                    {
                        direccion = 2;
                    }
                    break;

                case 4:
                    // Para mover la pelota
                    picPelota.Left = picPelota.Left - 1;
                    picPelota.Top = picPelota.Top + 1;

                    // Choque pared izquierda
                    if (picPelota.Location.X == 0)
                    {
                        direccion = 3;
                    }
                    // Choque pared bottom
                    if (picPelota.Location.Y == 386)
                    {
                        direccion = 1;
                    }
                    break;

            }
        }
        private void timerPelota_Tick(object sender, EventArgs e)
        {
            changeDirection(direccion);
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                picBarra.Left = picBarra.Left + 15;
            }
            if (e.KeyCode == Keys.Left)
            {
                picBarra.Left = picBarra.Left - 15;
            }
        }
    }
}
