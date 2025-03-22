using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail; // Adiciona a biblioteca para MailAddress
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cadastro_cliente
{
    public partial class Form1 : Form
    {
        private readonly BindingSource BindingSource = [];
    
        private readonly List<Cliente> Clientes = new List<Cliente>();
        Endereco endereçoFabio = new Endereco() { logradouro = "endereçoFabio", numero = "345" };

        public Form1()
        {

            InitializeComponent();
           
            Cliente fabio = new Cliente() { id = 1, Nome = "Fabio Saraiva", dataNacimento = "30 / 08 / 2013", etnia = etnia.Asiatico, tipo = TipoCliente.PF };
            Clientes.Add(fabio);

            Endereco endereçoVitor = new Endereco() { logradouro = "endereçoVitor", numero = "304" };
            Cliente vitor = new Cliente() { id = 2, Nome = "Vitor", dataNacimento = "15 / 09/ 1997", etnia = etnia.Negro, tipo = TipoCliente.PF };
            Clientes.Add(vitor);

            Endereco felipe = new Endereco() { logradouro = "endereçofelipe", numero = "42" };
            Cliente Felipe = new Cliente() { id = 3, Nome = "Felipe", dataNacimento = "9 / 12/ 2005", etnia = etnia.Negro, tipo = TipoCliente.PF };
            Clientes.Add(Felipe);

            BindingSource.DataSource = Clientes;
            dgv_clientes.DataSource = BindingSource;
            
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            string nome = txb_nome.Text;
            string telefone = msk_numero.Text;
            string datanascimento = msk_nascimento.Text;
            string nomesocial = txb_nomesocial.Text;
            string genero = cmb_genero.Text;
            string email = txb_email.Text;
            bool PF = rdb_fisica.Checked;
            bool PJ = rdb_juridica.Checked;
            bool estrangeiro = ckb_sim.Checked;


            string cep = txb_cep.Text;
            string logradouro = txb_lagradouro.Text;
            string bairro = txb_bairro.Text;
            string numero = msk_numero.Text;
            string municipio = txb_municipio.Text;
            string estado = cmb_estado.Text;

            Endereco endereco_Novo = new Endereco()
            {
                logradouro = txb_lagradouro.Text,
                numero = msk_numero.Text,
                complemento = txb_complemento.Text,
                bairro = txb_bairro.Text,
                municipio = txb_municipio.Text,
                estado = cmb_estado.Text,
                cep = txb_cep.Text

            };

            int tipoClienteIndex = rdb_fisica.Checked ? 0 : 1;
            TipoCliente tipoClienteSelecionado = (TipoCliente)tipoClienteIndex;

            if (ValidarDados(nome, email, telefone, cep, datanascimento, genero, logradouro, bairro, numero, municipio, estado, PF, PJ))
            {
                Cliente novoCliente = new Cliente
                {
                    id = GerarNovoId(),
                    Nome = nome,
                    email = email,
                    Telefone = telefone,
                    enderecoDoCliente = endereco_Novo,
                    dataNacimento = datanascimento,
                    NomeSocial = txb_nomesocial.Text,
                    genero = (Genero)cmb_genero.SelectedIndex,
                    etnia = (etnia)cmb_etnia.SelectedIndex,
                    tipo = tipoClienteSelecionado,
                    estrangeiro = estrangeiro

                };

                Clientes.Add(novoCliente);

                BindingSource.ResetBindings(false);

                MessageBox.Show("Cliente adicionado com sucesso!");
                LimparFormulario();
            }
            else
            {
                MessageBox.Show("Por favor, preencha todos os campos corretamente.");
            }
        }

        private bool ValidarDados(string nome, string email, string telefone, string cep, string datanascimento, string genero, string logradouro, string bairro, string numero, string municipio, string estado, bool PF, bool PJ)
        {
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefone) ||
                string.IsNullOrWhiteSpace(cep) ||
                string.IsNullOrWhiteSpace(datanascimento) ||
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

            if (Clientes.Any(cliente => cliente.email == email))
            {
                MessageBox.Show("Este email já está cadastrado.");
                return false;
            }

            if (Clientes.Any(cliente => cliente.Telefone == telefone))
            {
                MessageBox.Show("Este número de telefone já está cadastrado.");
                return false;
            }

            return true;
        }

        private bool ValidarEmail(string email)
        {
            return email.Count(c => c == '@') == 1;
        }

        private bool ValidarTelefone(string telefone)
        {
            string apenasNumeros = new string(telefone.Where(char.IsDigit).ToArray());
            return apenasNumeros.Length == 11;
        }

        private int GerarNovoId()
        {
            if (Clientes.Count == 0)
                return 1;

            return Clientes.Max(cliente => cliente.id) + 1;
        }

        private void LimparFormulario()
        {
            txb_numero.Clear();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

    public class cliente
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string email { get; set; }
        public string Telefone { get; set; }
    }
}