using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Backend
{
    public class clsRefaccionesConsultas
    {
        /// <summary>
        /// este método se encarga de obtener las refacciones de la base de datos, se establece una conexión con la base de datos, se ejecuta una consulta SQL para obtener los datos de las refacciones activas,
        /// a continuación, se utiliza un MySqlDataAdapter para llenar un DataTable con los resultados de la consulta y se devuelve el DataTable con las refacciones obtenidas. Si ocurre algún error durante el proceso, se lanza una excepción con un mensaje descriptivo del error.
        /// al finalizar, se cierra la conexión a la base de datos en el bloque finally para asegurar que la conexión se cierre correctamente, independientemente de si ocurrió un error o no.
        /// </summary>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public System.Data.DataTable obtenerRefacciones()
        {
            MySqlConnection conexion = Conexion.conexion();
            try
            {
                conexion.Open();
                string query = "SELECT codigoRefaccion, nombre, marca, precioUnitario, stockActual, stockMinimo, proveedor" +
                    " FROM refacciones where estado='ACTIVO'";
                MySqlCommand comando = new MySqlCommand(query, conexion);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                System.Data.DataTable tablaProductos = new System.Data.DataTable();

                adapter.Fill(tablaProductos);
                return tablaProductos;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener las refacciones: " + ex.Message);
            }
            finally
            {
                conexion.Close();
            }

        }

        /// <summary>
        /// este método se encarga de actualizar los datos de una refacción en la base de datos, se establece una conexión con la base de datos, se ejecuta una consulta SQL para actualizar los datos de la refacción con el ID especificado,
        /// y se utilizan parámetros para evitar problemas de inyección SQL. Si ocurre algún error durante el proceso, se muestra un mensaje de error con una descripción del problema. Al finalizar, se cierra la conexión a la base de datos.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="stockActual"></param>
        /// <param name="stockMinimo"></param>
        /// <param name="proveedor"></param>
        public void actualizarRefaccion(int id, string nombre, string marca, decimal precio, int stockActual, int stockMinimo, string proveedor)
        {
            using (MySqlConnection conexion = Conexion.conexion())
            {
                try
                {
                    conexion.Open();

                    string query = @"UPDATE refacciones
                             SET nombre = @nombre,
                                 marca = @marca,
                                 precioUnitario = @precio,
                                 stockActual = @stockActual,
                                 stockMinimo = @stockMinimo,
                                 proveedor = @proveedor
                             WHERE codigoRefaccion = @id";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stockActual", stockActual);
                    cmd.Parameters.AddWithValue("@stockMinimo", stockMinimo);
                    cmd.Parameters.AddWithValue("@proveedor", proveedor);
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
        /// este método se encarga de insertar una nueva refacción en la base de datos, se establece una conexión con la base de datos, se ejecuta una consulta SQL para insertar los datos de la nueva refacción,
        /// donde se utilizan parámetros para evitar problemas de inyección SQL. Si ocurre algún error durante el proceso, se muestra un mensaje de error con una descripción del problema. Al finalizar, se cierra la conexión a la base de datos.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="precio"></param>
        /// <param name="stockActual"></param>
        /// <param name="stockMinimo"></param>
        /// <param name="proveedor"></param>
        public void insertarRefaccion(int codigo,string nombre, string marca, decimal precio, int stockActual, int stockMinimo, string proveedor)
        {
            using (MySqlConnection conexion = Conexion.conexion())
            {
                try
                {
                    conexion.Open();

                    string query = @"INSERT INTO refacciones 
                             (codigoRefaccion, nombre, marca, precioUnitario, stockActual, stockMinimo, proveedor) 
                             VALUES 
                             (@codigo, @nombre, @marca, @precio, @stockActual, @stockMinimo, @proveedor)";

                    MySqlCommand cmd = new MySqlCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@codigo", codigo); 
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@marca", marca);
                    cmd.Parameters.AddWithValue("@precio", precio);
                    cmd.Parameters.AddWithValue("@stockActual", stockActual);
                    cmd.Parameters.AddWithValue("@stockMinimo", stockMinimo);
                    cmd.Parameters.AddWithValue("@proveedor", proveedor);
                   

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al insertar: " + ex.Message);
                }
            }
        }

        /// <summary>
        /// este método se encarga de eliminar una refacción de la base de datos, se establece una conexión con la base de datos, se ejecuta una consulta SQL para actualizar el estado de la refacción a "INACTIVO" en lugar de eliminarla físicamente de la base de datos,
        /// y se utiliza un parámetro para evitar problemas de inyección SQL. Si ocurre algún error durante el proceso, se muestra un mensaje de error con una descripción del problema. Al finalizar, se cierra la conexión a la base de datos.
        /// </summary>
        /// <param name="id"></param>
        public void eliminarRefaccion(int id)
        {
            using (MySqlConnection conexion = Conexion.conexion())
            {
                try
                {
                    conexion.Open();
                    string query = @"update refacciones set estado='INACTIVO' where codigoRefaccion=@id";
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

       
    }
}
