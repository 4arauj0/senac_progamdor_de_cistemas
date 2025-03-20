using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail; // Adiciona a biblioteca para MailAddress
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cadastro_cliente
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> Clientes = new List<Cliente>();

        public Form1()
        {
            InitializeComponent();
            Cliente felipe = new Cliente();
            Clientes.Add(felipe);

            Endereco enderecoFelipe = new Endereco()
            {
                logradouro = "endereco felipe",
                numero = "10",
                bairro = "zl",
                cep = "04857510",
                cidade = "sp",
                complemento = "casa2",
                estado = "sp"
            };
            Cliente Felipe = new Cliente()
            {
                id = 1,
                Nome = "Felipe araujo",
                dataNacimento = "09/12/2005",
                etnia = etnia.Outro,
                tipo = TipoCliente.PF,
                email = "felipe0912@homtail",
                estrangeiro = false,
                enderecoDoCliente = enderecoFelipe,
                genero = Genero.naoBinario,
                NomeSocial = "felipe",
                Telefone = "11955595521"
            };

            Endereco enderecoFabio = new Endereco() { logradouro = "endereçoFabio", numero = "345" };
            Cliente fabio = new Cliente() { id = 2, Nome = "Fabio Saraiva", dataNacimento = "30/08/2013", etnia = etnia.Branco, tipo = TipoCliente.PF };

            Endereco enderecoVitor = new Endereco() { logradouro = "endereçoVitor", numero = "304" };
            Cliente vitor = new Cliente() { id = 3, Nome = "Fabio Saraiva", dataNacimento = "15/09/1997", etnia = etnia.Branco, tipo = TipoCliente.PF };

            Clientes.Add(vitor);
            Clientes.Add(felipe);
            Clientes.Add(fabio);
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txb_nome.Text;
            string telefone = msk_numero.Text;
            string cep = txb_cep.Text;
            string datanascimento = msk_nascimento.Text;
            string nomesocial = txb_nomesocial.Text;
            string genero = cmb_genero.Text;
            string email = txb_email.Text;
            string logradouro = txb_lagradouro.Text;
            string complemento = txb_complemento.Text;
            string bairro = txb_bairro.Text;
            string numero = txb_municipio.Text;
            string municipio = txb_municipio.Text;
            string estado = cmb_estado.Text;
            bool PF = rdb_fisica.Checked;
            bool PJ = rdb_juridica.Checked;
            bool estrangeiro = ckb_sim.Checked;

            if (ValidarDados(nome, email, telefone, cep, datanascimento, nomesocial, genero, logradouro, complemento, bairro, numero, municipio, estado, PF, PJ, estrangeiro))
            {
                Cliente novoCliente = new Cliente
                {
                    Nome = nome,
                    email = email,
                    Telefone = telefone
                };

                Clientes.Add(novoCliente);

                MessageBox.Show("Cliente adicionado com sucesso!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
            }
        }

        private bool ValidarDados(string nome, string email, string telefone, string cep, string datanascimento, string nomesocial, string genero, string logradouro, string complemento, string bairro, string numero, string municipio, string estado, bool PF, bool PJ, bool estrangeiro)
        {
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefone) ||
                string.IsNullOrWhiteSpace(cep) ||
                string.IsNullOrWhiteSpace(datanascimento) ||
                string.IsNullOrWhiteSpace(nomesocial) ||
                string.IsNullOrWhiteSpace(genero) ||
                string.IsNullOrWhiteSpace(logradouro) ||
                string.IsNullOrWhiteSpace(bairro) ||
                string.IsNullOrWhiteSpace(numero) ||
                string.IsNullOrWhiteSpace(municipio) ||
                string.IsNullOrWhiteSpace(estado))
            {
                MessageBox.Show("Todos os campos obrigatórios devem ser preenchidos.");
                return false;
            }

            if (!ValidarEmail(email))
            {
                MessageBox.Show("O email fornecido não é válido.");
                return false;
            }

            if (!ValidarTelefone(telefone))
            {
                MessageBox.Show("O telefone fornecido não é válido.");
                return false;
            }

            if (!PF && !PJ)
            {
                MessageBox.Show("Selecione se o cliente é Pessoa Física ou Jurídica.");
                return false;
            }

            return true;
        }

        private bool ValidarEmail(string email)
        {
            try
            {
                // Expressão regular para validar o e-mail de forma simples
                var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
                return regex.IsMatch(email);
            }
            catch
            {
                return false;
            }
        }

        private bool ValidarTelefone(string telefone)
        {
            return telefone.All(char.IsDigit) && (telefone.Length == 11); // Assumindo que o telefone tenha 11 dígitos
        }

        private void LimparFormulario()
        {
            txb_nome.Clear();
            txb_email.Clear();
            msk_numero.Clear();
            txb_cep.Clear();
            msk_nascimento.Clear();
            txb_nomesocial.Clear();
            cmb_genero.SelectedIndex = -1;
            txb_lagradouro.Clear();
            txb_complemento.Clear();
            txb_bairro.Clear();
            txb_municipio.Clear();
            cmb_estado.SelectedIndex = -1;
            rdb_fisica.Checked = false;
            rdb_juridica.Checked = false;
            ckb_sim.Checked = false;
        }
    }
}