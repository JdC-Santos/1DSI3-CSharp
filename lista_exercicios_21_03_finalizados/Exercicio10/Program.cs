using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, e, total;
            string c, resposta = "n";

            Console.WindowWidth = 120;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Exercicio 10";

            Console.WriteLine("========================================================");
            Console.WriteLine("+ Enunciado mto grande, deu preguiça de colocar aqui   +");
            Console.WriteLine("========================================================");

            Console.ReadKey();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite o código do funcionario: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                c = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite o número de horas trabalhadas: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 50)
                {
                    total = 50 * 10;
                    e = (n - 50) * 20;
                }
                else
                {
                    e = 0;
                    total = n * 10;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("O salário total é: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("R$ "+total);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("O valor excedente é: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("R$ "+ e);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Deseja encerrar o programa? ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                resposta = Console.ReadLine();
            } while (resposta.ToLower() != "s");
        }
    }
}
