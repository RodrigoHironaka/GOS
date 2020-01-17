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
using Ferramentas;
using static Ferramentas.ValidaCEP;

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
                modelo.DataNasc = txtDataNasc.Text;
                modelo.DataCadastro = txtDataCadastro.Text;
                if (chbAtivo.Checked == true)
                    modelo.Situacao = "A";
                else if (chbAtivo.Checked == false)
                    modelo.Situacao = "I";
                modelo.IdDepartamento = Convert.ToInt32(cbDepartamento.SelectedValue);

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
            txtDataNasc.Clear();
        }

        private void FrmCadastroCliente_Load(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLCliente bll = new BLLCliente(cx);
            cbDepartamento.DataSource = bll.CarregaComboDepartamentos();
            cbDepartamento.ValueMember = "id";
            cbDepartamento.DisplayMember = "nome";
            //cbDepartamento.Update();
        }

        private void CbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPessoa.SelectedIndex == 0)
            {
                txtRazaoSocial.Enabled = false;
                lbRGIE.Text = "RG";
                txtRGIE.Mask = "00,000,000-0";
                lbCPFCNPJ.Text = "CPF";
                txtCPFCNPJ.Mask = "000,000,000-00";
                lbRazaoNome.Enabled = false;
                txtNomeFantasia.Text = "";
                lbNomeFantasia.Text = "Nome:";
            }
            else if (cbTipoPessoa.SelectedIndex == 1)
            {
                txtRazaoSocial.Enabled = true;
                lbRGIE.Text = "IE";
                txtRGIE.Mask = "000,000,000,000";
                lbCPFCNPJ.Text = "CNPJ";
                txtCPFCNPJ.Mask = "00,000,000/0000-00";
                lbRazaoNome.Enabled = true;
                lbNomeFantasia.Text = "Nome Fantasia:";
            }
        }

        private void PbCalendario_Click(object sender, EventArgs e)
        {
            mcCalendar.Visible = true;
        }

        private void McCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtDataNasc.Text = Convert.ToString(mcCalendar.SelectionStart.Date.ToShortDateString());
            mcCalendar.Visible = false;
        }

        private void TxtCPFCNPJ_Leave(object sender, EventArgs e)
        {
            pbInvalido.Visible = false;
            string valor = txtCPFCNPJ.Text;
            if (cbTipoPessoa.SelectedIndex == 0)
            {
                if (ValidaCpfCnpj.ValidaCpf(valor) == false)
                {
                    pbInvalido.Visible = true;
                }
                else
                {
                    pbInvalido.Visible = false;
                }
            }
            else if (cbTipoPessoa.SelectedIndex == 1)
            {
                if (ValidaCpfCnpj.ValidaCnpj(valor) == false)
                {
                    pbInvalido.Visible = true;
                }
            }
        }

        private void TxtCEP_Leave(object sender, EventArgs e)
        {
            if (ValidaCEP.ValidaCep(txtCEP.Text) == false)
            {
                pbInvalidoCEP.Visible = true;
                txtBairro.Clear();
                cbUF.SelectedIndex = 24;
                txtCidade.Clear();
                txtEndereco.Clear();
                txtCEP.Clear();
            }
            else
            {
                if (BuscaEndereco.verificaCEP(txtCEP.Text) == true)
                {
                    txtBairro.Text = BuscaEndereco.bairro;
                    cbUF.Text = BuscaEndereco.estado;
                    txtCidade.Text = BuscaEndereco.cidade;
                    txtEndereco.Text = BuscaEndereco.endereco;
                    pbInvalidoCEP.Visible = false;
                }
            }
        }

        private void TxtEmail_Leave(object sender, EventArgs e)
        {
            if(ValidaEmail.validaEmail(txtEmail.Text) == false)
            {
                pbInvalidoEmail.Visible = true;
            }
            else
            {
                if (ValidaEmail.validaEmail(txtEmail.Text) == true)
                {
                    pbInvalidoEmail.Visible = false;
                }
            }
        }

        private void FrmCadastroCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

            }
        }
    }
}
