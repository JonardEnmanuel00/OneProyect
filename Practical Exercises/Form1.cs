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
            int inicio = int.Parse(textBox2.Text);
            int fin = int.Parse(textBox3.Text);
            listBox2.Items.Clear();

            for (int i = inicio; i <= fin; i++)
            {
                if (i < 2) continue;

                int divisores = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0) divisores++;
                }

                if (divisores == 2) listBox2.Items.Add(i);
            }
        }

    }
}

  


