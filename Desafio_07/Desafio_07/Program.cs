using MySql.Data.MySqlClient;
using System;

namespace Desafio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            aluno.AddAluno();

            try
            {
                Console.Write("Id do aluno: ");
                aluno.aluno_id = Convert.ToInt32(Console.ReadLine());

                Console.Write("Nome: ");
                aluno.Nome = Console.ReadLine();

                Console.Write("Nota: ");
                aluno.Nota = Console.ReadLine();

                string query = "insert into tb_aluno values(" +
                      aluno.aluno_id + ", '" + aluno.Nome + "', " + aluno.Nota + ") ";
                Console.WriteLine(query);

                string cs = @"Server=localhost;Port=3306;database=DB_Challenge7;User=root;Pwd=password";

                MySqlConnection cn = new MySqlConnection(cs);
                cn.Open();
                Console.WriteLine("Conectado.");

                MySqlCommand cmd = new MySqlCommand(query, cn);
                int result = cmd.ExecuteNonQuery();
                Console.WriteLine(result + " Dados inseridos na tabela.");

                Console.WriteLine("\nDados dos alunos");
                query = "select * from tb_aluno";
                MySqlCommand cmd2 = new MySqlCommand(query, cn);
                MySqlDataReader r = cmd2.ExecuteReader();

                while (r.Read() == true)
                {
                    int aid = r.GetInt32(0);
                    string nm = r.GetString(1);
                    string nt = r.GetString(2);

                    Console.WriteLine("{0}\t {1} \t {2}", aid, nm, nt);
                }
                cn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e);
            }

        }
    }
}
