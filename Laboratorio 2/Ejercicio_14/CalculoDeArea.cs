using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_14
{
    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double area;
            area = Math.Pow(lado, 2);
            return area;
        }

        public static double CalcularTriangulo(double basse , double altura)
        {
            double AreaTriangulo;
            AreaTriangulo = (basse * altura) / 2;
            return AreaTriangulo;
        }

        public static double CalcularCircunferencia(double radio)
        {
            double circunferencia;
            circunferencia = (Math.Pow(radio, 2)* Math.PI);
            return circunferencia;
        }
    }
}
