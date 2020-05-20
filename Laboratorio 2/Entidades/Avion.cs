using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Avion: Transporte
    {
        private bool vuelosInternacionales;


        public bool VuelosInternaciones
        {
            get { return this.vuelosInternacionales; }
            set { this.vuelosInternacionales = value; }
        }


        public Avion(bool vuelosInternacionales, Etipo tipo, ECombustible combustible, int cantPasajeros) : base(tipo, combustible, cantPasajeros)
        {
            this.vuelosInternacionales = vuelosInternacionales;
        }

        public override void Frenar()
        {
            Console.WriteLine("Baja las revoluciones de turbinas, aterriza y frena lentamente");
        }
    }
}
