﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Proyecto_escuela
{
    class Cls_conexion
    {
        public static string connectionString = "datasource=127.0.0.1;port=3306;username=root;database=escuela;";

        public MySqlConnection databaseConnection = new MySqlConnection(connectionString);
    }
}
