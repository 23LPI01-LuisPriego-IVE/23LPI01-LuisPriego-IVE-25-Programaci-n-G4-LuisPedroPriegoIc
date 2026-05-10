using System;

namespace NumerosPrimos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_inicial, divisor, contador_divisores;

            Console.WriteLine("Dame un numero para ver si es numero primo:");
            
            if (int.TryParse(Console.ReadLine(), out numero_inicial))
            {
                divisor = 1;
                contador_divisores = 0;

                while (divisor <= numero_inicial)
                {
                    if (numero_inicial % divisor == 0)
                    {
                        contador_divisores = contador_divisores + 1;
                    }

                    divisor = divisor + 1;
                }

                if (contador_divisores == 2)
                {
                    Console.WriteLine("El numero " + numero_inicial + " es un numero primo");
                }
                else
                {
                    Console.WriteLine("El numero " + numero_inicial + " no es un numero primo");
                }
            }

            Console.ReadKey();
        }
    }
}