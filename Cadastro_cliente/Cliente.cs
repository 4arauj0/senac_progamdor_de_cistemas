using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Cadastro_cliente
{
    internal class Cliente
    {
        public int id {  get; set; }
        public string Nome { get; set; }
        public TipoCliente tipo { get; set; }
        public string Telefone { get; set; }
        public string email { get; set; }
        public Endereco enderecoDoCliente { get; set; }
        public Genero genero { get; set; }
        public string NomeSocial { get; set; }
        public etnia etnia { get; set; }
        public bool estrangeiro { get; set; }
        public string dataNacimento { get; set; }


    }
}
