using System.Diagnostics.Eventing.Reader;
using static System.Runtime.InteropServices.JavaScript.JSType;

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


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                int numero = int.Parse(maskedTextBox1.Text);
                int sumaDivisores = 0;

                for (int i = 1; i < numero; i++)
                {
                    if (numero % i == 0) sumaDivisores += i;
                }

                if (sumaDivisores == numero && numero > 0)
                    MessageBox.Show("¡Es un número perfecto!");
                else
                    MessageBox.Show("No es un número perfecto.");
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}

  


