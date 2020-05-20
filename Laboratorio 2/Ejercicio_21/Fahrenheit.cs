using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_21
{
    public class Fahrenheit
    {
        private double temperatura;
        private static double conversionACelsius;
        private static double conversionAKelvin;

        #region Constructores
        static Fahrenheit()
        {
            
            Fahrenheit.conversionACelsius = 0.5555;
            Fahrenheit.conversionAKelvin = 0.5555;
        }
        public Fahrenheit(double temperatura)
        {
            this.temperatura = temperatura;
        }
        public Fahrenheit(double temperatura, double conversionACelsius, double conversionAKelvin):this(temperatura)
        {
            Fahrenheit.conversionAKelvin = conversionAKelvin;
            Fahrenheit.conversionACelsius = conversionACelsius;
        }
       
        #endregion
        
        #region Propiedades
        public double GetTemperatura()
        {
            return this.temperatura;
        }
        public static double GetValorInKelvin()
        {
            return Fahrenheit.conversionAKelvin;
        }
        public static double GetValorInCelcius()
        {
            return Fahrenheit.conversionACelsius;
        }
        #endregion

        #region Explicit e implicit

        public static implicit operator Fahrenheit(double fahrenheit)
        {
            Fahrenheit f1  = new Fahrenheit(fahrenheit);
            return f1;
        }
        public static explicit operator Celsius(Fahrenheit fahrenheit )
        {

            Celsius c1 = new Celsius(fahrenheit.temperatura);
            c1 = (fahrenheit.GetTemperatura()-32) *Fahrenheit.GetValorInCelcius() ;
            return c1;
        }
        public static explicit operator Kelvin(Fahrenheit fahrenheit)
        {
            Kelvin kelvin = new Kelvin(fahrenheit.GetTemperatura());
            kelvin =(fahrenheit.GetTemperatura()+459.67)* Fahrenheit.GetValorInKelvin();
            return kelvin;
        }
        #endregion

        #region Sobrecarga de operadores == & !=

        public static bool operator ==(Fahrenheit fahrenheit, Celsius celsius)
        {
            return (fahrenheit.GetTemperatura() == celsius.GetTemperatura());
        }
        public static bool operator !=(Fahrenheit fahrenheit, Celsius celsius)
        {
            return !(fahrenheit == celsius);
        }
        public static bool operator ==( Fahrenheit fahrenheit, Kelvin kelvin)
        {
            return (fahrenheit.GetTemperatura()== kelvin.GetTemperatura());
        }
        public static bool operator !=(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            return !(fahrenheit == kelvin );
        }
        public static bool operator ==(Fahrenheit f1, Fahrenheit f2)
        {
            return (f1.GetTemperatura() == f2.GetTemperatura());
        }
        public static bool operator !=(Fahrenheit f1, Fahrenheit f2)
        {
            return !(f1==f2);
        }
        #endregion

        #region Sobrecarga de operadores + y -

        public static Fahrenheit operator +(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            Fahrenheit aux = new Fahrenheit(fahrenheit.GetTemperatura() + ((Fahrenheit)kelvin).GetTemperatura());

            return aux;
        }
        public static Fahrenheit operator +(Fahrenheit fahrenheit, Celsius celsius)
        {
            Fahrenheit aux = new Fahrenheit(fahrenheit.GetTemperatura() + ((Fahrenheit)celsius).GetTemperatura());

            return aux;
        }

        public static Fahrenheit operator -(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            Fahrenheit aux = new Fahrenheit(fahrenheit.GetTemperatura() - ((Fahrenheit)kelvin).GetTemperatura());

            return aux;
        }
        public static Fahrenheit operator -(Fahrenheit fahrenheit, Celsius celsius)
        {
            Fahrenheit aux = new Fahrenheit(fahrenheit.GetTemperatura() - ((Fahrenheit)celsius).GetTemperatura());

            return aux;
        }

        #endregion
    }
}
