using System;

namespace ContadorBilletes
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, billete, cont_100, suma_100;
            cont_100 = 0;
            suma_100 = 0;
            i = 1;

            Console.WriteLine(" Contador de Billetes de $100 ");
            Console.WriteLine("Ingrese 0 en cualquier momento para finalizar");

            while (i <= 1000)
            {
                Console.WriteLine("Billete " + i + ": Ingrese valor (20, 50, 100 o 0 para salir):");

                if (int.TryParse(Console.ReadLine(), out billete))
                {
                    if (billete == 0)
                    {
                        Console.WriteLine("Proceso finalizado por el usuario");
                        i = 1001;
                    }
                    else
                    {
                        if (billete == 100)
                        {
                            cont_100 = cont_100 + 1;
                            suma_100 = suma_100 + 100;
                            Console.WriteLine("Billete de $100 registrado");
                        }
                        else
                        {
                            Console.WriteLine("Billete distinto a 100 registrado");
                        }

                        i = i + 1;
                    }
                }
            }

            Console.WriteLine(" Reporte Final ");
            Console.WriteLine("Total de billetes de $100: " + cont_100);
            Console.WriteLine("Dinero total en billetes de $100: $" + suma_100);

            Console.ReadKey();
        }
    }
}