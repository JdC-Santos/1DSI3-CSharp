using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, a, b;

            Console.Write("Digite o primeiro numero: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            b = Convert.ToInt32(Console.ReadLine());

            x = a / b;
            Console.WriteLine("O Resultado da divisão é: " + x);
            Console.ReadKey();
        }
    }
}
