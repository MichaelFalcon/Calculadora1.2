using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora1._2
{
    public partial class Form1 : Form
    {

        double num1 = 0, num2 = 0;
        string operacion = "";
        bool nuevaOperacion = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void AgregarNumero(string numero)
        {
            if (txtPantalla.Text == "0" || nuevaOperacion)
            {
                txtPantalla.Text = numero;
                nuevaOperacion = false;
            }
            else
            {
                txtPantalla.Text += numero;
            }
        }

        private void RealizarOperacion(string operador)
        {
            num1 = Convert.ToDouble(txtPantalla.Text);
            operacion = operador;
            nuevaOperacion = true;
        }

        private void CalcularResultado()
        {
            num2 = Convert.ToDouble(txtPantalla.Text);
            double resultado = 0;

            switch (operacion)
            {
                case "+": resultado = num1 + num2; break;
                case "-": resultado = num1 - num2; break;
                case "*": resultado = num1 * num2; break;
                case "/":
                    if (num2 != 0)
                        resultado = num1 / num2;
                    else
                    {
                        MessageBox.Show("Error: División por cero");
                        resultado = 0;
                    }
                    break;
            }

            txtPantalla.Text = resultado.ToString();
            nuevaOperacion = true;
        }

        private void btn0_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("0");
        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("1");
        }

        private void btn2_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("2");
        }

        private void btn3_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("3");
        }

        private void btn4_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("4");
        }

        private void btn5_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("5");
        }

        private void btn6_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("6");
        }

        private void btn7_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("7");
        }

        private void btn8_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("8");
        }

        private void btn9_Click_1(object sender, EventArgs e)
        {
            AgregarNumero("9");
        }

        private void btnPunto_Click_1(object sender, EventArgs e)
        {
            if (!txtPantalla.Text.Contains(","))
            {
                txtPantalla.Text += ",";
            }
        }

        private void btnSuma_Click_1(object sender, EventArgs e)
        {
            RealizarOperacion("+");
        }

        private void btnResta_Click_1(object sender, EventArgs e)
        {
            RealizarOperacion("-");
        }

        private void btnMultiplicar_Click_1(object sender, EventArgs e)
        {
            RealizarOperacion("*");
        }

        private void btnDividir_Click_1(object sender, EventArgs e)
        {
            RealizarOperacion("/");
        }

        private void btnIgual_Click_1(object sender, EventArgs e)
        {
            CalcularResultado();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            num1 = 0;
            num2 = 0;
            operacion = "";
            nuevaOperacion = false;
        }
    }
}