using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Estante estante = new Estante(5);

            for (int i = 0; i < estante.productos.Length; i++)
            {
                Producto producto = new Producto();
                producto.Ingresar();
                if (estante + producto)
                    Console.WriteLine("Se agregó correctamente");
            }
            Producto prodVacio = new Producto();
            prodVacio.fabricante = "lucas";
            prodVacio.marca = "Segunda Mano";
            prodVacio.tipo = "Barbijo";
            prodVacio.precio = 250.99f;
            prodVacio.cantidad = 0;
            bool a = estante - prodVacio;
            bool b = estante - (new Producto());
            Estante estanteA = prodVacio;


            Producto producto1 = (Producto)"Barbijo";

            Console.WriteLine((string)producto1);

            Console.ReadKey();
            /* Producto[] productos = new Producto[5];

             for (int i = 0; i < Estante; i++)
             {
                 Producto producto = new Producto();
                 producto.ingresar();
                 if (Estante)
                 {

                 }
             }

             #region ejercicio
             string tipo = string.Empty;
             float precio = 0;
             int cantidad = 0;
             string marca = string.Empty;
             string fabricante = " ";

             for (int i = 0; i < productos.Length; i++)
             {

                 Console.WriteLine("Ingrese el producto que desea agregar: barbijo / jabon / alcohol ");
                 tipo = Console.ReadLine();

                 Console.WriteLine("Ingrese el precio: ");
                 /* while(!float.TryParse(Console.ReadLine(), out precio)&& precio)
                  {
                      Console.WriteLine(" ");
                  }

                  Console.WriteLine("Ingrese la cantidad; ");
                  while()*/

            // productos[i].precio = precio;
            // productos[i].cantidad = cantidad;
            // productos[i].fabricante = fabricante;
            // productos[i].marca = marca;*/


        }
    }
}
