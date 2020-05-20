using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Velero:Transporte
    {
        private double precio;
     

        public double Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public Velero(double precio, Etipo tipo, ECombustible combustible, int cantPasajeros) : base(tipo, combustible, cantPasajeros)
        {
            this.precio = precio;
        }
        public override void Frenar()
        {
            Console.WriteLine("GUARDA LA VELA Y FRENA LENTAMENTE");
        }
    }
}
