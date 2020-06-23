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
    public delegate void CargarMensaje(string palabra);//delegado
    public partial class FrmEnvia : Form
    {
        public event CargarMensaje EnviaMensaje;//crea un evento
        public FrmEnvia()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text != string.Empty)
            {
                if ((EnviaMensaje.GetInvocationList()) != null)
                {
                    //
                    EnviaMensaje.Invoke(txtTexto.Text);
                }   
            }
        }
    }
}
