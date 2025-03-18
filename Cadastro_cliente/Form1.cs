using System.Windows.Forms;

namespace Cadastro_cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        List<string> nomes = new List<string> { "Ana", "Carlos", "Mariana" };

  

        private void Form1_oad(object sender, EventArgs e)
        {
    
            AtualizarLista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
        
            nomes.Add("Pedro");
            AtualizarLista();
        }

        private void AtualizarLista()
        {
          
        }
    }
}
