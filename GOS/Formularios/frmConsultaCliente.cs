using BLL;
using DAL;
using Model;
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
    public partial class frmConsultaCliente : Form
    {
        public int cod = 0;

        public frmConsultaCliente()
        {
            InitializeComponent();            
            txtPesquisar.Select();
        }

        public frmConsultaCliente(bool selecao)
        {
            InitializeComponent();
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            dgvDados.DataSource = bll.LocalizarTodosAtivos();
            dgvDados.Select();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            frmCadastroCliente f = new frmCadastroCliente(AcaoTela.Inserir);
            f.ShowDialog();
            f.Dispose();
            if (chbPesqAtivos.Checked == true)
            {
                lbAtencao.Visible = false;
                dgvDados.DataSource = bll.LocalizarAtivos(txtPesquisar.Text);
                chbPesqAtivos.ForeColor = Color.Black;
                chbPesqInativos.ForeColor = Color.Black;
            }
            else if (chbPesqInativos.Checked == true)
            {
                lbAtencao.Visible = false;
                dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
                chbPesqAtivos.ForeColor = Color.Black;
                chbPesqInativos.ForeColor = Color.Black;
            }

            if (chbPesqAtivos.Checked == true && chbPesqInativos.Checked == true)
            {
                lbAtencao.Visible = false;
                dgvDados.DataSource = bll.carregaGrid();
                chbPesqAtivos.ForeColor = Color.Black;
                chbPesqInativos.ForeColor = Color.Black;
            }
            else if (chbPesqAtivos.Checked == false && chbPesqInativos.Checked == false)
            {
                lbAtencao.Visible = true;
                chbPesqAtivos.ForeColor = Color.Red;
                chbPesqInativos.ForeColor = Color.Red;
                ((DataTable)dgvDados.DataSource).Rows.Clear();
            }
            dgvDados.ClearSelection();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);

            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.cod = Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModelCliente modelo = bll.CarregaModelCliente(cod);
                frmCadastroCliente f = new frmCadastroCliente(AcaoTela.Alterar, modelo); // acao na tela para verificar se é incluir ou alterar
                f.ShowDialog();
                f.Dispose();
                if (chbPesqAtivos.Checked == true)
                {
                    lbAtencao.Visible = false;
                    dgvDados.DataSource = bll.LocalizarAtivos(txtPesquisar.Text);
                    chbPesqAtivos.ForeColor = Color.Black;
                    chbPesqInativos.ForeColor = Color.Black;
                }
                else if (chbPesqInativos.Checked == true)
                {
                    lbAtencao.Visible = false;
                    dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
                    chbPesqAtivos.ForeColor = Color.Black;
                    chbPesqInativos.ForeColor = Color.Black;
                }

                if (chbPesqAtivos.Checked == true && chbPesqInativos.Checked == true)
                {
                    lbAtencao.Visible = false;
                    dgvDados.DataSource = bll.carregaGrid();
                    chbPesqAtivos.ForeColor = Color.Black;
                    chbPesqInativos.ForeColor = Color.Black;
                }
                else if (chbPesqAtivos.Checked == false && chbPesqInativos.Checked == false)
                {
                    lbAtencao.Visible = true;
                    chbPesqAtivos.ForeColor = Color.Red;
                    chbPesqInativos.ForeColor = Color.Red;
                    ((DataTable)dgvDados.DataSource).Rows.Clear();
                }
                dgvDados.ClearSelection();
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    DialogResult d = MessageBox.Show("Deseja excluir o Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d.ToString() == "Yes")
                    {
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLCliente bll = new BLLCliente(cx);
                        bll.Excluir(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if (chbPesqAtivos.Checked == true)
                        {
                            lbAtencao.Visible = false;
                            dgvDados.DataSource = bll.LocalizarAtivos(txtPesquisar.Text);
                            chbPesqAtivos.ForeColor = Color.Black;
                            chbPesqInativos.ForeColor = Color.Black;
                        }
                        else if (chbPesqInativos.Checked == true)
                        {
                            lbAtencao.Visible = false;
                            dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
                            chbPesqAtivos.ForeColor = Color.Black;
                            chbPesqInativos.ForeColor = Color.Black;
                        }

                        if (chbPesqAtivos.Checked == true && chbPesqInativos.Checked == true)
                        {
                            lbAtencao.Visible = false;
                            dgvDados.DataSource = bll.carregaGrid();
                            chbPesqAtivos.ForeColor = Color.Black;
                            chbPesqInativos.ForeColor = Color.Black;
                        }
                        else if (chbPesqAtivos.Checked == false && chbPesqInativos.Checked == false)
                        {
                            lbAtencao.Visible = true;
                            chbPesqAtivos.ForeColor = Color.Red;
                            chbPesqInativos.ForeColor = Color.Red;
                            ((DataTable)dgvDados.DataSource).Rows.Clear();
                        }
                        dgvDados.ClearSelection();
                    }
                }
            }
            catch
            { MessageBox.Show("Impossivel excluir o registro. \n O registro esta sendo usado em outro local"); }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                if (chbPesqAtivos.Checked == true)
                {
                    lbAtencao.Visible = false;
                    dgvDados.DataSource = bll.LocalizarAtivos(txtPesquisar.Text);
                    chbPesqAtivos.ForeColor = Color.Black;
                    chbPesqInativos.ForeColor = Color.Black;
                }
                else if (chbPesqInativos.Checked == true)
                {
                    lbAtencao.Visible = false;
                    dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
                    chbPesqAtivos.ForeColor = Color.Black;
                    chbPesqInativos.ForeColor = Color.Black;
                }

                if (chbPesqAtivos.Checked == true && chbPesqInativos.Checked == true)
                {
                    lbAtencao.Visible = false;
                    dgvDados.DataSource = bll.carregaGrid();
                    chbPesqAtivos.ForeColor = Color.Black;
                    chbPesqInativos.ForeColor = Color.Black;
                }
                else if (chbPesqAtivos.Checked == false && chbPesqInativos.Checked == false)
                {
                    lbAtencao.Visible = true;
                    chbPesqAtivos.ForeColor = Color.Red;
                    chbPesqInativos.ForeColor = Color.Red;
                    ((DataTable)dgvDados.DataSource).Rows.Clear();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void DgvDados_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (e.RowIndex >= 0)
            {
                this.cod = Convert.ToInt32(dgvDados.Rows[e.RowIndex].Cells[0].Value);
                this.Close();
            }
        }
    }
}