using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Kelvin kelvin = new Kelvin(50);
            Celsius celsius = new Celsius(60);
            Fahrenheit fahrenheit = new Fahrenheit(2000);

            Console.WriteLine("CALCULAR CAMBIO DE TEMPERATURAS ");
            Console.WriteLine("Fahrenheit a Celsius: " + ((Celsius)fahrenheit).GetTemperatura() + " ~~ Kelvin a Celsius: " + ((Celsius)kelvin).GetTemperatura());
            Console.WriteLine("Celsius a Kelvin: " + ((Kelvin)celsius).GetTemperatura() + " ~~ Fahrenheit a Kelvin: " + ((Kelvin)fahrenheit).GetTemperatura());
            Console.WriteLine("Kelvin a Fahrenheit: " + ((Fahrenheit)kelvin).GetTemperatura() + " ~~ Celcius a Fahrenheit: " + ((Fahrenheit)celsius).GetTemperatura());

            Console.WriteLine("\n SUMA ENTRE TEMPERATURAS");
            Console.WriteLine("La suma entre :{0} Fahrenheit y {1}  ", fahrenheit.GetTemperatura(), ((Fahrenheit)kelvin).GetTemperatura() + " Kelvin, en Fahrenheit es de: " + (fahrenheit + kelvin).GetTemperatura());
            Console.WriteLine("La suma entre :{0} Celsius y {1}  ", celsius.GetTemperatura(), ((Celsius)kelvin).GetTemperatura() + " kelvin, en Celsius es de: " + (celsius + kelvin).GetTemperatura());
            Console.WriteLine("La Resta entre :{0} Fahrenheit y {1}  ", fahrenheit.GetTemperatura(), ((Fahrenheit)celsius).GetTemperatura() + " Celsius, en Fahrenheit es de: " + (fahrenheit - celsius).GetTemperatura());
            Console.WriteLine("La Resta entre :{0} Kelvin y {1}  ", ((Kelvin)kelvin).GetTemperatura(), ((Kelvin)celsius).GetTemperatura() + " Celsius, en Kelvin es de: " + (kelvin - celsius).GetTemperatura());

            Console.ReadKey();
        }
    }
}
