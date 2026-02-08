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
            double numero1 = double.Parse(textBox1.Text);
            double numero2 = double.Parse(textBox2.Text);

            double resultado = numero1 + numero2;
            label3.Text = "El resultado de la suma es " + resultado.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
