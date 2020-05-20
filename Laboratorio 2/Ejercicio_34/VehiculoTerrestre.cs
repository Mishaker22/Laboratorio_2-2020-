using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class VehiculoTerrestre
    {
        protected short cantRuedas;
        protected short cantPuertas;
        protected EColores colores;

        public VehiculoTerrestre(short cantRuedas, short cantPuertas, EColores colores)
        {
            this.cantPuertas = cantPuertas;
            this.cantRuedas = cantRuedas;
            this.colores = colores;
        }

        public short CantRuedas
        {
            get { return cantRuedas; }
            set { cantRuedas = value; }
        }
        public short CantPuertas
        {
            get { return cantPuertas; }
            set { cantPuertas = value; }
        }
        public EColores Colores
        {
            get { return colores; }
            set { colores = value; }
        }
    }
}
