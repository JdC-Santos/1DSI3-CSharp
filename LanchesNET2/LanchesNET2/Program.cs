using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchesNet
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            double total = 0;
            string[] pedidos = new string[]{"Hamburger","X-Hamburger","X-Egg","Bauru",
            "Coca-cola","Guaraná","Tubaína","Soda Limonada","Fanta"};

            double[] vl = new double[] { 5.00, 7.00, 10.00, 3.00, 5.00, 4.00, 3.00, 4.00, 5.00 };

            int[] qtd = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            Console.Title = "Lanchonete Lanches .NET";

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine("================================================");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("           LANCHONETE LANCHES .NET            ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|");
                Console.WriteLine("|                     MENU                     |");
                Console.WriteLine("================================================");
                Console.WriteLine("|                 1 - Lanches                  |");
                Console.WriteLine("|                 2 - Bebidas                  |");
                Console.WriteLine("|                 3 - Conta                    |");
                Console.Write("|");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("                 0 - Sair                     ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("|");
                Console.WriteLine("================================================");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("\n\nDigite o número da opção que voce deseja: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 1: //pedir lanche

                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("================================================");
                            Console.Write("|");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("           LANCHONETE LANCHES .NET            ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("|");
                            Console.WriteLine("|                MENU > Lanches                |");
                            Console.WriteLine("================================================");
                            Console.WriteLine("|            1. Hamburger    R$ 5,00           |");
                            Console.WriteLine("|            2. X-Burger     R$ 7,00           |");
                            Console.WriteLine("|            3. X-Egg        R$ 10,00          |");
                            Console.WriteLine("|            4. Bauru        R$ 3,00           |");
                            Console.WriteLine("|            0. Voltar                         |");
                            Console.WriteLine("================================================");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\n\nDigite o número do lanche que voce deseja: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            op = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;

                            switch (op)
                            {
                                case 1:
                                    Console.Write("Quantos Hamburgers voce deseja? ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    qtd[0] += Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Pedido anotado!\nPressione uma tecla para continuar!");
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.Write("Quantos X-Burgers voce deseja? ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    qtd[1] += Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Pedido anotado!\nPressione uma tecla para continuar!");
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.Write("Quantos X-Eggs voce deseja? ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    qtd[2] += Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Pedido anotado!\nPressione uma tecla para continuar!");
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.Write("Quantos Baurus voce deseja? ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    qtd[3] += Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Pedido anotado!\nPressione uma tecla para continuar!");
                                    Console.ReadKey();
                                    break;

                                case 0:
                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Este número nao existe no menu!");
                                    Console.Write("Pressione uma tecla para coninuar!");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (op != 0);
                        op = 1;
                        break;

                    case 2:// pedir bebida

                        do
                        {
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("================================================");
                            Console.Write("|");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("           LANCHONETE LANCHES .NET            ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("|");
                            Console.WriteLine("|                MENU > Bebidas                |");
                            Console.WriteLine("================================================");
                            Console.WriteLine("|            1. Coca-cola      R$ 5,00         |");
                            Console.WriteLine("|            2. Guaraná        R$ 4,00         |");
                            Console.WriteLine("|            3. Tubaína        R$ 3,00         |");
                            Console.WriteLine("|            4. Soda Limonada  R$ 4,00         |");
                            Console.WriteLine("|            5. Fanta          R$ 5,00         |");
                            Console.WriteLine("|            0. Voltar                         |");
                            Console.WriteLine("================================================");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("\n\nDigite o número da bebida que voce deseja: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            op = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Green;

                            switch (op)
                            {
                                case 1:
                                    Console.Write("Quantas Coca-colas voce deseja? ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    qtd[4] += Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Pedido anotado!\nPressione uma tecla para continuar!");
                                    Console.ReadKey();
                                    break;

                                case 2:
                                    Console.Write("Quantos Guaranás voce deseja? ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    qtd[5] += Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Pedido anotado!\nPressione uma tecla para continuar!");
                                    Console.ReadKey();
                                    break;

                                case 3:
                                    Console.Write("Quantas Tubaína voce deseja? ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    qtd[6] += Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Pedido anotado!\nPressione uma tecla para continuar!");
                                    Console.ReadKey();
                                    break;

                                case 4:
                                    Console.Write("Quantas Soda Limonada voce deseja? ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    qtd[8] += Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Pedido anotado!\nPressione uma tecla para continuar!");
                                    Console.ReadKey();
                                    break;

                                case 5:
                                    Console.Write("Quantas Fanta voce deseja? ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    qtd[9] += Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Pedido anotado!\nPressione uma tecla para continuar!");
                                    Console.ReadKey();
                                    break;

                                case 0:
                                    break;

                                default:
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Este número nao existe no menu!");
                                    Console.Write("Pressione uma tecla para coninuar!");
                                    Console.ReadKey();
                                    break;
                            }

                        } while (op != 0);
                        op = 1;
                        break;

                    case 3://calcular a conta

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n\n");

                        for (int l = 0; l < qtd.Length; l++)
                        {

                            if (qtd[l] > 0)
                            {
                                Console.Write(qtd[l]);
                                Console.Write(" - " + pedidos[l]);
                                Console.WriteLine(" R$ " + (qtd[l] * vl[l]));
                                total += qtd[l] * vl[l];
                            }
                        }
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("O total é: {0:N}", total);
                        if (total > 0)
                        {
                            Console.Write("Deseja CPF na nota?");
                        }

                        Console.ReadKey();

                        op = 1;
                        break;

                    case 0: // sair do programa
                        break;

                    default:// tratamento de erro
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Este número nao existe no menu!");
                        Console.Write("Pressione uma tecla para coninuar!");
                        Console.ReadKey();
                        break;
                }
            } while (op != 0);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("**Obrigado pela preferencia, volte sempre!**");
            Console.ReadKey();
        }
    }
}
