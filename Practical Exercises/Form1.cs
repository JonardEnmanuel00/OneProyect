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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Azul")
            {
                this.BackColor = Color.Blue;
            }
            else if (comboBox1.Text == "Rojo")
            {
                this.BackColor = Color.Red;
            }
            else if (comboBox1.Text == "Verde")
            {
                this.BackColor = Color.Green;
            }
        }
    }
}
