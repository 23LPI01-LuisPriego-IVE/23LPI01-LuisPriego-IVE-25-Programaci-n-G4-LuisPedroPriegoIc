using System;

namespace NumerosImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_final, numero_inicial, inicio_original;
            numero_final = 20;

            Console.WriteLine("Dame un inicial para mostrar sus numero impares hasta el 20:");
            
            if (int.TryParse(Console.ReadLine(), out numero_inicial))
            {
                inicio_original = numero_inicial;

                while (numero_inicial <= numero_final)
                {
                    if (numero_inicial % 2 != 0)
                    {
                        Console.WriteLine(numero_inicial);
                    }
                    
                    numero_inicial = numero_inicial + 1;
                }

                Console.WriteLine("Esos son los numeros impares entre: " + inicio_original + " y " + numero_final);
            }

            Console.ReadKey();
        }
    }
}