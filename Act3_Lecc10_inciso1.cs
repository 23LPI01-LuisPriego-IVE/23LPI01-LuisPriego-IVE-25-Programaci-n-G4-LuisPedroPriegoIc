using System;

namespace SumaNumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, divisor, cont_divisores, suma;
            suma = 0;

            Console.WriteLine("Números primos entre 1 y 22:");

            for (i = 1; i <= 22; i++)
            {
                cont_divisores = 0;

                for (divisor = 1; divisor <= i; divisor++)
                {
                    if (i % divisor == 0)
                    {
                        cont_divisores = cont_divisores + 1;
                    }
                }

                if (cont_divisores == 2)
                {
                    Console.WriteLine(i);
                    suma = suma + i;
                }
            }

            Console.WriteLine("La suma total de los números primos es: " + suma);

            Console.ReadKey();
        }
    }
}