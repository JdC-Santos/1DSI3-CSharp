using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Promoção do mercadinho";
            Console.ForegroundColor = ConsoleColor.Yellow;
            int  qtd;
            double vl;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|               Exercicio 14                    |");
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|              ATENÇÃO CIDADÃO!!!               |");
            Console.WriteLine("|               NOVA PROMOÇÃO!!!                |");
            Console.WriteLine("|  COMPRE UMA DUZIA DE MAÇÃS E PAGUE MENOS!!!   |");
            Console.WriteLine("-------------------------------------------------");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Digite a quantidade de maçãs que voce comprou: ");
            Console.ForegroundColor = ConsoleColor.Green;
            qtd = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;

            if (qtd >= 12)
            {
                Console.Write("O valor da compra é R$");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("{0:f2}",qtd*.25);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" Centavos");
            }
            else
            {
                Console.Write("O valor da compra é R$");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(qtd * .30);
            }

            Console.ReadKey();

        }
    }
}
