using DAL;
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
    }
}
