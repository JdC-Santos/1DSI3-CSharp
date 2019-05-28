using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, pote, a = 0, complete;

            Console.Title = "Exercicio 2";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(" =============================================================");
            Console.WriteLine("( Escreva um programa que exiba na tela em ordem decrescente  )");
            Console.WriteLine("( apenas os números ímpares existentes entre dois números     )");
            Console.WriteLine("( digitados pelo usuário (inclusive eles).                    )");
            Console.WriteLine(" =============================================================");


            Console.WriteLine("");
            Console.Write("Digite o primeiro número: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite o segundo número: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            n2 = Convert.ToInt32(Console.ReadLine());


            if (n1 > n2)
            {
                pote = n1;
                n1 = n2;
                n2 = pote;
            }

            Loading();

            Console.ForegroundColor = ConsoleColor.White;

            for (int l = n2; l >= n1; l--)
            {


                if (l % 2 == 1)
                {
                    if (a == 0)
                    {
                        Console.Write(l);
                        a = 1;
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
