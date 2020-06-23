using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_de_Eventos
{
    public partial class Form1 : Form
    {
        List<Thread> hilos;
        List<Numero> numeros;

        public Form1()
        {
            InitializeComponent();
            hilos = new List<Thread>();
            numeros = new List<Numero>();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            lblPuntaje.Text = "0";
            btnEmpezar.Click -= btnEmpezar_Click;

            Numero n1 = new Numero();
            Numero n2 = new Numero();
            Numero n3 = new Numero();
            Numero n4 = new Numero();

            numeros.Add(n1);
            numeros.Add(n2);
            numeros.Add(n3);
            numeros.Add(n4);

            n1.TxtAsociado = tbJugador1;
            n2.TxtAsociado = tbJugador2;
            n3.TxtAsociado = tbJugador3;
            n4.TxtAsociado = tbJugador4;

            n1.LlegueACero += Perdi;
            n2.LlegueACero += Perdi;
            n3.LlegueACero += Perdi;
            n4.LlegueACero += Perdi;

            hilos.Add(new Thread(n1.Descontar));
            hilos.Add(new Thread(n2.Descontar));
            hilos.Add(new Thread(n3.Descontar));
            hilos.Add(new Thread(n4.Descontar));
            hilos.Add(new Thread(SumarPuntos));

            btnJugador1.Click += n1.Reset;
            btnJugador1.Click += btnJugador1_Click;

            btnJugador2.Click += n2.Reset;
            btnJugador2.Click += btnJugador2_Click;

            btnJugador3.Click += n3.Reset;
            btnJugador3.Click += btnJugador3_Click;

            btnJugador4.Click += n4.Reset;
            btnJugador4.Click += btnJugador4_Click;

            foreach (var item in hilos)
            {
                if (!item.IsAlive)
                {
                    item.Start();
                }
            }

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            EliminarHilos(null);
        }
        private void EliminarHilos(object obj)
        {
            for (int i = 0; i < hilos.Count; i++)
            {
                if (hilos[i].IsAlive && (obj is null || ((Numero)obj).TxtAsociado.Name.Substring(6, 1) != (i+1).ToString()))
                {
                    hilos[i].Abort();
                }
            }

        }

        private void btnJugador1_Click(object sender, EventArgs e)
        {
            hilos[0].Abort();
            hilos[0] = new Thread(numeros[0].Descontar);
            hilos[0].Start();
        }

        private void btnJugador2_Click(object sender, EventArgs e)
        {
            hilos[1].Abort();
            hilos[1] = new Thread(numeros[1].Descontar);
            hilos[1].Start();
        }
        private void btnJugador3_Click(object sender, EventArgs e)
        {
            hilos[2].Abort();
            hilos[2] = new Thread(numeros[2].Descontar);
            hilos[2].Start();
        }
        private void btnJugador4_Click(object sender, EventArgs e)
        {
            hilos[3].Abort();
            hilos[3] = new Thread(numeros[3].Descontar);
            hilos[3].Start();
        }
        private void Perdi(object obj)
        {
            EliminarHilos(obj);
            MessageBox.Show("Perdiste");
        }
        private void SumarPuntos()
        {
            while (true)
            {
                if (lblPuntaje.InvokeRequired)
                    lblPuntaje.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 1).ToString();
                    });
                else
                    lblPuntaje.Text = (int.Parse(lblPuntaje.Text) + 1).ToString();

                Thread.Sleep(15);
            }

        }

    }
}
