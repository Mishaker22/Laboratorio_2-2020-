using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Player
    {
        private string name;
        public int lifeLevel;
        public int armorLevel;
        public bool isHero;

        public void CambiarNombre(string nombre)
        {
            this.name = nombre;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("¡INFO DEL PERSONAJE!");

            Console.WriteLine("El nombre de mi personaje es: " + this.name);
            Console.WriteLine("La vida actual es de: " + lifeLevel);
            Console.WriteLine("El nivel de armadura es de: " + armorLevel);

            if (isHero)
            {
                Console.WriteLine("Es un ¡Heroe!");
            }
            else
            {
                Console.WriteLine("NO es un HEROE");
            }
            //Console.Write(!isHero ? "NO es" : "ES" + "un Heroe");
            //Console.Write(CONDICION a EVALUAR ? "SI ES VERDADERA PARA ESTO" : "SI NO PASA ESTO OTRO");
        }
    }
}
