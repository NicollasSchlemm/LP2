using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pimc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImc_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void Calcular_Click(object sender, EventArgs e)
        {
            Double Peso, Altura, Imc;

            if (Double.TryParse(txtPeso.Text, out Peso))
                if (Double.TryParse(txtAltura.Text, out Altura))
                {
                    Imc = Peso / Math.Pow(Altura, 2);
                     Imc = Math.Round(Imc, 1);
                    txtImc.Text = Convert.ToString(Imc);

                    if (Imc < 18.5) 
                        MessageBox.Show("Magreza");

                    else
                        {
                            if (Imc >= 18.5 & Imc < 25)
                                MessageBox.Show("Normal");

                            else
                            {
                                if (Imc >= 25 & Imc < 30)
                                    MessageBox.Show("Sobrepeso");

                                else
                                {
                                    if (Imc >= 30 & Imc < 40)
                                        MessageBox.Show("Obesidade");
                                }

                            }

                        }
                    if (Imc >= 40)
                        MessageBox.Show("Obesidade Grave");

                }
                else
                {
                    MessageBox.Show("Dados invalidos");
                }
            else
            {
                MessageBox.Show("Dados invalidos");
            }


        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtImc.Clear();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
