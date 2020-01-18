namespace GOS.Formularios
{
    partial class frmConsultaOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultaOS));
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.btnSair = new System.Windows.Forms.Button();
            this.btnIncluir = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.chbPesqAtivos = new System.Windows.Forms.CheckBox();
            this.chbPesqInativos = new System.Windows.Forms.CheckBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lbAtencao = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.groupUsuario = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.groupUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Silver;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(724, 298);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 41);
            this.btnSair.TabIndex = 42;
            this.ttInfo.SetToolTip(this.btnSair, "Sair da tela");
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // btnIncluir
            // 
            this.btnIncluir.BackColor = System.Drawing.Color.Silver;
            this.btnIncluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncluir.Image = ((System.Drawing.Image)(resources.GetObject("btnIncluir.Image")));
            this.btnIncluir.Location = new System.Drawing.Point(724, 91);
            this.btnIncluir.Name = "btnIncluir";
            this.btnIncluir.Size = new System.Drawing.Size(48, 41);
            this.btnIncluir.TabIndex = 39;
            this.ttInfo.SetToolTip(this.btnIncluir, "Incluir registro");
            this.btnIncluir.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Silver;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.Location = new System.Drawing.Point(724, 228);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(48, 41);
            this.btnExcluir.TabIndex = 41;
            this.ttInfo.SetToolTip(this.btnExcluir, "Excluir registro");
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // chbPesqAtivos
            // 
            this.chbPesqAtivos.AutoSize = true;
            this.chbPesqAtivos.Checked = true;
            this.chbPesqAtivos.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbPesqAtivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPesqAtivos.Location = new System.Drawing.Point(608, 28);
            this.chbPesqAtivos.Name = "chbPesqAtivos";
            this.chbPesqAtivos.Size = new System.Drawing.Size(65, 21);
            this.chbPesqAtivos.TabIndex = 14;
            this.chbPesqAtivos.Text = "Ativos";
            this.ttInfo.SetToolTip(this.chbPesqAtivos, "Marque este campo para pesquisar registros inativados.");
            this.chbPesqAtivos.UseVisualStyleBackColor = true;
            // 
            // chbPesqInativos
            // 
            this.chbPesqInativos.AutoSize = true;
            this.chbPesqInativos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbPesqInativos.Location = new System.Drawing.Point(679, 28);
            this.chbPesqInativos.Name = "chbPesqInativos";
            this.chbPesqInativos.Size = new System.Drawing.Size(75, 21);
            this.chbPesqInativos.TabIndex = 13;
            this.chbPesqInativos.Text = "Inativos";
            this.ttInfo.SetToolTip(this.chbPesqInativos, "Marque este campo para pesquisar registros inativados.");
            this.chbPesqInativos.UseVisualStyleBackColor = true;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.Location = new System.Drawing.Point(6, 25);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(596, 24);
            this.txtPesquisar.TabIndex = 0;
            this.ttInfo.SetToolTip(this.txtPesquisar, "Digite aqui para buscar o registro desejado.");
            this.txtPesquisar.WordWrap = false;
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Silver;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterar.Image")));
            this.btnAlterar.Location = new System.Drawing.Point(724, 159);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(48, 41);
            this.btnAlterar.TabIndex = 40;
            this.ttInfo.SetToolTip(this.btnAlterar, "Alterar registro");
            this.btnAlterar.UseVisualStyleBackColor = false;
            // 
            // lbAtencao
            // 
            this.lbAtencao.AutoSize = true;
            this.lbAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAtencao.ForeColor = System.Drawing.Color.Red;
            this.lbAtencao.Location = new System.Drawing.Point(637, 10);
            this.lbAtencao.Name = "lbAtencao";
            this.lbAtencao.Size = new System.Drawing.Size(71, 15);
            this.lbAtencao.TabIndex = 15;
            this.lbAtencao.Text = "ATENÇÃO!!!";
            this.lbAtencao.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Controls.Add(this.lbAtencao);
            this.groupBox2.Controls.Add(this.chbPesqAtivos);
            this.groupBox2.Controls.Add(this.chbPesqInativos);
            this.groupBox2.Controls.Add(this.txtPesquisar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 58);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pesquisar";
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDados.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDados.Location = new System.Drawing.Point(3, 22);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(700, 355);
            this.dgvDados.TabIndex = 1;
            // 
            // groupUsuario
            // 
            this.groupUsuario.Controls.Add(this.dgvDados);
            this.groupUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupUsuario.Location = new System.Drawing.Point(12, 69);
            this.groupUsuario.Name = "groupUsuario";
            this.groupUsuario.Size = new System.Drawing.Size(706, 380);
            this.groupUsuario.TabIndex = 44;
            this.groupUsuario.TabStop = false;
            this.groupUsuario.Text = "Ordem de Serviço(s)";
            // 
            // frmConsultaOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnIncluir);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupUsuario);
            this.Controls.Add(this.btnAlterar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmConsultaOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Ordem de serviços";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.groupUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnIncluir;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.CheckBox chbPesqAtivos;
        private System.Windows.Forms.CheckBox chbPesqInativos;
        public System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lbAtencao;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.GroupBox groupUsuario;
    }
}