using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6.Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona alumno = new Alumno();
            //Persona profesor = new Profesor();
            //Profesor t1 = new Profesor();

            List<Persona> personasCurso = new List<Persona>();

            personasCurso.Add(alumno);
            //personasCurso.Add(t1);
            //if (t1 is Profesor)
            //{
            //    ((Profesor)t1).CodigoMateria=25;
            //}

            //t1.MostrarNombre();

            
        }
    }
}
