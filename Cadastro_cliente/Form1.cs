using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Cadastro_cliente
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> Clientes = [];
        public Form1()
        {
            InitializeComponent();
            Cliente felipe = new Cliente();
            Clientes.Add(felipe);

            Endereco enderecoFelipe = new Endereco() { logradouro = "endereco felipe", numero = "10", bairro = "zl", cep = "04857510", cidade = "sp", complemento = "casa2", estado = "sp" };
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
            Clientes.Add(felipe);



        }
        private void AtulizarLista()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {

        }

     
    }
}
