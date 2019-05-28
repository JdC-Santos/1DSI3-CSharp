using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            double calcularPesoIdeal(double h, string s)
            {
                double p;
                if (s.ToLower() == "m")
                {
                    p = (72.7 * h) - 58; 
                }
                else
                {
                    p = (62.1 * h) - 44.7;
                }
                return p;
            }

            Console.WriteLine("Digite a sua altura e o seu sexo: ");
            Console.Write("O seu peso ideal é: " + calcularPesoIdeal(double.Parse(Console.ReadLine()), Console.ReadLine()));
            Console.ReadKey();
        }
    }
}
