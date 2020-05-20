using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {

            string dibujo;

            Boligrafo esfero1 = new Boligrafo(ConsoleColor.Blue,100);
            if (esfero1.Pintar(45, out dibujo)==false)
            {
                Console.WriteLine("Tinta insuficiente");
            }
            Console.WriteLine(dibujo);

            Boligrafo esfero2 = new Boligrafo(ConsoleColor.Red,50);
            if (esfero2.Pintar(55, out dibujo) == false)
            {
                Console.WriteLine("Tinta insuficiente");
            }
            ;
            Console.WriteLine(dibujo);




            Console.ReadLine();

        }
    }
}
