using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Dolar dolares = new Dolar(50);
            Euro euros = new Euro(60);
            Pesos pesitos = new Pesos(2000);

            Console.WriteLine("CALCULAR CAMBIO DE MONEDAS ");
            Console.WriteLine("Pesos a Dolar: " + ((Dolar)pesitos).GetCantidad()+" ~~ Euros a Dolar: "+((Dolar)euros).GetCantidad());
            Console.WriteLine("Dolar a Euros: " + ((Euro)dolares).GetCantidad() + " ~~ Pesos a Euros: " + ((Euro)pesitos).GetCantidad());
            Console.WriteLine("Euros a Pesos: " + ((Pesos)euros).GetCantidad() + " ~~ Dolar a Pesos: " + ((Pesos)dolares).GetCantidad());

            Console.WriteLine("\n SUMA ENTRE MONEDAS");
            Console.WriteLine("La suma entre :{0} dolares y {1}  ", dolares.GetCantidad(), euros.GetCantidad()+ " Euros, en Dolares es de: " + (dolares+euros).GetCantidad());
            Console.WriteLine("La suma entre :{0} dolares y {1}  ", dolares.GetCantidad(), pesitos.GetCantidad() + " Pesos, en Dolares es de: " + (dolares + pesitos).GetCantidad());
            Console.WriteLine("La Resta entre :{0} dolares y {1}  ",((Euro)dolares).GetCantidad(), euros.GetCantidad() + " Euros, en Euros es de: " + (euros-dolares).GetCantidad());
            Console.WriteLine("La Resta entre :{0} euros y {1}  ",((Pesos)euros).GetCantidad(), pesitos.GetCantidad() + " Pesos, en pesos es de: " + (euros - pesitos).GetCantidad());

            Console.ReadKey();
        }
    }
}
