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

namespace TallerMecanico
{
    public partial class servicios : Form
    {
        clsServiciosConsultas consultas = new clsServiciosConsultas();
        public servicios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void llenarDatos()
        {
            //clsServiciosConsultas consultas = new clsServiciosConsultas();
            dataGridView1.DataSource = consultas.obtenerServicios();
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[0].HeaderText = "Clave";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Descripción";
            dataGridView1.Columns[3].HeaderText = "Precio";
            dataGridView1.Columns[4].HeaderText = "Tiempo servicio";
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

        private void servicios_Load(object sender, EventArgs e)
        {
            llenarDatos();
            textBox1.Text = consultas.obtenerSiguienteId().ToString();

        }
        int idServicio = -1;
        bool editando = false;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Editar")
            {
                idServicio = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["claveServicio"].Value);
                textBox1.Text = idServicio.ToString();
                txtNombre.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDescripcion.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtCosto.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                TimeSpan tiempo = TimeSpan.Parse(dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString());
                dateTimePicker1.Value = DateTime.Today.Add(tiempo);
                editando = true;
                btnAgregar.Text = "Actualizar";
            }
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                idServicio = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["claveServicio"].Value);
                DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este servicio?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    consultas.eliminarServicio(idServicio);
                    llenarDatos();
                    limpiarCampos();
                    textBox1.Text = consultas.obtenerSiguienteId().ToString();
                }
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsServiciosConsultas serv = new clsServiciosConsultas();
            if (editando)
            {

                serv.actualizarServicio(idServicio, txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtCosto.Text), dateTimePicker1.Value.TimeOfDay);
                MessageBox.Show("Servicio actualizado correctamente.");
                editando = false;
                idServicio = -1;
                btnAgregar.Text = "Agregar servicio";
            }
            else {                 
                serv.insertarServicio(txtNombre.Text, txtDescripcion.Text, Convert.ToDecimal(txtCosto.Text), dateTimePicker1.Value.TimeOfDay);
                MessageBox.Show("Servicio agregado correctamente.");
            }
            llenarDatos();
            limpiarCampos();
            textBox1.Text = consultas.obtenerSiguienteId().ToString();
        }

        public void limpiarCampos()
        {
            textBox1.Text = "";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtCosto.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarCampos();
             editando = false;
        }
    }
}
