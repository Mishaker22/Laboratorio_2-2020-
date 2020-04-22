using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPizzeria
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private string domicilio;
        

        private Cliente()
        {
            this.nombre = "Sin nombre";
            this.apellido = "sin apellido";
            this.apellido = "sin domicilio";
        }

        public Cliente(string nombre) : this()
        {
            this.nombre = nombre;
        }
        public Cliente(string nombre, string domicilio):this(nombre)
        {
            this.domicilio = domicilio;
        }
        public Cliente(string nombre, string domicilio, string apellido):this(nombre, domicilio)
        {
            this.apellido = apellido;
        }

    }

}
