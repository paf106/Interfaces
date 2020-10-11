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
        string[] paises = {"España", "Portugal", "Francia", "Alemania", "Finlandia","Grecia","Belgica", "Rumania", "Rusia","Polonia","Suecia", "Suiza"};
        string[] capitales = {"Madrid", "Lisboa", "Paris", "Berlín", "Helsinki", "Atenas", "Bruselas", "Bucarest", "Moscu", "Varsovia", "Estocolmo", "Berna"};

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
        /// <summary>
        /// Metodo que rellena las cajas de texto con capitales aleatorias
        /// </summary>
        public void fillTxtBoxes()
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

            //Sacar pais aleatorio y mostrarlo en el txt
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(0, paises.Length);
            indicePais = numeroAleatorio;
            TxtPais.Text = paises[numeroAleatorio];

            //Sacar la respuesta correcta y mostrarlo en el txt aleatoriamente
            string respuestaCorrecta = capitales[numeroAleatorio];
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
            TextBox[] cajas = { TxtCapital1, TxtCapital2, TxtCapital3, TxtCapital4 };
            do {
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

        public bool checkAnswer(TextBox textBox)
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
            newGame();
            fillTxtBoxes();
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
            fillTxtBoxes();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}