using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    public class Kelvin
    {
        private double temperatura;
        private static double conversionACelcius;
        private static double conversionAFahrenheit;

        #region Constructores

        static Kelvin()
        {
            Kelvin.conversionAFahrenheit = 459.67;
            Kelvin.conversionACelcius = 273.15;
        }

        public Kelvin(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public Kelvin(double temperatura, double conversionAFahrenheit, double conversionACelsius):this(temperatura)
        {
            Kelvin.conversionACelcius = conversionACelsius;
            Kelvin.conversionAFahrenheit = conversionAFahrenheit;
        }
        
        #endregion

        #region Propiedades
        public double GetTemperatura()
        {
            return this.temperatura;
        }

        public static double GetConversionACelsius()
        {
            return Kelvin.conversionACelcius;
        }
        public static double GetConversionAFahrenheit()
        {
            return Kelvin.conversionAFahrenheit;
        }



        #endregion

        #region Explicit e implicit

        public static implicit operator Kelvin(double kelvin)
        {
            Kelvin kv1 = new Kelvin(kelvin);
            return kv1;
        }
        public static explicit operator Celsius(Kelvin kv)
        {

            Celsius c1 = new Celsius(kv.temperatura);
            c1 = kv.temperatura - Kelvin.GetConversionACelsius();
            return c1;
        }
        public static explicit operator Fahrenheit(Kelvin kv)
        {
            Fahrenheit fahrenheit = new Fahrenheit(kv.temperatura);
            fahrenheit =(kv.temperatura *1.8)- Kelvin.GetConversionAFahrenheit();
            return fahrenheit;
        }
        #endregion

        #region Sobrecarga de operadores == & !=

        public static bool operator ==(Kelvin kelvin, Celsius celsius)
        {
            return (kelvin.temperatura == celsius.GetTemperatura());
        }
        public static bool operator !=(Kelvin kelvin, Celsius celsius)
        {
            return !(kelvin == celsius);
        }
        public static bool operator ==(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            return (kelvin.GetTemperatura() == fahrenheit.GetTemperatura());
        }
        public static bool operator !=(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            return !(kelvin == fahrenheit);
        }
        public static bool operator ==(Kelvin kv1, Kelvin kv2)
        {
            return (kv1.GetTemperatura() == kv2.GetTemperatura());
        }
        public static bool operator !=(Kelvin kv1, Kelvin kv2)
        {
            return !(kv1 == kv2);
        }
        #endregion

        #region Sobrecarga de operadores + y -

        public static Kelvin operator +(Kelvin kelvin, Celsius celsius)
        {
            Kelvin aux = new Kelvin(kelvin.GetTemperatura() + ((Kelvin)celsius).GetTemperatura());

            return aux;
        }
        public static Kelvin operator +(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            Kelvin aux = new Kelvin(kelvin.GetTemperatura() + ((Kelvin)fahrenheit).GetTemperatura());

            return aux;
        }

        public static Kelvin operator -(Kelvin kelvin, Celsius celsius)
        {
            Kelvin aux = new Kelvin(kelvin.GetTemperatura() - ((Kelvin)celsius).GetTemperatura());

            return aux;
        }
        public static Kelvin operator -(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            Kelvin aux = new Kelvin(kelvin.GetTemperatura() - ((Kelvin)fahrenheit).GetTemperatura());

            return aux;
        }

        #endregion

    }
}
