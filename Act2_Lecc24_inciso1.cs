using System;

namespace MultiplosVeinte
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, multiplo;

            Console.WriteLine("Ingrese el numero del cual desea conocer sus multiplos:");

            if (int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Los primeros 20 multiplos de " + n + " son:");

                for (i = 1; i <= 20; i++)
                {
                    multiplo = n * i;
                    Console.WriteLine(n + " x " + i + " = " + multiplo);
                }
            }

            Console.ReadKey();
        }
    }
}