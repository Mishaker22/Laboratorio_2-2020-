using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Validaciones;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {

            double num1, num2, resultado;
            char operacion, continuar='s';
            

            do
            {
                Console.WriteLine("Ingrese un numero: ");
                num1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese otro numero: ");
                num2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la opecacion, + - * /");
                operacion =char.Parse( Console.ReadLine());

                resultado = Validacion.Calcular(num1, num2, operacion);
                Console.WriteLine("La operacion de {0} {1} {2} es de: {3} ", num1, operacion, num2, resultado);


            } while (Validacion.ValidarS_N(continuar));

        }
    }
}
