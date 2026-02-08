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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label3.Text = "Has Seleccionado Chocolate";
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                label3.Text = "Has Selecionado El Sabor Chocolate";
            }

            else if (radioButton2.Checked == true)
            {
                label3.Text = "Has Seleccionado El sabor Vainilla";
            }

            else if (radioButton3.Checked == true)
            {
                label3.Text = "Has Seleccionado El sabor Fresa";
            }
        }
    }
}
