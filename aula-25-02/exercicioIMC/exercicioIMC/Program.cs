using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio de IMC";
            double peso, altura, res;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("============================================");
            Console.WriteLine("|          Exercicio de IMC                |");
            Console.WriteLine("============================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Digite o seu peso: ");
            Console.ForegroundColor = ConsoleColor.Green;
            peso = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Digite a sua altura: ");
            Console.ForegroundColor = ConsoleColor.Green;
            altura = double.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;

            res = peso /(altura * altura);

            if (res < 16)
            {
                Console.WriteLine(res+ " COMO VOCE AINDA ESTÁ VIVO?, VÁ COMER PIZZA!!");
            }else if (res > 16 && res < 17)
            {
                Console.WriteLine("SEU PESO ESTÁ MUITO BAIXO!");
            }else if (res >= 17 && res < 18.5)
            {
                Console.WriteLine("VOCE ESTÁ ABAIXO DO PESO!");
            }else if (res >= 18.5 && res < 25)
            {
                Console.WriteLine("Parabens, voce está com o peso normal!");
            }else if (res >= 25 && res < 30 )
            {
                Console.WriteLine("VOCE ESTÁ ACIMA DO PESO, COMA MENOS PIZZA!");
            }
            else
            {
                Console.WriteLine("VOCE ESTÁ MUITO ACIMA DO PESO,SAIA DO PC E VÁ MALHAR!");
            }

            Console.ReadKey();

        }
    }
}
