using System;

namespace SumaRango
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, menor, mayor, suma, i;
            suma = 0;

            Console.WriteLine("Ingresa primer numero:");
            int.TryParse(Console.ReadLine(), out n1);

            Console.WriteLine("Ingresa segundo numero:");
            int.TryParse(Console.ReadLine(), out n2);

            if (n1 < n2)
            {
                menor = n1;
                mayor = n2;
            }
            else
            {
                menor = n2;
                mayor = n1;
            }

            for (i = menor; i <= mayor; i++)
            {
                suma = suma + i;
            }

            Console.WriteLine("La suma total de los numeros entre " + menor + " y " + mayor + " es: " + suma);

            Console.ReadKey();
        }
    }
}