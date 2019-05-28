using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeExercicios02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio 1";

            Console.WindowWidth = 120;

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("============================================================================================================");
            Console.WriteLine("| Escreva um programa que exiba na tela em ordem crescente apenas os números pares existentes de 11 a 250. |");
            Console.WriteLine("============================================================================================================");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("");
            Console.Write("Tecle ENTER para executar!");
            Console.ReadKey();

            Loading();
            Console.ForegroundColor = ConsoleColor.White;

            for (int l = 11; l <= 250; l++)
            {


                if (l % 2 == 0)
                {
                    if (l < 13)
                    {
                        Console.Write(l);
                    }
                    else
                    {
                        Console.Write("," + l);
                    }

                }
            }

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
