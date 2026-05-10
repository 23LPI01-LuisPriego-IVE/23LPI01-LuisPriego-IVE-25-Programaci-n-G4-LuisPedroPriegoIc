using System;

namespace MultiplosRango
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, menor, mayor, i;

            Console.WriteLine("Ingresa el primer numero:");
            int.TryParse(Console.ReadLine(), out n1);

            Console.WriteLine("Ingresa el segundo numero:");
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

            Console.WriteLine("Multiplos de 4 entre " + menor + " y " + mayor + ":");

            for (i = menor; i <= mayor; i++)
            {
                if (i % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}