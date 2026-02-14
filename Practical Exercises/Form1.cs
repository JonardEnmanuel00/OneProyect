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
            double celsius = double.Parse(textBox1.Text);
            double fahr = (celsius * 9 / 5) + 32;
            label4.Text = fahr + " °F";

        }

    

       
    }
}
