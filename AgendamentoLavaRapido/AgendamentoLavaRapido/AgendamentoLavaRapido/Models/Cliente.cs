using AgendamentoLavaRapido.Repository;
using System;
using System.ComponentModel;

namespace AgendamentoLavaRapido.Models
{
    public class Cliente
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Nome completo")]
        public string Nome { get; set; }

        [DisplayName("CPF")]
        public int Cpf { get; set; }

        [DisplayName("Data de Nascimento")]
        public DateTime DataNascimento { get; set; }

        [DisplayName("Telefone")]
        public string Telefone { get; set; }

        [DisplayName("Av, Rua, Trav...")]
        public string Logradouro { get; set; }

        [DisplayName("Número")]
        public string Numero { get; set; }

        [DisplayName("Bairro")]
        public string Bairro { get; set; }

        public void Gravar(Cliente cliente)
        {
            ClienteDAO clienteDAO = new ClienteDAO();

            if (Id == 0)
            {
                clienteDAO.Insert(this);
            }
            else
            {
                clienteDAO.Update(this);
            }
        }
    }
}