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

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = textBox2.Text.Trim();

            if (string.IsNullOrEmpty(texto))
            {
                label4.Text = "Palabras: 0";
            }
            else
            {
                string[] palabras = texto.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                label4.Text = "Palabras: " + palabras.Length;
            }
        }
    }

}
