using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validacion = true;
            if (valor < max && valor > min)
            {
                validacion = false;
            }
            return validacion;
        }
        public static bool ValidarS_N(char c)
        {
            bool validcion = false;

            Console.WriteLine("¿Desea continuar? S para continuar.");
            c = char.Parse(Console.ReadLine());

            if (c=='S'|| c == 's')
            {
                
                validcion = true;
            }
            return validcion;

        }

        public static bool Division(double input)
        {
            if (input == 0)
            {
                return false;
            }
            return true;
        }

        public static double Calcular(double num1, double num2, char signo)
        {
            double resultado = 0;
            switch (signo)
            {

                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    if (Division(num2))
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error. No se puede dividir por 0");
                        Console.ReadLine();
                    }
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Error. El signo ingresado es invalido.");
                    Console.ReadLine();
                    break;
            }


            return resultado;
        }
    }
}
