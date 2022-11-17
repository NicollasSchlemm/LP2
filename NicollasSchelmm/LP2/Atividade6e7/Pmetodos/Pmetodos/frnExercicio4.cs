using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pmetodos
{
    public partial class bntQantLetras : Form
    {
        public bntQantLetras()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bntQuantNum_Click(object sender, EventArgs e)
        {
            string Texto = richTextBox1.Text;
            string aux;

            int i,j=0;

            for (i = 0; i < Texto.Length; i++)
            {

                if (Char.IsNumber(Texto[i]))
                {
                    j++;
                }
            }
            aux = Convert.ToString(j);
            MessageBox.Show(aux);
        }


        private void bntProcuraEspa_Click(object sender, EventArgs e)
        {
            string Texto = richTextBox1.Text;
            string aux;
            int i = 0;
            int posicao = 0;
            while (i < Texto.Length)
            {
                if (!Char.IsWhiteSpace(Texto[i]))
                {
                    i++;
                }
                else
                {
                    posicao = i + 1;
                    break;
                }
            }
             aux = Convert.ToString(posicao);
            MessageBox.Show("O primeiro espaço se localiza na posição "  +  aux);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string aux = richTextBox1.Text;
            int cont=0, j;

            foreach (var i in richTextBox1.Text)
            {
              
                if (char.IsLetter(i))
                    cont++;
            }
            

            MessageBox.Show("Existem " +  cont  + " Caracteres");
        }
    }
}
