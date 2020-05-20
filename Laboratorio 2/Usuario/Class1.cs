using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario
{
    public enum EPuesto
    {
        cocina,
        delivery,
        atencionAlCliente
    }
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private string nombreDeUsuario;
        private string pass;
        private EPuesto epuesto;

        private int myVar;

        public String Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public String Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public String NombreDeUsuario
        {
            get { return this.nombreDeUsuario; }
            set { this.nombreDeUsuario = value; }
        }
        public String Pass
        {
            get { return this.pass; }
            set { this.pass = value; }
        }
        public EPuesto EPuesto
        {
            get { return this.epuesto; }
            set { this.epuesto = value; }
        }

    }
}
