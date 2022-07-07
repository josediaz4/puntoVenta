using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class Conexion
    {
        public static string ConexionString = "server=localhost;" +
                                              "database= PuntodeVenta;" +
                                              "integrated security=true";

        SqlConnection con = new SqlConnection(ConexionString);

        public int ConsultaLogin(string usuario, string contraseña)
        {
            int count;
            con.Open();

            string query = "Select Count(*) from Persona where Usuario = '"+usuario+"' " +
                "and Contraseña = '" + contraseña + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            count = Convert.ToInt32(cmd.ExecuteScalar());

            con.Close();
            return count;
        }

        public DataTable ConsultarUsuario()
        {
            string query = "Select * from Persona";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);

            return table;
        }

        public int NuevoUsuario(string nom, string ape, string dni, string tel, string user, string pass)
        {
            int flag = 0;
            con.Open();

            string query = "insert into Persona values ('" + nom + "','" + ape + "','" + dni + "','" + tel + "'," +
                "'" + user + "', '" + pass + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();

            con.Close();
            return flag;
        }
    }
}
