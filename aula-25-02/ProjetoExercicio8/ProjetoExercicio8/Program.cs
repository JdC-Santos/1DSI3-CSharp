using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.Write("Digite o primeiro valor: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("O resultado é: " + (2 * a + b) / c);
            Console.ReadKey();
        }
    }
}
