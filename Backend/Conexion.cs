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
        /// <summary>
        /// aqui se establece la cadena de conexión a la base de datos, se especifica el servidor, el nombre de la base de datos, el usuario y la contraseña para acceder a la base de datos.
        /// </summary>
        private static string connectionString = "server=9.234.136.64; database=tallerMecanico; user=montse; password=Montserrat3; Allow User Variables=True;";
        //private static string connectionString = "server=localhost; database=tallerMecanico; user=root; password=31tv9; Allow User Variables=True;";
        public static MySqlConnection conexion()
        {
            return new MySqlConnection(connectionString);
        }

    }
}
