using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto:Transporte
    {
        private int cantPuertas;

        public int CantPuertas
        {
            get { return this.cantPuertas; }
            set { this.cantPuertas = value; }
        }


        public Auto(int cantPuertas, Etipo tipo, ECombustible combustible, int cantPasajeros):base(tipo, combustible, cantPasajeros )
        {
            this.cantPuertas = cantPuertas;
        }

        public override void Frenar()
        {
            Console.WriteLine("EL CHOFER PISO FRENO");
        }

        public override string Mostrar()
        {
            StringBuilder mensjae = new StringBuilder();
            mensjae.AppendLine(base.Mostrar());
            mensjae.AppendLine($"Cantidad de puertas; {this.cantPuertas}");
            return mensjae.ToString();
        }
        public override string ToString()//Es el que mas se va a usar para mostrar datos
        {
            StringBuilder mensjae = new StringBuilder();
            mensjae.AppendLine(base.ToString());
            mensjae.AppendLine($"Cantidad de puertas; {this.cantPuertas}");
            return mensjae.ToString();
        }
    }
}
