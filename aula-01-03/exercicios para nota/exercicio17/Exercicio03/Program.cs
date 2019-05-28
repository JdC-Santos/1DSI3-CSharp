using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio 03";
            int num;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("===========================================");
            Console.WriteLine("|   Exercicio 03: O quadrado do redondo   |");
            Console.WriteLine("===========================================");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite um numero inteiro: ");

            Console.ForegroundColor = ConsoleColor.Green;
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("O Quadrado do numero ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(num);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" é: ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(Math.Pow(num,3));

            Console.ReadKey();
        }
    }
}
