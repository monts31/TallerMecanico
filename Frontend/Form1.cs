namespace TallerMecanico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Boton de servicios, al hacer click se abre el formulario de servicios y se cierra el formulario principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnServicios_Click(object sender, EventArgs e)
        {
           
            servicios serviciosForm = new servicios();
            this.Hide();
            serviciosForm.ShowDialog();
            this.Close();

        }
        /// <summary>
        /// Boton de refacciones, al hacer click se abre el formulario de refacciones y se cierra el formulario principal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefacciones_Click(object sender, EventArgs e)
        {
            Refacciones refaccionesForm = new Refacciones();
            this.Hide();
            refaccionesForm.ShowDialog();
            this.Close();
        }
    }
}
