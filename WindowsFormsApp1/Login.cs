using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public Login()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cn.ConsultaLoginSQLN(txtUsuario.Text, txtContraseña.Text) == 1)
            {
                //MessageBox.Show("El usuario fue encontrado");

                this.Hide();

                Principal ventanaPrincipal = new Principal();
                ventanaPrincipal.Show();

            }
            else
            {
                MessageBox.Show("El usuario no fue encontrado");
            }

        }
    }
}
