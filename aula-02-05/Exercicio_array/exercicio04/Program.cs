using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtNota;
            double res = 0;

            Console.Write("Digite quantas notas o aluno tem: ");
            qtNota = int.Parse(Console.ReadLine());
            double[] nota = new double[qtNota];
            

            for(int i = 0; i < nota.Length; i++)
            {
                Console.Write("Digite a {0}º nota do aluno: ", i + 1);
                nota[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < nota.Length; i++)
            {
                res += nota[i];
                Console.WriteLine("A média do aluno é: {0,2}", res/nota.Length);
            }
            Console.ReadKey();

        }
    }
}
