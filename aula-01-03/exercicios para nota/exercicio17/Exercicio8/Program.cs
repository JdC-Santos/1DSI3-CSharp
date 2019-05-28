using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio 08";
            double real, dolar, res1,res2, euro;

            Console.Write("Digite o valor em reais: ");
            real = double.Parse(Console.ReadLine());

            Console.Write("Digite a cotação do dolar: ");
            dolar = double.Parse(Console.ReadLine());

            Console.Write("Digite a cotação do euro: ");
            euro = double.Parse(Console.ReadLine());

            res1 = real / dolar;
            res2 = real / euro;

            Console.WriteLine("voce tem {0:f2} em dolars", res1);
            Console.Write("voce tem {0:f2} em euros", res2);

            Console.ReadKey();
        }
    }
}
