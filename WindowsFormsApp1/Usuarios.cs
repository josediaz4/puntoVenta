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
    public partial class Usuarios : Form
    {
        ConexionSQLN cn = new ConexionSQLN();

        public Usuarios()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            dgvGrilla.DataSource = cn.ConsultaUsuarios();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            cn.NuevoUsuario(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtTelefono.Text, txtUsuario.Text, txtContrasena.Text);
            dgvGrilla.DataSource = cn.ConsultaUsuarios();
        }
    }
}
