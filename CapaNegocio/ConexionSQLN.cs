using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public  class ConexionSQLN
    {
        Conexion cn = new Conexion();

        public int ConsultaLoginSQLN (string user, string pass)
        {
            return cn.ConsultaLogin(user, pass);
        }

        public DataTable ConsultaUsuarios()
        {
            return cn.ConsultarUsuario();
        }
        public int NuevoUsuario(string nom, string ape, string dni, string tel, string user, string pass)
        {
            return cn.NuevoUsuario(nom, ape, dni, tel, user, pass);

        }
    }
}
