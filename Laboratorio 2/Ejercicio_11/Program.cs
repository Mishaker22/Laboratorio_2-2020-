using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;
namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {

            int suma = 0, max = 0, min = 0, numero = 0, i;
            float promedio;

            Console.WriteLine("Ingrese 10 numeros enteros: ");
            for ( i = 0; i < 4; i++)
            {
                do
                {
                    Console.WriteLine("numero {0}", i);
                    numero = int.Parse(Console.ReadLine());
                } while (Validacion.Validar(numero, -100, 100));

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

            promedio =(float) suma / i;
            Console.WriteLine("Valor minimo es de: {0}\n Valor maximo es de: {1}\n Promedio es de: {2}", min, max, promedio);
            Console.ReadKey();

          

        }
    }
}
