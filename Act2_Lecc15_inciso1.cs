using System;

namespace ConteoYSumaPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, divisores, cont_primos, suma_primos;
            cont_primos = 0;
            suma_primos = 0;

            for (i = 1; i <= 100; i++)
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
                    cont_primos = cont_primos + 1;
                    suma_primos = suma_primos + i;
                }
            }

            Console.WriteLine("Cantidad de numeros primos encontrados: " + cont_primos);
            Console.WriteLine("La suma de todos ellos es: " + suma_primos);

            Console.ReadKey();
        }
    }
}