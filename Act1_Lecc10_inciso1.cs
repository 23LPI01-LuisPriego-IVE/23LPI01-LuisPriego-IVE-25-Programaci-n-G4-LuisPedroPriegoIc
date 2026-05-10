using System;

namespace BarberiaCuponera
{
    class Program
    {
        static void Main(string[] args)
        {
            int corte;

            Console.WriteLine("Bienvenido a la barberia");
            Console.WriteLine("Presiona una tecla para obtener cada sello hasta llenar tu cuponera");

            for (corte = 1; corte <= 8; corte++)
            {
                Console.WriteLine("Presiona una tecla para marcar el sello #" + corte + "...");
                Console.ReadKey(true);

                Console.WriteLine("¡Sello #" + corte + " marcado con exito!");
            }

            Console.WriteLine("¡Felicidades! Has completado tus 8 sellos");
            Console.WriteLine("Tu proximo corte de cabello es gratis");

            Console.ReadKey();
        }
    }
}