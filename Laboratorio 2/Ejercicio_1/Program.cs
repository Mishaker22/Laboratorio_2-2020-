using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, suma = 0, max = 0, min = 0, i;
            float promedio = 0;

            Console.WriteLine("Ingrese 5 numeros enteros: ");

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("numero {0}", i);
                numero = int.Parse(Console.ReadLine());

                if (i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else if (numero > max)
                {
                    max = numero;
                }
                else if (numero < min)
                {
                    min = numero;
                }
                suma += numero;
            }
            promedio = (float)suma / i;

            Console.WriteLine("\n el numero maximo es: {0}\n el numero minimo es: {1}\n la suma es: {2}\n el promedio es: {3}", max, min, suma, promedio);
            Console.ReadKey();
        }
    }
}
