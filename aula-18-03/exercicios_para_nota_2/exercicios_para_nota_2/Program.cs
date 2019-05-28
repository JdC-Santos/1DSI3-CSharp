using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios_para_nota_2
{
    class Program
    {
        static void Main(string[] args)
        {

            for(int l = 11; l <= 250; l++)
            {
                if (l%2 == 0)
                {
                    Console.WriteLine(l);
                }
            }

            Console.ReadKey();
        }
    }
}
