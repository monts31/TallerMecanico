using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerMecanico.Backend;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TallerMecanico
{
    public partial class Refacciones : Form
    {
        public Refacciones()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Función para llenar el DataGridView con los datos de las refacciones obtenidos de la base de datos, 
        /// también se configuran las columnas del DataGridView para mostrar los datos de manera adecuada y se agregan botones de editar y eliminar para cada fila.
        /// </summary>
        public void llenarDatos()
        {
            clsRefaccionesConsultas consultas = new clsRefaccionesConsultas();
            dataGridView1.DataSource = consultas.obtenerRefacciones();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Marca";
            dataGridView1.Columns[3].HeaderText = "Precio";
            dataGridView1.Columns[4].HeaderText = "Stock actual";
            dataGridView1.Columns[5].HeaderText = "Stock mínimo";
            dataGridView1.Columns[6].HeaderText = "Proveedor";
            dataGridView1.Columns[0].Width = 65;
            dataGridView1.Columns[3].Width = 85;
            dataGridView1.Columns[4].Width = 85;
            dataGridView1.Columns[0].ReadOnly = true;
            dataGridView1.Columns[1].ReadOnly = true;
            dataGridView1.Columns[2].ReadOnly = true;
            dataGridView1.Columns[3].ReadOnly = true;
            dataGridView1.Columns[4].ReadOnly = true;


            if (!dataGridView1.Columns.Contains("Editar"))
            {
                DataGridViewImageColumn btnEditar = new DataGridViewImageColumn();
                btnEditar.Name = "Editar";
                btnEditar.HeaderText = "Editar";
                btnEditar.Image = Properties.Resources.editar;
                btnEditar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridView1.Columns.Add(btnEditar);
                btnEditar.Width = 70;
            }

            if (!dataGridView1.Columns.Contains("Eliminar"))
            {
                DataGridViewImageColumn btnEliminar = new DataGridViewImageColumn();
                btnEliminar.Name = "Eliminar";
                btnEliminar.HeaderText = "Eliminar";
                btnEliminar.Image = Properties.Resources.eliminar;
                btnEliminar.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGridView1.Columns.Add(btnEliminar);
                btnEliminar.Width = 70;
            }
        }
        int idRefaccion = -1;
        bool editando = false;
        /// <summary>
        /// Evento que se ejecuta al hacer click en una celda del DataGridView, si se hace click en el botón de editar 
        /// se llenan los campos de texto con los datos de la refacción seleccionada para poder editarlos, 
        /// si se hace click en el botón de eliminar se muestra un mensaje de confirmación y si se confirma se elimina la refacción seleccionada 
        /// de la base de datos. Después de cada acción se actualiza el DataGridView y se limpian los campos de texto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            clsRefaccionesConsultas consultas = new clsRefaccionesConsultas();
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                idRefaccion = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["codigoRefaccion"].Value);
                txtCodigo.Text = idRefaccion.ToString();
                txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtMarca.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecio.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtStockActual.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtStockMinimo.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtProveedor.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                editando = true;
                btnRegistrar.Text = "Actualizar refaccion";
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                idRefaccion = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["codigoRefaccion"].Value);
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este servicio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    consultas.eliminarRefaccion(idRefaccion);
                    llenarDatos();
                    limpiarCampos();

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Evento que se ejecuta al hacer click en el botón de registrar, ademas de que no se permiten campos vacíos, se valida que el precio sea un número decimal válido 
        /// y que el nombre tenga al menos 5 caracteres y no sea un número,
        /// si se está editando una refacción se actualizan los datos de la refacción en la base de datos,
        /// y si no se está editando se inserta una nueva refacción en la base de datos con los datos ingresados en los campos de texto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtMarca.Text == "" || txtNombre.Text == "" || txtPrecio.Text == ""
                || txtProveedor.Text == "" || txtStockActual.Text == "" || txtStockMinimo.Text == "")
            {
                MessageBox.Show("Debe de llenar todos los campos.");
                return;
            }
            if (txtCodigo.Text.Length > 15 || !int.TryParse(txtCodigo.Text, out _))
            {
                MessageBox.Show("El código debe ser un número entero válido y no debe exceder los 15 caracteres.");
                return;
            }
            if (txtStockActual.Text.Length > 8 || !int.TryParse(txtStockActual.Text, out int stockactual) || stockactual < 0)
            {
                MessageBox.Show("El stock actual debe ser un número entero válido y no debe exceder los 8 caracteres.");
                return;
            }
            if (txtStockMinimo.Text.Length > 8 || !int.TryParse(txtStockMinimo.Text, out int stockminimo) || stockminimo <= 0)
            {
                MessageBox.Show("El stock mínimo debe ser un número entero válido y no debe exceder los 8 caracteres.");
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out decimal precio) || precio<= 0)
            {
                MessageBox.Show("El precio debe ser un número decimal válido.");
                return;
            }
            if (txtNombre.Text.Length < 5 || int.TryParse(txtNombre.Text, out _))
            {
                MessageBox.Show("Por favor ingrese un nombre valido");
                return;
            }
            else
            {
                clsRefaccionesConsultas consultas = new clsRefaccionesConsultas();
                if (editando)
                {

                    consultas.actualizarRefaccion(idRefaccion, txtNombre.Text, txtMarca.Text, Convert.ToDecimal(txtPrecio.Text), stockactual, stockminimo, txtProveedor.Text);
                    MessageBox.Show("Refaccion actualizada correctamente.");
                    editando = false;
                    idRefaccion = -1;
                    btnRegistrar.Text = "Agregar refaccion";
                }

                else
                {
                    consultas.insertarRefaccion(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtMarca.Text, Convert.ToDecimal(txtPrecio.Text), stockactual, stockminimo, txtProveedor.Text);
                    MessageBox.Show("Refaccion agregada correctamente.");
                }
                llenarDatos();
                limpiarCampos();
            }

        }
        /// <summary>
        /// Evento que se ejecuta al hacer click en el botón de cancelar, 
        /// se limpian los campos de texto y se reinician las variables de edición.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }
        public void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtMarca.Text = "";
            txtPrecio.Text = "";
            txtStockActual.Text = "";
            txtStockMinimo.Text = "";
            txtProveedor.Text = "";
        }

        /// <summary>
        /// Evento del formulario que se ejecuta al cargar el formulario, se llama a la función 
        /// llenarDatos para mostrar las refacciones en el DataGridView al abrir el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refacciones_Load(object sender, EventArgs e)
        {
            llenarDatos();
            dataGridView1.AutoGenerateColumns = false;

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
