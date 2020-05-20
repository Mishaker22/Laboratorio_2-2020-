using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Clase_6.Abstraccion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transportes = new List<Transporte>();

            transportes.Add(new Auto(5, Etipo.terrestre, ECombustible.diesel, 4));
            transportes.Add(new Avion(true, Etipo.areo, ECombustible.diesel, 2000));
            transportes.Add(new Velero(5000, Etipo.maritimo, ECombustible.diesel, 20));
            transportes.Add(new Carreta(2, Etipo.terrestre, ECombustible.traccionSangre, 4));

            //foreach(Transporte item in transportes)
            //{

            //}

            Transporte transporte1 = new Carreta(2, Etipo.terrestre, ECombustible.traccionSangre, 4);
            Transporte transporte2 = new Auto(5, Etipo.terrestre, ECombustible.diesel, 4);

            Console.WriteLine("***CARRETA***");
            Console.WriteLine(((Carreta)transporte1).Mostrar(),"\n");
            Console.WriteLine(transporte1.Mostrar());

            Console.WriteLine("***PROBANDO***");
            Console.WriteLine(((Carreta)transporte1).ToString(), "\n");
            Console.WriteLine(transporte1.ToString());

            Console.WriteLine("***AUTO***");
            Console.WriteLine(((Auto)transporte2).ToString(), "\n");
            //Console.WriteLine(transporte2.Mostrar());

            Console.ReadKey();


        }
    }
}
