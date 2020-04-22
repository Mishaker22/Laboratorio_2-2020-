using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesPizzeria
{
    public class Pedido
    {
        private string envia;
        private DateTime horaDeIngreso;
        private DateTime horsaDeSalida;
        private Pizza[] pizzas;

        private Cliente cliente;

        private Pedido(Cliente cliente)
        {
            this.cliente = cliente;
            this.pizzas = new Pizza[8];
        }

        public static implicit operator Pedido(Cliente c1)
        {
            Pedido aux = new Pedido(c1);
            return aux;
        }

        public static bool operator +(Pedido pedido, Pizza p1)
        {
            for (int i = 0; i < pedido.pizzas.Length; i++)//buscar si en el array de pizzas si la pizza existe.
            {
                if (pedido.pizzas[i]+p1)
                {
                    return true;
                }

            }
            for (int i = 0; i< pedido.pizzas.Length ; i++)//buscar un lugar libre y la agrega
            {
                if (pedido.pizzas[i] is null)
                {
                    pedido.pizzas[i] = p1;
                    return true;
                }
            }
            return false;
        }
    }
}
