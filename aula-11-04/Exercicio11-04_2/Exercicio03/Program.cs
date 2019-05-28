using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            string triangulo(double a,double b,double c)
            {
                string tipo;

                if ((a < (b + c)) && (b < (a + c)) && (c < a + b))
                {
                    if (trianguloEquilatero(a,b,c))
                    {
                        tipo = "equilatero";
                    }
                    else if (trianguloIsosceles(a,b,c))
                    {
                        tipo = "isosceles";
                    }
                    else
                    {
                        tipo = "escaleno";
                    }
                }
                else
                {
                    tipo = "não é um triangulo";
                }

                return tipo;
            }

            Boolean trianguloEquilatero(double a, double b, double c)
            {
                Boolean ret = false;
                if ((a == b) && (b == c))
                {
                    ret =  true;
                }
                return ret;
            }

            bool trianguloIsosceles(double a, double b, double c)
            {
                Boolean ret = false;

                if ((a == b) || (a == c) || (b == c))
                {
                    ret = true;
                }

                return ret;
            }
        }
    }
}
