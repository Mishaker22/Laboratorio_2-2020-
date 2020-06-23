using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegados_y_Eventos
{
    public partial class FrmRecibe : Form
    {
        public FrmRecibe()
        {
            InitializeComponent();
        }
        public void MostrarMensaje(string texto)
        {
            this.lblTexto.Text = texto;
        }
        private void MuestroMensaje(object sender, EventArgs e)
        {
            switch (((Button)sender).Name)
            {
                case "button1":
                    button1.Click -= MuestroMensaje;
                    button2.Click += MuestroMensaje;
                    break;
                case "button2":
                    button2.Click -= MuestroMensaje;
                    button3.Click += MuestroMensaje;
                    break;
                case "button3":
                    button3.Click -= MuestroMensaje;
                    button4.Click += MuestroMensaje;
                    break;
                case "button4":
                    button4.Click -= MuestroMensaje;
                    button1.Click += MuestroMensaje;
                    break;
                default:
                    break;
            }
            MessageBox.Show("Soy el boton: " + ((Button)sender).Name);
        }

        private void FrmRecibe_Load(object sender, EventArgs e)
        {
            button1.Click += MuestroMensaje;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Click -= MuestroMensaje;
            button2.Click += MuestroMensaje;
        }
    }
}
