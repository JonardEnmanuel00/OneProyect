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

        int contador = 0;

        private void button1_Click_1(object sender, EventArgs e)
        {

            contador++;
            label4.Text = "Clics: " + contador;
        }
    
    }
}
