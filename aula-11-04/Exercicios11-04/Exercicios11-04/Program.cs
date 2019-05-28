using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios11_04
{
    class Program
    {
        static void Main(string[] args)
        {  
            int calcularFatorial(int n)
            {
                int r = 1;

                for(int i = 1; i < n; i++)
                {
                    r += i * r;
                }

                return r;
            }

            Console.Write("Digite um numero inteiro: ");
            Console.Write("O fatorial dele é: " + calcularFatorial(int.Parse(Console.ReadLine())));
            Console.ReadKey();
        }
    }
}
