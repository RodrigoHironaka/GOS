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
    public partial class frmConsultaUsuario : Form
    {
        public int cod = 0;
        public frmConsultaUsuario()
        {
            InitializeComponent();
            txtPesquisar.Select();
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
            frmCadastroUsuario f = new frmCadastroUsuario(AcaoTela.Inserir);
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
            BLLUsuario bll = new BLLUsuario(cx);
            frmCadastroUsuario f = new frmCadastroUsuario(AcaoTela.Alterar);

            if (dgvDados.SelectedRows.Count == 0) 
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.cod = Convert.ToInt32(dgvDados.SelectedRows[0].Cells[0].Value); 
                ModelUsuario modelo = bll.CarregaModelUsuario(cod);
                if (cod != 0)
                {
                    f.txtCodigo.Text = modelo.IdUsuario.ToString();
                    f.txtNomeDep.Text = modelo.Nome;
                    f.txtSenha.Text = modelo.Senha;

                    //combo Nivel de Acesso
                    if (modelo.NivelAcesso == "ADM")
                        f.cbNivelAcesso.SelectedIndex = 1;
                    else if (modelo.NivelAcesso == "USU")
                        f.cbNivelAcesso.SelectedIndex = 2;

                    //checkBox situação do registro (Ativo ou Inativo)
                    if (modelo.Situacao == "A")
                        f.chbAtivo.Checked = true;
                    else if (modelo.Situacao == "I")
                        f.chbAtivo.Checked = false;
                }
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
                        BLLUsuario bll = new BLLUsuario(cx);
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

        private void TxtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLUsuario bll = new BLLUsuario(cx);
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

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
