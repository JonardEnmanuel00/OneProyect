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

        int totalSegundos;

        private void button1_Click_1(object sender, EventArgs e)
        {
            totalSegundos = ((int)numMinutos.Value * 60) + (int)numSegundos.Value;
            timer9.Start();
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            if (totalSegundos > 0)
            {
                totalSegundos--;
            
                this.Text = "Tiempo: " + totalSegundos;
            }
            else
            {
                timer9.Stop();
                MessageBox.Show("¡Tiempo agotado!");
            }
        }
    }

}
