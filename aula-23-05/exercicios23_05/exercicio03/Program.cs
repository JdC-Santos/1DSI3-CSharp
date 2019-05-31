using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    class Program
    {
        public struct Carro
        {
            public int Ano;
            public string Modelo;
            public string Cor;
        }

        static void Main(string[] args)
        {
            Carro[] carro = new Carro[500];
            bool sair = false;
            int opc;

            do
            {
                MostraMenu();
                try
                {
                    opc = int.Parse(Console.ReadLine());

                    switch (opc)
                    {
                        case 0:
                            sair = true;
                            break;

                        case 1:
                            carro = CadastrarCarro(carro);
                            break;

                        case 2:
                            Console.Write("Digite o ano que deseja procurar: ");
                            ConsultarCarroAno(carro, false, int.Parse(Console.ReadLine()),"","");
                            break;

                        case 3:
                            Console.Write("Digite o modelo que deseja procurar: ");
                            ConsultarCarroAno(carro, false, 1, Console.ReadLine(),"");
                            break;

                        case 4:
                            Console.Write("Digite a cor que deseja procurar: ");
                            ConsultarCarroAno(carro, false, 1,"", Console.ReadLine());
                            break;

                        case 5:
                            ConsultarCarroAno(carro, true, 1, "","");
                            break;

                        case 6:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("Digite o código do carro que deseja atualizar: ");
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            carro = AtualizarCarro(carro,( int.Parse(Console.ReadLine()) - 1 ));
                            break;

                        case 7:
                            break;

                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Digite um número entre 0 e 7!");
                            Console.Write("Aperte uma tecla para continuar...");
                            Console.ReadKey();
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Digite um número inteiro!");
                    Console.WriteLine(e);
                    Console.Write("Aperte uma tecla para continuar...");
                    Console.ReadKey();
                }

            } while (!sair);
        }
        static void MostraMenu()
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("===================================");
            Console.WriteLine("|              MENU               |");
            Console.WriteLine("===================================");
            Console.WriteLine("| 1 - Cadastrar Carro             |");
            Console.WriteLine("| 2 - Consultar carro por ano     |");
            Console.WriteLine("| 3 - Consultar carro por modelo  |");
            Console.WriteLine("| 4 - Consultar carro por cor     |");
            Console.WriteLine("| 5 - Exibir todos os carros      |");
            Console.WriteLine("| 6 - Atualizar um carro          |");
            Console.WriteLine("| 7 - Excluir um Carro            |");
            Console.WriteLine("| 0 - Sair                        |");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.Write("Digite o número desejado: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
        }

        static Carro[] CadastrarCarro(Carro[] carro)
        {
            bool sair = false;
            int nrCarro = 0;
            do
            {
                foreach(Carro car in carro)
                {
                    if (car.Modelo != null)
                    {
                        nrCarro++;
                    }
                }

                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite o ano do carro: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                carro[nrCarro].Ano = int.Parse(Console.ReadLine());
    
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite o modelo do carro: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                carro[nrCarro].Modelo = Console.ReadLine();
    
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite o cor do carro: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                carro[nrCarro].Cor = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Yellow;
                
                Console.Write("Deseja registrar mais um carro?  < S | N >: ");
                Console.ForegroundColor = ConsoleColor.Cyan;
                if(Console.ReadLine().ToLower() == "n"){
                    sair = true;
                }
            }while(!sair);
            
            return carro;
        }

        static void ConsultarCarroAno(Carro[] carros, bool mostrarTodos , int ano, string modelo = "" , string cor = "")
        {
            int linha = 1;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("==========================================================");
            Console.WriteLine("|              Lista de Carros Registrados               |");
            Console.WriteLine("==========================================================");
            Console.WriteLine("| Cod |      Modelo      |      Cor      |      ANO      |");
            Console.WriteLine("==========================================================");
            Console.ForegroundColor = ConsoleColor.Cyan;

            foreach (Carro carro in carros)
            {
               if((carro.Ano == ano || carro.Modelo == modelo || carro.Cor == cor) || (mostrarTodos && carro.Modelo != null))
                {
                    Console.Write("| {0} ",linha++);

                    for (int i = 0; i < 3 - linha.ToString().Length; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("| "+ carro.Modelo);
                    for (int i =0; i < 17 - carro.Modelo.Length; i++ )
                    {
                        Console.Write(" ");
                    }

                    Console.Write("| " + carro.Cor);
                    for (int i = 0; i < 14 - carro.Cor.Length; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.Write("| " + carro.Ano);
                    for (int i = 0; i < 14 - carro.Ano.ToString().Length; i++)
                    {
                        Console.Write(" ");
                    }

                    Console.WriteLine("|");
                    Console.WriteLine("----------------------------------------------------------");
                }
            }

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Pressione uma tecla para voltar ao menu");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.ReadKey();
        }

        static Carro[] AtualizarCarro(Carro[] carro, int nrCarro)
        {
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Ano do carro {0}", carro[nrCarro].Ano);
            Console.Write("Atualize o ano do carro: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            carro[nrCarro].Ano = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Modelo do carro {0}", carro[nrCarro].Modelo);
            Console.Write("Atualize o modelo do carro: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            carro[nrCarro].Modelo = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Cor do carro {0}", carro[nrCarro].Cor);
            Console.Write("Atualize a cor do carro: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            carro[nrCarro].Cor = Console.ReadLine();

            return carro;
        }

        static Carro[] ExcluirCarro(Carro[] carro, int nrCarro)
        {
            foreach (Carro car in carro)
            {

            }


            return carro;
        }
    }
}
