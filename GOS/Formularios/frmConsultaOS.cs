using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOS.Formularios
{
    public partial class frmConsultaOS : Form
    {
        public frmConsultaOS()
        {
            InitializeComponent();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            frmCadastroOS f = new frmCadastroOS(AcaoTela.Inserir);
            f.txtSituacao.Text = "ABERTO";
            f.txtDataInicial.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
            f.ShowDialog();
            f.Dispose();
        }
    }
}
