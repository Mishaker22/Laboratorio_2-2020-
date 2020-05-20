using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, altura;
            string linea = "*";
            string espacio = " ";

            do
            {
                Console.WriteLine("Ingrese la altura de su piramide: ");
                altura = int.Parse(Console.ReadLine());
            } while (altura < 1);

            for (i = 0; i < altura; i++)
            {
                Console.SetCursorPosition((Console.WindowWidth - linea.Length) / 2, Console.CursorTop);
                Console.WriteLine(linea);
                linea += "**";
            }
            Console.ReadKey();


        }
    }
}
