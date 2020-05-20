using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_17
{
    public class Boligrafo
    {
        const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        public ConsoleColor Getcolor()
        {
            return this.color;
        }

      public short GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(short tinta)
        {
            this.tinta -= tinta;

            if (this.tinta< 0)
            {
                this.tinta = 0;

            }else if (this.tinta > cantidadTintaMaxima)
            {
                this.tinta = 100;
            }

        }

        public void Recargar()
        {
            SetTinta(100);
        }
        public bool Pintar(short gasto, out string dibujo)
        {
            bool respuesta=false;
            string aux = "";
            Console.ForegroundColor = this.color;//Obtiene el color

            if (this.GetTinta() >= 0)
            {

                if (gasto > this.GetTinta())
                {

                    for (int i = 0; i < this.GetTinta(); i++)
                    {
                        aux = aux + "*";
                    }
                    SetTinta((short)gasto);
                    respuesta = false;
                }
                else
                {

                    for (int i = 0; i < gasto; i++)
                    {
                        aux = aux + "*";

                    }
                    this.SetTinta((short)gasto);
                    respuesta = true;
                }

            }
           
            dibujo = aux;
            return respuesta;

        }

       



    }
}
