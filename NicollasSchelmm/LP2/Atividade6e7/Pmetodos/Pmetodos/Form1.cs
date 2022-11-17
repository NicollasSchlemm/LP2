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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exercicio2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frnExercicio2 frn2 = new frnExercicio2();
            frn2.Show();*/

            Form fc = Application.OpenForms["frnExercicio2"];
            if (fc != null)
                fc.Close();

            frnExercicio2 frn2 = new frnExercicio2();
            frn2.MdiParent = this;
            frn2.WindowState = FormWindowState.Maximized;
            frn2.Show();
        }

        private void exercicio3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frnExercicio3"];
            if (fc != null)
                fc.Close();

            frnExercicio3 frn3 = new frnExercicio3();
            frn3.MdiParent = this;
            frn3.WindowState = FormWindowState.Maximized;
            frn3.Show();
        }

        private void exercicio4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frnExercicio4"];
            if (fc != null)
                fc.Close();

            bntQantLetras frn4 = new bntQantLetras();
            frn4.MdiParent = this;
            frn4.WindowState = FormWindowState.Maximized;
            frn4.Show();
        }

        private void exercicio5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fc = Application.OpenForms["frnExercicio2"];
            if (fc != null)
                fc.Close();

            txtNum1 frn5 = new txtNum1();
            frn5.MdiParent = this;
            frn5.WindowState = FormWindowState.Maximized;
            frn5.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclou CTRL + C");
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teclou CTRL + V");
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

       
    }
}
