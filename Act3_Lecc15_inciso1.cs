using System;

namespace MultiplosSiete
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, multiplo, suma, cont_pares;
            suma = 0;
            cont_pares = 0;

            for (i = 1; i <= 20; i++)
            {
                multiplo = i * 7;
                suma = suma + multiplo;

                if (multiplo % 2 == 0)
                {
                    cont_pares = cont_pares + 1;
                }

                Console.WriteLine("Multiplo " + i + ": " + multiplo);
            }

            Console.WriteLine("La sumatoria total es: " + suma);
            Console.WriteLine("Cantidad de multiplos pares: " + cont_pares);

            Console.ReadKey();
        }
    }
}