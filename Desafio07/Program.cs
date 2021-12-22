using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Desafio07;
using MySql.Data.MySqlClient;

public class Program {
    public static void Main()
    {
        string connStr = "server=localhost;user=root;database=desafio07;port=3306;password=Lolmicrosoft126";

        DAOAluno jubileu = new DAOAluno();
        Console.WriteLine("qual é o nome da criatura ? \n");
        jubileu.Nome = Console.ReadLine();
       
        Console.WriteLine("qual é a idade da criatura ? \n");
        jubileu.Idade = Convert.ToInt32(Console.ReadLine());
        
        
        Console.WriteLine("qual é a nota da criatura ? \n");
        jubileu.Nota = Convert.ToDouble(Console.ReadLine());
        

        DAOCurso jubileuCurso = new DAOCurso();
        Console.WriteLine("Qual o curso que o criatura está cursando ? \n");
        jubileuCurso.Nome = Console.ReadLine();

        Console.WriteLine("Qual o periodo que o criatura está cursando ? \n");
        jubileuCurso.Periodo = Convert.ToInt32(Console.ReadLine());
        
        DAOStatus jubileuStatus = new DAOStatus();
        Console.WriteLine("Está Cursando ? \n ");
        jubileuStatus.Nome = Console.ReadLine();
        jubileuStatus.getCursando(jubileuStatus.Nome);


        Guid Id = Guid.NewGuid();
        using (var conn = new MySqlConnection(connStr))
        {
            MySqlCommand comm = conn.CreateCommand();
            conn.Open();
            comm.CommandText = $"INSERT INTO desafio07 (IdAluno,Nome,Idade,Nota,Curso,Periodo,Status) VALUES (?IdAluno,?Nome,?Idade,?Nota,?Curso,?Periodo,?Status)";
            comm.Parameters.AddWithValue($"@IdAluno", $"{Id}");
            comm.Parameters.AddWithValue($"@Nome", $"{jubileu.Nome}");
            comm.Parameters.AddWithValue($"@Idade", $"{jubileu.Idade}");
            comm.Parameters.AddWithValue($"@Nota", $"{jubileu.Nota}");
            comm.Parameters.AddWithValue($"@Curso", $"{jubileuCurso.Nome}");
            comm.Parameters.AddWithValue($"@Periodo", $"{jubileuCurso.Periodo}");
            comm.Parameters.AddWithValue($"@Status", $"{jubileuStatus.Cursando}");
            comm.ExecuteNonQuery();
            conn.Close();
        }
        Console.WriteLine("Desafio Concluido");
    }

}

