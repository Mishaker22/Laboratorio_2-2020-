using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public void Estudiar(byte nota1, byte nota2)
        {

            this.nota1 = nota1;
            this.nota2 = nota2;
            
        }
        public void CalcularFinal()
        {
            if (this.nota1>=4 && this.nota2>=4)
            {
                Random notaAleatoria = new Random();
                notaFinal =(float) notaAleatoria.Next(1, 10);
            }
            else
            {
                this.notaFinal = -1;
            }
            
        }
        public string Mostrar()
        {
            string resultado;
            if (this.notaFinal != -1)
            {
                resultado = this.notaFinal.ToString();
            }
            else
            {
                resultado = "Desaprobado";
            }
            

            return resultado;
        }
        
    }
}
