using System;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;

            Console.WriteLine("Ingresa un numero limite:");

            if (int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Los numeros pares entre 2 y " + n + " son:");

                for (i = 2; i <= n; i = i + 2)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}