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
            frmCadastroCliente f = new frmCadastroCliente();
            f.ShowDialog();
            f.Dispose();
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
        //    DALConexao cx = new DALConexao(DadosDaConexao.StringDeConexao);
        //    BLLCliente bll = new BLLCliente(cx);
        //    frmCadastroCliente f = new frmCadastroCliente(AcaoTela.Alterar); // acao na tela para verificar se é incluir ou alterar

        //    if (dgvDados.SelectedRows.Count == 0) //verifica se uma linha esta selecionada no grid ou nao
        //    {
        //        MessageBox.Show("Nenhum registro selecionado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    else
        //    {
        //        this.cod = Convert.ToInt32(dgvDados.SelectedRows[0].Cells[0].Value); //cod recebe o valor do codigo da linha selecionada no grid
        //        ModelCliente modelo = bll.CarregaModelCliente(cod);
        //        if (cod != 0)
        //        {
        //            f.txtCodigo.Text = modelo.IdCliente.ToString();
        //            f.txtNomeFantasia.Text = modelo.Nome;
        //            f.txtRazaoSocial.Text = modelo.RazaoSocial;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            f.txtNomeDep.Text = modelo.Nome;
        //            if (modelo.Situacao == "A")
        //                f.chbAtivo.Checked = true;
        //            else if (modelo.Situacao == "I")
        //                f.chbAtivo.Checked = false;
        //        }
        //        f.ShowDialog();
        //        f.Dispose();
        //        if (chbPesqInativos.Checked == false)
        //            dgvDados.DataSource = bll.carregaGrid();
        //        else if (chbPesqInativos.Checked == true)
        //            dgvDados.DataSource = bll.LocalizarInativos(txtPesquisar.Text);
        //        dgvDados.ClearSelection();
            }
    }
}
