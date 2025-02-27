namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txb_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            string usuario = txb_name.Text;
            string senha = txb_senha.Text;
            string senha2 = txb_cSenha.Text;

            if (usuario == null || usuario == "")
            {
                lbl_resultado.Text = "usuario obrigatorio!";
                lbl_resultado.ForeColor = Color.Red;

            }
            else if (senha == null || senha == "")
            {
                lbl_resultado.Text = "usuario obrigatorio!";
                lbl_resultado.ForeColor = Color.Red;

            }

            else if (usuario =="felipe araujo" && senha == "12345" && senha2 == "12345")
            {
                lbl_resultado.Text = "Autenticado com sucesso";
                lbl_resultado.ForeColor = Color.Green;

            }
            else
            {
                lbl_resultado.Text = "usuario ou senha incoreto";
                lbl_resultado.ForeColor = Color.Red;
            }
        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }
    }
}
