namespace App_WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mensaje_Click(object sender, EventArgs e)
        {

            string nombre= text_nombre.Text;

            MessageBox.Show("Bienvendio!!!  " + nombre);
        }
    }
}