using BLL;
using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOS.Formularios
{
    public partial class frmCadastroDepartamento : Form
    {
        public frmCadastroDepartamento(AcaoTela acaoTela)
        {
            InitializeComponent();
            if (acaoTela == AcaoTela.Inserir)
            {this.Text = "Cadastro de Departamento - Inserir";}
            else if(acaoTela == AcaoTela.Alterar)
            {this.Text = "Cadastro de Departamento - Alterar";}
            txtNomeDep.Select();
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
            {MessageBox.Show("Não foi possivel sair! Erro: " + ex.Message);}
        }

        private void BtnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                ModelDepartamento modelo = new ModelDepartamento();
                modelo.Nome = txtNomeDep.Text;
                if (chbAtivo.Checked == true)
                    modelo.Situacao = "A";
                else if (chbAtivo.Checked == false)
                    modelo.Situacao = "I";

                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLDepartamento bll = new BLLDepartamento(cx);
                if (txtCodigo.Text == "")
                {
                    bll.Incluir(modelo);
                    MessageBox.Show("Cadastro efetuado: Código " + modelo.IdDep.ToString(), "Informação",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();  
                }
                else
                {
                    modelo.IdDep = Int32.Parse(txtCodigo.Text);
                    bll.Alterar(modelo);
                    MessageBox.Show("Cadastro alterado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                this.LimpaTela();
            }
            catch (Exception erro)
            {MessageBox.Show(erro.Message);}
        }
        private void LimpaTela()
        {
            txtCodigo.Clear();
            txtNomeDep.Clear();
            chbAtivo.Checked = true;
        }

        private void FrmCadastroDepartamento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);

            }
        }
    }
}

