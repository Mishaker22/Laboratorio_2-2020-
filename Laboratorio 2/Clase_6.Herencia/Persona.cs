using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_6.Herencia
{
    public  class Persona
    {
        private string Nombre { get; set; }
        protected string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string MostrarNombre()
        {
            return this.Nombre + " " + this.apellido;
        }

        public Persona(String nombre)
        {
            this.Nombre = nombre;
        }

        public Persona()
        {
            this.Nombre = "Sin nombre";
            this.apellido = "sin Apellido";
        }
        
    }
}
