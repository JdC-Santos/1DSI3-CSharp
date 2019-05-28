using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio 01";

            string nome, cidade;
            int idade;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("===========================================");
            Console.WriteLine("|         Exercicio 01 para nota          |");
            Console.WriteLine("===========================================");

            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("Digite o seu nome: ");
            Console.ForegroundColor = ConsoleColor.Black;
            nome = Console.ReadLine();
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite sua idade: ");
            Console.ForegroundColor = ConsoleColor.Black;
            idade = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Digite o nome da cidade onde voce mora: ");
            Console.ForegroundColor = ConsoleColor.Black;
            cidade = Console.ReadLine();
            Console.WriteLine("");

            Console.Write(nome+" voce tem "+ idade +" anos e mora em "+cidade);

            Console.ReadKey();
        }
    }
}
