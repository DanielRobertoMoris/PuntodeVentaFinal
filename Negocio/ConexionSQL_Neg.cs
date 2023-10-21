using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Negocio
{
    public class ConexionSQL_Neg
    {
        ConexionSQL cn=new ConexionSQL();

        public int conSQL(string user, string pass) 
        {
            return cn.consultaLogin(user, pass);
        }
    }
}
