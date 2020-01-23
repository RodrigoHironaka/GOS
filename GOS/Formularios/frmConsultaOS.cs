using BLL;
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
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLOrdemServico bll = new BLLOrdemServico(cx);
            dgvDados.DataSource = bll.LocalizarAbertos(txtPesquisar.Text);
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            frmCadastroOS f = new frmCadastroOS(AcaoTela.Inserir);
            f.txtSituacao.Text = "ABERTO";
            f.txtDataInicial.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
            f.ShowDialog();
            f.Dispose();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {

        }

        private void TxtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLOrdemServico bll = new BLLOrdemServico(cx);
                if (cbSituacao.SelectedIndex == 0)
                {
                    dgvDados.DataSource = bll.LocalizarTodos();
                   
                }
                else if (cbSituacao.SelectedIndex == 1)
                {
                    dgvDados.DataSource = bll.LocalizarAbertos(txtPesquisar.Text);
                }
                else if (cbSituacao.SelectedIndex == 2)
                {
                    dgvDados.DataSource = bll.LocalizarFinalizados(txtPesquisar.Text);
                }
                else if (cbSituacao.SelectedIndex == 3)
                {
                    dgvDados.DataSource = bll.LocalizarCancelados(txtPesquisar.Text);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
