using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("Digite o tamanho da base do triangulo: ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite a altura do triangulo: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("A area do triangulo é: " + b * a / 2);
            Console.ReadKey();
        }
    }
}
