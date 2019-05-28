using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
        
            Console.Title = "Exercicio 3";
            
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("================================================================");
            Console.WriteLine("+ Escreva um programa que exiba na tela a tabuada de um número +");
            Console.WriteLine("+ que deverá ser informado pelo usuário                        +");
            Console.WriteLine("+ (deverá ser usada qualquer estrutura de repetição).          +");
            Console.WriteLine("================================================================");
            
           
            Console.WriteLine("");
            Console.Write("Digite um número: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            n = Convert.ToInt32(Console.ReadLine());

            //Loading();
            Console.ForegroundColor = ConsoleColor.White;

            for(int l = 1 ; l <= 10; l++){
                Console.WriteLine(n +" * "+ l +" = "+ (l*n));
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
