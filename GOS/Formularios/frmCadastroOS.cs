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
    public partial class frmCadastroOS : Form
    {
        public frmCadastroOS(AcaoTela acaoTela)
        {
            InitializeComponent();
            if (acaoTela == AcaoTela.Inserir)
            { this.Text = "Cadastro de Cliente - Inserir"; }
            else if (acaoTela == AcaoTela.Alterar)
            { this.Text = "Cadastro de Cliente - Alterar"; }
            txtCodCliente.Select();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult resultado = MessageBox.Show("Deseja sair sem salvar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                    Close();
            }
            catch (Exception ex)
            { MessageBox.Show("Não foi possivel sair! Erro: " + ex.Message); }
        }

        private void TxtCodCliente_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCodCliente.Text == "")
                {
                    frmConsultaCliente f = new frmConsultaCliente(true);
                    f.ShowDialog();
                    if (f.cod != 0)
                    {
                        txtCodCliente.Text = f.cod.ToString();
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLCliente bll = new BLLCliente(cx);
                        ModelCliente modelo = bll.CarregaModelCliente(Convert.ToInt32(txtCodCliente.Text));
                        if (modelo.IdCliente <= 0)
                        {
                            txtCodCliente.Clear();
                            txtNomeCliente.Clear();
                            txtCelCliente.Clear();
                        }
                        else
                        {
                            txtNomeCliente.Text = modelo.Nome;
                            txtCelCliente.Text = modelo.Celular;
                        }
                    }
                }
                else
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLCliente bll = new BLLCliente(cx);
                    ModelCliente modelo = bll.CarregaModelCliente(Convert.ToInt32(txtCodCliente.Text));
                    if (modelo.IdCliente <= 0)
                    {
                        txtCodCliente.Clear();
                        txtNomeCliente.Clear();
                        txtCelCliente.Clear();
                    }
                    else
                    {
                        txtNomeCliente.Text = modelo.Nome;
                        txtCelCliente.Text = modelo.Celular;
                    }
                }
            }
            catch
            {
                txtCodCliente.Clear();
                txtNomeCliente.Clear();
                txtCelCliente.Clear();
            }
        }

        private void TxtCodServico_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtCodServico.Text == "")
                {
                    frmConsultaServico f = new frmConsultaServico(true);
                    f.ShowDialog();
                    if (f.cod != 0)
                    {
                        txtCodServico.Text = f.cod.ToString();
                        DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                        BLLServico bll = new BLLServico(cx);
                        ModelServico modelo = bll.CarregaModelServico(Convert.ToInt32(txtCodServico.Text));
                        if (modelo.IdServico <= 0)
                        {
                            txtCodServico.Clear();
                            txtNomeServico.Clear();
                        }
                        else
                        {
                            txtNomeServico.Text = modelo.Nome;
                        }
                    }
                }
                else
                {
                    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                    BLLServico bll = new BLLServico(cx);
                    ModelServico modelo = bll.CarregaModelServico(Convert.ToInt32(txtCodServico.Text));
                    if (modelo.IdServico <= 0)
                    {
                        txtCodServico.Clear();
                        txtNomeServico.Clear();
                    }
                    else
                    {
                        txtNomeServico.Text = modelo.Nome;
                    }
                }
            }
            catch
            {
                txtCodServico.Clear();
                txtNomeServico.Clear();
            }
        }

        private void BtAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if((txtCodServico.Text != "") && (txtNomeServico.Text != ""))
                {
                    String[] i = new String[] { txtCodServico.Text, txtNomeServico.Text, txtDetalhesServico.Text };
                    this.dgvItens.Rows.Add(i);

                    txtCodServico.Clear();
                    txtNomeServico.Clear();
                    txtDetalhesServico.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO: " + ex.ToString(), "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtRemover_Click(object sender, EventArgs e)
        {
            if (dgvItens.SelectedRows.Count == 0)
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.dgvItens.Rows.RemoveAt(dgvItens.CurrentRow.Index);
            }
        }

        private void FrmCadastroOS_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void TxtDetalhesServico_Click(object sender, EventArgs e)
        {
            if (txtDetalhesServico.Focus())
            {
                txtDetalhesServico.Text = "";
            }
            else
            {
                txtDetalhesServico.Text = "DIGITE AQUI OS DETALHES DO SERVIÇO A SER FEITO.";
            }
        }
    }
}

