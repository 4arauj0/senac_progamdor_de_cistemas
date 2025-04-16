using listas_atividades.dominio;

namespace listas_atividades
{
    public partial class ListaDeAtividade : Form
    {
        public ListaDeAtividade()
        {
            InitializeComponent();
        }

        private void ListaDeAtividade_Load(object sender, EventArgs e)
        {
            atividade atividade = new();

            var atividadeEmAndamento = atividade.BuscarAtividadeEmAndamento();
            if (atividadeEmAndamento.id > 0)
            { 
            txt_atividade_em_andamento.Text = $"{atividadeEmAndamento.id} - {atividadeEmAndamento.titulo} ";
            }

            var atividadePendente = atividade.ListarAtividadesPendentes();
            dgv_atividade.DataSource = atividadeEmAndamento;


        }
    }
}
