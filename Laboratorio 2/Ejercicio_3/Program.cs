using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0; 

            Console.WriteLine("Ingrese un numero entero: ");
            num = int.Parse(Console.ReadLine());

            do
            {
                if (num < 0)
                {
                    Console.WriteLine("Numero invalido, ingrese un numero nuevamente: ");
                    num = int.Parse(Console.ReadLine());
                }

            } while (num < 0);

            for (int i=1; i<num; i++)
            {
                numerosPrimos(i);
            }

           

        }
        public static int numerosPrimos(int num)
        {
            int i;
            int contador = 0;
            int numeroPrimo = 0;

            for (i = 1; i < num + 1; i = i + 1)
            {
                if (num % i == 0)
                {
                    contador++;
                }
            }

            if (contador == 2)
            {
                numeroPrimo = i;
                Console.Write("{0} ,",num);
            }

            return numeroPrimo;
            

        }
    }
}
