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
            double diferenca(double n1, double n2)
            {
                if (n1 > n2)
                {
                    double p = n1;
                    n1 = n2;
                    n2 = p;
                }

                return n2 - n1;
            }

            Console.Write("Digite dois números: ");
            Console.Write("A diferença entre eles é: " + diferenca(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
