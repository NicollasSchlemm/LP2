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
    public partial class frnExercicio2 : Form
    {
        public frnExercicio2()
        {
            InitializeComponent();
        }

        private void bntIGUAIS_Click(object sender, EventArgs e)
        {
            if (String.Compare(txtTexto1.Text, txtTexto2.Text, true) == 0)
            {
                MessageBox.Show("São iguais");
            }
            else
                MessageBox.Show("São diferentes");
        }

        private void bntInserText1NoText2_Click(object sender, EventArgs e)
        {
            int meio = txtTexto2.Text.Length / 2;

            txtTexto2.Text = txtTexto2.Text.Substring(0, meio) + txtTexto1.Text + txtTexto2.Text.Substring(meio, txtTexto2.Text.Length - meio);
        }

        private void bntColocarAsteristico_Click(object sender, EventArgs e)
        {
            int meio = txtTexto1.Text.Length / 2;

            txtTexto2.Text = txtTexto1.Text.Insert(meio, "**");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtTexto1.Clear();
            txtTexto2.Clear();
        }
    }
}
