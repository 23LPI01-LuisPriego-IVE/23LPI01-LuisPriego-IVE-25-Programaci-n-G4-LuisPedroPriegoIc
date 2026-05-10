using System;

namespace CuentaRegresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, suma_total;
            suma_total = 0;

            Console.WriteLine("Ingresa un numero para iniciar la cuenta regresiva:");

            if (int.TryParse(Console.ReadLine(), out n))
            {
                for (i = n; i >= 1; i--)
                {
                    Console.WriteLine(i);
                    suma_total = suma_total + i;
                }

                Console.WriteLine("La suma es " + suma_total);
            }

            Console.ReadKey();
        }
    }
}