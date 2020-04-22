using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5.Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int UbicacionEstante;

        private Estante(int capacidad)
        {
            this.productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.UbicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return this.productos;
        }
        public static string MostrarEstante(Estante estante)
        {
            StringBuilder stringBuilder = new StringBuilder();
            if (estante is null)
            {
                stringBuilder.AppendLine(String.Format("Estante Ubicacion {0}", estante.UbicacionEstante));
                stringBuilder.AppendLine("Productos del estante");

                for (int i = 0; i < estante.productos.Length; i++)
                {
                    stringBuilder.AppendLine(Producto.MostrarProducto(estante.productos[i]));
                }
            }


            return stringBuilder.ToString();
        }
        public static bool operator ==(Producto producto, Estante estante)
        {
            if (estante is null)
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (estante.productos[i] == producto)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public static bool operator !=(Producto producto, Estante estante)
        {
            return !(producto == estante);
        }

        public static bool operator +(Estante estante, Producto producto)
        {
            if (!(estante is null) && !(producto is null) && estante != producto)
            {
                Producto[] productoAux = estante.GetProductos();
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (productoAux[i] is null)
                    {
                        productoAux[i] = producto;
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator -(Estante estante, Producto producto)
        {
            Producto[] productoAux = estante.GetProductos();
            if (!(estante is null) && !(producto is null))
            {
                for (int i = 0; i < estante.productos.Length; i++)
                {
                    if (productoAux[i] == producto)
                    {
                        productoAux[i] = null;
                        return true;
                    }
                }
            }

            return false;

        }
    }
}
