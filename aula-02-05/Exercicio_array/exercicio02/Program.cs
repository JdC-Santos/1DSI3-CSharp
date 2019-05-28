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
            string[] nome = new string[5];

            for (int i = 0;i < nome.Length; i++)
            {
                Console.Write("Digite o {0}º nome: ", i + 1);
                nome[i] = Console.ReadLine();
            }

            for (int i = 0; i < nome.Length; i++)
            {
                if(i%2 == 0)
                {
                    Console.WriteLine(nome[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
