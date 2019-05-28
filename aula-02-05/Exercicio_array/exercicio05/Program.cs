using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio05
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pessoa = new double[5];
            double tot = 0;
            double media = 0;
            double desvio = 0;

            for (int i = 0; i < pessoa.Length; i++)
            {
                Console.Write("Digite a altura da {0}º pessoa: ", i + 1);
                pessoa[i] = double.Parse(Console.ReadLine());
                tot += pessoa[i];
            }

            media = tot / pessoa.Length;

            for (int i = 0; i < pessoa.Length; i++)
            {
                desvio += (pessoa[i] - media) * (pessoa[i] - media);
            }
            Console.WriteLine("A média de altura é: {0}", media);
            Console.Write("O desvio de padrao é: {0,2} ", Math.Sqrt((desvio/ pessoa.Length)));
            Console.ReadKey();
        }
    }
}
