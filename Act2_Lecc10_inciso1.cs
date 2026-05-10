using System;

namespace MultiplosDeCuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, resultado;

            Console.WriteLine("Primeros 20 multiplos de 4:");

            for (i = 1; i <= 20; i++)
            {
                resultado = i * 4;
                Console.WriteLine(i + " x 4 = " + resultado);
            }

            Console.WriteLine("Son todos los multiplos de 4.");

            Console.ReadKey();
        }
    }
}