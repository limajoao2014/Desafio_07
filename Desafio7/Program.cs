using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio7
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Funcoes.Menu();
            }
        }
        public class Funcoes
        {
            public static void DataCollect()
            {
                bdAlunos DataAluno = new bdAlunos();
                bdCurso DataCurso = new bdCurso();
                bdStatus DataStatus = new bdStatus();

                Console.WriteLine("Nome do aluno:");
                DataAluno.Nome = Console.ReadLine();
                Console.WriteLine("Matricula:");
                DataAluno.Matricula = Console.ReadLine();
                Console.WriteLine("CPF:");
                DataAluno.CPF = Console.ReadLine();
                Console.WriteLine("Telefone para contato: ");
                DataAluno.Contato = Console.ReadLine();
                Console.WriteLine("Qual seu Curso: ");
                DataCurso.NomeCurso = Console.ReadLine();
                Console.WriteLine("Digite suas notas\n");
                Console.WriteLine("Prova 1: ");
                DataCurso.Nota1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Prova 2: ");
                DataCurso.Nota2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Prova: ");
                DataCurso.Nota3 = double.Parse(Console.ReadLine());
                DataCurso.Matricula1 = DataAluno.Matricula;
                DataStatus.Matricula2 = DataAluno.Matricula;
                DataStatus.Media = (DataCurso.Nota1 + DataCurso.Nota2 + DataCurso.Nota3) / 3;
                if (DataStatus.Media > 7)
                    DataStatus.Status1 = "APROVADO";
                else
                    DataStatus.Status1 = "REPROVADO";
                DataAluno.InsertData(DataAluno);
                DataCurso.InsertData2(DataCurso);
                DataStatus.InsertData3(DataStatus);
                Console.ReadKey();

               
            }
            public static void Menu()
            {
                int menu = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine("[1]->Cadastrar alunos\n");
                    Console.WriteLine("[2]->Sair\n");
                    menu = Int32.Parse(Console.ReadLine());

                    switch (menu)
                    {
                        case 1:
                            ColetaInfo();
                            break;
                        case 2:
                            Console.WriteLine("\nSaindo ...");
                            break;
                        default:
                            Console.WriteLine("\nCódigo Inválido!!");
                            break;
                    }
                } while (menu != 2);
            }
        }
    } 
}
        

            
