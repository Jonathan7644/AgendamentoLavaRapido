using System;
using AgendamentoLavaRapido.Models;
using System.Data.SqlClient;
using System.Data;

namespace AgendamentoLavaRapido.Repository
{
    public class ClienteDAO
    {
        public void Insert(Cliente cliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "INSERT INTO Clientes (id, nome, cpf, dataNascimento, telefone, logradouro, numero, bairro) VALUES (@nome, @cpf, @dataNascimento, @telefone, @logradouro, @numero, @bairro, @clienteId)";

            comando.Parameters.AddWithValue("@clienteId", cliente.Id);
            comando.Parameters.AddWithValue("@nome", cliente.Nome);
            comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
            comando.Parameters.AddWithValue("@dataNascimento", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@telefone", cliente.Telefone);
            comando.Parameters.AddWithValue("@logradouro", cliente.Logradouro);
            comando.Parameters.AddWithValue("@numero", cliente.Numero);
            comando.Parameters.AddWithValue("@bairro", cliente.Bairro);

            Conexao con = new Conexao();
            con.CRUD(comando);
        }

        public void Update(Cliente cliente)
        {
            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "";

            comando.Parameters.AddWithValue("@clienteID", cliente.Id);
            comando.Parameters.AddWithValue("@nome", cliente.Nome);
            comando.Parameters.AddWithValue("@cpf", cliente.Cpf);
            comando.Parameters.AddWithValue("@dtNascimento", cliente.DataNascimento);
            comando.Parameters.AddWithValue("@rg", cliente.Telefone);
            comando.Parameters.AddWithValue("@endereco", cliente.Logradouro);
            comando.Parameters.AddWithValue("@numero", cliente.Numero);
            comando.Parameters.AddWithValue("@orgaoExpedidor", cliente.Bairro);

            Conexao con = new Conexao();
            con.CRUD(comando);
        }
    }
}