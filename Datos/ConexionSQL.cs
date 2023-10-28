using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
/********************************************************************* */
/*  Debemos agregar estos dos "using" para poder manejar las tablas de */
/*  la Base de Datos                                                   */
/***********************************************************************/
using System.Data.SqlClient;
using System.Threading;

namespace Datos
{
    public class ConexionSQL
    {
        /* Conexion a la Base de Datos */
        static string ConexionStr = "server= NEWMORIS\\SQLEXPRESS ; database= PV;" +
            "integrated security=true";
        SqlConnection con= new SqlConnection(ConexionStr);
        /*******************************/

        public int consultaLogin(string username, string password) 
        {
            con.Open(); /* Abre la Base de Datos*/
            int contador;

            /* Creo la cadena de caracteres de los comandos de consulta de SQL */
            string stringQuery = "select count(*) from Personal where usuario='"+username+"'" +
                " and clave='"+password+"'";


            /* Hace la consulta */
            SqlCommand conexion = new SqlCommand(stringQuery,con);
            contador = Convert.ToInt32(conexion.ExecuteScalar());
            
            con.Close(); /* Cierra la base de Datos */
            return contador;
        }



    }
}
