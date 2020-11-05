using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Arkanoid
{
    public partial class FrmPrincipal : Form
    {
        private int direccion = 2;
        private int puntuacion = 0;
        private int velocidadLeft = 5;
        private int velocidadTop = 5;
        private int vidas = 3;

        public FrmPrincipal()
        {
            InitializeComponent();
            timerPelota.Interval = 15;
        }
        /// <summary>
        /// Aumenta la puntuación y la velocidad de la pelota al tocar la barra
        /// </summary>
        public void increaseScoreAndSpeed()
        {
            puntuacion += 50;
            lblPuntuacion.Text = puntuacion.ToString();
            velocidadLeft++;
            velocidadTop++;
        }
        public void finishGame()
        {
            timerPelota.Stop();
            var resultado = MessageBox.Show("Puntuación: " + puntuacion, "Has perdido",MessageBoxButtons.OK);

            if (resultado == DialogResult.OK)
            {
                picVida1.Image = Arkanoid.Properties.Resources.corazon;
                picVida2.Image = Arkanoid.Properties.Resources.corazon;
                velocidadLeft = 5;
                velocidadTop = 5;
                direccion = 2;
                picPelota.Top =200;
                picPelota.Left = 200;
                puntuacion = 0;
                lblPuntuacion.Text = puntuacion.ToString();
                vidas = 3;
                timerPelota.Start();
            }
        }
        public void stopGame()
        {

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
                    picPelota.Left = picPelota.Left - velocidadLeft;
                    picPelota.Top = picPelota.Top - velocidadTop;

                    // Choque pared arriba
                    if (picPelota.Top <= 0)
                    {
                        direccion = 4;
                    }
                    // Choque pared izquierda
                    if (picPelota.Left <= 0)
                    {
                        direccion = 2;
                    }
                    break;
                case 2:
                    // Para mover la pelota
                    picPelota.Left = picPelota.Left + velocidadLeft;
                    picPelota.Top = picPelota.Top - velocidadTop;

                    // Choque pared arriba
                    if (picPelota.Top <= 0)
                    {
                        direccion = 3;
                    }
                    // Choque pared derecha
                    if (picPelota.Location.X >= 727)
                    {
                        direccion = 1;
                    }
                    break;
                case 3:

                    // Para mover la pelota
                    picPelota.Left = picPelota.Left + velocidadLeft;
                    picPelota.Top = picPelota.Top + velocidadTop;

                    if (picPelota.Bottom >= picBarra.Top && picPelota.Bottom <= picBarra.Bottom && picPelota.Left >= picBarra.Left && picPelota.Right <= picBarra.Right)
                    {
                        direccion = 2;
                        increaseScoreAndSpeed();


                    }

                    // Choque pared derecha
                    if (picPelota.Location.X >= 727)
                    {
                        direccion = 4;
                    }
                    // Choque pared bottom
                    if (picPelota.Location.Y >= 387)
                    {
                        if (vidas == 1)
                        {
                            finishGame();
                        }
                        else
                        {
                            if (picVida1.Image != null)
                            {
                                picVida1.Image = null;
                            }
                            else if (picVida2.Image != null)
                            {
                                picVida2.Image = null;
                            }
                            else if (picVida1.Image != null)
                            {
                                picVida3.Image = null;
                            }
                            vidas--;
                            picPelota.Top = 200;
                            picPelota.Left = 200;
                            direccion = 2;
                        }
                        
                    }
                    break;

                case 4:
                    // Para mover la pelota
                    picPelota.Left = picPelota.Left - velocidadLeft;
                    picPelota.Top = picPelota.Top + velocidadTop;

                    if (picPelota.Bottom >= picBarra.Top && picPelota.Bottom <= picBarra.Bottom && picPelota.Left >= picBarra.Left && picPelota.Right <= picBarra.Right)
                    {
                        direccion = 1;
                        increaseScoreAndSpeed();
                    }

                    // Choque pared izquierda
                    if (picPelota.Location.X <= 0)
                    {
                        direccion = 3;
                    }
                    // Choque pared bottom
                    if (picPelota.Location.Y >= 386)
                    {
                        if (vidas == 1)
                        {
                            finishGame();
                        }
                        else
                        {
                            if (picVida1.Image != null)
                            {
                                picVida1.Image = null;
                            }
                            else if (picVida2.Image != null)
                            {
                                picVida2.Image = null;
                            }
                            else if (picVida1.Image != null)
                            {
                                picVida3.Image = null;
                            }
                            vidas--;
                            picPelota.Top = 200;
                            picPelota.Left = 200;
                            direccion = 2;
                        }
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
                if (e.KeyCode == Keys.Right)
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
