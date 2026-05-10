using System;

namespace ActividadManzanas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definición de variables
            double peso_total = 0;
            double peso_manzana;
            int i = 0;

            Console.WriteLine("Objetivo: Comprar 1 kilo (1000 gramos) de manzanas");

            // Estructura Mientras -> while
            while (peso_total < 1000)
            {
                Console.WriteLine("Coloca una manzana en la bascula y pon su peso en gramos (150 a 200):");

                // Lectura de datos con validación básica de formato
                if (double.TryParse(Console.ReadLine(), out peso_manzana))
                {
                    // Estructura Si -> if
                    if (peso_manzana >= 150 && peso_manzana <= 200)
                    {
                        peso_total = peso_total + peso_manzana;
                        i = i + 1;
                        Console.WriteLine("Llevas esta cantidad de manzanas: " + i);
                        Console.WriteLine("Peso actual en la bascula: " + peso_total + " gramos.");
                    }
                    else
                    {
                        Console.WriteLine("¡Error! Pon una manzana del rango (entre 150 y 200 gramos)");
                    }
                }
                else
                {
                    Console.WriteLine("¡Error! Por favor, ingresa un número válido.");
                }
            }

            Console.WriteLine("¡Listo! Ya tienes " + peso_total + " gramos (1 kilo o un poco más) en la bascula");

            // Para que la consola no se cierre inmediatamente
            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}