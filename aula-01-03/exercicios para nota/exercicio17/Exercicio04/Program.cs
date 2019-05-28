using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio 04";
            int a, b, c;
            double res;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("===============================================");
            Console.WriteLine("| Exercicio 04: nao lembro que formula é essa |");
            Console.WriteLine("===============================================");
            Console.BackgroundColor = ConsoleColor.White;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o primeiro numero: ");
            Console.ForegroundColor = ConsoleColor.Green;
            a = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite o segundo numero: ");
            Console.ForegroundColor = ConsoleColor.Green;
            b = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o terceiro numero: ");
            Console.ForegroundColor = ConsoleColor.Green;
            c = Convert.ToInt32(Console.ReadLine());

            res = (a * a) * 5 - c / (b - a % 4);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("O resultado é: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(res);
            
            Console.ReadKey();
        }
    }
}
