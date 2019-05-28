using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {

            int x, y, z, w;

            Console.Write("Digite o primeiro numero: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro numero: ");
            z = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o quarto numero: ");
            w = Convert.ToInt32(Console.ReadLine());

            if ((x >= y) && (z <= x) ||(x==w) &&(y==z) ||(!( x != w)))
            {
                Console.WriteLine("verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }

            Console.ReadKey();
        }
    }
}
