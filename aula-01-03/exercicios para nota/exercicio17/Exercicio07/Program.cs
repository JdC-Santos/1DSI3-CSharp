using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "exercicio 07";

            string nm1, nm2;

            Console.WriteLine("Digite o primeiro nome: ");
            nm1 = Console.ReadLine();

            Console.Write("Digite o nome da segunda pessoa: ");
            nm2 = Console.ReadLine();

            Console.WriteLine(nm1.ToUpper()+ " e "+nm2.ToUpper());
            Console.WriteLine(nm1.Length + " e " + nm2.Length);
            Console.WriteLine(nm1.Substring(0,3) +" e "+nm2.Substring(0,3));

            Console.ReadKey();
        }
    }
}
