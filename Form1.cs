using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadorA
{
    public partial class Form1 : Form
    {
        private double num1;
        private double num2;
        private double resultado;
        private int operador;
        public Form1()
        {
            InitializeComponent();
            // para acomodar los numeros a la izquierda
            box_text.TextAlign = HorizontalAlignment.Right;
        }

        private void btn_cuatro_Click(object sender, EventArgs e)
        {
            box_text.Text += "4";
        }
        private void btn_uno_Click(object sender, EventArgs e)
        {
            box_text.Text += "1";
        }

        private void btn_dos_Click(object sender, EventArgs e)
        {
            box_text.Text += "2";
        }

        private void btn_tres_Click(object sender, EventArgs e)
        {
            box_text.Text += "3";
        }

        private void btn_cinco_Click(object sender, EventArgs e)
        {
            box_text.Text += "5";
        }

        private void btn_seis_Click(object sender, EventArgs e)
        {
            box_text.Text += "6";
        }

        private void btn_siete_Click(object sender, EventArgs e)
        {
            box_text.Text += "7";
        }

        private void btn_ocho_Click(object sender, EventArgs e)
        {
            box_text.Text += "8";
        }

        private void btn_nueve_Click(object sender, EventArgs e)
        {
            box_text.Text += "9";
        }

        private void btn_cero_Click(object sender, EventArgs e)
        {
            box_text.Text += "0";
        }

        private void btn_punto_Click(object sender, EventArgs e)
        {
            box_text.Text += ".";
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            box_text.Text = " ";
            num1 = 0;
            num2 = 0;
            resultado = 0;
        }

        private void btn_suma_Click(object sender, EventArgs e)
        {
            operador = 1;
            num1 = Convert.ToDouble(box_text.Text);
            box_text.Text = " ";
        }

        private void btn_resta_Click(object sender, EventArgs e)
        {
            operador = 2;
            num1 = Convert.ToDouble(box_text.Text);
            box_text.Text = " ";
        }

        private void btn_multiplicar_Click(object sender, EventArgs e)
        {
            operador = 3;
            num1 = Convert.ToDouble(box_text.Text);
            box_text.Text = " ";
        }

        private void btn_dividir_Click(object sender, EventArgs e)
        {
            operador = 4;
            num1= Convert.ToDouble(box_text.Text);
            box_text.Text = " ";    
        }
        private void btn_igual_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(box_text.Text);
            resultado = 0;
            switch (operador)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        MessageBox.Show("Error: no se puede diviri por cero");
                        return;
                    }
                    break;
            }
            box_text.Text = resultado.ToString();
        }

        private void btn_elminar_Click(object sender, EventArgs e)
        {
            if(box_text.Text.Length > 0)
            {
                // asigancion de variable
                string vActual = box_text.Text;
                // elimina los numeros ingresados
                vActual = vActual.Substring(0, vActual.Length - 1);
                // actualiza
                box_text.Text = vActual;
            }
        }
    }
}
