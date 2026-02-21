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
        public System.Data.DataTable obtenerServicios()
        {
            MySqlConnection conexion = Conexion.conexion();
            try
            {
                conexion.Open();
                string query = "SELECT * FROM servicios where estado='ACTIVO'";
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

        public int obtenerSiguienteId()
        {
            int siguienteId = 0;

            using (MySqlConnection conexion = Conexion.conexion())
            {
                conexion.Open();

                string query = "SELECT AUTO_INCREMENT FROM information_schema.TABLES WHERE TABLE_SCHEMA = DATABASE() AND TABLE_NAME = 'servicios'";
        
        MySqlCommand cmd = new MySqlCommand(query, conexion);
                siguienteId = Convert.ToInt32(cmd.ExecuteScalar());
            }

            return siguienteId;
        }

    }
}
