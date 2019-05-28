using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            Console.Write("Digite o raio do circulo: ");
            r = Convert.ToDouble(Console.ReadLine());
            Console.Write("A area do circulo é: " + 3.14 * (r * r));
            Console.ReadKey();
        }
    }
}
