using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(2);
            Sumador s2 = new Sumador(2);

            Console.WriteLine("SUMA DE LONG DE S1\n La suma es de: {0} La cantidad de sumas es de: {1} ", s1.Sumar(12, 10), s1.CantSumas);
            Console.WriteLine("SUMA DE CADENAS DE S1\n"+"La suma de 2 palabas es de: "+s1.Sumar("hola qu", "e haces?")+" Y Su cantidad de sumas es de: {0}", s1.CantSumas);

            Console.WriteLine("\n SUMA DE LONG DE S2 \n La suma es de: {0} La cantidad de sumas es de: {1} ", s2.Sumar(8, 10), s2.CantSumas);
            Console.WriteLine("SUMA DE CADENAS DE S2\n" + "La suma de 2 palabas es de: " + s2.Sumar("Adio", "s Popo ") + " Y Su cantidad de sumas es de: {0}", s2.CantSumas);

            Console.WriteLine("\n¿Tienen la misma cantidad de sumas S1 Y S2?: {0} ",s1 | s2);
            Console.WriteLine("\nProbando operador + : \n s1: " + (long)s1 +" + "+ " s2: " + (long)s2+" = "+(s1+s2));
           
            Console.ReadKey();
          
            
        }
    }
}
