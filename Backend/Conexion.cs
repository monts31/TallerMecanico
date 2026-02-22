using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MySql.Data.MySqlClient;

namespace TallerMecanico.Backend
{
    public class Conexion
    {
        //private static string connectionString = "server=9.234.136.64; database=tallerMecanico; user=montse; password=Montserrat3; Allow User Variables=True;";
        private static string connectionString = "server=localhost; database=tallerMecanico; user=root; password=31tv9; Allow User Variables=True;";
        public static MySqlConnection conexion()
        {
            return new MySqlConnection(connectionString);
        }

    }
}
