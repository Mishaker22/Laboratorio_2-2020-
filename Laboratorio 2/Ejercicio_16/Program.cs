using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno();
            Alumno a2 = new Alumno();
            Alumno a3 = new Alumno();
            byte nota1 = 0;
            byte nota2 = 0;

            a1.nombre = "Michell";
            a1.apellido = "Quintero";
            a1.legajo = 122;
            Console.WriteLine("Ingrese la primera nota de {0} {1}: ", a1.nombre, a1.apellido);
            nota1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota de {0} {1}: ", a1.nombre, a1.apellido);
            nota2 = byte.Parse(Console.ReadLine());
            a1.Estudiar(nota1, nota2);
            a1.CalcularFinal();
            


            a2.nombre = "Ricardo";
            a2.apellido = "Herran";
            a2.legajo = 123;
            Console.WriteLine("Ingrese la primera nota de {0} {1}: ", a2.nombre, a2.apellido);
            nota1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota de {0} {1}: ", a2.nombre, a2.apellido);
            nota2 = byte.Parse(Console.ReadLine());
            a2.Estudiar(nota1, nota2);
            a2.CalcularFinal();

            a3.nombre = "fredy";
            a3.apellido = "Marinez";
            a3.legajo = 224;
            Console.WriteLine("Ingrese la primera nota de {0} {1}: ", a3.nombre, a3.apellido);
            nota1 = byte.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la segunda nota de {0} {1}: ", a3.nombre, a3.apellido);
            nota2 = byte.Parse(Console.ReadLine());
            a3.Estudiar(nota1, nota2);
            a3.CalcularFinal();


            Console.WriteLine("Nota final del alumno {0} {1} es de: {2} ", a1.nombre, a1.apellido, a1.Mostrar());
            Console.WriteLine("Nota final del Alumno {0} {1} es de {2}: ", a2.nombre, a2.apellido, a2.Mostrar());
            Console.WriteLine("Nota final del Alumno {0} {1} es de {2}: ", a3.nombre, a3.apellido, a3.Mostrar());

            Console.ReadKey();
        }
    }
}
