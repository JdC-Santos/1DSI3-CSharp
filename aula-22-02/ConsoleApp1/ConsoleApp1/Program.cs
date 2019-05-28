using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "mostrar o maior";
            Console.ForegroundColor = ConsoleColor.Yellow;
            int val1, val2,burro;

            burro = 0;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|               Exercicio 12                    |");
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Digite um numero: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite um numero diferente: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            while(val1 == val2 || val2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("O numero deve ser diferente!");

                burro++;
                /*
                if (burro > 2)
                {
                    Console.WriteLine("vc é burro?!");
                }
                */

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Digite um novo numero: ");
                val2 = Convert.ToInt32(Console.ReadLine());
            }

            if (val1 > val2)
            {
                Console.Write("O numero {0} é maior que o numero {1}",val1,val2);
            }
            else
            {
                Console.Write("O numero {0} é maior que o numero {1}", val2, val1);
            }

            Console.ReadKey();
        }
    }
}
