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
        public static decimal Memory = 0;
        public static decimal TempMemory = 0;

        public Form1()
        {
            InitializeComponent();
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EfetuarOperacao()
        {
            var valores = Resultado.Text.Split('+', '-', '*', '/');
            var index = valores[0].Length;
            var operacao = Resultado.Text[index];

            switch (operacao)
            {
                case '+':
                    Resultado.Text = (decimal.Parse(valores[0]) + decimal.Parse(valores[1])).ToString();
                    TempMemory = decimal.Parse(Resultado.Text);
                    break;

                case '-':
                    Resultado.Text = valores[0] == "" ? ((decimal.Parse(valores[1]) * -1) - decimal.Parse(valores[2])).ToString() : (decimal.Parse(valores[0]) - decimal.Parse(valores[1])).ToString();
                    TempMemory = decimal.Parse(Resultado.Text);
                    break;

                case '/':
                    if(valores[1]=="0")
                    {
                        Resultado.Text = "Impossível realizar a divisão por 0";
                    }
                    else
                    {
                        Resultado.Text = (decimal.Parse(valores[0]) / decimal.Parse(valores[1])).ToString();
                        TempMemory = decimal.Parse(Resultado.Text);
                    }
                    break;


                case '*':
                    Resultado.Text = (decimal.Parse(valores[0]) * decimal.Parse(valores[1])).ToString();
                    TempMemory = decimal.Parse(Resultado.Text);
                    break;

            }




        }
        private void VerificarOperacao()
        {
            bool validate = false;
            validate = validate || Resultado.Text.Contains('+');
            validate = validate || Resultado.Text.Contains('*');
            validate = validate || Resultado.Text.Contains('/');
            validate = validate || Resultado.Text.Substring(1).Contains('-');

            if (validate)
            {
                EfetuarOperacao();
            }
        }




        private void btn0_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 0;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 1;
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 2;
            
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 3;
            
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 4;
            
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 5;
            
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 6;
            
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 7;
            
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 8;
            
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text == "0" ? "" : Resultado.Text;
            Resultado.Text += 9;
            
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            bool addOperator = Resultado.Text == "0";
            decimal aux;
            if (Resultado.Text.ContainsAny("+", "-", "*", "/") && !decimal.TryParse(Resultado.Text.Substring(Resultado.Text.Length-1),out aux))
            {
                Resultado.Text = Resultado.Text.Substring(0, Resultado.Text.Length - 1);
            }

            VerificarOperacao();

            if (!addOperator)
            {
                Resultado.Text += "+";
            }

        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            bool addOperator = Resultado.Text == "0";
            decimal aux;
            if (Resultado.Text.ContainsAny("+", "-", "*", "/") && !decimal.TryParse(Resultado.Text.Substring(Resultado.Text.Length - 1), out aux))
            {
                Resultado.Text = Resultado.Text.Substring(0, Resultado.Text.Length - 1);
            }

            VerificarOperacao();

            if (!addOperator)
            {
                Resultado.Text += "*";
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            VerificarOperacao();
        }


        private void btnDivisao_Click(object sender, EventArgs e)
        {
            bool addOperator = Resultado.Text == "0";
            decimal aux;
            if (Resultado.Text.ContainsAny("+", "-", "*", "/") && !decimal.TryParse(Resultado.Text.Substring(Resultado.Text.Length - 1), out aux))
            {
                Resultado.Text = Resultado.Text.Substring(0, Resultado.Text.Length - 1);
            }

            VerificarOperacao();

            if (!addOperator)
            {
                Resultado.Text += "/";
            }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            bool addOperator = Resultado.Text == "0";
            decimal aux;
            if (Resultado.Text.ContainsAny("+", "-", "*", "/") && !decimal.TryParse(Resultado.Text.Substring(Resultado.Text.Length - 1), out aux))
            {
                Resultado.Text = Resultado.Text.Substring(0, Resultado.Text.Length - 1);
            }

            VerificarOperacao();

            if (!addOperator)
            {
                Resultado.Text += "-";
            }
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            char[] containers = { '+', '-', '*', '/' };
            bool containsCharOperator = Resultado.Text.ContainsAny("+", "-", "*", "/");
            string[] vetValores;
            if (containsCharOperator)
            {
                vetValores = new string[2];
                vetValores = Resultado.Text.IndexOf('-') > -1 ? Resultado.Text.Split('-') : vetValores;
                vetValores = Resultado.Text.IndexOf('*') > -1 ? Resultado.Text.Split('*') : vetValores;
                vetValores = Resultado.Text.IndexOf('/') > -1 ? Resultado.Text.Split('/') : vetValores;
                vetValores = Resultado.Text.IndexOf('+') > -1 ? Resultado.Text.Split('+') : vetValores;
                Resultado.Text += vetValores[1].IndexOf(',') == -1 ? "," : "";
            }
            else
            {
                Resultado.Text += Resultado.Text.IndexOf(',') == -1 ? "," : "";
            }
        }

        private void btnSeta_Click(object sender, EventArgs e)
        {
            Resultado.Text = Resultado.Text != "0" ? Resultado.Text.Length == 1 ? "0" : Resultado.Text.Substring(0,Resultado.Text.Length -1) : Resultado.Text;
        }

        private void btnMS_Click(object sender, EventArgs e)
        {
            Memory = Resultado.Text.ContainsAny("+", "-", "*", "/") ? decimal.Parse(Resultado.Text.Substring(0, Resultado.Text.Length - 1)) : decimal.Parse(Resultado.Text);
            btnMR.Enabled = true;
            btnMC.Enabled = true;
        }

        private void btnMMenos_Click(object sender, EventArgs e)
        {
            decimal value = Resultado.Text.ContainsAny("+", "-", "*", "/") ? decimal.Parse(Resultado.Text.Substring(0, Resultado.Text.Length - 1)) : decimal.Parse(Resultado.Text);
            Memory -= value;
        }

        private void btnMMais_Click(object sender, EventArgs e)
        {
            decimal value = Resultado.Text.ContainsAny("+", "-", "*", "/") ? decimal.Parse(Resultado.Text.Substring(0, Resultado.Text.Length - 1)) : decimal.Parse(Resultado.Text);
            Memory += value;
        }

        private void btnMR_Click(object sender, EventArgs e)
        {
            Resultado.Text = Memory.ToString();
        }

        private void btnMC_Click(object sender, EventArgs e)
        {
            Memory = 0;
            btnMR.Enabled = false;
            btnMC.Enabled = false;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Resultado.Text = TempMemory.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
            TempMemory = 0;
        }

        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            decimal value = Resultado.Text[0] == '-' 
                            ? Resultado.Text.Substring(1).ContainsAny("+", "-", "*", "/") 
                            ? decimal.Parse(Resultado.Text.Substring(0, Resultado.Text.Length - 1)) 
                            : decimal.Parse(Resultado.Text) : Resultado.Text.ContainsAny("+", "-", "*", "/") 
                            ? decimal.Parse(Resultado.Text.Substring(0, Resultado.Text.Length - 1)) 
                            : decimal.Parse(Resultado.Text);

            Resultado.Text = (value * (-1)).ToString();
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double value = Resultado.Text[0] == '-'
                            ? Resultado.Text.Substring(1).ContainsAny("+", "-", "*", "/")
                            ? double.Parse(Resultado.Text.Substring(0, Resultado.Text.Length - 1))
                            : double.Parse(Resultado.Text) : Resultado.Text.ContainsAny("+", "-", "*", "/")
                            ? double.Parse(Resultado.Text.Substring(0, Resultado.Text.Length - 1))
                            : double.Parse(Resultado.Text);

            if (value <= 0)
            {
                Resultado.Text = "Impossível fazer a operação.";
            }

            else
            {
                Resultado.Text = Math.Sqrt(value).ToString();
                TempMemory = decimal.Parse(Resultado.Text);
            }

        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {
            var values = Resultado.Text.Split(new char[] { '+', '-', '*', '/' });
            try
            {
                 if (values[0] == "")
                 {
                     Resultado.Text = "-" + values[0] + Resultado.Text[values[1].Length].ToString() + decimal.Parse(values[2]) / 100;
                 }
                 else
                 {
                     Resultado.Text = values[0] + Resultado.Text[values[0].Length].ToString() + decimal.Parse(values[1]) / 100;
                 }
                 if (Resultado.Text[0] != '0')
                 {
                     VerificarOperacao();
                 }
            }
            catch
            {

            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            bool thereIsOperator = Resultado.Text[0] == '-'
                                   ? Resultado.Text.Substring(1).ContainsAny("+", "-", "*", "/")
                                   : Resultado.Text.ContainsAny("+", "-", "*", "/");

            if (!thereIsOperator)
            {
                Resultado.Text = "1/" + Resultado.Text;
            }

        }
    }

    public static class Util
    {
        public static bool ContainsAny(this string stringToCheck, params string[] parameters)
        {
            return parameters.Any(parameter => stringToCheck.Contains(parameter));
        }
    }
        
}
