using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[50];

            for (int i = 0;i < numero.Length;i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                numero[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < numero.Length; i++)
            {
                if (numero[i]%2 == 1)
                {
                    Console.WriteLine(numero[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
