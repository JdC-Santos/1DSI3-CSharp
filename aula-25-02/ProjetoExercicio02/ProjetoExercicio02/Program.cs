using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,a,b;
            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());
            x = a - b;
            Console.WriteLine("O resultado da subtração é: "+x);
            Console.ReadKey();
        }
    }
}
