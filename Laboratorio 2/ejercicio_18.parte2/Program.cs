using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo prueba = new Rectangulo(new Punto(1, 3), new Punto(5, 3), new Punto(3, -5), new Punto(5, -9));
    
            
            Console.WriteLine("El area del rectangulo es de: {0} ", prueba.Area());
            Console.WriteLine("El Perímetro del rectangulo es de: {0}", prueba.Perimetro());
            Console.ReadKey();
        }
    }
}
