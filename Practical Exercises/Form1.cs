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


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        { 
            timer5.Start(); 
        }

        private void button2_Click(object sender, EventArgs e)
        { 
            timer5.Stop();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 5;
            }
            else
            {
                timer5.Stop();
                MessageBox.Show("Carga finalizada con éxito");
            }
        }

    }

}


