using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5.Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        //constructor instanciado
        public Producto(string codigo, string marca, float precio)
        {
            this.codigoDeBarra = codigo;
            this.marca = marca;
            this.precio = precio;
        }

        //get es un metodo que guarda los valores. su tarea es devolver un dato
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }

        //Cuando te dicen un metodo de la clase es estatico por lo general
        public static string MostrarProducto(Producto producto)
        {
            StringBuilder stringBuilder = new StringBuilder();//Sirve para armar cadenas de texto mas limpias
            stringBuilder.AppendLine(String.Format("Producto Marca {0}", producto.marca));
            stringBuilder.AppendLine(String.Format("Producto Codigo {0}", producto.codigoDeBarra));
            stringBuilder.AppendLine(String.Format("Producto Precio {0}", producto.precio));

            return stringBuilder.ToString();
        }

        // este convierte un producto en un codigo de barras
        public static explicit operator string(Producto producto)
        {
            return producto.codigoDeBarra;
        }

        public static bool operator ==(Producto productoUno, Producto productoDos)
        {
            return !(productoDos is null) && productoUno == productoDos.marca && productoUno.codigoDeBarra == productoDos.codigoDeBarra;
        }

        public static bool operator !=(Producto productoUno, Producto productoDos)
        {
            return !(productoUno == productoDos);
        }
        public static bool operator ==(Producto producto, string marca)
        {
            return !(producto is null) && producto.marca == marca;
        }
        public static bool operator !=(Producto producto, string marca)
        {
            return !(producto == marca);
        }
    }
}
