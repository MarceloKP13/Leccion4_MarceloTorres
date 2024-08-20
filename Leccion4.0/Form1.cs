using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Leccion4._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            //Este botón es para calcular
            //recupero numero 1
            double numero1 = double.Parse(num1.Text);
            //recupero numero 2
            double numero2 = double.Parse(num2.Text);
            //
            if (suma.Checked == true)
            {
                MessageBox.Show($"La suma es: {numero1 + numero2:F2}");
            }
            else if (resta.Checked == true)
            {
                MessageBox.Show($"La resta es: {numero1 - numero2:F2}");
            }
            else if (multi.Checked == true)
            {
                MessageBox.Show($"El producto es {numero1 * numero2:F2}");
            }
            else if (divi.Checked == true)
            {
                if (numero2 != 0)
                {
                    MessageBox.Show($"La división es {numero1 / numero2:F2}");
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero");
                }
            }
            else if (modulo.Checked == true)
            {
                MessageBox.Show($"La división es {numero1 % numero2:F2}");
            }
            else if (raiz.Checked == true)
            {
                if (numero1 >= 0 && numero2 >= 0)
                {
                    double resultado1 = Math.Sqrt(numero1);
                    double resultado2 = Math.Sqrt(numero2);
                    MessageBox.Show($"La raíz cuadradra de {numero1} es {resultado1:F2}" +
                        $"\nLa raíz cuadradra de {numero2} es {resultado2:F2}");
                }else
                {
                    MessageBox.Show("No se puede calcular raíz cuadrada de número negativos.");
                }
            }
        }

        private void nueva_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            this.Hide();
        }
    }
}
