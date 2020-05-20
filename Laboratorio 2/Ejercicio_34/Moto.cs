using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Moto:VehiculoTerrestre
    {
        protected short  cilindrada;

        public Moto(short cantRuedas, short cantPuertas, short cilindrada, EColores color):base(cantPuertas:cantPuertas,colores :color,cantRuedas:cantRuedas)
        {
            this.cilindrada = cilindrada;
        }


        public short Cilindrada
        {
            get { return cilindrada; }
            set { cilindrada = value; }
        }
        public EColores Colores
        {
            get { return colores; }
            set { colores = value; }
        }
    }
}
