using System;

namespace NumerosImparesRepetir
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;

            Console.WriteLine("Numeros impares del 1 al 100:");

            do
            {
                Console.WriteLine(i);
                i = i + 2;
            } while (i <= 100);

            Console.ReadKey();
        }
    }
}