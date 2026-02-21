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
            // dataGridView1.Columns[2].Width = 350;


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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clsRefaccionesConsultas consultas = new clsRefaccionesConsultas();
            if (editando)
            {

                consultas.actualizarRefaccion(idRefaccion, txtNombre.Text, txtMarca.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtStockActual.Text), Convert.ToInt32(txtStockMinimo.Text), txtProveedor.Text);
                MessageBox.Show("Refaccion actualizada correctamente.");
                editando = false;
                idRefaccion = -1;
                btnRegistrar.Text = "Agregar refaccion";
            }
            else
            {
                consultas.insertarRefaccion(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, txtMarca.Text, Convert.ToDecimal(txtPrecio.Text), Convert.ToInt32(txtStockActual.Text), Convert.ToInt32(txtStockMinimo.Text), txtProveedor.Text);
                MessageBox.Show("Refaccion agregada correctamente.");
            }
            llenarDatos();
            limpiarCampos();
            
        }

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

        private void Refacciones_Load(object sender, EventArgs e)
        {
            llenarDatos();
            
        }
    }
}
