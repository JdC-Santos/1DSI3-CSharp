using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosParaNota02
{
    class Program
    {
        static void Main(string[] args)
        {

            int a, b=0,l;

            Console.Title = "Exercicio 20";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("===========================================================================");
            Console.WriteLine("|                                                                         |");
            Console.WriteLine("|Elabore um programa que receba 50 números e mostre na tela o menor deles.|");
            Console.WriteLine("|                                                                         |");
            Console.WriteLine("===========================================================================");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite o 1º número: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            a = Convert.ToInt32(Console.ReadLine());

            for (l=1;l < 5; l++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite o " + (l + 1) + "º número: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                b = Convert.ToInt32(Console.ReadLine());

                if (b > a)
                {
                    b = a;
                }
            }
            Loading();
            Console.Write("O menor número é: " + b);
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
