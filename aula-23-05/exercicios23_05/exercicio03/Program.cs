using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class Program
    {
        public struct Carro
        {
            public int Ano;
            public string Modelo;
            public string Cor;
        }
        static void Main(string[] args)
        {
            Carro[] carro = new Carro[500];
            bool sair = false;
            int opc;

            do
            {
                MostraMenu();
                try
                {
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 0:
                            sair = true;
                            break;

                        case 1:
                            break;

                        case 2:
                            break;

                        case 3:
                            break;

                        case 4:
                            break;

                        case 5:
                            break;

                        case 6:
                            break;

                        case 7:
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Digite um número entre 0 e 7!");
                            Console.Write("Aperte uma tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um número inteiro!");
                    Console.Write("Aperte uma tecla para continuar...");
                    Console.ReadKey();
                }

            } while (!sair);

        }

        static void MostraMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("===================================");
            Console.WriteLine("|              MENU               |");
            Console.WriteLine("===================================");
            Console.WriteLine("| 1 - Cadastrar Carro             |");
            Console.WriteLine("| 2 - Consultar carro por ano     |");
            Console.WriteLine("| 3 - Consultar carro por modelo  |");
            Console.WriteLine("| 4 - Consultar carro por cor     |");
            Console.WriteLine("| 5 - Exibir todos os carros      |");
            Console.WriteLine("| 6 - Atualizar um carro          |");
            Console.WriteLine("| 7 - Excluir um Carro            |");
            Console.WriteLine("| 0 - Sair                        |");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.Write("Digite o número desejado: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
