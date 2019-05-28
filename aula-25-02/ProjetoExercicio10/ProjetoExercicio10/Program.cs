using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.Write("Digite um numero: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("O quadrado de "+x+" é: "+x*x);
            Console.ReadKey();
        }
    }
}
