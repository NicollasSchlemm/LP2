using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class mskbxDESCINSS : Form
    {
        public mskbxDESCINSS()
        {
            InitializeComponent();     
        }

        private void bntVERIDADOS_Click(object sender, EventArgs e)
        {
            double salarioBruto, numeroFilhos, DescontoINSS, DescontoIRPF, SalarioFamilia, salarioLiquido;

            if ( !double.TryParse(mskbxSalarioBruto.Text, out salarioBruto)
                || !double.TryParse(nudNumFIlho.Text, out numeroFilhos))
            {
                MessageBox.Show("Salario bruto e numeros de filhos deve ser NUmericos");
            }
            else
            {
                if (salarioBruto <= 0)
                {
                    MessageBox.Show("O salario deve ser maior que 0");
                }
                else
                {
                    if (salarioBruto <= 800.46)
                    {
                        mskbxALIINSS.Text = "7,65%";
                        DescontoINSS = 0.0765 * salarioBruto;
                        mskbxINSSDESC.Text = Convert.ToString(DescontoINSS);
                    }
                    else if (salarioBruto <= 1050)
                    {
                        mskbxALIINSS.Text = "8,65%";
                        DescontoINSS = 0.0865 * salarioBruto;
                        mskbxINSSDESC.Text = Convert.ToString(DescontoINSS);
                    }
                    else if (salarioBruto <= 1400.77)
                    {
                        mskbxALIINSS.Text = "9%";
                        DescontoINSS = 0.09 * salarioBruto;
                        mskbxINSSDESC.Text = Convert.ToString(DescontoINSS);
                    }
                    else if (salarioBruto <= 2801.56)
                    {
                        mskbxALIINSS.Text = "11%";
                        DescontoINSS = 0.11 * salarioBruto;
                        mskbxINSSDESC.Text = Convert.ToString(DescontoINSS);
                    }
                    else
                    {
                        mskbxALIINSS.Text = "Teto";
                        DescontoINSS = 308.17;
                        mskbxINSSDESC.Text = Convert.ToString(DescontoINSS);
                    }
                    if (salarioBruto <= 1257.12)
                    {
                        mskbxALIIRPF.Text = "Isento";
                        DescontoIRPF = 0;
                        mskbxDESCIRPF.Text = Convert.ToString(DescontoIRPF);
                    }
                    else if (salarioBruto <= 2512.08)
                    {
                        mskbxALIIRPF.Text = "15%";
                        DescontoIRPF = 0.15 * salarioBruto;
                        mskbxDESCIRPF.Text = Convert.ToString(DescontoIRPF);
                    }
                    else
                    {
                        mskbxALIIRPF.Text = "27.5%";
                        DescontoIRPF = 0.275 * salarioBruto;
                        mskbxDESCIRPF.Text = Convert.ToString(DescontoIRPF);
                    }
                    double.TryParse(nudNumFIlho.Text, out numeroFilhos);
                    if (salarioBruto <= 435.52)
                    {
                        SalarioFamilia = numeroFilhos * 22.33;
                        mskbxSAlaFami.Text = Convert.ToString(SalarioFamilia);
                    }
                    else if (salarioBruto <= 654.61)
                    {
                        SalarioFamilia = numeroFilhos * 15.74;
                        mskbxSAlaFami.Text = Convert.ToString(SalarioFamilia);
                    }
                    else
                    {
                        SalarioFamilia = 0;
                        mskbxSAlaFami.Text = Convert.ToString(SalarioFamilia);
                    }

                    salarioLiquido = salarioBruto - DescontoINSS - DescontoIRPF + SalarioFamilia;
                    mskbxSALALIQUI.Text = Convert.ToString(salarioLiquido);

                    string sexo, estadocivil;

                    if (rbtnMasculino.Checked)
                    {
                        sexo = "Sr.";
                    }
                    else 
                    {
                        sexo = "Sra.";
                    }
                    if (ckbutCAsado.Checked)
                    {
                        estadocivil = "casado(a)";
                    }
                    else
                    {
                        estadocivil = "solteiro(a)";
                    }

                    lbDados.Text = "Os descontos " + sexo + txtNome.Text + " que é " + estadocivil + " e que tem " + numeroFilhos + " filhos.";


                



                }
            }
        }

        private void lbDados_Click(object sender, EventArgs e)
        {
            
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            mskbxSalarioBruto.Clear();
            nudNumFIlho.Minimum = 0;
            mskbxALIINSS.Clear();
            mskbxALIIRPF.Clear();
            mskbxINSSDESC.Clear();
            mskbxDESCIRPF.Clear();
            mskbxSAlaFami.Clear();
            mskbxSALALIQUI.Clear();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
