using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Proyecto_escuela
{
    class Cls_conexion
    {
        public static string connectionString = "datasource=189.204.133.38;username=escuela_user_jane;password=escuelaPR0y3cto;database=bd_escuela;";
        public MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    }
}
