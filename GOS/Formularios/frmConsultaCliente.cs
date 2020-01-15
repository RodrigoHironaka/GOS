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
        }

        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLUsuario bll = new BLLUsuario(cx);
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
            frmCadastroCliente f = new frmCadastroCliente(AcaoTela.Alterar); // acao na tela para verificar se é incluir ou alterar

            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.cod = Convert.ToInt32(dgvDados.SelectedRows[0].Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModelCliente modelo = bll.CarregaModelCliente(cod);
                if (cod != 0)
                {
                    f.txtCodigo.Text = modelo.IdCliente.ToString();
                    f.txtNomeFantasia.Text = modelo.Nome;
                    f.txtCPFCNPJ.Text = modelo.CPFCNPJ;
                    f.txtRGIE.Text = modelo.RGIE;
                    f.txtRazaoSocial.Text = modelo.RazaoSocial;
                    f.cbTipoPessoa.Text = modelo.TipoPessoa;
                    f.txtCEP.Text = modelo.CEP;
                    f.txtEndereco.Text = modelo.Endereco;
                    f.txtNumero.Text = modelo.EndNumero;
                    f.txtComplemento.Text = modelo.Complemento;
                    f.txtBairro.Text = modelo.Bairro;
                    f.txtTelefone.Text = modelo.Telefone;
                    f.txtCelular.Text = modelo.Celular;
                    f.txtCelular2.Text = modelo.Celular2;
                    f.txtEmail.Text = modelo.Email;
                    f.txtCidade.Text = modelo.Cidade;
                    f.cbUF.Text = modelo.UF;
                    f.txtDataNasc.Text = modelo.DataNasc.ToString();
                    f.txtDataCadastro.Text = modelo.DataCadastro;
                    f.cbDepartamento.Text = modelo.IdDepartamento.ToString();
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
    }
}