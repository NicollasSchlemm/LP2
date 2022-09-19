using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mais_Click(object sender, EventArgs e)
        {

            double numero1, numero2, resultado;
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
            resultado = numero1 + numero2;

            txtResultado.Text = Convert.ToString(resultado);

        }

        private void Menos_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);

            resultado = numero1 - numero2;

            txtResultado.Text = Convert.ToString(resultado);
        }

        private void Vezes_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);

            resultado = numero1 * numero2;

            txtResultado.Text = Convert.ToString(resultado);
        }

        private void Divisão_Click(object sender, EventArgs e)
        {
            double numero1, numero2, resultado;
            numero1 = Convert.ToDouble(txtNum1.Text);
            numero2 = Convert.ToDouble(txtNum2.Text);
            if (numero1 != 0 || numero2 != 0)
            {

                resultado = numero1 / numero2;
                txtResultado.Text = Convert.ToString(resultado);
            }
            else
            {
                MessageBox.Show("Numeros invalidos");
                txtNum1.Clear();
                txtNum2.Clear();
                txtResultado.Clear();
            }
        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();
        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {
            Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 17 && e.KeyChar != 16)
            {
                e.Handled = true;
            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)&& e.KeyChar != 8 && e.KeyChar != 44 && e.KeyChar != 17 && e.KeyChar != 16)
            {
                e.Handled = true;
            }
        }
    }
}
