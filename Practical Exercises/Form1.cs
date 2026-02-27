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
     
        private void button1_Click_2(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(Valor.Text))
            {
                MessageBox.Show("Por favor, ingresa un valor.");
                return;
            }

            double valor = double.Parse(Valor.Text);
            double metros = 0;
            double resultado = 0;

            // 2. PASO A: Convertimos cualquier entrada a METROS (nuestra base)
            if (Desde.Text == "Metros")
            {
                metros = valor;
            }
            else if (Desde.Text == "Centimetros")
            {
                metros = valor / 100;
            }
            else if (Desde.Text == "Pulgadas")
            {
                metros = valor / 39.3701;
            }

            // 3. PASO B: De METROS convertimos a la unidad de destino
            if (Hacia.Text == "Metros")
            {
                resultado = metros;
            }
            else if (Hacia.Text == "Centimetros")
            {
                resultado = metros * 100;
            }
            else if (Hacia.Text == "Pulgadas")
            {
                resultado = metros * 39.3701;
            }

            // 4. Mostramos el resultado
            MessageBox.Show("El resultado de la conversión es: " + resultado.ToString("N2"));
        }
    }

}

  


