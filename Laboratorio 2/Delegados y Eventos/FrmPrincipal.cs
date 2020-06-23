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
    public partial class FrmPrincipal : Form
    {
        FrmRecibe frmRecibe;
        public FrmPrincipal()
        {
            InitializeComponent();
            frmRecibe = new FrmRecibe();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEnvia frmEnviar = new FrmEnvia();

            frmEnviar.EnviaMensaje += frmRecibe.MostrarMensaje;
            frmEnviar.EnviaMensaje += FrmEnviar_EnviaMensaje;
            frmEnviar.Show();
        }

        private void FrmEnviar_EnviaMensaje(string palabra)
        {
            MessageBox.Show(palabra);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            frmRecibe.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Click -= button3_Click;
            txtNumero.Text = (int.Parse(txtNumero.Text) + 1).ToString();
            button4.Click += button4_Click;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Click -= button4_Click;
            txtNumero.Text = (int.Parse(txtNumero.Text) - 1).ToString();
            button3.Click += button3_Click;
        }
    }
}
