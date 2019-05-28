using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[20];

            for (int i = 0; i < numero.Length; i++)
            {
                Console.Write("Digite o {0}º número: ", i + 1);
                numero[i] = int.Parse(Console.ReadLine());
            }

            for (int j = 0; j < (numero.Length - 1); j++) {
                for (int i = 0; i < (numero.Length - 1); i++)
                {
                    if (numero[i] > numero[i + 1])
                    {
                        int p = numero[i];
                        numero[i] = numero[i + 1];
                        numero[i + 1] = p;
                    }
                }
           }

            for(int i = 0;i < numero.Length; i++)
            {
                Console.WriteLine(numero[i]);
            }

            Console.ReadKey();
        }
    }
}
