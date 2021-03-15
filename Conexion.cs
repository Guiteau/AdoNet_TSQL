using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DiegoMendez_proyectoADO_net
{
    class Conexion
    {
        SqlConnection connection;

        public SqlConnection Conn
        {
            get
            {
                return connection;
            }
            set
            {
                connection = value;
            }
        }

        public Conexion()
        {
            String stringConnection = "Data Source=localhost;Initial Catalog=bdFutbol;Integrated Security=true";
            connection = new SqlConnection(stringConnection);
        }
    }
}
