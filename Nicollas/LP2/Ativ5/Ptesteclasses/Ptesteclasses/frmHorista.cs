using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ptesteclasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void txtMatricula_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmHorista_Load(object sender, EventArgs e)
        {

        }

        private void butInstanciarHorista_Click(object sender, EventArgs e)
        {
            Horista objHorista = new Horista();

            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEnt.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalaHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumHora.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtDiasFalta.Text);
            if (rbtnSim.Checked)
                objHorista.HomeOffice = 'S';
            else
                objHorista.HomeOffice = 'N';

            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" +
                     "Nome: " + objHorista.NomeEmpregado + "\n" +
              "Data Entrada: " +
              objHorista.DataEntradaEmpresa.ToShortDateString() +
               "\n" +
               "Salário Bruto: " + objHorista.SalarioBruto().ToString("N2")
               + "\n" +
               "Tempo Empresa (dias): " + objHorista.TempoTrabalho() +
               '\n' + objHorista.VerificaHome());
        }
    }
}
