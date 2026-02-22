namespace TallerMecanico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
           
            servicios serviciosForm = new servicios();
            this.Hide();
            serviciosForm.ShowDialog();
            this.Close();

        }

        private void btnRefacciones_Click(object sender, EventArgs e)
        {
            Refacciones refaccionesForm = new Refacciones();
            this.Hide();
            refaccionesForm.ShowDialog();
            this.Close();
        }
    }
}
