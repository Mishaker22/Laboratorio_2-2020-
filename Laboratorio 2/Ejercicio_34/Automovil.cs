using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_34
{
    public class Automovil:VehiculoTerrestre
    {
        protected short  cantMarchas;
        int cantPasajeros;
        public Automovil(short cantRuedas, short cantPuerras, short cantMarchas, int cantPasajeros, EColores color):base(cantPuertas:cantPuerras,colores :color,cantRuedas:cantRuedas)
        {
            
            this.cantMarchas = cantMarchas;
            this.cantRuedas = cantRuedas;
        }

       
        public short CantMarchas
        {
            get { return cantMarchas; }
            set { cantMarchas = value; }
        }
        public EColores Colores
        {
            get { return colores; }
            set { colores = value; }
        }
        public int CantPasajeros
        {
            get { return cantPasajeros; }
            set { cantPasajeros = value; }
        }
    }
}
