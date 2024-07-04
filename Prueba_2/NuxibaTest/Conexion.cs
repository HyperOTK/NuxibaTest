using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuxibaTest
{
    public class Conexion
    {

        public static SqlConnection EstableceConexion()
        {
            SqlConnection Conect = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=PRACTICASQL;Data Source=CYGNUSX-1\\SQLEXPRESS");
            Conect.Open();

            return Conect;

        }
    }
}
