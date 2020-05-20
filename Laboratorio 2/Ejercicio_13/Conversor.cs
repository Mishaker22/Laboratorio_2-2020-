using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_13
{
    class Conversor
    {
        public static string DecimalBinario(double input)
        {
            int entradaAux = (int)(input);
            double decimales;
            int contador = 0;
            double decimalReferencia;
            int resto;
            string respuesta = "";
            string respuestaDecimales = "";
            decimales = input - entradaAux;
            while (entradaAux > 0)
            {
                resto = entradaAux % 2;
                entradaAux = entradaAux / 2;
                if (resto == 1)
                {
                    respuesta = "1" + respuesta;//Los nuevo numeros deben ir por detras de los antiguos
                }
                else
                {
                    respuesta = "0" + respuesta;//Los nuevo numeros deben ir por detras de los antiguos
                }

            }
            if (decimales > 1)
            {
                decimalReferencia = decimales - 1;
                respuesta = respuesta + ".";

            }
            else if (decimales == 0)
            {
                decimalReferencia = decimales;
                respuesta = respuesta + ".0";
            }
            else
            {
                decimalReferencia = decimales;
                respuesta = respuesta + ".";
            }

            while ((decimalReferencia > 0) && contador < 20)//Decimales
            {

                decimales = decimales * 2;

                if (decimales >= 1)
                {
                    decimales = decimales - 1;
                    respuestaDecimales = respuestaDecimales + "1";
                }
                else
                {
                    respuestaDecimales = respuestaDecimales + "0";
                }
                if (decimales == decimalReferencia || decimales == 0)
                {
                    break;
                }
                contador++;
            }
            respuesta = respuesta + respuestaDecimales;
            return respuesta;
        }
        public static double BinarioDecimal(string input)
        {
            double entradaDouble = double.Parse(input);
            int entradaInt = (int)entradaDouble;
            int suma = 0;
            int decimalExponenciado;
            int isAOne;
            for (int i = input.Length - 3; i >= 0; i--)
            {
                decimalExponenciado = (int)(Math.Pow(10, i));
                isAOne = (entradaInt - decimalExponenciado);
                if (isAOne >= 0)
                {
                    suma += (int)(Math.Pow(10, i));
                    entradaInt = isAOne;
                }
            }
            return suma;
        }
    }
}
