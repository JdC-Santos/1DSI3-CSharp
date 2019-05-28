using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoExercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade;
            int idade;

            Console.Write("Digite o seu nome: ");
            nome = Console.ReadLine();
            Console.Write("Digite o nome da sua cidade: ");
            cidade = Console.ReadLine();
            Console.Write("Digite a sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());
            Console.Write(nome + " voce mora em " + cidade + " e tem " + idade + " anos");
            Console.ReadKey();
        }
    }
}
