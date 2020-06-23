using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_de_Eventos
{
    public delegate void EnCero(object sender);
    public class Numero
    {
        public event EnCero LlegueACero;

        private TextBox txtAsociado;

        private int valor;

        private int velocidad;

        public int Velocidad
        {
            get { return this.velocidad; }
            set
            {
                if (value < 1)
                    throw new Exception("No se puede asignar velocidad menor a 0");
                velocidad = value;

            }
        }


        public int Valor
        {
            get { return this.valor; }
            set
            {
                if (value == 0 && LlegueACero.GetInvocationList() != null)
                    LlegueACero.Invoke(this);
                valor = value;
            }
        }


        public TextBox TxtAsociado
        {
            get { return this.txtAsociado; }
            set { this.txtAsociado = value; }
        }

        public Numero()
        {
            Velocidad = 50;
            Valor = 100;
        }

        public void Reset(object sender, EventArgs e)
        {
            Valor = 100;
            Velocidad = velocidad - 5;
        }
        public void Descontar()
        {

            while (Valor > 0)
            {
                Valor--;
                if (this.txtAsociado.InvokeRequired)
                {
                    this.txtAsociado.BeginInvoke((MethodInvoker)delegate ()
                    {
                        this.txtAsociado.Text = Valor.ToString();
                    });
                }
                else
                {
                    this.txtAsociado.Text = Valor.ToString();
                }
                Thread.Sleep(Velocidad);
            }

        }
    }
}
