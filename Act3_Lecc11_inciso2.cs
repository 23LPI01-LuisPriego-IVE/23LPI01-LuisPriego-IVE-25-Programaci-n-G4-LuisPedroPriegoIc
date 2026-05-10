using System;

namespace SumaNumerosHastaNueve
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, suma;
            suma = 0;
            num = 0;

            while (num != 9)
            {
                Console.WriteLine("Ingresa un numero (o presiona 9 para terminar):");

                if (int.TryParse(Console.ReadLine(), out num))
                {
                    if (num != 9)
                    {
                        suma = suma + num;
                    }
                }
            }

            Console.WriteLine("La suma total de los números ingresados es: " + suma);

            Console.ReadKey();
        }
    }
}