using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum Etipo
    {
        areo,
        maritimo,
        terrestre
    }
    public enum ECombustible
    {
        nafta,
        gas,
        diesel,
        traccionSangre
    }
    public abstract class Transporte
    {
        private Etipo tipo;
        private ECombustible combustible;
        private int cantMaxPasajeros;

        

        public Etipo Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }


        public ECombustible Combustible
        {
            get { return this.combustible; }
            set { this.combustible = value; }
        }

        public int CantMaxPasajeros
        {
            get { return this.cantMaxPasajeros; }
            set { this.cantMaxPasajeros = value; }
        }
        public Transporte(Etipo tipo,  ECombustible combustible, int pasajeros)
        {
            this.tipo = tipo;
            this.combustible = combustible;
            this.cantMaxPasajeros = pasajeros;

        }

        public virtual string Mostrar()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Tipo de transporte: {this.tipo}");
            mensaje.AppendLine($"Tipo de Combustible: {this.combustible}");
            mensaje.AppendLine($"Cantidad de pasajeros: {this.cantMaxPasajeros}");
            return mensaje.ToString();
        }
        public virtual string ToString()
        {
            StringBuilder mensaje = new StringBuilder();
            mensaje.AppendLine($"Tipo de transporte: {this.tipo}");
            mensaje.AppendLine($"Tipo de Combustible: {this.combustible}");
            mensaje.AppendLine($"Cantidad de pasajeros: {this.cantMaxPasajeros}");
            return mensaje.ToString();
        }
            public void Arrancar()
        {
            Console.WriteLine("Estoy arrancando");
        }
        public abstract void Frenar();

        



    }
}
