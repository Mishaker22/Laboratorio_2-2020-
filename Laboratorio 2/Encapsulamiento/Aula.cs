using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    class Aula
    {
        public List<Alumno> alumnos;

        public Aula()
        {
            alumnos = new List<Alumno>();
        }
       
        public Alumno this[int indice]
        {
            get { return this.alumnos[indice]; }
            
        }
        private int myVar;

        public List<Alumno> Alumnos
        {
            get { return this.alumnos; }
            //set { myVar = value; }
        }

    }
    
}
