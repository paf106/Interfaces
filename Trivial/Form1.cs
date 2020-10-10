﻿using System;
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
        string[] paises = {"España", "Portugal", "Francia", "Alemania", "Finlandia","Grecia","Belgica", "Rumania", "Rusia"};
        string[] capitales = {"Madrid", "Lisboa", "Paris", "Berlín", "Helsinki", "Atenas", "Bruselas", "Bucarest", "Moscu"};

        public void newGame()
        {
            TxtCapital1.Clear();
            TxtCapital2.Clear();
            TxtCapital3.Clear();
            TxtCapital4.Clear();
            
        }

        public void fillTxt()
        {
            TextBox[] cajas = { TxtCapital1, TxtCapital2, TxtCapital3, TxtCapital4 };

            for (int i = 0;i<cajas.Length;i++)
            {
                Random aleatori = new Random();
                int indiceCapitales = aleatori.Next(0, capitales.Length);
                //MessageBox.Show(indiceCapitales.ToString());
                if (string.IsNullOrEmpty(cajas[i].Text) && !TxtCapital1.Text.Equals(capitales[indiceCapitales]) && !TxtCapital2.Text.Equals(capitales[indiceCapitales])
                    && !TxtCapital3.Text.Equals(capitales[indiceCapitales]) && !TxtCapital4.Text.Equals(capitales[indiceCapitales]))
                {
                    cajas[i].Text = capitales[indiceCapitales];
                }
            }


        }
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newGame();
            //Sacar pais aleatorio y mostrarlo en el txt
            Random aleatorio = new Random();
            int numeroAleatorio = aleatorio.Next(0, paises.Length);
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
            fillTxt();

        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {

        }

        private void TxtPais_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
