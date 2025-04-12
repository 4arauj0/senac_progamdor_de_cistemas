using MySql.Data.MySqlClient;

namespace login
{
    public partial class Form1 : Form
    {

        private static readonly string ConnectionString = "datasource=localhost;username=root;password=;database=cenac;";
        private readonly MySqlConnection Connection = new MySqlConnection(ConnectionString);

        List<usuario> usuarios = new List<usuario>();



        public Form1()
        {
            InitializeComponent();

            usuario felipe = new usuario() { email = "felipearaujo0912@.com", senha = "009" };
            usuario tamires = new usuario() { email = "0912@.com", senha = "0912" };
            usuario daniela = new usuario() { email = "daniela@.com", senha = "1009" };
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {

            string usuario_bus = txb_name.Text;
            string senha2 = txb_cSenha.Text;
            string email = txb_email.Text;
            string senha_use = txb_cSenha.Text;
            string email_use = txb_email.Text;
            string Ncadastro = txb_Ncadastro.Text;
            string senha = txb_senha.Text;


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

            bool autenticado = false;

           try
            {
                Connection.Open();

                string query = $" SELECT senha FROM usuarios WHERE email = '{usuario_bus}';";

                MySqlCommand mySqlCommand = new MySqlCommand(query, Connection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();

                autenticado = reader.Read() && reader.GetString(0) == senha;
            }
                
                catch
            {
                MessageBox.Show("erro de banco de dados");
            }

            finally
           
            {
                Connection.Close();
            }

            if (!autenticado)
            {
                lbl_resultado.Text = "usuario ou senha incorreros...";

                lbl_resultado.ForeColor = Color.Red;
                return;

            }
            lbl_resultado.Text = "autenticado com sucesso  ";
            lbl_resultado.ForeColor = Color.Green;

            txb_name.Clear();
            txb_senha.Clear();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            //List<string> listaabc = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            //List<string> listaABC = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", };
            //List<string> lista123 = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            //List<string> listaespecial = new List<string>() { "@", "#", "$", "%", "&", "*", "(", ")", "_", "+", "!", "=", "{", "}", "[", "]", "|", };



        }


        private void button1_Click_1(object sender, EventArgs e)
        {





        }

        private void btncadastra_Click(object sender, EventArgs e)
        {
            // Busca o novo usuário e senha digitados
            string novoUsuario = txb_Ncadastro.Text;
            string novaSenha = txb_senha.Text;

            // Verifica se o novo usuário foi digitado
            if (string.IsNullOrWhiteSpace(novoUsuario))
            {
                lbl_resultado.Text = "Usuario eh obrigatorio!!!";
                return;
            }

            // Verifica se a nova senha foi digitada
            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                lbl_resultado.Text = "Senha eh obrigatoria!!!";
                return;
            }

            // Verifica se a senha tem pelo menos 8 caracteres
            if (novaSenha.Length < 8)
            {
                lbl_resultado.Text = "A senha deve ter pelo menos 8 caracteres";
                return;
            }

            // Verifica se a senha tem pelo menos uma letra maiúscula
            if (!novaSenha.Any(char.IsUpper))
            {
                lbl_resultado.Text = "A senha deve ter pelo menos uma letra maiuscula";
                return;
            }

            // Verifica se a senha tem pelo menos uma letra minúscula
            if (!novaSenha.Any(char.IsLower))
            {
                lbl_resultado.Text = "A senha deve ter pelo menos uma letra minuscula";
                return;
            }

            // Verifica se a senha tem pelo menos um número
            if (!novaSenha.Any(char.IsNumber))
            {
                lbl_resultado.Text = "A senha deve ter pelo menos um numero";
                return;
            }

            // Verifica se a senha tem pelo menos um caracter especial
            if (!novaSenha.Any(char.IsPunctuation) && !novaSenha.Any(char.IsSymbol) && !novaSenha.Contains('@'))
            {
                lbl_resultado.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }

            // Verifica se a senha tem espaços em branco
            if (novaSenha.Any(char.IsWhiteSpace))
            {
                lbl_resultado.Text = "A senha nao deve ter espacos em branco";
                return;
            }

            // Verifica se o novo usuário já está cadastrado
            bool encontrado = false;
            for (int i = 0; i < usuarios.Count; i++)
            {
                if (usuarios[i].email == novoUsuario)
                {
                    encontrado = true;
                }
            }

            // Se o usuário já estiver cadastrado, exibe mensagem de erro
            if (encontrado)
            {
                lbl_resultado.Text = "Já existe um usuário cadastrado";
                return;


                try
                {
                    Connection.Open();

                    string query = $"select email usuario where email =";
                }
                catch
                {
                    MessageBox.Show("Erro de banco de dados");
                }
                finally
                {
                    Connection.Close();
                }
                // Adiciona o novo usuário na lista
                usuarios.Add(new usuario() { email = novoUsuario, senha = novaSenha });
                lbl_resultado.Text = "Usuário cadastrado com sucesso!";
                txb_Ncadastro.Clear();
                txb_senha.Clear();
            }
        }
    }
}


