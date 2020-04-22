using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num=0;
            double alCuadrado = 0;
            double alCubo = 0;

            Console.WriteLine("Ingrese un numero.");
            num = int.Parse(Console.ReadLine());

            do
            {
               if (num <= 0)
                {
                    Console.WriteLine("El numero que ingreso es invalido, debe ser mayor a 0.");
                    Console.WriteLine("Ingrese nuevamente un numero: ");
                    num = int.Parse(Console.ReadLine());
                }

            } while (num <= 0);
            
            alCuadrado = Math.Pow(num, 2);
            alCubo = Math.Pow(num, 3);
            Console.WriteLine("El numero ingresado fue: {0} y su resultado al cuadrado es de: {1}, y su resultado al cubo es de: {2}", num, alCuadrado, alCubo);
            Console.ReadLine();

        }
    }
}
