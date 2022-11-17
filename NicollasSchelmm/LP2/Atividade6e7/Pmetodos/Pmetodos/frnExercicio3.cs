using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;    

namespace Pmetodos
{
    public partial class frnExercicio3 : Form
    {
        public frnExercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            txtTexto1.Text = txtTexto1.Text.ToUpper();
            txtTexto2.Text = txtTexto2.Text.ToUpper();

            posicao = txtTexto2.Text.IndexOf(txtTexto1.Text);

            while (posicao >= 0)
            {
                txtTexto2.Text = txtTexto2.Text.Substring(0, posicao) +
                    txtTexto2.Text.Substring(posicao + txtTexto1.Text.Length,
                    txtTexto2.Text.Length - posicao - txtTexto1.Text.Length);

                posicao = txtTexto2.Text.IndexOf(txtTexto1.Text);
            }

        }

        private void bntReaplace_Click(object sender, EventArgs e)
        {
            txtTexto1.Text = txtTexto1.Text.ToUpper();
            txtTexto2.Text = txtTexto2.Text.ToUpper();
            txtTexto2.Text = txtTexto2.Text.Replace(txtTexto1.Text, "");
        }
             
        private void button3_Click(object sender, EventArgs e)
        {
            string auxiliar = txtTexto1.Text;
            char[] arr = auxiliar.ToCharArray();
            Array.Reverse(arr);

            auxiliar = "";
            foreach (char cara in arr)
            {
                auxiliar += cara.ToString();
            }
            txtTexto2.Text = auxiliar;  
        }  
      
    }
}
