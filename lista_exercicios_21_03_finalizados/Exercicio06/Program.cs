using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0, nota;

            Console.WindowWidth = 120;
            Console.Title = "Exercicio 5";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(" ==================================================================================================");
            Console.WriteLine("( Escreva um programa que calcule e exiba a média de 10 notas digitadas pelo usuário.              )");
            Console.WriteLine("( Considerar notas válidas, somente valores entre 0 (zero) e 10 (dez).                             )");
            Console.WriteLine("( Se o usuário digitar algum valor inválido, deverá ser exibida uma mensagem informando o ocorrido.)");
            Console.WriteLine(" ==================================================================================================");

            for (int l = 1; l <= 10; l++)
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Digite a " + l + "ª nota do aluno: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    nota = Convert.ToInt32(Console.ReadLine());

                } while ((nota > 10) || (nota < 0));

                total += nota;
            }
            nota = total / 10;


            Loading();
            Console.Write("A média do aluno é: " + nota);
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
