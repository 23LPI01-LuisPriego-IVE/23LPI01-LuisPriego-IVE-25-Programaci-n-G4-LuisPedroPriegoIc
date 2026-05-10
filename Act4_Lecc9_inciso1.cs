using System;

namespace TablasMultiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_inicial, contador, resultado;

            Console.WriteLine("Dame un numero para mostrar su tabla de multiplicar (1 al 10):");
            
            if (int.TryParse(Console.ReadLine(), out numero_inicial))
            {
                contador = 1;

                Console.WriteLine("Tabla del:" + numero_inicial);

                while (contador <= 10)
                {
                    resultado = numero_inicial * contador;
                    Console.WriteLine(numero_inicial + " x " + contador + " = " + resultado);
                    contador = contador + 1;
                }
            }

            Console.ReadKey();
        }
    }
}