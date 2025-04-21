namespace Parcial1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FormCliente Form2 = new FormCliente();
            Form2.Show();
            this.Hide();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FormAdmin Form3 = new FormAdmin();
            Form3.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Salir del programa
            Application.Exit();
        }
    }
}
