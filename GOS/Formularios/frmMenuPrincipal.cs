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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            ssDataHora.Text = System.DateTime.Now.ToLongDateString() + " - " + System.DateTime.Now.ToLongTimeString();
            this.Text = "Menu Principal V." + Application.ProductVersion;
        }

        private void DepartamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaDepartamento f = new frmConsultaDepartamento();
            f.MdiParent = this;
            f.Show();
        }

        private void ToolStripSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SsDataHora_Click(object sender, EventArgs e)
        {
            ssDataHora.Text = System.DateTime.Now.ToLongDateString() + " - " + System.DateTime.Now.ToLongTimeString();
        }

        private void ServiçosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaServico f = new frmConsultaServico();
            f.MdiParent = this;
            f.Show();
        }

        private void UsuáriosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario f = new frmConsultaUsuario();
            f.MdiParent = this;
            f.Show();
        }

        private void ClientesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaCliente f = new frmConsultaCliente();
            f.MdiParent = this;
            f.Show();
        }

        private void OrdemDeServiçoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaOS f = new frmConsultaOS();
            f.MdiParent = this;
            f.Show();
        }
    }
}
