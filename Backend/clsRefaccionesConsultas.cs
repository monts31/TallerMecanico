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

        public void insertarRefaccion(int codigo,string nombre, string marca, decimal precio, int stockActual, int stockMinimo, string proveedor)
        {
            using (MySqlConnection conexion = Conexion.conexion())
            {
                try
                {
                    conexion.Open();

                    string query = @"INSERT INTO refacciones 
                             (codigo, nombre, marca, precioUnitario, stockActual, stockMinimo, proveedor) 
                             VALUES 
                             (@nombre, @marca, @precio, @stockActual, @stockMinimo, @proveedor)";

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
