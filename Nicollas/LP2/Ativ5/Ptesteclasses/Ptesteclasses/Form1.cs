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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void butMensalista_Click(object sender, EventArgs e)
        {
            frmMensalista FrmMensalista = new frmMensalista();
            FrmMensalista.Show();
        }

        private void butHorista_Click(object sender, EventArgs e)
        {
            frmHorista FrmHorista = new frmHorista();
            FrmHorista.Show();
        }
    }
}
