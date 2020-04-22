using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPizzeria
{
    public class Pizza
    {
        private decimal cantidad;
        private string gusto;
        private string tipoDeCoccion;

      
        public Pizza(decimal cant, string gusto, string tipoCoccion)
        {
            this.cantidad = cant;
            this.gusto = gusto;
            this.tipoDeCoccion = tipoCoccion;
        }
        public static bool operator ==(Pizza p1 , Pizza p2)
        {
            if (p1!=null)
            {

                return p1.cantidad == p2.cantidad && p1.gusto == p2.gusto && p1.tipoDeCoccion == p2.tipoDeCoccion;
            }
            return false;
        }
        public static bool operator != (Pizza p1, Pizza p2)
        {
            return !(p1 == p2);
        }
        public static bool operator +(Pizza p1, Pizza p2)
        {
            bool flag = false;
            if (p1==p2)
            {
                p1.cantidad += p2.cantidad;
                flag = true;
            }
            return flag;
        }

        
    }
}
