using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TiendaAbarrotes
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String CuentaAdmin = "Admin";
            String ContraAdmin = "Hola123";

            if(txtContra.Text.Equals(ContraAdmin) && txtCuenta.Text.Equals(CuentaAdmin))
            {
                ContenedorPrincipal inicio = new ContenedorPrincipal();
                this.Hide();
                inicio.Show();
                

            }
            else
            {
                MessageBox.Show("Usuario o contraseña Incorrectos");
            }
        }
    }
}
