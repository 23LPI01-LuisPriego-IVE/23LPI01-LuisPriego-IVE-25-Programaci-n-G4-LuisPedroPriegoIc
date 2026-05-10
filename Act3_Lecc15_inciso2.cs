using System;

namespace ConteoYSumaInversa
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, divisores, cont_primos, suma_pares;
            cont_primos = 0;
            suma_pares = 0;

            // Ciclo que va desde 300 hasta 1 en orden descendente
            for (i = 300; i >= 1; i--)
            {
                // Verificar si el número es par
                if (i % 2 == 0)
                {
                    suma_pares = suma_pares + i;
                }

                // Lógica para verificar si el número es primo
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
                }
            }

            Console.WriteLine("Suma de los numeros pares: " + suma_pares);
            Console.WriteLine("Cantidad de numeros primos encontrados: " + cont_primos);

            Console.ReadKey();
        }
    }
}