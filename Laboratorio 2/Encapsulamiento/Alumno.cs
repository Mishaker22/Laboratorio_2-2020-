using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamiento
{
    public class Alumno
    {
        private string nombre;
        private string apellido;
        private int edad;
        private int legajo;

        public Alumno(string name, string lastName, int age, int legajo)
        {
            this.nombre = name;
            this.apellido = lastName;
            this.edad = age;
            this.legajo = legajo;
        }
        
        //propfull tab tab

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

    }
}
