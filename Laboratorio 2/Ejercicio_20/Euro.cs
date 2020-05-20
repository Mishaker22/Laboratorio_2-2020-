using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_20
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        #region constructores
        static Euro()
        {
            
            Euro.cotizRespectoDolar = 1.16F;
        }
        public Euro(double cant) 
        {
            this.cantidad = cant;
        }
        public Euro(double cant, double cotizacion) : this(cant)
        {
            Euro.cotizRespectoDolar = cotizacion;
        }
        #endregion

        #region Propiedades
        public double GetCantidad()
        {
            return this.cantidad;
        }
        public static double GetCotizacion()
        {
            return Euro.cotizRespectoDolar;
        }
        #endregion

        #region Sobrecarga Explicit y implicit

        public static implicit operator Euro(double euro)
        {
            Euro euros = new Euro(euro);
            return euros;
        }
        public static explicit operator Dolar(Euro euro)
        {

            Dolar dolares = new Dolar(euro.cantidad);
            dolares = euro.cantidad * Euro.GetCotizacion();
            return dolares;
        }
        public static explicit operator Pesos(Euro euro)
        {
            Pesos pesos = new Pesos(euro.cantidad);
            pesos = euro.cantidad * Euro.GetCotizacion()*Pesos.GetCotizacion();
            return pesos;
        }
        #endregion

        #region Sobrecarga de operadores == & !=

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            return (dolar.GetCantidad() == euro.GetCantidad());
        }
        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(dolar == euro);
        }
        public static bool operator ==(Euro euro, Pesos pesos)
        {
            return (euro.GetCantidad() == pesos.GetCantidad());
        }
        public static bool operator !=(Euro euro, Pesos pesos)
        {
            return !(euro==pesos);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        #endregion

        #region Sobrecarga de operadores + y -

        public static Euro operator +( Euro euro, Dolar dolar)
        {
            Euro aux = new Euro(euro.GetCantidad() + ((Euro)dolar).cantidad);

            return aux;
        }
        public static Euro operator +(Euro euro, Pesos pesos)
        {
            Euro aux = new Euro(euro.GetCantidad() + ((Euro)pesos).cantidad);

            return aux;
        }

        public static Euro operator -(Euro euro, Dolar dolar)
        {
            Euro aux = new Euro(euro.GetCantidad() - ((Euro)dolar).cantidad);

            return aux;
        }
        public static Euro operator -(Euro euro, Pesos pesos)
        {
            Euro aux = new Euro(euro.GetCantidad() - ((Euro)pesos).cantidad);

            return aux;
        }

        #endregion
    }
}
