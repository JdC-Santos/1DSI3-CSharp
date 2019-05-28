using System;

namespace exercicios23_05
{
    class Program
    {
        public struct Data
        {
            public int dia;
            public int mes;
            public int ano;
        }
        static void Main(string[] args)
        {
            Data data;
            data.dia = 0;
            data.mes = 0;
            data.ano = 0;
            bool ok = false;
            //ano
            do
            {
                try
                {
                    Console.Write("Digite um ano: ");
                    data.ano = int.Parse(Console.ReadLine());

                    if (data.ano.ToString().Length < 4)
                    {
                        Console.WriteLine("Digite um ano válido");
                    }
                    else
                    {
                        ok = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite um numero inteiro!");
                }
            } while (!ok);
            ok = false;
            //mes
            do
            {
                try
                {
                    Console.Write("Digite um mês: ");
                    data.mes = int.Parse(Console.ReadLine());

                    if (data.mes <= 0 || data.mes > 12)
                    {
                        Console.WriteLine("Digite um mês válido");
                    }
                    else
                    {
                        ok = true;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite um numero inteiro!");
                }
            } while (!ok);
            ok = false;
            //dia
            do
            {
                try
                {
                    
                    Console.Write("Digite um dia: ");
                    data.dia = int.Parse(Console.ReadLine());

                    //validacao do ano
                    if(data.ano/4 == 0)
                    {
                        if ((data.mes == 1 && data.dia <= 31) || 
                            (data.mes == 2 && data.dia <= 29) ||
                            (data.mes == 3 && data.dia <= 31) ||
                            (data.mes == 4 && data.dia <= 30) ||
                            (data.mes == 5 && data.dia <= 31) ||
                            (data.mes == 6 && data.dia <= 30) ||
                            (data.mes == 7 && data.dia <= 31) ||
                            (data.mes == 8 && data.dia <= 31) ||
                            (data.mes == 9 && data.dia <= 30) ||
                            (data.mes == 10 && data.dia <= 31)||
                            (data.mes == 11 && data.dia <= 30)||
                            (data.mes == 12 && data.dia <= 31))
                        {
                            ok = true;
                        }
                        else
                        {
                            Console.WriteLine("Digite um dia válido para este mês!");
                        }
                    }
                    else
                    {
                        if ((data.mes == 1 && data.dia <= 31) ||
                            (data.mes == 2 && data.dia <= 28) ||
                            (data.mes == 3 && data.dia <= 31) ||
                            (data.mes == 4 && data.dia <= 30) ||
                            (data.mes == 5 && data.dia <= 31) ||
                            (data.mes == 6 && data.dia <= 30) ||
                            (data.mes == 7 && data.dia <= 31) ||
                            (data.mes == 8 && data.dia <= 31) ||
                            (data.mes == 9 && data.dia <= 30) ||
                            (data.mes == 10 && data.dia <= 31) ||
                            (data.mes == 11 && data.dia <= 30) ||
                            (data.mes == 12 && data.dia <= 31))
                        {
                            ok = true;
                        }
                        else
                        {
                            Console.WriteLine("Digite um dia válido para este mês!");
                        }
                    }

                    if (data.dia <= 0 || data.dia > 31)
                    {
                        Console.WriteLine("Digite um numero válido");
                        ok = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite um numero inteiro!");
                }
            } while (!ok);
            ok = false;


            Console.WriteLine("{0}/{1}/{2}",data.dia, data.mes, data.ano);
            Console.ReadKey();
        }
    }
}
