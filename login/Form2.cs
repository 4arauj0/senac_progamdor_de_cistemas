namespace login
{
    public partial class Form1 : Form
    {
        //usuario
        List<string> lista_use = new List<string>() { "felipe", "tamires", "daniela", "bruno", "rafael", "daniela", "1" };
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

        private void button_Click(object sender, EventArgs e)
        {
            List<string> listaabc = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            List<string> listaABC = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
            List<string> lista123 = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            List<string> listaespecial = new List<string>() { "@", "#", "$", "%", "&", "*", "(", ")", "_", "+", "!", "=", "{", "}", "[", "]", "|", };

            List<string> alfabetoMaiusculo = new List<string>() { "A", "B", "C", "D", "E" };
            List<string> alfabetoMinusculo = new List<string>() { "a", "b", "c", "d", "e" };
            List<char> numeros = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            List<char> especiais = new List<char>() { '!', '@', '#', '$', '%', '&', '*' };

            List<string> listaUsuarios = new List<string>() { "neymar.jr", "pablo.vitar", "sukuna.silva" };
            List<string> listaSenhas = new List<string>() { "Brun@123", "12345Abc!", "Sete7Sete!" };

        }

        private void button1_Click_1(object sender, EventArgs e)
            {
                string button1_Click_1;
                string usuarioBuscado = txb_Ecadastro.Text;
                string senha = txb_senha.Text;
                string senha2 = txb_cSenha.Text;
                string email = txb_email.Text;


                if (string.IsNullOrWhiteSpace(usuarioBuscado))
                {
                    lbl_resultado.Text = "Usuario eh obrigatorio!!!";
                    lbl_resultado.ForeColor = Color.Red;
                    return;
                }

                if (string.IsNullOrWhiteSpace(senha))
                {
                    lbl_resultado.Text = "Senha eh obrigatoria!!!";
                    lbl_resultado.ForeColor = Color.Red;
                    return;
                }

                int posicaoUsuarioEncontrado = -1;
                for (int i = 0; i < lista_use.Count; i++)
                {
                    if (usuarioBuscado == lista_use[i])
                    {
                        posicaoUsuarioEncontrado = i;
                    }
                }

                if (posicaoUsuarioEncontrado > -1 && senha == senha_use[posicaoUsuarioEncontrado])
                {
                    lbl_resultado.Text = "Autenticado com sucesso!";
                    lbl_resultado.ForeColor = Color.Green;
                }
                else
                {
                    lbl_resultado.Text = "Usuario ou Senha incorretos...";
                    lbl_resultado.ForeColor = Color.Red;
                }
            }

        private void buttonCadastrar_Click(object sender, EventArgs e)
            {
                string novoUsuario = txb_Ncadastro.Text;
                string novaSenha = txb_senha.Text;

                if (string.IsNullOrWhiteSpace(novoUsuario))
                {
                    lbl_resultado.Text = "Usuario eh obrigatorio!!!";
                    return;
                }

                if (string.IsNullOrWhiteSpace(novaSenha))
                {
                    lbl_resultado.Text = "Senha eh obrigatoria!!!";
                    return;
                }

                if (novaSenha.Length < 8)
                {
                    lbl_resultado.Text = "A senha deve ter pelo menos 8 caracteres";
                    return;
                }

                if (!novaSenha.Any(char.IsUpper))
                {
                    lbl_resultado.Text = "A senha deve ter pelo menos uma letra maiuscula";
                    return;
                }

                if (!novaSenha.Any(char.IsLower))
                {
                    lbl_resultado.Text = "A senha deve ter pelo menos uma letra minuscula";
                    return;
                }

                if (!novaSenha.Any(char.IsDigit))
                {
                    lbl_resultado.Text = "A senha deve ter pelo menos um numero";
                    return;
                }

                if (!novaSenha.Any(char.IsPunctuation))
                {
                    lbl_resultado.Text = "A senha deve ter pelo menos um caracter especial";
                    return;
                }

                if (novaSenha.Contains(' '))
                {
                    lbl_resultado.Text = "A senha nao deve ter espacos em branco";
                    return;
                }

                if (lista_use.Contains(novoUsuario))
                {
                    lbl_resultado.Text = "Já existe um usuário cadastrado";
                    return;
                }

                lista_use.Add(novoUsuario);
            senha_use.Add(novaSenha);
                lbl_resultado.Text = "Usuário cadastrado com sucesso!";
                txb_Ncadastro.Clear();
                txb_senha.Clear();




            }
        

    }
}


