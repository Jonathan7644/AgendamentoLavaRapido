using System;
using System.Data;
using System.Data.SqlClient;

namespace AgendamentoLavaRapido.Repository
{
    public class Conexao
    {
        public SqlConnection Conectar()
        {
            string stringConexao = "Password = .; Persist Security Info = True; User ID = TOOR-01; Initial Catalog = BD_AGENDAMENTOLAVARAPIDO; Data Source=TooR-01/RooT";
            var conexao = new SqlConnection(stringConexao);
            conexao.Open();
            return (conexao);
        }
        public void CRUD(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            comando.ExecuteNonQuery();
            int Id = Convert.ToInt32(comando.ExecuteNonQuery());
            con.Close();
        }

        public SqlDataReader Selecionar(SqlCommand comando)
        {
            SqlConnection con = Conectar();
            comando.Connection = con;
            SqlDataReader dr = comando.ExecuteReader(CommandBehavior.CloseConnection);
            return dr;
        }
    }
}