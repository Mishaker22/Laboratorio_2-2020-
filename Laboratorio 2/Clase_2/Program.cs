using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mi ejemplo de jueguito";

            Level.MostrarLevelActual();

            Player Mario = new Player();
            Player Luigi = new Player();

            //Mario.name = "Michell";
            Mario.isHero = true;
            Mario.lifeLevel = 100;
            Mario.armorLevel = 50;
            Mario.CambiarNombre("Michael");

            //Luigi.name = "Summer";
            Luigi.isHero = false;
            Luigi.lifeLevel = 300;
            Luigi.armorLevel = 250;

            Mario.MostrarDatos();
            Luigi.MostrarDatos();
        }
    }
}
