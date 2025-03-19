using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static double Somar(double calculo1, double calculo2)
        {

            return calculo1 + calculo2;
        }

        private static double Subtracao(double calculo1, double calculo2)

        {
            return calculo1 - calculo2;
        }

        private static double Multiplicar(double val1, double val2)
        {
            return val1 * val2;
        }

        private static double Dividir(double val1, double val2)
        {
            return val1 / val2;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {



            double doubleValor1 = Convert.ToDouble(txb_calculo1.Text);
            double doubleValor2 = Convert.ToDouble(txb_calculo2.Text);
            double resultado;

            switch (lbl_contas.Text)
            {
                case "+":
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
                case "-":
                    resultado = Subtracao(doubleValor1, doubleValor2);
                    break;
                case "*":
                    resultado = Multiplicar(doubleValor1, doubleValor2);
                    break;
                case "/":
                    resultado = Dividir(doubleValor1, doubleValor2);
                    break;




                default:
                    resultado = Somar(doubleValor1, doubleValor2);
                    break;
            }

            txb_resultado.Text = Convert.ToString(resultado);

        }


        private void rdb_divisao_CheckedChanged(object sender, EventArgs e)
        {
            lbl_contas.Text = "/";
        }

        private void rdb_multiplicacao_CheckedChanged(object sender, EventArgs e)
        {
            lbl_contas.Text = "*";
        }

        private void rdb_subtracao_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcula_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!rdb_diametro.Checked &&
               !rdb_perimetro.Checked &&
               !rdb_perimetru.Checked &&
               !rdb_volume.Checked &&
               !rdb_volumi.Checked &&
               !rdb_diametro.Checked &&
               !rdb_area.Checked &&
               !rdb_aria.Checked)
            {

                string raio = txb_raio.ToString();

                if (string.IsNullOrWhiteSpace(raio) || !raio.All(char.IsNumber))
                {
                    labeErro.text = "insirir raio valido";
                    return;
                }
                double raioDoNumero = Convert.ToDouble(raio);
                double resultado;


                if (rdb_diametro.Checked)
                {
                    resultado = 2 * raioDoNumero;
                    txb_result.Text = Math.Round(resultado).ToString();
                    return;
                }
                if (rdb_perimetro.Checked)
                {
                    resultado = 2 * Math.PI * raioDoNumero;
                    txb_result.Text = Math.Round(resultado).ToString(); return;
                    return;
                }
                if (rdb_volumi.Checked)
                {
                    resultado = (4 / 3) * Math.PI * Math.Pow(raioDoNumero, 3);
                    txb_result.Text = Math.Round(resultado).ToString();
                    return;
                }
                if (rdb_volume.Checked)
                {
                    return;
                }
                if (rdb_area.Checked)
                {
                    return;
                }
                if (rdb_aria.Checked)
                {
                    return;
                }

            }
        }
    }
}
  