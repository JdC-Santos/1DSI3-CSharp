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
            int n;

            Console.Write("Digite um numero para ver a tabuada dele: ");
            n = Convert.ToInt32(Console.ReadLine());

            for(int l = 1; l <= 10; l++)
            {
                Console.WriteLine(n +" * "+l+" = "+ (n*l));
            }

            Console.ReadKey();
        }
    }
}
