using Exercicio_07.Interfaces;
using System;
using MySql.Data.MySqlClient;

namespace Exercicio_07.Entidades
{
    public class Aluno : IDaoBase
    {
        public int Id { get; set; }
        public int CursoId { get; set; }
        public decimal Nota { get; set; }
        public int Idade { get; set; }
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
                    command.CommandText = "insert into aluno (Nome,Idade,CursoId,Nota) values (@nome,@idade,@curso,@nota)";
                    command.Parameters.AddWithValue("@nome", this.Nome);
                    command.Parameters.AddWithValue("@idade", this.Idade);
                    command.Parameters.AddWithValue("@curso", this.CursoId);
                    command.Parameters.AddWithValue("@nota", this.Nota);

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
