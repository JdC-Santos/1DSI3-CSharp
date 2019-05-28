using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            double l,a;
            Console.Write("Digite a largura do retangulo: ");
            l = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura do retangulo: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("A area do retangulo é: " + l*a);
            Console.ReadKey();
        }
    }
}
