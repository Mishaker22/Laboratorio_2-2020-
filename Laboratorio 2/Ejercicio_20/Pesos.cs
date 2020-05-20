using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region constructores
        static Pesos()
        {
            
             Pesos.cotizRespectoDolar= 38.33F;
        }
        public Pesos(double cant) 
        {
            this.cantidad = cant;
        }
        public Pesos(double cant, double cotizacion) : this(cant)
        {
            Pesos.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Propiedades
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Pesos.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga Explicit y implicit

        public static implicit operator Pesos(double pesos)
        {
            Pesos peso = new Pesos(pesos);
            return peso;
        }
        public static explicit operator Dolar(Pesos pesos)
        {

            Dolar dolares = new Dolar(pesos.cantidad);
            dolares = pesos.GetCantidad() / Pesos.GetCotizacion();
            return dolares;
        }
        public static explicit operator Euro(Pesos pesos)
        {
            Euro euros = new Euro(pesos.cantidad);
            euros = pesos.cantidad / (Pesos.GetCotizacion()*Euro.GetCotizacion());
            return euros;
        }
        #endregion

        #region Sobrecarga de operadores == & !=

        public static bool operator ==(Pesos peso, Dolar dolar)
        {
            return (dolar.GetCantidad() == peso.GetCantidad());
        }
        public static bool operator !=(Pesos peso, Dolar dolar)
        {
            return !(dolar == peso);
        }
        public static bool operator ==(Pesos pesos, Euro euro)
        {
            return (euro.GetCantidad() == pesos.GetCantidad());
        }
        public static bool operator !=(Pesos pesos, Euro euro)
        {
            return !(euro == pesos);
        }
        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.cantidad == p2.cantidad);
        }
        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1 == p2);
        }
        #endregion

        #region Sobrecarga de operadores + y -

        public static Pesos operator +(Pesos peso, Dolar dolar)
        {
            peso = peso.cantidad + ((Pesos)dolar).cantidad;
            return peso;
        }
        public static Pesos operator +( Pesos pesos, Euro euros)
        {
            pesos = pesos.cantidad + ((Pesos)euros).cantidad;

            return pesos;
        }

        public static Pesos operator -(Pesos peso, Dolar dolar)
        {
            peso = peso.cantidad - ((Pesos)dolar).cantidad;
            return peso;
        }
        public static Pesos operator -(Pesos pesos, Euro euros)
        {
            pesos = pesos.cantidad - ((Pesos)euros).cantidad;

            return pesos;
        }

        #endregion
    }
}
