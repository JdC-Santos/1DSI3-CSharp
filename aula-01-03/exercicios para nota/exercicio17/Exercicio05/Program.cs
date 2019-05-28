using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio 05";

            int idade;

            Console.Write("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            Console.Write("Voce é "+( idade > 18 ? "maior de idade" : "menor de idade"));
            Console.ReadKey();


        }
    }
}
