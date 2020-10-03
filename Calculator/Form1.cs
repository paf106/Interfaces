using Calculator.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double primero;
        double segundo;
        string operador;
        double memoria;
        public Calculator()
        {
            InitializeComponent();
        }

        Classes.Suma suma = new Classes.Suma();
        Classes.Resta resta = new Classes.Resta();
        Classes.Multiplicacion mult = new Classes.Multiplicacion();
        Classes.Division div = new Classes.Division();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "1";

        }

        private void TxtEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "0";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = TxtEntry.Text + "9";
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(TxtEntry.Text);
            TxtEntry.Clear();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(TxtEntry.Text);
            TxtEntry.Clear();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(TxtEntry.Text);
            TxtEntry.Clear();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(TxtEntry.Text);
            TxtEntry.Clear();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            TxtEntry.Clear();
            primero = 0;
            segundo = 0;
            operador = "";
        }

        private void BtnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                segundo = double.Parse(TxtEntry.Text);
            }
            catch (FormatException)
            {

            }
           

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+" :
                    Sum = suma.Sumar(primero, segundo);
                    TxtEntry.Text = Sum.ToString();
                    break;

                case "-":
                    Res = resta.Restar(primero, segundo);
                    TxtEntry.Text = Res.ToString();
                    break;

                case "*":
                    Mul = mult.Multiplicar(primero, segundo);
                    TxtEntry.Text = Mul.ToString();
                    break;

                case "/":
                    Div = div.Dividir(primero, segundo);
                    TxtEntry.Text = Div.ToString();
                    break;

                default:
                    break;
            }
        }

        private void Btn1EntreX_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Double.Parse(TxtEntry.Text);
                double operacion = 1 / numero;
                TxtEntry.Clear();
                TxtEntry.Text = operacion.ToString();
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Escribe un número antes de pulsar la tecla", "Error");
            }
            

        }

        private void BtnMemoryClear_Click(object sender, EventArgs e)
        {
            memoria = 0;
        }

        private void BtnMemoryRecall_Click(object sender, EventArgs e)
        {
            TxtEntry.Text = memoria.ToString();
        }

        private void BtnMemoryStorage_Click(object sender, EventArgs e)
        {
            try
            {
                memoria = Double.Parse(TxtEntry.Text);
            }
            catch (FormatException ev)
            {
                memoria = 0;
            }
           
        }

        private void BtnMemoryAdd_Click(object sender, EventArgs e)
        {
            try
            {
                memoria = memoria + Double.Parse(TxtEntry.Text);
            }
            catch (FormatException er)
            {
                memoria = memoria + 0;
            }
            
        }

        private void BtnClearError_Click(object sender, EventArgs e)
        {
            TxtEntry.Clear();
        }
    }
}
