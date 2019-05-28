using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Exercicio 7";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("==============================================================================");
            Console.WriteLine("+ Escreva um programa que exiba todos os números de 1 a 100                  +");
            Console.WriteLine("+ e a cada número que for múltiplo de 10, exiba a mensagem “MÚLTIPLO DE 10”. +");
            Console.WriteLine("==============================================================================");

            Console.WriteLine("");
            Console.Write("Aperte ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("ENTER ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("para executar");
            Console.ReadKey();

            Loading();

            for (int l =1; l <= 100; l++)
            {

                if (l%10 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(l);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" é multiplo de 10!");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(l);
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
