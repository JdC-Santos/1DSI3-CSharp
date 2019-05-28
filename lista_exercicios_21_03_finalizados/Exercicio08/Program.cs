using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, total = 1;

            Console.WindowWidth = 120;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Exercicio 8";

            Console.WriteLine("==========================================================================================");
            Console.WriteLine("+ Escreva um programa que calcule o fatorial de um número informado pelo usuário.        +");
            Console.WriteLine("+ Dica: O fatorial de um número N é dado pela fórmula: N! = 1 * 2 * 3 * 4 * 5 * ... * N  +");
            Console.WriteLine("==========================================================================================");

            Console.WriteLine("");
            Console.Write("Digite um número: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            n = Convert.ToInt32(Console.ReadLine());

            Loading();

            for (int l = 2;l <= n;l++)
            {
                total = total * l;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("O fatorial de ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(n);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" é: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(total);
            Console.ReadKey();
        }
        public static int Loading()
        {
            int total = 0, vazio, fade = 0;
            string barra = "", pontos = "", p = "";
            //string[] fade = new String[5];
            //fade[0] = "Green";

            Console.Clear();

            while (total < 40)
            {
                pontos = "";
                barra = "";
                for (fade = 0; fade <= total - 3; fade++)
                {
                    barra += ">";
                }


                Console.Write("[");

                Console.Write(barra);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(">");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.Write(">");

                Console.ForegroundColor = ConsoleColor.White;

                for (vazio = 1; vazio < (40 - total); vazio++)
                {
                    pontos += "·";
                }
                Console.WriteLine(pontos + "]");

                if (total <= 10)
                {
                    Console.Write("Pegando dados");
                }
                else if (total <= 20)
                {
                    Console.Write("Pesquisando no google");
                }
                else if (total <= 30)
                {
                    Console.Write("Copiando do StackOverflow");
                }
                else
                {
                    Console.Write("Alterando codigo");
                }

                p += ".";

                if (total % 3 == 1 && total > 1)
                {
                    p = ".";
                }

                Console.Write(p);

                System.Threading.Thread.Sleep(150);
                Console.Clear();
                total++;
            }

            return 1;
        }
    }
}
