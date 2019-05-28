using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "mostrar o maior";
            Console.ForegroundColor = ConsoleColor.Yellow;
            int anoNasc, anoAtual;
            string nome;
            anoAtual = DateTime.Now.Year;

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|               Exercicio 13                    |");
            Console.WriteLine("-------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Digite o seu nome: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            nome = Console.ReadLine();

            Console.Write(nome);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(" Digite o ano que voce nasceu: ");
            anoNasc = Convert.ToInt32(Console.ReadLine());

            if ((anoAtual - anoNasc) < 16)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(nome);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" voce tem ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(anoAtual - anoNasc);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(", portanto não pode votar este ano");
            } else {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(nome);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(" voce tem ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(anoAtual - anoNasc);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(", portanto pode votar este ano");
            }
            Console.ReadKey();
        }
    }
}
