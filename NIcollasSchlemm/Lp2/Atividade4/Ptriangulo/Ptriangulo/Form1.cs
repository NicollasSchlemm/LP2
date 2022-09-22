using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLadoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLadoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Clear();
            txtLadoC.Clear();
            
        }

        private void Resultado_Click(object sender, EventArgs e)
        {
            Double A, B, C;
             

            if (Double.TryParse(txtLadoA.Text, out A))
                if (Double.TryParse(txtLadoB.Text, out B))
                    if (Double.TryParse(txtLadoC.Text, out C))
                    {
                       
                        
                        if (A == B && A == C)
                        {
                            MessageBox.Show("Equilatero");
                        }
                        else if (A == B && A != C)
                        {
                            MessageBox.Show("Isosceles");
                        }
                        else if (A != B && A != C && B != C)
                        {
                            MessageBox.Show("escaleno");
                        }
                        else
                        {
                            MessageBox.Show("Não é um triangulo");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Dados Invalidos");
                    }
                else
                {
                    MessageBox.Show("Dados Invalidos");
                }
            else
            {
                MessageBox.Show("Dados Invalidos");
            }

        }

        private void Sair_Click(object sender, EventArgs e)
        {
            Close();
;        }
    }
}
