using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    public class Celsius
    {
        private double temperatura;
        private static double conversionAKelvin;
        private static double conversionAFahrenheit;

        #region Constructores
        static Celsius()
        {
            Celsius.conversionAKelvin = 273.15;
            Celsius.conversionAFahrenheit = 32;
        }
        public Celsius(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public Celsius(double temperatura, double conversionAKelvin, double conversionAFahrenheit) : this(temperatura)
        {
            Celsius.conversionAFahrenheit = conversionAFahrenheit;
            Celsius.conversionAKelvin = conversionAKelvin;
        }
        #endregion

        #region Propiedades
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        public static double GetConvertirAKelvin()
        {
            return Celsius.conversionAKelvin;
        }
        public static double GetConvertirAFahrenheit()
        {
            return Celsius.conversionAFahrenheit; 
        }
        #endregion

        #region Explicit e implicit

        public static implicit operator Celsius(double celsius)
        {
            Celsius c1 = new Celsius(celsius);
            return c1;
        }
        public static explicit operator Kelvin(Celsius celsius)
        {

            Kelvin kelvin = new Kelvin(celsius.temperatura);
            kelvin = celsius.temperatura + Celsius.GetConvertirAKelvin();
            
            return kelvin;
        }
        public static explicit operator Fahrenheit(Celsius celsius)
        {
            Fahrenheit fahrenheit = new Fahrenheit(celsius.temperatura);
            fahrenheit=celsius.temperatura*1.8+ Celsius.GetConvertirAFahrenheit();
            
            return fahrenheit;
        }
        #endregion

        #region Sobrecarga de operadores == & !=

        public static bool operator ==(Celsius celsius, Kelvin kelvin)
        {
            return (celsius.temperatura == kelvin.GetTemperatura());
        }
        public static bool operator !=(Celsius celsius, Kelvin kelvin)
        {
            return !(celsius == kelvin);
        }
        public static bool operator ==(Celsius celsius, Fahrenheit fahrenheit)
        {
            return (celsius.GetTemperatura() == fahrenheit.GetTemperatura());
        }
        public static bool operator !=(Celsius celsius, Fahrenheit fahrenheit)
        {
            return !(celsius == fahrenheit);
        }
        public static bool operator ==(Celsius c1, Celsius c2)
        {
            return (c1.GetTemperatura() == c2.GetTemperatura());
        }
        public static bool operator !=(Celsius c1, Celsius c2)
        {
            return !(c1 == c2);
        }
        #endregion

        #region Sobrecarga de operadores + y -

        public static Celsius operator +(Celsius celsius, Kelvin kelvin)
        {
            Celsius aux = new Celsius(celsius.GetTemperatura() + ((Celsius)kelvin).GetTemperatura());

            return aux;
        }
        public static Celsius operator +(Celsius celsius, Fahrenheit fahrenheit)
        {
            Celsius aux = new Celsius(celsius.GetTemperatura() + ((Celsius)fahrenheit).GetTemperatura());

            return aux;
        }

        public static Celsius operator -(Celsius celsius, Kelvin kelvin)
        {
            Celsius aux = new Celsius(celsius.GetTemperatura() - ((Celsius)kelvin).GetTemperatura());

            return aux;
        }
        public static Celsius operator -(Celsius celsius, Fahrenheit fahrenheit)
        {
            Celsius aux = new Celsius(celsius.GetTemperatura() - ((Celsius)fahrenheit).GetTemperatura());

            return aux;
        }

        #endregion
    }
}
