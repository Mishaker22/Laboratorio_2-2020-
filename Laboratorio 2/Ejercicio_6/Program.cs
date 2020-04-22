using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int fechaInicio = 0;
            int fechaFinal = 0;
            

            Console.WriteLine("Ingrese el año de Inicio: ");
            fechaInicio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el año final a revisar: ");
            fechaFinal = int.Parse(Console.ReadLine());

            Console.WriteLine("\n AÑOS BISIESTOS\n");

            for (int i=fechaInicio; i<=fechaFinal; i++)
            {
                if (i % 4 == 0 && (!(i % 100 == 0) || i % 400 == 0))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

        }
        
    }
}
