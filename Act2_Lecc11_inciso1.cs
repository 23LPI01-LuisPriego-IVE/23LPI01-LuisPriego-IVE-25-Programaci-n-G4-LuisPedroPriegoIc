using System;

namespace FactorialNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, factorial;

            Console.WriteLine("Digite un numero para ver su factorial:");

            if (int.TryParse(Console.ReadLine(), out n))
            {
                i = n;
                factorial = 1;

                do
                {
                    factorial = factorial * i;
                    i = i - 1;

                } while (i > 0);

                Console.WriteLine("El factorial de " + n + " es: " + factorial);
            }

            Console.ReadKey();
        }
    }
}