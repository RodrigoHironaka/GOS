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

            //verifica se o checkbox Inativo esta marcado e filtra de acordo com a escolha
            if (chbPesqInativos.Checked == false)
                dgvDados.DataSource = bll.carregaGrid();
            else if (chbPesqInativos.Checked == true)
                dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
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

                //verifica se o checkbox Inativo esta marcado e filtra de acordo com a escolha
                if (chbPesqInativos.Checked == false)
                    dgvDados.DataSource = bll.carregaGrid();
                else if (chbPesqInativos.Checked == true)
                    dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
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

                        //verifica se o checkbox Inativo esta marcado e filtra de acordo com a escolha
                        if (chbPesqInativos.Checked == false)
                            dgvDados.DataSource = bll.carregaGrid();
                        else if (chbPesqInativos.Checked == true)
                            dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
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
                if (chbPesqInativos.Checked == false)
                {
                    dgvDados.DataSource = bll.Localizar(txtPesquisar.Text);
                }
                else if (chbPesqInativos.Checked == true)
                {
                    dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
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
