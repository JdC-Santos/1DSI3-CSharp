using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioteste
{
    class Program
    {
        static void Main(string[] args)
        {
            //var
            string nm;
            int ano , nasc;
            ano = DateTime.Now.Year;
            //header
            Console.Title = "exercicio 11";
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WindowHeight = 57;
            Console.WindowWidth = 169;
            //main
            Console.Write("Digite o seu nome");
            nm =Console.ReadLine();
            Console.Write("Digite o seu ano de nascimento");
            nasc = Convert.ToInt32(Console.ReadLine());

            if ((ano - nasc) < 18)
            {
                Console.WriteLine("Voce é menor de idade");
            }
            else
            {
                Console.WriteLine("Voce é maior de idade");
            }

            Console.ReadKey();
        }
    }
}
