
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {

        private float area=-1;
        private float perimetro=-1;
        private float laBase, altura;
        private Punto vertice;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice = vertice1;
            this.vertice3 = vertice3;

            this.vertice2 = new Punto(vertice1.GetX(), vertice3.GetY());
            this.vertice4 = new Punto(vertice3.GetX(), vertice1.GetY());
            float altura=0;
            altura= Math.Abs(this.vertice2.GetX() - vertice4.GetX()) + Math.Abs(this.vertice2.GetY() - this.vertice4.GetY());
            this.altura = altura;

        }
        public Rectangulo(Punto vertice1, Punto vertice3, Punto vertice2, Punto vertice4) : this(vertice1, vertice3)
        {
            this.vertice2 = vertice2;
            this.vertice4 = vertice4;

            this.vertice = new Punto(vertice2.GetX(), vertice4.GetY());
            this.vertice3 = new Punto(vertice4.GetX(), vertice2.GetY());
            float laBase = 0;
            laBase= Math.Abs(this.vertice.GetX() - vertice3.GetX()) + Math.Abs(this.vertice.GetY() - this.vertice.GetY());
            this.laBase = laBase;

        }

        public float GetArea
        {
            get
            {
                if (this.area == -1)
                {
                    this.area = this.Area();
                }
                return this.area;
            }
            
            
        }
        public float GetPerimetro
        {
            get { return this.perimetro; }

        }
        public float Area()
        {
            return (this.laBase * this.altura);
        }
        public float Perimetro()
        {
            
            return (this.laBase + this.altura) * 2;
        }




    }
}
