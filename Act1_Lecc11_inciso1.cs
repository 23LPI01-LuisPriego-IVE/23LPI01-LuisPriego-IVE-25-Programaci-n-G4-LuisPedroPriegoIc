using System;

namespace Estacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            int autos_estacionados;
            autos_estacionados = 0;

            do
            {
                autos_estacionados = autos_estacionados + 1;
                Console.WriteLine("Ha entrado un auto. Lugares disponibles: " + (200 - autos_estacionados));

            } while (autos_estacionados < 200);

            Console.WriteLine("Ya no hay cajones libres. Estacionamiento lleno.");

            Console.ReadKey();
        }
    }
}