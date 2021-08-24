using Exercicio_07.Interfaces;
using MySql.Data.MySqlClient;
using System;

namespace Exercicio_07.Entidades
{
    public class Status : IDaoBase
    {
        public Status(EStatus tipo)
        {
            this.Id = 0;
            this.Tipo = tipo;
        }

        public int Id { get; set; }
        public EStatus Tipo { get; set; }

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
                    command.CommandText = "insert into status (Tipo) values (@tipo)";
                    command.Parameters.AddWithValue("@tipo", (int)this.Tipo);

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
    
    public enum EStatus
    {
        Andamento,
        Concluido,
        Fechado
    }
}
