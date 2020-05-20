using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Camion:VehiculoTerrestre
    {
        
        protected short cantMarchas;
        protected int pesoCarga;

        public Camion(short cantMarcha, int pesoCarga,short cantRuedas, short cantPuertas, EColores colores):base(cantPuertas:cantPuertas,cantRuedas:cantRuedas,colores:colores)
        {
            this.cantMarchas = cantMarcha;
            this.pesoCarga = pesoCarga;
        }

        public short CantMarchas
        {
            get { return cantMarchas; }
            set { cantMarchas = value; }
        }
        
        public int PesoCarga
        {
            get { return pesoCarga; }
            set { pesoCarga = value; }
        }


    }
}
