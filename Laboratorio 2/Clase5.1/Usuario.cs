using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5._1
{
    class Usuario
    {
        string nombre;
        string apellido;
        double dni;

        public Usuario(string name, string lastName, int dni)
        {
            this.nombre = name;
            this.apellido = lastName;
            this.dni = dni;
        }
    }
}
