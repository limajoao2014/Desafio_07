using Exercicio_07.Entidades;
using System;
using System.Collections.Generic;

namespace Exercicio_07
{
    class Program
    {
        //Console.WriteLine("Qual a nota do {0}? (utilizar ',' para separar os decimais)", nome);
        //double nota = Double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        static void Main(string[] args)
        {
            //do while para coleta de informações
            do
            {
                Console.WriteLine("\nEscolha uma opção:");
                Console.WriteLine("1 - Popular Base");
                Console.WriteLine("2 - Cadastrar usuário");

                string resposta = Console.ReadLine();
                switch (resposta)
                {
                    case "1":

                        //lista de status de curso
                        List<Status> status = new List<Status>() {
                            new Status(EStatus.Andamento),
                            new Status(EStatus.Concluido),
                            new Status(EStatus.Fechado)
                        };

                        foreach (var item in status)
                            item.Salvar();

                        //Aqui foi predefinido o nome dos cursos, e o status que o curso está, sendo 0 = em andamento, 1 = concluído e 2 = fechado
                        List<Curso> cursos = new List<Curso>() {
                            new Curso("Administração", 0),
                            new Curso("Ciência da computação", 1),
                            new Curso("Arquitetura", 2)
                        };

                        //salvando no BD
                        foreach (var item in cursos)
                            item.Salvar();

                        Console.WriteLine("Cadastro com sucesso!");

                        break;

                    case "2":
                        //coletando as informações do(s) aluno(s)
                        var aluno = new Aluno();

                        Console.WriteLine("\nDigite o nome do Aluno: ");
                        aluno.Nome = Console.ReadLine();
                        Console.WriteLine("\nDigite a idade do Aluno: ");
                        aluno.Idade = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\nDigite a nota do Aluno: ");
                        aluno.Nota = Decimal.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
                        Console.WriteLine("\nDigite o curso do Aluno.\n(0 = Administração; 1 = Ciência da computação; 2 = Arquitetura)");
                        aluno.CursoId = Convert.ToInt32(Console.ReadLine());

                        //salvando no BD
                        aluno.Salvar();
                        Console.WriteLine("Cadastro com sucesso!");

                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                //Código para parar a repetição
                Console.WriteLine("Digite 'parar' para sair");
            } while (Console.ReadLine() != "parar");

        }


    }
}
