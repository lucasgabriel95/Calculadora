using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float valor1, valor2;
        string operador;
        


        private void button25_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn1_Click(object sender, EventArgs e)
        {       
          if (Visor.Text == "")
          {
                Visor.Text = "1";
                Visor2.Text += "1";
          }
          else
          {
                Visor.Text  += "1";
                Visor2.Text += "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
            {
                Visor.Text = "2";
                Visor2.Text += "2";
            }
            else
            {
                Visor.Text += "2";
                Visor2.Text += "2";
            }

        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
            {
                Visor.Text = "3";
                Visor2.Text += "3";
            }
            else
            {
                Visor.Text += "3";
                Visor2.Text += "3";
            }

        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
            {
                Visor.Text = "4";
                Visor2.Text += "4";
            }
            else
            {
                Visor.Text += "4";
                Visor2.Text += "4";
            }

        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
            {
                Visor.Text = "5";
                Visor2.Text += "5";
            }
            else
            {
                Visor.Text += "5";
                Visor2.Text += "5";
            }

        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
            {
                Visor.Text = "6";
                Visor2.Text += "6";
            }
            else
            {
                Visor.Text += "6";
                Visor2.Text += "6";
            }

        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
            {
                Visor.Text = "7";
                Visor2.Text += "7";
            }
            else
            {
                Visor.Text += "7";
                Visor2.Text += "7";
            }

        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
            {
                Visor.Text = "8";
                Visor2.Text += "8";
            }
            else
            {
                Visor.Text += "8";
                Visor2.Text += "8";
            }

        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
            {
                Visor.Text = "9";
                Visor2.Text += "9";
            }
            else
            {
                Visor.Text += "9";
                Visor2.Text += "9";
            }

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Visor.Text == "")
            {
                Visor.Text = "0";
                Visor2.Text += "0";
            }
            else
            {
                Visor.Text += "0";
                Visor2.Text += "0";
            }

        }
        private void btnResultado_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                valor2 = (float)Convert.ToDouble(Visor.Text);
                Controle cl = new Controle();
                cl.operacao(operador, valor1, valor2);
                Visor.Text = Convert.ToString(cl.ResultadoFinal);
                Visor2.Text += "=" + cl.ResultadoFinal;
            }           

        }
        private void btnSoma_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                operador = "+";
                Visor2.Text += "+";
            }

            if (Visor.Text != "")
            {
                valor1 = (float)Convert.ToDouble(Visor.Text);
            }            
            
            Visor.Clear();
            Visor.Focus();
            

        }
        private void btnSubitracao_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                operador = "-";
                Visor2.Text += "-";
            }

            if (Visor.Text != "")
            {
                valor1 = (float)Convert.ToDouble(Visor.Text);
            }
            
            
            Visor.Clear();
            Visor.Focus();
        }
        private void btnMultiplicação_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                operador = "*";
                Visor2.Text += "X";
            }

            if (Visor.Text != "")
            {
                valor1 = (float)Convert.ToDouble(Visor.Text);
            }            
            
            Visor.Clear();
            Visor.Focus();
        }
        private void btnDivisao_Click(object sender, EventArgs e)
        {       
            operador = "/";
            
            if (Visor.Text != "")
            {
                operador = "/";
                Visor2.Text += "÷";
            }

            if (Visor.Text != "")
            {
                valor1 = (float)Convert.ToDouble(Visor.Text);
            }
            Visor.Clear();
            Visor.Focus();
            
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (Visor.Text != "")
            {
                Visor.Text += ",";
                Visor2.Text += ",";
            }


          //  Visor.Clear();
          //   Visor.Focus();
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            if(Visor.Text != "")
            {
                operador = "%";
                Visor2.Text += "%";
            }

            if (Visor.Text != "")
            {
                valor1 = (float)Convert.ToDouble(Visor.Text);
            }

            
            Visor.Clear();
            Visor.Focus();




        }

        private void btnApagarCampo_Click(object sender, EventArgs e)
        {
            Visor2.Clear();
            valor1 = 0;
            valor2 = 0;
            Visor.Clear();
            Visor.Focus();
        }

        
    }

}
