namespace login
{
    public partial class Form1 : Form
    {
        //usuario
        List<string> lista_use = new List<string>() { "felipe", "tamires", "daniela", "bruno", "rafael", "daniela", "1"};
        //senha
        List<string> senha_use = new List<string>() { "009", "0912", "1009", "bruno000", "2311", "3568", "1" };
        //email
        List<string> email_use = new List<string>() { "felipearaujo0912@.com", "tamires@.com", "daniela@.com", "bruno@.com", "rafão@.com", "daniela@.com", "1" };


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {


            string usuario_bus = txb_name.Text;
            string senha = txb_senha.Text;
            string senha2 = txb_cSenha.Text;
            string email = txb_email.Text;

            if (string.IsNullOrWhiteSpace(usuario_bus))
            {
                lbl_resultado.Text = "usuario obrigatorio!";
                lbl_resultado.ForeColor = Color.Red;
                return;
            }


            if (senha == null || senha == "")
            {
                lbl_resultado.Text = "senha obrigatorio!";
                lbl_resultado.ForeColor = Color.Red;
                return;

            }

            int usuario_enc = -1;
            for (int i = 0; i < lista_use.Count; i++)
            {
                if (usuario_bus == lista_use[i])
                {
                    usuario_enc = i;
                }
            }

            int senha_enc = -1;
            for (int i = 0; i < senha_use.Count; i++)
            {
                if (senha == senha_use[i])
                {
                    senha_enc = i;
                }
            }



            int email_enc = -1;
            for (int i = 0; i < email_use.Count; i++)
            {
                if (email == email_use[i])
                {
                    email_enc = i;
                }
            }


            if (usuario_enc > -1 && senha == senha_use[senha_enc] && senha2 == senha_use[senha_enc])
            {
                lbl_resultado.Text = "Autenticado com sucesso";
                lbl_resultado.ForeColor = Color.White;

            }
            else
            {
                lbl_resultado.Text = "usuario ou senha incoretos";
                lbl_resultado.ForeColor = Color.Red;


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbl_resultado_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario_bus = txb_name.Text;
            string senha = txb_senha.Text;
            string senha2 = txb_cSenha.Text;
            string email = txb_email.Text;

            if (string.IsNullOrWhiteSpace(usuario_bus))
            {
                lbl_resultado.Text = "usuario obrigatorio!";
                lbl_resultado.ForeColor = Color.Red;
                return;
            }


            if (senha == null || senha == "")
            {
                lbl_resultado.Text = "senha obrigatorio!";
                lbl_resultado.ForeColor = Color.Red;
                return;

            }

            int usuario_enc = -1;
            for (int i = 0; i < lista_use.Count; i++)
            {
                if (usuario_bus == lista_use[i])
                {
                    usuario_enc = i;
                }
            }

            int senha_enc = -1;
            for (int i = 0; i < senha_use.Count; i++)
            {
                if (senha == senha_use[i])
                {
                    senha_enc = i;
                }
            }



            int email_enc = -1;
            for (int i = 0; i < email_use.Count; i++)
            {
                if (email == email_use[i])
                {
                    email_enc = i;
                }
            }


            if (usuario_enc > -1 && senha == senha_use[senha_enc] && senha2 == senha_use[senha_enc])
            {
                lbl_resultado.Text = "Autenticado com sucesso";
                lbl_resultado.ForeColor = Color.White;

            }
            else
            {
                lbl_resultado.Text = "usuario ou senha incoretos";
                lbl_resultado.ForeColor = Color.Red;


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

