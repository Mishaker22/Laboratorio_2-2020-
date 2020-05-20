using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_19
{
    public class Sumador
    {
        private int cantSumas;

       
        public int CantSumas
        {
            get { return this.cantSumas; }
            set { this.cantSumas = value; }
        }


        public Sumador()
        {
            this.cantSumas = 0;
        }
        public Sumador(int cantSumas):this()
        {
            this.cantSumas = cantSumas;
        }
        public long Sumar(long a, long b)
        {
            long resultado=0;
            this.cantSumas++;
            resultado = a + b;
            return resultado;
        }
        public string Sumar(string a ,string b)
        {
            string mensaje = " ";
            this.cantSumas++;
            mensaje = a + b;
            return mensaje;
        }
        public static explicit operator int(Sumador s)
        {

            return s.cantSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return (long)(s1.cantSumas + s2.cantSumas);
        } 
        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool respuesta = false;
            if (s1.cantSumas==s2.cantSumas)
            {
                respuesta = true;
            }
            return respuesta;
        }
    }
}
