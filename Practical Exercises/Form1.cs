using System.Diagnostics.Eventing.Reader;

namespace Practical_Exercises
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click_1(object sender, EventArgs e)
        {

            if (double.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Es un número válido");
            }
            else
            {
                MessageBox.Show("Error: Ingresa solo números");
            }
        }
    
    }
}
