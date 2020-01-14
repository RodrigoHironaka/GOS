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
    public partial class frmConsultaDepartamento : Form
    {
        public int cod = 0; //guarda o codigo da linha seleiconada no grid
        public frmConsultaDepartamento()
        {
            InitializeComponent();
            txtPesquisar.Select();
        }
        private void BtnIncluir_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLDepartamento bll = new BLLDepartamento(cx);
            frmCadastroDepartamento f = new frmCadastroDepartamento(AcaoTela.Inserir);
            f.ShowDialog();
            f.Dispose();
            if (chbPesqInativos.Checked == false)
                dgvDados.DataSource = bll.carregaGrid();
            else if (chbPesqInativos.Checked == true)
                dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
            dgvDados.ClearSelection();

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
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
                        BLLDepartamento bll = new BLLDepartamento(cx);
                        bll.Excluir(Convert.ToInt32(dgvDados.CurrentRow.Cells[0].Value));
                        MessageBox.Show("Registro excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (chbPesqInativos.Checked == false)
                            dgvDados.DataSource = bll.carregaGrid();
                        else if (chbPesqInativos.Checked == true)
                            dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
                        dgvDados.ClearSelection();
                    }
                }  
            }
            catch
            {MessageBox.Show("Impossivel excluir o registro. \n O registro esta sendo usado em outro local");}
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
            BLLDepartamento bll = new BLLDepartamento(cx);
            frmCadastroDepartamento f = new frmCadastroDepartamento(AcaoTela.Alterar); // acao na tela para verificar se é incluir ou alterar
           
            if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
            {
                MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.cod = Convert.ToInt32(dgvDados.SelectedRows[0].Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
                ModelDepartamento modelo = bll.CarregaModelDepartamento(cod);
                if(cod != 0)
                {
                    f.txtCodigo.Text = modelo.IdDep.ToString();
                    f.txtNomeDep.Text = modelo.Nome;
                    if (modelo.Situacao == "A")
                        f.chbAtivo.Checked = true;
                    else if (modelo.Situacao == "I")
                        f.chbAtivo.Checked = false;
                }
                f.ShowDialog();
                f.Dispose();
                if(chbPesqInativos.Checked == false)
                    dgvDados.DataSource = bll.carregaGrid();
                else if(chbPesqInativos.Checked == true)
                    dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
                dgvDados.ClearSelection();   
            }
        }

        private void TxtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
                BLLDepartamento bll = new BLLDepartamento(cx);
                if (chbPesqInativos.Checked == false)
                {
                    dgvDados.DataSource = bll.Localizar(txtPesquisar.Text);
                }
                else if(chbPesqInativos.Checked == true)
                {
                    dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

    }
}
