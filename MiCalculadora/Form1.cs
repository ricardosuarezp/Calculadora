using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class Form1 : Form
    {
        double valorResultado = 0;
        string operacion = "";
        bool esOperacionPresionado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            valorResultado = Convert.ToDouble(textBoxPantalla.Text);
            operacion = "-";
            esOperacionPresionado = true;
        }
        private void buttonMultiplicacion_Click(object sender, EventArgs e)
        {
            valorResultado = Convert.ToDouble(textBoxPantalla.Text);
            operacion = "*";
            esOperacionPresionado = true;
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            valorResultado = Convert.ToDouble(textBoxPantalla.Text);
            operacion = "+";
            esOperacionPresionado = true;
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            valorResultado = Convert.ToDouble(textBoxPantalla.Text);
            operacion = "/";
            esOperacionPresionado = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado) { 
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "";
                esOperacionPresionado = false;
            }
            Button boton = (Button)sender;
            if (textBoxPantalla.Text == "0" || String.IsNullOrEmpty(textBoxPantalla.Text))
            {
                textBoxPantalla.Text = boton.Text;
            }
            else
            {
                textBoxPantalla.Text = textBoxPantalla.Text + boton.Text;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (esOperacionPresionado)
            {
                textBoxPantalla.Text = "0";
                esOperacionPresionado = false;
            }


            if (!textBoxPantalla.Text.Contains("."))
            {
                if (textBoxPantalla.Text == "0" || string.IsNullOrEmpty(textBoxPantalla.Text))
                {
                    textBoxPantalla.Text = "0."; 
                }
                else
                {
                    textBoxPantalla.Text = textBoxPantalla.Text + ".";
                }
            }
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            double segundoNumero = Convert.ToDouble(textBoxPantalla.Text);
            double resultado = 0;
            switch (operacion) 
            {
                case "+":
                    resultado = valorResultado+segundoNumero;
                    break;
                case "-":
                    resultado = valorResultado - segundoNumero;
                    break;
                case "*":
                    resultado = valorResultado * segundoNumero;
                    break;
                case "/":
                    if (segundoNumero != 0)
                    {
                        resultado = valorResultado / segundoNumero;
                    }
                    else 
                    {
                        textBoxPantalla.Text = "Error";
                        return;
                    }
                    break;
                default:
                    resultado = segundoNumero;
                    break;
            }
            textBoxPantalla.Text = resultado.ToString();
            operacion = "";
            valorResultado = resultado;
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxPantalla.Text = "0";
            valorResultado = 0;
            operacion = "";
            esOperacionPresionado = false;
        }
    }
}
