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
    public partial class txtNum1 : Form
    {
        public txtNum1()
        {
            InitializeComponent();
        }

        private void bntSorteio_Click(object sender, EventArgs e)
        {
            int num1, num2, resultado;
          

            if(int.TryParse(txtNum01.Text, out num1) && int.TryParse(txtNum2.Text, out num2))
            {
                if(num2 < num1)
                {
                    txtNum01.Text = "";
                    txtNum2.Text = "";
                    MessageBox.Show("O segundo numero tem que ser maio que o primeiro");
                }
                else
                {
                    Random sorteio =  new Random();
                    resultado = sorteio.Next(num1, num2);
                    MessageBox.Show(resultado.ToString());

                }
            }
        }
    }
}
