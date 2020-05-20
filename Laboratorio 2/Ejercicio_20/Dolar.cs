using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region constructores
         static Dolar()
        {
            
            Dolar.cotizRespectoDolar = 1;
        }
        public Dolar(double cant)
        {
            this.cantidad = cant;
        }
        public Dolar(double cant, double cotizacion):this(cant)
        {
            Dolar.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Propiedades
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Dolar.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga Explicit y implicit

        public static implicit operator Dolar(double dolar)
        {
            Dolar dolar1 = new Dolar(dolar);
            return dolar1;
        }
        public static explicit operator Euro(Dolar dolar)
        {

            Euro euros = new Euro(dolar.cantidad);
            euros= dolar.cantidad/ Euro.GetCotizacion();
            return euros;
        }
        public static explicit operator Pesos(Dolar dolar)
        {
            Pesos pesos = new Pesos(dolar.cantidad);
            pesos= dolar.cantidad * Pesos.GetCotizacion();
            return pesos;
        }
        #endregion

        #region Sobrecarga de operadores == & !=

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return (dolar.cantidad == euro.GetCantidad());
        }
        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar == euro);
        }
        public static bool operator ==(Dolar dolar, Pesos pesos)
        {
            return (dolar.cantidad == pesos.GetCantidad());
        }
        public static bool operator !=(Dolar dolar, Pesos pesos)
        {
            return !(dolar == pesos);
        }
        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            return (dolar1.cantidad == dolar2.cantidad);
        }
        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return !(dolar1 == dolar2);
        }
        #endregion

        #region Sobrecarga de operadores + y -

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            Dolar aux = new Dolar(dolar.GetCantidad() + ((Dolar)euro).cantidad);
            
            return aux;
        }
        public static Dolar operator +(Dolar dolar, Pesos pesos)
        {
            Dolar aux = new Dolar(dolar.GetCantidad() + ((Dolar)pesos).cantidad);

            return aux;
        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            Dolar aux = new Dolar(dolar.GetCantidad() - ((Dolar)euro).cantidad);

            return aux;
        }
        public static Dolar operator -(Dolar dolar, Pesos pesos)
        {
            Dolar aux = new Dolar(dolar.GetCantidad() - ((Dolar)pesos).cantidad);

            return aux;
        }

        #endregion





    }
}
