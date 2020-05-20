using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Extensions;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura, i;
            string linea = "*";

            do
            {
                Console.WriteLine("Ingrese la altura de la piramide: ");
                altura = int.Parse(Console.ReadLine());

            } while (altura.IsLessThan(1));//Si altura es menor a 1 vuelve a entrar al bucle, si es mayor a 1 salta el bucle.

            for ( i = 0; i<altura ; i++) 
            {
                Console.WriteLine(linea);//muesta los columna de los asteriscos segun la altura que escogio el usuario
                linea += "**"; 
            }
            Console.ReadKey();
        }
    }
}
