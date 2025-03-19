namespace calculadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string calculo1 = txb_calculo1.Text;
            string calculo2 = txb_calculo2.Text;

            if (!calculo1.All(char.IsNumber))
            {
                lbl_resultado.Text = "insira somente numero";
                return;
            }

            double doublecalculo1 = Convert.ToDouble(calculo1);
            double doublecalculo2 = Convert.ToDouble(calculo2);

            double resultado = doublecalculo1 / doublecalculo2;

            lbl_resultado.Text = (double.Parse(txb_calculo1.Text) / float.Parse(txb_calculo2.Text)).ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string calculo1 = txb_calculo1.Text;
            string calculo2 = txb_calculo2.Text;

            if (!calculo1.All(char.IsNumber))
            {
                lbl_resultado.Text = "insira somente numero";
                return;
            }

            double doublecalculo1 = Convert.ToDouble(calculo1);
            double doublecalculo2 = Convert.ToDouble(calculo2);

            double resultado = doublecalculo1 + doublecalculo2;

            lbl_resultado.Text = (double.Parse(txb_calculo1.Text) + float.Parse(txb_calculo2.Text)).ToString();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            string calculo1 = txb_calculo1.Text;
            string calculo2 = txb_calculo2.Text;

            if (!calculo1.All(char.IsNumber))
            {
                lbl_resultado.Text = "insira somente numero";
                return;
            }

            double doublecalculo1 = Convert.ToDouble(calculo1);
            double doublecalculo2 = Convert.ToDouble(calculo2);

            double resultado = doublecalculo1 * doublecalculo2;

            lbl_resultado.Text = (double.Parse(txb_calculo1.Text) * float.Parse(txb_calculo2.Text)).ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string calculo1 = txb_calculo1.Text;
            string calculo2 = txb_calculo2.Text;

            if (!calculo1.All(char.IsNumber))
            {
                lbl_resultado.Text = "insira somente numero";
                return;
            }


            double doublecalculo1 = Convert.ToDouble(calculo1);
            double doublecalculo2 = Convert.ToDouble(calculo2);

            double resultado = doublecalculo1 - doublecalculo2;

            lbl_resultado.Text = (double.Parse(txb_calculo1.Text) - float.Parse(txb_calculo2.Text)).ToString();



        }

        private void txb_calculo2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();

            frm.Show();

            this.Close();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
