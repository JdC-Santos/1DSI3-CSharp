using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2 = 0;

            for (int l = 1;l <= 15;l++)
            {
                Console.Write("Digite o " + l + "º numero: ");
                n1 = Convert.ToInt32(Console.ReadLine());
                if (n2 < n1 || l == 1)
                {
                    n2 = n1;
                }
            }
            Console.Write("o maior numero é: " + n2);
            Console.ReadKey();
        }
    }
}
