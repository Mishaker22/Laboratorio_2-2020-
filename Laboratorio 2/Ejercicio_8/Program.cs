using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            float valorHora;
            string nombre;
            int antiguedad;
            float horasPorMes;
            double sueldoNeto;
            double descuentos;
            double sueldoBruto;

            Console.WriteLine("Ingrese el valor de la hora: ");
            valorHora = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese los años de antiguedad del empleado: ");
            antiguedad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de horas trabajadas en el mes:  ");
            horasPorMes = float.Parse(Console.ReadLine());

            sueldoBruto = (valorHora * horasPorMes) + (antiguedad * 150);

            descuentos = sueldoBruto * 0.13;

            sueldoNeto = sueldoBruto - descuentos;

            Console.WriteLine("\nNombre: {0} \n Antiguedad: {1} \n Valor por hora: {2}\n sueldo en Bruto: {3}\n Descuentos: {4}\n sueldo Total en Neto: {5}\n", nombre, antiguedad, valorHora, sueldoBruto, descuentos, sueldoNeto);
            Console.ReadKey();



        }
    }
}
