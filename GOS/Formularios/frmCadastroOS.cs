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

        public frmCadastroOS(AcaoTela acaoTela, ModelOrdemServico os)
        {
            InitializeComponent();
            if (acaoTela == AcaoTela.Inserir)
            { this.Text = "Cadastro de Cliente - Inserir"; }
            else if (acaoTela == AcaoTela.Alterar)
            {
                this.Text = "Cadastro de Cliente - Alterar";
            }
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

        private void BtAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if ((txtCodServico.Text != "") && (txtNomeServico.Text != ""))
                {
                    String[] i = new String[] { txtCodServico.Text, txtNomeServico.Text, txtDetalhesServico.Text };
                    this.dgvItens.Rows.Add(i);

                    txtCodServico.Clear();
                    txtNomeServico.Clear();
                    txtDetalhesServico.Clear();
                    DialogResult d = MessageBox.Show("Deseja Inserir outro serviço?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (d.ToString() == "Yes")
                    {
                        txtCodServico.Focus();
                    }
                    else
                    {
                        txtObservacao.Select();
                    }
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

        private void TxtObservacao_Click(object sender, EventArgs e)
        {
            if (txtObservacao.Text.Equals(" OBS. GERAL "))
            {
                txtObservacao.Clear();
            }
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            frmConsultaOS f = new frmConsultaOS();
            cx.Conectar();
            cx.IniciarTransacao();

            try
            {
                //Inserindo Dados da Tabela OS
                ModelOrdemServico modeloOS = new ModelOrdemServico();
                modeloOS.DataInicial = txtDataInicial.Text;
                modeloOS.DataFinal = txtDataFinal.Text;
                modeloOS.Situacao = txtSituacao.Text;
                modeloOS.Observacao = txtObservacao.Text;
                modeloOS.IdCliente = Convert.ToInt32(txtCodCliente.Text);
                BLLOrdemServico bllOS = new BLLOrdemServico(cx);

                //Inserindo dados da Tabela OSItens
                ModelOrdemServicoItens modeloOSItens = new ModelOrdemServicoItens();
                BLLOrdemServicoItens bllOSItens = new BLLOrdemServicoItens(cx);

                //Inserir ou alterar
                if (txtCodigo.Text == "")
                {
                    //inclui dados da tabela OS
                    bllOS.Incluir(modeloOS);

                    //Percorre o grid com itens e insere na tabela OSItens
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        modeloOSItens.IdOSItens = i + 1;
                        modeloOSItens.IdOS = modeloOS.IdOS;
                        modeloOSItens.IdServico = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        modeloOSItens.Detalhes = dgvItens.Rows[i].Cells[2].Value.ToString();
                        bllOSItens.Incluir(modeloOSItens);
                    }
                    MessageBox.Show("Ordem de serviço salva com sucesso: Código " + modeloOS.IdOS.ToString());
                }
                else
                {
                    //Alterar
                    modeloOS.IdOS = Int32.Parse(txtCodigo.Text);
                    bllOS.Alterar(modeloOS);
                    bllOSItens.ExcluirTodosOsItens(modeloOS.IdOS);

                    //cadastrar itens da OS
                    for (int i = 0; i < dgvItens.RowCount; i++)
                    {
                        modeloOSItens.IdOSItens = i + 1;
                        modeloOSItens.IdOS = modeloOS.IdOS;
                        modeloOSItens.IdServico = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                        modeloOSItens.Detalhes = dgvItens.Rows[i].Cells[2].Value.ToString();
                        bllOSItens.Incluir(modeloOSItens);
                    }
                    MessageBox.Show("Cadastro Alterado com sucesso!!!");
                    this.Close();

                }
                this.LimpaTela();
                cx.TerminarTransacao();
                cx.Desconectar();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                cx.CancelaTransacao();
                cx.Desconectar();
            }
        }

        public void LimpaTela()
        {
            txtCodigo.Clear();
            txtCodCliente.Clear();
            txtNomeCliente.Clear();
            txtCelCliente.Clear();
            txtCodServico.Clear();
            txtNomeServico.Clear();
            txtDetalhesServico.Clear();
            txtObservacao.Clear();
            dgvItens.Rows.Clear();
        }

        private void TxtCodCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacao para permitir apenas numeros
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TxtCodServico_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacao para permitir apenas numeros
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSituacao_TextChanged(object sender, EventArgs e)
        {
            if (txtSituacao.Text == "CANCELADO")
            {
                pbCancelado.Visible = true;
            }
            else
            {
                pbCancelado.Visible = false;
            }
            if (txtSituacao.Text == "FINALIZADO")
            {
                pbFinalizado.Visible = true;
            }
            else
            {
                pbFinalizado.Visible = false;
            }
        }

        private void btFinalizar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("DESEJA FINALIZAR A ORDEM DE SERVICO?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                txtDataFinal.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
                txtSituacao.Text = "FINALIZADO";

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                cx.Conectar();
                cx.IniciarTransacao();

                try
                {
                    //Inserindo Dados da Tabela OS
                    ModelOrdemServico modeloOS = new ModelOrdemServico();
                    modeloOS.DataInicial = txtDataInicial.Text;
                    modeloOS.DataFinal = txtDataFinal.Text;
                    modeloOS.Situacao = txtSituacao.Text;
                    modeloOS.Observacao = txtObservacao.Text;
                    modeloOS.IdCliente = Convert.ToInt32(txtCodCliente.Text);
                    BLLOrdemServico bllOS = new BLLOrdemServico(cx);

                    //Inserindo dados da Tabela OSItens
                    ModelOrdemServicoItens modeloOSItens = new ModelOrdemServicoItens();
                    BLLOrdemServicoItens bllOSItens = new BLLOrdemServicoItens(cx);


                    if (txtCodigo.Text != "")
                    {
                        //Alterar
                        modeloOS.IdOS = Int32.Parse(txtCodigo.Text);
                        bllOS.Alterar(modeloOS);
                        bllOSItens.ExcluirTodosOsItens(modeloOS.IdOS);

                        //cadastrar itens da OS
                        for (int i = 0; i < dgvItens.RowCount; i++)
                        {
                            modeloOSItens.IdOSItens = i + 1;
                            modeloOSItens.IdOS = modeloOS.IdOS;
                            modeloOSItens.IdServico = Convert.ToInt32(dgvItens.Rows[i].Cells[0].Value);
                            modeloOSItens.Detalhes = dgvItens.Rows[i].Cells[2].Value.ToString();
                            bllOSItens.Incluir(modeloOSItens);
                        }
                        MessageBox.Show("Ordem de serviço finalizado com sucesso!!!");
                    }
                    else
                    {
                        MessageBox.Show("Campo código da OS esta vazia por favor verifique!!!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    this.LimpaTela();
                    cx.TerminarTransacao();
                    cx.Desconectar();
                    this.Close();
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    cx.CancelaTransacao();
                    cx.Desconectar();
                }
            }
            else
            {
                return;
            }

        }

        private void txtCodServico_Leave(object sender, EventArgs e)
        {
            try
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
            catch
            {
                txtCodServico.Clear();
                txtNomeServico.Clear();
            }
        }

        private void btProcurar_Click(object sender, EventArgs e)
        {
            frmConsultaServico f = new frmConsultaServico(true);
            f.ShowDialog();
            if (f.cod != 0)
            {
                txtCodServico.Text = f.cod.ToString();
                txtCodServico_Leave(sender, e);
            }
        }

        public void txtCodCliente_Leave(object sender, EventArgs e)
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
                            txtCodCliente.Select();
                        }
                        else
                        {
                            txtNomeCliente.Text = modelo.Nome;
                            txtCelCliente.Text = modelo.Celular;
                            txtCodServico.Select();
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
                        txtCodCliente.Select();
                    }
                    else
                    {
                        txtNomeCliente.Text = modelo.Nome;
                        txtCelCliente.Text = modelo.Celular;
                        txtCodServico.Select();
                    }
                }
            }
            catch
            {
                txtCodCliente.Clear();
                txtNomeCliente.Clear();
                txtCelCliente.Clear();
                txtCodCliente.Select();
            }
        }
    }
}


