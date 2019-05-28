using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, p, qtd = 0;

            Console.Write("Digite o primeiro numero: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            if (n1 > n2)
            {
                p = n1;
                n1 = n2;
                n2 = p;
            }

            for (int n = n2; n >= n1; n--)
            {
                if (n % 2 == 1)
                {
                    qtd ++;
                }
            }
            Console.Write("A Quandidade de numeros impares é: "+qtd);
            Console.ReadKey();
        }
    }
}
