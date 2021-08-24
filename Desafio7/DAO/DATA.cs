using System;
using MySql.Data.MySqlClient;
using Desafio7.Entities;


public class bdAlunos : Alunos
{
    public int InsertData(Alunos aluno)
    {
        var connectring = "server = localhost; user id = root; database = desafio7; sslmode = None";
        var connect = new MySqlConnection(connectring);
        var command = connect.CreateCommand();

        try
        {
            connect.Open();
            command.CommandText = "INSERT INTO aluno (Nome, Matricula, CPF, Contato)" +
                                   "VALUES (?nome, ?matricula, ?cpf, ?contato)";

            command.Parameters.Add("?nome", MySqlDbType.VarChar).Value = aluno.Nome;
            command.Parameters.Add("?matricula", MySqlDbType.VarChar).Value = aluno.Matricula;
            command.Parameters.Add("?cpf", MySqlDbType.VarChar).Value = aluno.CPF;
            command.Parameters.Add("?contato", MySqlDbType.VarChar).Value = aluno.Contato;

            Console.WriteLine("Dados do aluno salvos com sucesso!");
            command.ExecuteNonQuery();
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
            return (int)command.LastInsertedId;
        }
        catch (Exception)
        {
            return 0;
        }

    }
}
public class bdCurso : Curso
{
    public int InsertData2(Curso curso)
    {
        var connectring = "server = localhost; user id = root; database = desafio7; sslmode = None";
        var connect = new MySqlConnection(connectring);
        var command = connect.CreateCommand();

        try
        {
            connect.Open();
            command.CommandText = "INSERT INTO curso (Curso, Nota1, Nota2, Nota3, Matricula)" +
                                   "VALUES (?curso, ?nota1, ?nota2, ?nota3, ?matricula)";

            command.Parameters.Add("?curso", MySqlDbType.VarChar).Value = curso.NomeCurso;
            command.Parameters.Add("?nota1", MySqlDbType.Double).Value = curso.Nota1;
            command.Parameters.Add("?nota2", MySqlDbType.Double).Value = curso.Nota2;
            command.Parameters.Add("?nota3", MySqlDbType.Double).Value = curso.Nota3;
            command.Parameters.Add("?matricula", MySqlDbType.VarChar).Value = curso.Matricula1;

            Console.WriteLine("Dados Salvos em Banco curso com sucesso!");
            command.ExecuteNonQuery();
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
            return (int)command.LastInsertedId;
        }
        catch (Exception)
        {
            return 0;
        }
    }
}
public class bdStatus : Status
{
    public int InsertData3(Status status)
    {
        var connectring = "server = localhost; user id = root; database = desafio7; sslmode = None";
        var connect = new MySqlConnection(connectring);
        var command = connect.CreateCommand();

        try
        {
            connect.Open();
            command.CommandText = "INSERT INTO status (Media, Status, Matricula)" +
                                   "VALUES (?media, ?status, ?matricula)";

            command.Parameters.Add("?media", MySqlDbType.Double).Value = status.Media;
            command.Parameters.Add("?status", MySqlDbType.VarChar).Value = status.Status1;
            command.Parameters.Add("?matricula", MySqlDbType.VarChar).Value = status.Matricula2;

            Console.WriteLine("Dados Salvos em Banco Status com sucesso!");
            command.ExecuteNonQuery();
            if (connect.State == System.Data.ConnectionState.Open)
                connect.Close();
            return (int)command.LastInsertedId;
        }
        catch (Exception)
        {
            return 0;
        }
    }
}

