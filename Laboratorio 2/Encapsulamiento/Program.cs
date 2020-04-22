using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("pepe", "martinez", 15, 320);
            Alumno a2 = new Alumno("pepo", "maz", 16, 322);

            Aula miAula = new Aula();

            miAula.alumnos.Add(new Alumno("juan", "mora", 14, 321));
            miAula.alumnos.Add(a1);
            miAula.alumnos.Add(a2);
            miAula.alumnos.Add(new Alumno("mike", "herra", 22, 324));


        }
    }
}
