using DAL;
using Ferramentas;
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
    public partial class frmBackupRestore : Form
    {
        public frmBackupRestore()
        {
            InitializeComponent();
        }

        private void btBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog d = new SaveFileDialog();
                d.Filter = "Backup Files | *.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @" Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master; User=" +
                        DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SqlServerBackupRestore.BackupDataBase(conexao, nomeBanco, d.FileName);
                    lbRealizado.Visible = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btRestore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog d = new OpenFileDialog();
                d.Filter = "Backup Files | *.bak";
                d.ShowDialog();
                if (d.FileName != "")
                {
                    String nomeBanco = DadosDaConexao.banco;
                    String localBackup = d.FileName;
                    String conexao = @" Data Source=" + DadosDaConexao.servidor + ";Initial Catalog=master; User=" +
                        DadosDaConexao.usuario + ";Password=" + DadosDaConexao.senha;
                    SqlServerBackupRestore.RestauraDatabase(conexao, nomeBanco, d.FileName);
                    lbRestoreRealizado.Visible = true;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
