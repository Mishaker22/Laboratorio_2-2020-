using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoCuadrado, areaCuadrado;
            double basse, altura, areaTriangulo;
            double radio, areaCircunferencia;


            

            Console.WriteLine("Ingrese el lado del cuadrado para calcular el area: ");
            ladoCuadrado = double.Parse(Console.ReadLine());
            areaCuadrado = CalculoDeArea.CalcularCuadrado(ladoCuadrado);


            Console.WriteLine("Ingrese la base del triangulo a calcular: ");
            basse = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura del triangulo a calcular: ");
            altura = double.Parse(Console.ReadLine());

            areaTriangulo = CalculoDeArea.CalcularTriangulo(basse, altura);

            Console.WriteLine("Ingrese el radio del circulo a calcular: ");
            radio = double.Parse(Console.ReadLine());
            areaCircunferencia = CalculoDeArea.CalcularCircunferencia(radio);


            Console.WriteLine("El area del cuadrado es de: {0}\n El area del triangulo es de: {1}\n La circunferencia es de: {2} ", areaCuadrado, areaTriangulo, areaCircunferencia);
            Console.ReadKey();



        }
    }
}
