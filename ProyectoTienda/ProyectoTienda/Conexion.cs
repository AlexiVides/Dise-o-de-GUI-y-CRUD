using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoTienda
{
     class Conexion
    {
        public static SqlConnection Conectar()
        {
            string connectionString = "Data Source=LAPTOP-G5GPCEC8;Initial Catalog=TiendaTec;Integrated Security=SSPI";

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return connection;
        }
    }
}
