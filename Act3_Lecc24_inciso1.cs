using System;

namespace SumaPrimosCincuenta
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, divisores, suma_primos;
            suma_primos = 0;

            for (i = 1; i <= 50; i++)
            {
                divisores = 0;

                for (j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisores = divisores + 1;
                    }
                }

                if (divisores == 2)
                {
                    suma_primos = suma_primos + i;
                }
            }

            Console.WriteLine("La suma de los numeros primos entre 1 y 50 es: " + suma_primos);

            Console.ReadKey();
        }
    }
}