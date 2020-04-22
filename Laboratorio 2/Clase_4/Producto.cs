using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_4
{
    public class Producto
    {
        public string marca;
        public string fabricante;
        public string tipo;
        public float precio;
        public int cantidad;


        //Constructor sobrecargados
        #region constructores
        public Producto()
        {
            this.tipo = "defecto tipo";
            this.precio = 100;
            this.marca = "Mishaker";
            this.fabricante = "Michellin";
            this.cantidad = 1;
        }
        public Producto(string tipo) : this()
        {
            this.tipo = "defecto tipo";

        }
        public Producto(string tipo, float precio) : this(tipo)
        {
            this.precio = precio;

        }
        public Producto(string tipo, float precio, int cantidad) : this(tipo, precio)
        {
            this.cantidad = cantidad;
        }
        public Producto(string tipo, float precio, int cantidad, string marca) : this(tipo, precio, cantidad)
        {
            this.marca = marca;
        }
        public Producto(string tipo, float precio, int cantidad, string marca, string fabricante) : this(tipo, precio, cantidad, marca)
        {

            this.fabricante = fabricante;
        }
        #endregion

        public void Ingresar()
        {
            this.tipo = "DEFECTO TIPO";
            this.precio = 100;
            this.cantidad = 1;
            this.marca = "MARCA MARCA";
            this.fabricante = "FABRI FABRICA";
        }

        public static bool operator ==(Producto producto1, Producto producto2)
        {
            if (!(producto1 is null) && !(producto2 is null))
            {

                return producto1.tipo == producto2.tipo && producto1.marca == producto2.marca && producto1.fabricante == producto2.fabricante;
            }
            return false;
        }
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }

        public static implicit operator Producto(string tipo)
        {
            Producto aux = new Producto();
            aux.tipo = tipo;
            return aux;
        }

        public static explicit operator string(Producto prod)
        {
            string aux = " tipo:" + prod.tipo;
            aux += " precio:" + prod.precio.ToString();
            aux += " cantidad:" + prod.cantidad.ToString();
            aux += " marca:" + prod.marca;
            aux += " fabricante:" + prod.fabricante;

            return aux;
        }

        public static explicit operator int(Producto prod)
        {
            return prod.cantidad;
        }



        public static implicit operator Estante(Producto producto)
        {
            Estante estante = new Estante(1);
            if (estante + producto)
                return estante;
            return null;

        }

        public void Mostrar()
        {
            Console.WriteLine(this.tipo);
        }
        public void Mostrar(string texto)
        {
            Console.WriteLine(texto);
        }

        public static bool validarPrecio(int precio)
        {
            bool esValido = false;

            if (precio >= 100 && precio <= 300)
            {
                esValido = true;
            }
            else
            {

                esValido = false;
            }

            return esValido;
        }
    }
}
