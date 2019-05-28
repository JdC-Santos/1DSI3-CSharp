using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio 02";

            int num;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("===========================================");
            Console.WriteLine("|     Exercicio: O dobro da metade        |");
            Console.WriteLine("===========================================");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite um numero inteiro: ");

            Console.ForegroundColor = ConsoleColor.Black;
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("O dobro do numero ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(num);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" é: ");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(num * 2);
            
            Console.ReadKey();
        }
    }
}
