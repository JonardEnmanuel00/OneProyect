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
            {

                string palabraOriginal = textBox2.Text.ToLower().Replace(" ", "");


                string palabraInversa = "";

    for (int i = palabraOriginal.Length - 1; i >= 0; i--)
                {
                    palabraInversa += palabraOriginal[i];
                }


                if (palabraOriginal == palabraInversa)
                {
                    MessageBox.Show("¡Es un palíndromo!", "Resultado");
                }
                else
                {
                    MessageBox.Show("No es un palíndromo.", "Resultado");
                }
            }

        }
    }

}

  


