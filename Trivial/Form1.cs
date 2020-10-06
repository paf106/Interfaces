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
        string[] paises = {"España", "Portugal", "Francia", "Alemania", "Finlandia","Grecia","Belgica", "Rumania", "Rusia"};
        string[] capitales = {"Madrid", "Lisboa", "Paris", "Berlín", "Helsinki", "Atenas", "Bruselas", "Bucarest", "Moscu"};

        public void newGame()
        {
            TxtCapital1.Text = "";
            TxtCapital2.Text = "";
            TxtCapital3.Text = "";
            TxtCapital4.Text = "";
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
            string paisAleatorio = paises[numeroAleatorio];
            TxtPais.Text = paisAleatorio;

            //Sacar la respuesta correcta y mostrarlo en el txt aleatoriamente
            string respuestaCorrecta = capitales[numeroAleatorio];
            string[] txtEntries = { "TxtCapital1", "TxtCapital2", "TxtCapital3", "TxtCapital4" };
            int cajaAleatoria = aleatorio.Next(0, txtEntries.Length);
            switch (txtEntries[cajaAleatoria])
            {
                case "TxtCapital1":
                    TxtCapital1.Text = respuestaCorrecta;
                    break;
                case "TxtCapital2":
                    TxtCapital2.Text = respuestaCorrecta;
                    break;
                case "TxtCapital3":
                    TxtCapital3.Text = respuestaCorrecta;
                    break;
                case "TxtCapital4":
                    TxtCapital4.Text = respuestaCorrecta;
                    break;
            }
            

        }

        private void MnuSalir_Click(object sender, EventArgs e)
        {

        }

        private void TxtPais_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
