using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
             int num;
            
          
            Console.Title = "Ejercicio 5";
            Console.WriteLine("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());

            for( int i =1; i < num; i++)
            {
                centroNumerico(i);
            }
           
            
        }
        public static int centroNumerico(int numIngresado)
        {
            int numCentrico = 0;
            int i;
            int sumaAntes = 0; //Suma de numeros anteriores al ingresado
            int sumaDespues = 0; //Suma de numeros posteriores al ingresado

            for ( i = 1; i < numIngresado; i++)
            {
                sumaAntes += + i;
            }
            for (int j = numIngresado + 1; sumaDespues < sumaAntes; j++)//A partir del numero siguiente al ingresado iterar hasta dar igual o mayor a sumaAntes
            {
                sumaDespues = sumaDespues + j;
            }
            if (sumaAntes == sumaDespues)//Si la suma de numeros anteriores es igual a la suma de los numeros posteriores
            {
                numCentrico = i;
                Console.WriteLine("El numero {0} es un centro numerico. Las sumas de ambas partes son {1} y {2}", numCentrico, sumaAntes, sumaDespues);
            }
            return numCentrico;

        }
    }
}
