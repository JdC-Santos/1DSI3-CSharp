using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio09
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "n";
            int positivo = 0, negativo = 0,impar = 0, par =0,numero; 

            Console.WindowWidth = 120;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Exercicio 9";

            Console.WriteLine("================================================================================================================");
            Console.WriteLine("+ Escreva um programa que leia vários números inteiros e ao final informe quantos números pares                +");
            Console.WriteLine("+ quantos números ímpares, quantos números positivos e quantos números negativos foram digitados pelo usuário  +");
            Console.Write("+ O programa só deve parar de rodar quando o usuário responder 'S' na seguinte pergunta:                       +\n+");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" Deseja encerrar o programa ?                                                                                 ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("+\n================================================================================================================");

            Console.ReadKey();

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Positivos: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(positivo);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" Negativos: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(negativo);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" ímpares: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(impar);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" pares: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(par);

                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.Write("Digite um numero: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero %2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }

                if(numero >= 0)
                {
                    positivo++;
                }
                else
                {
                    negativo++;
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Positivos: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(positivo);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" Negativos: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(negativo);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" ímpares: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write(impar);

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" pares: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(par);

                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Deseja encerrar o programa? ");
                Console.ForegroundColor = ConsoleColor.Green;
                resposta = Console.ReadLine();
                
            } while ((resposta.ToLower() != "s"));

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Positivos: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(positivo);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" Negativos: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(negativo);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" ímpares: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(impar);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(" pares: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(par);
            Console.ReadKey();
        }
    }
}
