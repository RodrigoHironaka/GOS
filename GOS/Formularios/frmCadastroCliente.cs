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
    public partial class frmCadastroCliente : Form
    {
        public frmCadastroCliente(AcaoTela acaoTela)
        {
            InitializeComponent();
            if (acaoTela == AcaoTela.Inserir)
            { this.Text = "Cadastro de Cliente - Inserir"; }
            else if (acaoTela == AcaoTela.Alterar)
            { this.Text = "Cadastro de Cliente - Alterar"; }
            cbTipoPessoa.SelectedIndex = 0;
            cbUF.SelectedIndex = 24;
            txtDataCadastro.Text = System.DateTime.Now.ToShortDateString() + " - " + System.DateTime.Now.ToShortTimeString();
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

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelCliente modelo = new ModelCliente();
                modelo.Nome = txtNomeFantasia.Text;
                modelo.CPFCNPJ = txtCPFCNPJ.Text;
                modelo.RGIE = txtRGIE.Text;
                modelo.RazaoSocial = txtRazaoSocial.Text;
                modelo.TipoPessoa = cbTipoPessoa.Text;
                modelo.CEP = txtCEP.Text;
                modelo.Endereco = txtEndereco.Text;
                modelo.EndNumero = txtNumero.Text;
                modelo.Complemento = txtComplemento.Text;
                modelo.Bairro = txtBairro.Text;
                modelo.Telefone = txtTelefone.Text;
                modelo.Celular = txtCelular.Text;
                modelo.Celular2 = txtCelular2.Text;
                modelo.Email = txtEmail.Text;
                modelo.Cidade = txtCidade.Text;
                modelo.UF = cbUF.Text;
                modelo.DataNasc = Convert.ToDateTime(txtDataNasc.Text);
                modelo.DataCadastro = txtDataCadastro.Text;
                modelo.IdDepartamento = Convert.ToInt32(cbDepartamento.Text);

                if (chbAtivo.Checked == true)
                    modelo.Situacao = "A";
                else if (chbAtivo.Checked == false)
                    modelo.Situacao = "I";

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLCliente bll = new BLLCliente(cx);
                if (txtCodigo.Text == "")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.IdCliente.ToString(), "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    modelo.IdCliente = Int32.Parse(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                this.LimpaTela();
            }
            catch (Exception erro)
            { MessageBox.Show(erro.Message); }
        }

        public void LimpaTela()
        {
            txtNomeFantasia.Clear();
            txtCPFCNPJ.Clear();
            txtRGIE.Clear();
            txtRazaoSocial.Clear();
            cbTipoPessoa.SelectedIndex = 0;
            txtCEP.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtTelefone.Clear();
            txtCelular.Clear();
            txtCelular2.Clear();
            txtEmail.Clear();
            txtCidade.Clear();
            cbUF.SelectedIndex = 24;
            txtDataNasc.Value = DateTime.Now;
        }
    }
}
