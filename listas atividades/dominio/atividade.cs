using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_atividades.dominio
{
    internal class atividade
    {
        public int id {  get; set; }
        public string titulo { get; set; }
        public Situacao Situacao { get; set; }

        public void Criar()
        {

        }
        public void AtualizarSituacao()
        {

        }
        public atividade BuscarAtividadeEmAndamento()
        {
            return new atividade();
        }
        public List<atividade> ListarAtividadesPendentes()
        {
            return [];
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrEmpty(titulo);
        }
        private Situacao BuscarProximaSituacao()
        {
            return Situacao.Concluido;
        }
    }
}
