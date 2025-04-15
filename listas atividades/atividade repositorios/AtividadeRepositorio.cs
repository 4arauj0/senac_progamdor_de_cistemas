using listas_atividades.banco_de_dados;
using listas_atividades.dominio;
using MySql.Data.MySqlClient;

namespace listas_atividades
{
    internal class AtividadeRepositorio
    {
        public void Criar(string titulo)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "INSERT INTO atividade (titulo VALUES (@titulo);";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void AtualizarSituacao(int id, int novaSituacao)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "UPDATE atividade SET situacao = @situacao = @ situacao WHERE id = @id";
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public atividade BuscarAtividadeEmAndamento()
        {

            using (var con = DataBase.GetConnection())
            {
                con.Open();
                string query = $"SELECT * FROM atividade WHERE situacao = {Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, con))
                {


                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new atividade()
                            {
                                id = reader.GetInt32("id"),
                                titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            };
                        }
                    }

                }
            }
            return new atividade();

        }
    }
}