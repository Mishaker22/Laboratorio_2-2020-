using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            char continuar='s';
            int numero = 0, suma = 0;

            do
            {
                Console.Write("Ingrese un numero entero: ");
                numero = int.Parse(Console.ReadLine());

                suma = suma + numero;

            } while (Validacion.ValidarS_N(continuar));

            Console.WriteLine("La suma de los numeros ingresados es de: {0}", suma);

            Console.ReadKey();
        }
    }
}
