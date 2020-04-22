using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona.metodoEstatico();
            Persona.huesos = 236;

            //creando un objeto persona tipo referencia
            Persona persona = new Persona();
            Persona persona2 = new Persona();
            persona.Edad = 3;
            persona2.Edad = 5;
            //creando una variable tipo valor
            double edad = 3;

            //se envian los datos a metodo
            Program.InicializarPersona(persona, edad);

            //el tipo referencia fue modificado y el tipo valor no
            
            string aux;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.Title = "Ejercicio";
            aux = Console.ReadLine();
            persona.Edad = ValidarEdad(aux);


            Console.WriteLine("Ingrese la edad: ");
            persona.Edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el Nombre: ");
            persona.Nombre = Console.ReadLine();

            Console.WriteLine(persona.Edad.ToString());
            Console.WriteLine(persona.Nombre);

            Console.WriteLine("La persona ingresada se llama " + persona.Nombre + "y su edad es de " + persona.Edad);
            Console.WriteLine("La persona ingresada se llama {0} y tiene {1} años", persona.Nombre, persona.Edad);
            Console.WriteLine("La persona ingresada se llama {0,50} y tiene {1,3} años", persona.Nombre, persona.Edad);

            Console.ReadKey();

        }
        static void InicializarPersona(Persona persona, double edad)
        {
            persona.Edad = (int)edad;//casteo explicito
            edad = persona.Edad;//casteo implicito

            // edad = double.Parse("23");
        }
        static int ValidarEdad(string edad)
        {
            int salida = -1;
            int.TryParse(edad, out salida);
            return salida;
        }
    }
    
}
