using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ano;
            string nome;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o ano que voce nasceu: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Seu nome é: " + nome + " e voce tem: " + (2019 - ano) + " anos de idade");
            Console.ReadKey();
        }
    }
}
