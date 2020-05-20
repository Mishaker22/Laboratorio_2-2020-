using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6.Herencia
{
    internal class Profesor: Staff
    {
        int codMateria;
        public Profesor(string nombre):base(nombre)
        {
            this.codMateria = 0;
        }

        public int CodigoMateria
        {
            get { return this.codMateria; }
            set { this.codMateria = value; }
        }
        public String MostrarNombre()
        {
            this.apellido = "sin apellido";
            return "Nombre de profesor";
        }
        public string ModificarNombre(Profesor t1, string name)
        {
            t1.apellido = name;
            return t1.Nombre;
        }
    }
}
