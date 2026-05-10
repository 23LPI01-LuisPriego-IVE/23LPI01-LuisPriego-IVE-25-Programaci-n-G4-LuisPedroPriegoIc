using System;

namespace DesbloqueoNivel
{
    class Program
    {
        static void Main(string[] args)
        {
            double monedas_totales = 0;
            double monedas_ingresadas;

            while (monedas_totales < 350)
            {
                Console.WriteLine("Nivel 5 bloqueado llevas: " + monedas_totales + " monedas");
                Console.WriteLine("Ingresa las monedas ganadas en esta partida:");

                if (double.TryParse(Console.ReadLine(), out monedas_ingresadas))
                {
                    monedas_totales = monedas_totales + monedas_ingresadas;
                }
                
                Console.WriteLine(); 
            }

            Console.WriteLine("¡Felicidades! Tienes " + monedas_totales + " monedas");
            Console.WriteLine("El Nivel 5 ha sido desbloqueado, puedes ingresar ahora");
            Console.ReadKey();
        }
    }
}