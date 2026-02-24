using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerMecanico.Backend
{
    public class clsServiciosConsultas
    {
        /// <summary>
        /// este método se encarga de obtener los servicios de la base de datos, se establece una conexión 
        /// con la base de datos, se ejecuta una consulta SQL para obtener los datos de los servicios activos,
        /// a continuación, se utiliza un MySqlDataAdapter para llenar un DataTable con los resultados de la consulta 
        /// y se devuelve el DataTable con los servicios obtenidos. Si ocurre algún error durante el proceso, 
        /// se lanza una excepción con un mensaje descriptivo del error.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public System.Data.DataTable obtenerServicios()
        {
            MySqlConnection conexion = Conexion.conexion();
            try
            {
                conexion.Open();
                string query = "SELECT claveServicio, nombreServicio, descripcion, costoBase, tiempoEstimado" +
                    " FROM servicios where estado='ACTIVO'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                System.Data.DataTable tablaProductos = new System.Data.DataTable();

                adapter.Fill(tablaProductos);
                return tablaProductos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los servicios: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        /// <summary>
        /// este método se encarga de actualizar los datos de un servicio en la base de datos, 
        /// se establece una conexión con la base de datos, se ejecuta una consulta SQL para 
        /// actualizar los datos del servicio con el ID especificado,
        /// y se utilizan parámetros para evitar problemas de inyección SQL. 
        /// Si ocurre algún error durante el proceso, se muestra un mensaje de error con una descripción del problema. Al finalizar, se cierra la conexión a la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="precio"></param>
        /// <param name="tiempo"></param>
        public void actualizarServicio(int id, string nombre, string descripcion, decimal precio, TimeSpan tiempo)
        {
            using (MySqlConnection conexion = Conexion.conexion())
            {
                try
                {
                    conexion.Open();

                    string query = @"UPDATE servicios 
                             SET nombreServicio = @nombre,
                                 descripcion = @descripcion,
                                 costoBase = @precio,
                                 tiempoEstimado = @tiempo
                             WHERE claveServicio = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@tiempo", tiempo);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }

        }

        /// <summary>
        /// este método se encarga de insertar un nuevo servicio en la base de datos, se establece una conexión 
        /// con la base de datos, se ejecuta una consulta SQL para insertar los datos del nuevo servicio,
        /// y se utilizan parámetros para evitar problemas de inyección SQL. 
        /// Si ocurre algún error durante el proceso, se muestra un mensaje de error con una descripción del problema. Al finalizar, se cierra la conexión a la base de datos.
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="descripcion"></param>
        /// <param name="costo"></param>
        /// <param name="tiempo"></param>
        public void insertarServicio(string nombre, string descripcion, decimal costo, TimeSpan tiempo)
        {
            using (MySqlConnection conexion = Conexion.conexion())
            {
                try
                {
                    conexion.Open();

                    string query = @"INSERT INTO servicios 
                             (nombreServicio, descripcion, costoBase, tiempoEstimado) 
                             VALUES 
                             (@nombre, @descripcion, @precio, @tiempo)";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@precio", costo);
                    cmd.Parameters.AddWithValue("@tiempo", tiempo);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// este método se encarga de eliminar un servicio de la base de datos, se establece una conexión 
        /// con la base de datos, se ejecuta una consulta SQL para actualizar el estado del servicio a "INACTIVO" 
        /// con el ID especificado,y se utiliza un parámetro para evitar problemas de inyección SQL. 
        /// Si ocurre algún error durante el proceso, se muestra un mensaje de error con una descripción del problema. 
        /// Al finalizar, se cierra la conexión a la base de datos.
        /// </summary>
        /// <param name="id"></param>
        public void eliminarServicio(int id)
        {
            using (MySqlConnection conexion = Conexion.conexion())
            {
                try
                {
                    conexion.Open();
                    string query = @"update servicios set estado='INACTIVO' where claveServicio=@id";
                    MySqlCommand cmd = new MySqlCommand(query, conexion);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar: " + ex.Message);
                }
            }

        }

        /// <summary>
        /// este método se encarga de obtener el siguiente ID disponible para un nuevo servicio, se establece una 
        /// conexión con la base de datos, se ejecuta una consulta SQL para obtener el máximo ID actual en la tabla 
        /// de servicios y se le suma 1 para obtener el siguiente ID disponible. 
        /// Si ocurre algún error durante el proceso, se muestra un mensaje de error con una descripción del problema. 
        /// Al finalizar, se cierra la conexión a la base de datos.
        /// </summary>
        /// <returns></returns>
        public int obtenerSiguienteId()
        {
            int siguienteId = 0;

            using (MySqlConnection conexion = Conexion.conexion())
            {
                conexion.Open();

                string query = "SELECT IFNULL(MAX(claveServicio),0) + 1 FROM servicios";

                MySqlCommand cmd = new MySqlCommand(query, conexion);
                siguienteId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return siguienteId;
        }

    }
}
