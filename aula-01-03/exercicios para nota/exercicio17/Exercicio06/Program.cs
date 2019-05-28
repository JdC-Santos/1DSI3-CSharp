using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio 06";
            double real, dolar,res;

            Console.Write("Digite o valor em reais: ");
            real = double.Parse(Console.ReadLine());

            Console.Write("Digite a cotação do dolar: ");
            dolar = double.Parse(Console.ReadLine());

            res = real / dolar;

            Console.Write("voce tem {0:f2} em dolars",res);

            Console.ReadKey();
        }
    }
}
