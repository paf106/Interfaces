using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trivial
{
    public partial class FrmPrincipal : Form
    {
        string[] paises = { "España", "Portugal", "Francia", "Alemania", "Finlandia", "Grecia", "Belgica", "Rumania", "Rusia", "Polonia", "Suecia", "Suiza" };
        string[] capitales = { "Madrid", "Lisboa", "Paris", "Berlín", "Helsinki", "Atenas", "Bruselas", "Bucarest", "Moscu", "Varsovia", "Estocolmo", "Berna" };

        int indicePais;
        double respuestasAcertadas = 0;
        double totalPreguntas = 0;
        double porcentaje = 0;

        /// <summary>
        /// Metodo que limpia todas las cajas de texto para empezar una nueva partida
        /// </summary>
        public void newGame()
        {
            TxtCapital1.Clear();
            TxtCapital2.Clear();
            TxtCapital3.Clear();
            TxtCapital4.Clear();

            TxtCapital1.BackColor = SystemColors.Control;
            TxtCapital2.BackColor = SystemColors.Control;
            TxtCapital3.BackColor = SystemColors.Control;
            TxtCapital4.BackColor = SystemColors.Control;

            BtnSiguente.Enabled = false;

            respuestasAcertadas = 0;
            totalPreguntas = 0;

            TxtPorcentajeAciertos.Clear();


        }

        public void calculatePercentage()
        {
            porcentaje = (respuestasAcertadas / totalPreguntas) * 100;
            int porcentajeInt = (int)porcentaje;
            TxtPorcentajeAciertos.Text = porcentajeInt.ToString() + "%";
        }

        public void fillEscribirRespuestas()
        {
            TxtCapital1.ReadOnly = false;

            TxtCapital1.Clear();
            TxtCapital1.BackColor = SystemColors.Control;

            if (MnuNombreCapitales.Checked == true && MnuEscribirRespuesta.Checked == true)
            {
                LblPais.Text = "Pais:";
                LblCapital.Text = "Capital:";

                //Sacar pais aleatorio y mostrarlo en el txt
                Random aleatorio = new Random();
                int numeroAleatorio = aleatorio.Next(0, paises.Length);
                indicePais = numeroAleatorio;
                TxtPais.Text = paises[numeroAleatorio];
            }
            else if (MnuNombrePaises.Checked == true && MnuEscribirRespuesta.Checked == true)
            {
                LblPais.Text = "Capital:";
                LblCapital.Text = "Pais:";

                //Sacar capital aleatoria y mostrarlo en el txt
                Random aleatorio = new Random();
                int numeroAleatorio = aleatorio.Next(0, capitales.Length);
                indicePais = numeroAleatorio;
                TxtPais.Text = capitales[numeroAleatorio];
            }
        }

        /// <summary>
        /// Metodo que rellena las cajas de texto con capitales aleatorias
        /// </summary>
        public void fillTxtBoxes()
        {
            LblPais.Text = "Pais:";
            LblCapital.Text = "Capitales:";

            TxtCapital1.Clear();
            TxtCapital2.Clear();
            TxtCapital3.Clear();
            TxtCapital4.Clear();

            TxtCapital1.BackColor = SystemColors.Control;
            TxtCapital2.BackColor = SystemColors.Control;
            TxtCapital3.BackColor = SystemColors.Control;
            TxtCapital4.BackColor = SystemColors.Control;

            BtnSiguente.Enabled = false;

            //Sacar pais aleatorio y mostrarlo en el txt
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(0, paises.Length);
            indicePais = numeroAleatorio;
            TxtPais.Text = paises[numeroAleatorio];

            //Sacar la respuesta correcta y mostrarlo en el txt aleatoriamente
            string respuestaCorrecta = capitales[indicePais];
            int cajaAleatoria = aleatorio.Next(0, 4);
            switch (cajaAleatoria)
            {
                case 0:
                    TxtCapital1.Text = respuestaCorrecta;
                    break;
                case 1:
                    TxtCapital2.Text = respuestaCorrecta;
                    break;
                case 2:
                    TxtCapital3.Text = respuestaCorrecta;
                    break;
                case 3:
                    TxtCapital4.Text = respuestaCorrecta;
                    break;
            }
            // escribir las capitales en los cuadros de texto
            TextBox[] cajas = { TxtCapital1, TxtCapital2, TxtCapital3, TxtCapital4 };
            do
            {
                for (int i = 0; i < cajas.Length; i++)
                {
                    int indiceCapitales = aleatorio.Next(0, capitales.Length);
                    if (string.IsNullOrEmpty(cajas[i].Text) && !TxtCapital1.Text.Equals(capitales[indiceCapitales]) && !TxtCapital2.Text.Equals(capitales[indiceCapitales])
                        && !TxtCapital3.Text.Equals(capitales[indiceCapitales]) && !TxtCapital4.Text.Equals(capitales[indiceCapitales]))
                    {
                        cajas[i].Text = capitales[indiceCapitales];
                    }
                }
            } while (string.IsNullOrEmpty(TxtCapital1.Text) || string.IsNullOrEmpty(TxtCapital2.Text) || string.IsNullOrEmpty(TxtCapital3.Text) || string.IsNullOrEmpty(TxtCapital4.Text));
        }
        public void fillTxtBoxesPaises()
        {
            LblPais.Text = "Capital:";
            LblCapital.Text = "Paises:";

            TxtCapital1.Clear();
            TxtCapital2.Clear();
            TxtCapital3.Clear();
            TxtCapital4.Clear();

            TxtCapital1.BackColor = SystemColors.Control;
            TxtCapital2.BackColor = SystemColors.Control;
            TxtCapital3.BackColor = SystemColors.Control;
            TxtCapital4.BackColor = SystemColors.Control;

            BtnSiguente.Enabled = false;

            //Sacar capital aleatoria y mostrarlo en el txt
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(0, capitales.Length);
            indicePais = numeroAleatorio;
            TxtPais.Text = capitales[numeroAleatorio];

            //Sacar la respuesta correcta y mostrarlo en el txt aleatoriamente
            string respuestaCorrecta = paises[indicePais];
            int cajaAleatoria = aleatorio.Next(0, 4);
            switch (cajaAleatoria)
            {
                case 0:
                    TxtCapital1.Text = respuestaCorrecta;
                    break;
                case 1:
                    TxtCapital2.Text = respuestaCorrecta;
                    break;
                case 2:
                    TxtCapital3.Text = respuestaCorrecta;
                    break;
                case 3:
                    TxtCapital4.Text = respuestaCorrecta;
                    break;
            }
            // Escribir los paises en los cuadros de texto
            TextBox[] cajas = { TxtCapital1, TxtCapital2, TxtCapital3, TxtCapital4 };
            do
            {
                for (int i = 0; i < cajas.Length; i++)
                {
                    int indicePaises = aleatorio.Next(0, paises.Length);
                    if (string.IsNullOrEmpty(cajas[i].Text) && !TxtCapital1.Text.Equals(paises[indicePaises]) && !TxtCapital2.Text.Equals(paises[indicePaises])
                        && !TxtCapital3.Text.Equals(paises[indicePaises]) && !TxtCapital4.Text.Equals(paises[indicePaises]))
                    {
                        cajas[i].Text = paises[indicePaises];
                    }
                }
            } while (string.IsNullOrEmpty(TxtCapital1.Text) || string.IsNullOrEmpty(TxtCapital2.Text) || string.IsNullOrEmpty(TxtCapital3.Text) || string.IsNullOrEmpty(TxtCapital4.Text));



        }

        public bool checkAnswer(TextBox textBox)
        {
            if (MnuNombreCapitales.Checked == true && MnuEscribirRespuesta.Checked == true)
            {
                if (textBox.Text.Equals(capitales[indicePais]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (MnuNombrePaises.Checked == true && MnuEscribirRespuesta.Checked == true)
            {
                if (textBox.Text.Equals(paises[indicePais]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (MnuNombreCapitales.Checked == true && MnuMultiplesOpciones.Checked == true)
            {
                if (textBox.Text.Equals(capitales[indicePais]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (MnuNombrePaises.Checked == true && MnuMultiplesOpciones.Checked == true)
            {
                if (textBox.Text.Equals(paises[indicePais]))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                return false;
            }

        }



        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Metodo que crea una nueva partida
        /// </summary>
        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MnuNombreCapitales.Checked == true && MnuMultiplesOpciones.Checked == true)
            {
                newGame();
                fillTxtBoxes();
            }
            else if (MnuNombrePaises.Checked == true && MnuMultiplesOpciones.Checked == true)
            {
                newGame();
                fillTxtBoxesPaises();
            }
            else if (MnuNombreCapitales.Checked == true && MnuEscribirRespuesta.Checked == true)
            {
                newGame();
                fillEscribirRespuestas();
                

            }
            else if (MnuNombrePaises.Checked == true && MnuEscribirRespuesta.Checked == true)
            {
                newGame();
                fillEscribirRespuestas();
            }

        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {

        }

        private void TxtPais_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtCapital1_TextChanged(object sender, EventArgs e)
        {
            if (checkAnswer(TxtCapital1))
            {
                TxtCapital1.BackColor = Color.Green;
                respuestasAcertadas++;
            }
            else
            {
                TxtCapital1.BackColor = Color.Red;
                TxtCapital1.Text = "INCORRECTO";
            }
            totalPreguntas++;
            BtnSiguente.Enabled = true;
            calculatePercentage();
        }

        private void TxtCapital2_TextChanged(object sender, EventArgs e)
        {
            if (checkAnswer(TxtCapital2))
            {
                TxtCapital2.BackColor = Color.Green;
                respuestasAcertadas++;
            }
            else
            {
                TxtCapital2.BackColor = Color.Red;
                TxtCapital2.Text = "INCORRECTO";
            }
            totalPreguntas++;
            BtnSiguente.Enabled = true;
            calculatePercentage();
        }

        private void TxtCapital3_TextChanged(object sender, EventArgs e)
        {
            if (checkAnswer(TxtCapital3))
            {
                TxtCapital3.BackColor = Color.Green;
                respuestasAcertadas++;
            }
            else
            {
                TxtCapital3.BackColor = Color.Red;
                TxtCapital3.Text = "INCORRECTO";
            }
            totalPreguntas++;
            BtnSiguente.Enabled = true;
            calculatePercentage();
        }

        private void TxtCapital4_TextChanged(object sender, EventArgs e)
        {
            if (checkAnswer(TxtCapital4))
            {
                TxtCapital4.BackColor = Color.Green;
                respuestasAcertadas++;
            }
            else
            {
                TxtCapital4.BackColor = Color.Red;
                TxtCapital4.Text = "INCORRECTO";
            }
            totalPreguntas++;
            BtnSiguente.Enabled = true;
            calculatePercentage();
        }

        private void BtnSiguente_Click(object sender, EventArgs e)
        {
            if (MnuNombreCapitales.Checked == true && MnuMultiplesOpciones.Checked == true)
            {
                fillTxtBoxes();
            }
            else if(MnuNombrePaises.Checked == true && MnuMultiplesOpciones.Checked == true)
            {
                fillTxtBoxesPaises();
            }
            else
            {
                fillEscribirRespuestas();
            }

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MnuNombrePaises_Click(object sender, EventArgs e)
        {
            MnuNombreCapitales.Checked = false;
            MnuNombrePaises.Checked = true;
        }

        private void MnuNombreCapitales_Click(object sender, EventArgs e)
        {
            MnuNombreCapitales.Checked = true;
            MnuNombrePaises.Checked = false;
        }

        private void MnuMultiplesOpciones_Click(object sender, EventArgs e)
        {
            TxtCapital1.Click += TxtCapital1_TextChanged;
            TxtCapital1.KeyDown -= TxtCapital1_KeyDown;
            TxtCapital1.Cursor = Cursors.Hand;

            MnuMultiplesOpciones.Checked = true;
            MnuEscribirRespuesta.Checked = false;

            TxtCapital1.ReadOnly = true;
            TxtCapital2.Visible = true;
            TxtCapital3.Visible = true;
            TxtCapital4.Visible = true;
        }
        private void TxtCapital1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (checkAnswer(TxtCapital1))
                {
                    TxtCapital1.BackColor = Color.Green;
                    respuestasAcertadas++;
                }
                else
                {
                    TxtCapital1.BackColor = Color.Red;
                    TxtCapital1.Text = "INCORRECTO";
                }
                totalPreguntas++;
                BtnSiguente.Enabled = true;
                calculatePercentage();
            }
        }
        private void MnuEscribirRespuesta_Click(object sender, EventArgs e)
        {
            MnuEscribirRespuesta.Checked = true;
            MnuMultiplesOpciones.Checked = false;

            TxtCapital1.ReadOnly = false;
            TxtCapital2.Visible = false;
            TxtCapital3.Visible = false;
            TxtCapital4.Visible = false;

            TxtCapital1.Cursor = Cursors.IBeam;

            TxtCapital1.Click -= TxtCapital1_TextChanged;
            TxtCapital1.KeyDown += TxtCapital1_KeyDown;
        }
    }
}