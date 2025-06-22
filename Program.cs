using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Variaveis
            float a, b;
            char sinal;
            float resultado;
            bool controlador;
            #endregion

            #region Input
            Console.WriteLine("Digite um número");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite um segundo número");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite a sinal aritimétrico + ou - ");
            sinal = char.Parse(Console.ReadLine());
            #endregion  
            if (sinal =='+' || sinal == '-')
            {
                if (sinal == '+')
                {
                    resultado = a + b;
                    Console.WriteLine(resultado);

                }

                else if (sinal == '-')
                {
                    resultado = a - b;
                    Console.WriteLine(resultado);
                }
                
            }
            else
            {

                controlador = true;
                while (controlador)
                {
                    Console.WriteLine("Digite apenas ou + ou menos sem epaço");
                    sinal = char.Parse(Console.ReadLine());
                    if (sinal == '+' || sinal == '-')
                    {
                        break;
                    }
                }
                if (sinal == '+')
                {
                    resultado = a + b;
                    Console.WriteLine(resultado);

                }

                else if (sinal == '-')
                {
                    resultado = a - b;
                    Console.WriteLine(resultado);
                }
            }
            //Console.ReadKey();
            Console.ReadLine();
        }

    }
}
