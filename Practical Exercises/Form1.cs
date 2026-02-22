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

            if (string.IsNullOrEmpty(maskedTextBox1.Text)) return;


            int numero = int.Parse(maskedTextBox1.Text);
            int contadorDivisores = 0;


            for (int i = 1; i <= numero; i++)
            {
                // El símbolo % nos dice si el residuo es cero (división exacta)
                if (numero % i == 0)
                {
                    contadorDivisores++;
                }
            }


            if (contadorDivisores == 2)
            {
                MessageBox.Show(numero + " es un número PRIMO.");
            }
            else
            {
                MessageBox.Show(numero + " NO es un número primo.");
            }
        }

    }

}

  


