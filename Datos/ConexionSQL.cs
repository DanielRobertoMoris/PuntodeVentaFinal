using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

namespace Datos
{
    public class ConexionSQL
    {
        static string ConexionStr = "server= NEWMORIS\\SQLEXPRESS ; database= PV;" +
            "integrated security=true";
        SqlConnection con= new SqlConnection(ConexionStr);

        public int consultaLogin(string username, string password) 
        {
            con.Open();
            int contador;
            string stringQuery = "select count(*) from Personal where usuario='"+username+"'" +
                " and clave='"+password+"'";

            SqlCommand conexion = new SqlCommand(stringQuery,con);
            contador = Convert.ToInt32(conexion.ExecuteScalar());
            
            con.Close();
            return contador;
        }



    }
}
