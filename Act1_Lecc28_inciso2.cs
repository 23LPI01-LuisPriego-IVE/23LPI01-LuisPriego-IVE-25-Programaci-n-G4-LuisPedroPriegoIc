using System;

namespace SistemaCobroBoletosLeccion28
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_boletos, total_dinero, tipo_boleto;

            total_boletos = 0;
            total_dinero = 0;
            tipo_boleto = 1;

            Console.WriteLine("Sistema de Cobro");
            Console.WriteLine("1. Adulto ($15) | 2. Niño ($10) | 0. Cerrar Turno");

            while (tipo_boleto != 0)
            {
                Console.WriteLine("Ingrese tipo de boleto:");
                if (int.TryParse(Console.ReadLine(), out tipo_boleto))
                {
                    if (tipo_boleto == 1)
                    {
                        total_dinero = total_dinero + 15;
                        total_boletos = total_boletos + 1;
                    }
                    else if (tipo_boleto == 2)
                    {
                        total_dinero = total_dinero + 10;
                        total_boletos = total_boletos + 1;
                    }

                    if (tipo_boleto != 0)
                    {
                        Console.WriteLine("Ventas actuales: " + total_boletos + " boletos. Total: $" + total_dinero);
                    }
                }
            }

            Console.WriteLine("Corte Final");
            Console.WriteLine("Boletos vendidos: " + total_boletos);
            Console.WriteLine("Total de dinero cobrado: $" + total_dinero);

            Console.ReadKey();
        }
    }
}