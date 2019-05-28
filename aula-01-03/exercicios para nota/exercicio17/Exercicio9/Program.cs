using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "exercicio 9";

            int a, b,c;

            Console.Write("Digite o primeiro valor: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());

            c = a;
            a = b;
            b = c;

            Console.WriteLine("O valor de A agora é: " + a + " e o valor de b é: " + b);
            Console.ReadKey();
        }
    }
}
