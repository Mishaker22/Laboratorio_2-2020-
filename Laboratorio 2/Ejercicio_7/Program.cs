using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fechaDeNacimiento = new DateTime();
            TimeSpan diasVividos = new TimeSpan();//representa un intervalo de tiempo
            int contDias; //Contador total de dias vividos
            string reciboFecha; //con el cua leo los datos en consola.

            do
            {
                Console.WriteLine("Ingrese su fecha de nacimeinto (aaaa/mm/dd)");
                reciboFecha = Console.ReadLine();

            } while ((DateTime.TryParse(reciboFecha, out fechaDeNacimiento)).Equals(false));//Convierto el string en una fecha 

            diasVividos = DateTime.Now.Subtract(fechaDeNacimiento);//resta una fecha a la otra fecha.
            contDias = (int)diasVividos.TotalDays;//Asigno los dias contados a la variable

            Console.WriteLine("Ud ha vividoo {0} dias ", contDias);

            Console.ReadKey();





        }
    }
}
