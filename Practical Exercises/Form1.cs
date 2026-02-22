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

        private void Label3_Click(object sender, EventArgs e)
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

        private void Button2_Click(object sender, EventArgs e)
        {
            timer5.Stop();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            int numero = int.Parse(textBox1.Text);

            listBox1.Items.Clear();

            for (int i = 1; i <= 10; i++)
            {

         

            int resultado = numero * i;

            listBox1.Items.Add(numero + " x " + i + " = " + resultado);


            }

        }

    }
}
