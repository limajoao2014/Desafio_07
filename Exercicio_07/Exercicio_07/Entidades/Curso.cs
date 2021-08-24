using Exercicio_07.Interfaces;
using MySql.Data.MySqlClient;
using System;

namespace Exercicio_07.Entidades
{
    public class Curso : IDaoBase
    {
        public Curso(string nome, int status)
        {
            this.Id = 0;
            this.StatusId = status;
            this.Nome = nome;
        }

        public int Id { get; set; }
        public int StatusId { get; set; }
        public string Nome { get; set; }

        public bool Salvar()
        {
            try
            {
                //configurando conexão com BD local
                using (var bdConn = new MySqlConnection("server=localhost;database=exercicio_07;uid=root;pwd='Israel@46743562'"))
                {
                    //abrindi conexão com BD
                    bdConn.Open();
                    MySqlCommand command = bdConn.CreateCommand();

                    //aplicando os valores a serem colocados na tabela
                    command.CommandText = "insert into curso (StatusId,Nome) values (@statusid,@nome)";
                    command.Parameters.AddWithValue("@statusid", this.StatusId);
                    command.Parameters.AddWithValue("@nome", this.Nome);

                    //Comando para exportar os valores para tabela
                    command.ExecuteNonQuery();

                    //fechando conexão com BD
                    bdConn.Close();
                    return true;
                }
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return false;
            }

        }
    }
}
