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
            int digito;
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Resto da Divisão");
                Console.WriteLine("6 - Dobro");
                Console.WriteLine("7 - Quadrado");
                Console.WriteLine("8 - Cubo");
                Console.WriteLine("9 - Raiz Quadrada");
                Console.WriteLine("0 - Sair");

                digito = int.Parse(Console.ReadLine());
                switch (digito)
                {
                    case 1:
                        Soma();
                        break;
                    case 2:
                        Subtracao();
                        break;
                }

            }while(digito != 0);
        }

        static void Soma()
        {
            double total = 0;
            string resp = "";
            
            do
            {
                Console.Clear();
                Console.WriteLine("Digite um número ou digitie <s> para sair: ");
                Console.WriteLine("o total é: " + total);
                resp = Console.ReadLine();
                if (resp.ToLower() == "s")
                {
                    break;
                }else{
                    total += double.Parse(resp);
                }
                
            } while (true);
        }

        static void Subtracao()
        {
            double n1;
            double n2;
            Console.Write("Digite o primeiro número: ");
            n1  = double.Parse(Console.ReadLine());
            do
            {
                Console.Clear();
                Console.Write("Digite o número que deseja subtrair: ");
                n2 = double.Parse(Console.ReadLine());
                Console.WriteLine("O resultado é: " + (n1 -= n2));
                Console.WriteLine("Deseja sair? <s/n>");
 
            } while (Console.ReadLine() != "s");
        }

        static double Divisao()
        {
            return 1;
        }

        static double Multiplicacao()
        {
            return 1;
        }

        static double RestoDaDivisao()
        {
            return 1;
        }

        static double Dobro()
        {
            return 1;
        }

        static double Quadrado()
        {
            return 1;
        }

        static double Cubo()
        {
            return 1;
        }

        static double RaizQuadrada()
        {
            return 1;
        }

        static bool Sair(int digito)
        {
            if (digito == 0) {
                return true;
            }
            else{
                return false;
            }
        }
    }
}
