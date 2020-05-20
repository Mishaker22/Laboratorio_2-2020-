using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carreta:Transporte
    {
        private int cantCaballos;

        public int CantCaballos
        {
            get { return this.cantCaballos; }
            set { this.cantCaballos = value; }
        }


        public Carreta(int cantCavallos, Etipo tipo, ECombustible combustible, int cantPasajeros) : base(tipo, combustible, cantPasajeros)
        {
            this.cantCaballos=cantCaballos;
        }
        public override void Frenar()
        {
            Console.WriteLine("Hala la cuerda y el caballo va parando");
        }
    }
}
