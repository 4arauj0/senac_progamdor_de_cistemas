using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastro_cliente
{
    internal class Endereco
    {
        string logradouro { get; set; }
        string número { get; set; }
        string complemento { get; set; }
        string bairro { get; set; }
        string cidade { get; set; }
        string estado { get; set; }
        string cep { get; set; }
    }
}
