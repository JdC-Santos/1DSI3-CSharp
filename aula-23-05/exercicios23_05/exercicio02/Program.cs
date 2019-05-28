using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    class Program
    {
        public struct Aluno
        {
            public string nome;
            public double nota1;
            public double nota2;
            public double media;
        }
        static void Main(string[] args)
        {
            string sair = "n";
            int opcao, nrAluno = 0, pesquisa;
            Aluno[] aluno = new Aluno[15];

            do
            {
                Console.Clear();
                Console.WriteLine("================================");
                Console.WriteLine("|              MENU            |");
                Console.WriteLine("================================");
                Console.WriteLine("| 1 - Cadastrar                |");
                Console.WriteLine("| 2 - Consultar                |");
                Console.WriteLine("| 0 - Sair                     |");
                Console.WriteLine("================================");

                Console.Write("Digite sua opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.Write("Digite o nome do aluno: ");
                            aluno[nrAluno].nome = Console.ReadLine();

                            Console.Write("Digite a primeira nota do aluno: ");
                            aluno[nrAluno].nota1 = double.Parse(Console.ReadLine());

                            Console.Write("Digite a segunda nota do aluno: ");
                            aluno[nrAluno].nota2 = double.Parse(Console.ReadLine());

                            aluno[nrAluno].media = (aluno[nrAluno].nota1 + aluno[nrAluno].nota2) / 2;

                            Console.Write("Deseja sair? <s/n>");
                            sair = Console.ReadLine().ToLower();
                            nrAluno++;
                        } while (sair == "n");
                        sair = "n";
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("========================================================");
                            Console.WriteLine("|                         ALUNOS                       |");
                            Console.WriteLine("========================================================");
                            Console.WriteLine("|      NOME     | NOTA 1 | NOTA 2 | MÉDIA |  SITUAÇÃO  |");
                            Console.WriteLine("|------------------------------------------------------|");

                            for (int i = 0; i < aluno.Length; i++)
                            {
                                if (aluno[i].nome != null)
                                {
                                    if (aluno[i].media >= 7)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Cyan;
                                    }
                                    else
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                    }

                                    Console.Write("|"+ aluno[i].nome);
                                    for (int n = 0;n < 14-aluno[i].nome.Length; n++)
                                    {
                                        Console.Write(" ");
                                    }
                                    Console.Write("|   " + aluno[i].nota1 + "    |");
                                    Console.Write("    " + aluno[i].nota2 + "   |");
                                    Console.Write("  {0:n1}  |",aluno[i].media);
                                    if (aluno[i].media >= 7)
                                    {
                                        Console.Write("   Aprovado  |");
                                    }
                                    else
                                    {
                                        Console.Write("  Reprovado  |");
                                    }
                                    Console.WriteLine("\n|------------------------------------------------------|");
                                }
                            }
                            Console.Write("\n\n");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Deseja sair? <s/n>");
                            sair = Console.ReadLine().ToLower();

                        } while (sair == "n");
                        sair = "n";
                        break;
                    case 0:
                        sair = "n";
                        break;
                }

            } while (sair == "n");


            for (int i = 0; i < 10; i++)
            {
                aluno[i].nome = "aluno" + i;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(aluno[i].nome);
            }
            Console.ReadKey();

        }
    }
}
