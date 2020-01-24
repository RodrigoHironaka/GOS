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
            cbSituacao.SelectedIndex = 1;
            txtPesquisar.Select();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            frmCadastroOS f = new frmCadastroOS(AcaoTela.Inserir);
            f.txtSituacao.Text = "ABERTO";
            f.txtDataInicial.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
            f.ShowDialog();
            f.Dispose();
            dgvDados.ClearSelection();
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            //Cancelando
            try
            {
                if (dgvDados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult d = MessageBox.Show("Deseja realmente cancelar esta Ordem de Serviço? ", "Aviso", MessageBoxButtons.YesNo);
                    if (d.ToString() == "Yes")
                    {
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLOrdemServico bll = new BLLOrdemServico(cx);
                        if (bll.CancelarOS(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value)) == true)
                        {
                            MessageBox.Show("OS cancelada com sucesso");
                            dgvDados.DataSource = bll.LocalizarAbertos(txtPesquisar.Text);
                        }

                        else
                        {
                            MessageBox.Show("Não foi possivel cancelar a OS. \nConsulte o suporte tecnico.");
                        }
                        dgvDados.ClearSelection();
                    }
                }
               
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void TxtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLOrdemServico bll = new BLLOrdemServico(cx);
                if (cbSituacao.SelectedIndex == 0)
                {
                    dgvDados.DataSource = bll.LocalizarTodos(txtPesquisar.Text);
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

        private void dgvDados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgvDados.Columns[e.ColumnIndex].Name == "situacao")
            {
                if (e.Value != null && (string)e.Value == "CANCELADO")
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLOrdemServico bll = new BLLOrdemServico(cx);
                if (cbSituacao.SelectedIndex == 0)
                {
                    dgvDados.DataSource = bll.LocalizarTodos(txtPesquisar.Text);
                    dgvDados.ClearSelection();
                }
                else if (cbSituacao.SelectedIndex == 1)
                {
                    dgvDados.DataSource = bll.LocalizarAbertos(txtPesquisar.Text); 
                    dgvDados.ClearSelection();
                }
                else if (cbSituacao.SelectedIndex == 2)
                {
                    dgvDados.DataSource = bll.LocalizarFinalizados(txtPesquisar.Text);
                    dgvDados.ClearSelection();
                }
                else if (cbSituacao.SelectedIndex == 3)
                {
                    dgvDados.DataSource = bll.LocalizarCancelados(txtPesquisar.Text);
                    dgvDados.ClearSelection();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}
