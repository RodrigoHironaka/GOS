using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GOS.Relatorios
{
    public partial class frmRelFichaOS : Form
    {
        public frmRelFichaOS()
        {
            InitializeComponent();
        }

        private void frmRelFichaOS_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
