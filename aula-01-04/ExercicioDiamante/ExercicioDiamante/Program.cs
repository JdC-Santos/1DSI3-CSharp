using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioDiamante
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string espaco = "", estrela = "";

            Console.Title = "Exercicio diamante";

            Console.Write("Digite um número impar: ");
            numero = int.Parse(Console.ReadLine());

            if (numero%2 == 0)
            {
                Console.Write("Este número não é impar!");
            }
            else
            {
                for (int l = 1; l <= numero; l++)
                {
                    for (int e = numero - l; e > 0; e--)
                    {
                        espaco += " ";
                    }
                    if (l == 1)
                    {
                        estrela += "*";
                    }
                    else
                    {
                        estrela += "**";
                    }
                    
                    Console.WriteLine(espaco + estrela);
                    espaco = "";
                    
                }
                estrela = "";
                for(int i = 1; i <= numero; i++)
                {
                    for (int e2 = 1; e2 <= i; e2++)
                    {
                        espaco += " ";
                    }

                    for (int b = 1; b <= numero - i; b++)
                    {
                        if (b > 1)
                        {
                            estrela += "**";
                        }
                        else
                        {
                            estrela += "*";
                        }
                        
                    }
                    Console.WriteLine(espaco + estrela);
                    espaco = "";
                    estrela = "";
                }
            }
            Console.ReadKey();
        }
    }
}