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

namespace Clase_23
{
    public partial class Form1 : Form
    {
        Thread t;//declaro hilo
       
        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ParameterizedThreadStart(MostrarTiempo));//usar metodo mostrar
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void MostrarTiempo(object utcObj)
        {
            int utc = -3;
            lblTiempo = (Label)utcObj;
            while (true)
            {
                if (lblTiempo.InvokeRequired)
                {
                    lblTiempo.BeginInvoke((MethodInvoker)delegate ()
                    {
                        lblTiempo.Text = DateTime.UtcNow.AddHours(utc).ToString("hh: mm:ss");
                    });
                }
                else
                {
                    lblTiempo.Text = DateTime.UtcNow.AddHours(utc).ToString("hh: mm:ss");
                }
                
                
                Thread.Sleep(1000);
            }
        }

        private void btnTiempo_Click(object sender, EventArgs e)
        {
            t.Start(this.lblTiempo);//inicializa
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Frm1_FormClosing(object sender, FormClosedEventArgs e)
        {
            if (t.IsAlive)
            {
                t.Abort();
            }
        }
    }
}
