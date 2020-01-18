namespace GOS.Formularios
{
    partial class frmCadastroOS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastroOS));
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtDataInicial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.lbRazaoNome = new System.Windows.Forms.Label();
            this.gbOS = new System.Windows.Forms.GroupBox();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.gbLancarServicos = new System.Windows.Forms.GroupBox();
            this.dgvServicos = new System.Windows.Forms.DataGridView();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtDetalhesServico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btRemover = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodServico = new System.Windows.Forms.TextBox();
            this.gbDadosOS = new System.Windows.Forms.GroupBox();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.gbOS.SuspendLayout();
            this.gbLancarServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).BeginInit();
            this.gbDadosOS.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGravar
            // 
            this.btnGravar.BackColor = System.Drawing.Color.Silver;
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Image = ((System.Drawing.Image)(resources.GetObject("btnGravar.Image")));
            this.btnGravar.Location = new System.Drawing.Point(444, 447);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(54, 46);
            this.btnGravar.TabIndex = 18;
            this.btnGravar.UseVisualStyleBackColor = false;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Silver;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(504, 447);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 46);
            this.btnSair.TabIndex = 19;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // txtDataInicial
            // 
            this.txtDataInicial.Enabled = false;
            this.txtDataInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataInicial.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDataInicial.Location = new System.Drawing.Point(97, 46);
            this.txtDataInicial.MaxLength = 10;
            this.txtDataInicial.Name = "txtDataInicial";
            this.txtDataInicial.Size = new System.Drawing.Size(144, 24);
            this.txtDataInicial.TabIndex = 262;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(97, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 20);
            this.label6.TabIndex = 283;
            this.label6.Text = "Data Inicial:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodigo.Location = new System.Drawing.Point(6, 46);
            this.txtCodigo.MaxLength = 6;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(85, 24);
            this.txtCodigo.TabIndex = 279;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 280;
            this.label1.Text = "Código:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeCliente.Location = new System.Drawing.Point(97, 98);
            this.txtNomeCliente.MaxLength = 60;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(444, 24);
            this.txtNomeCliente.TabIndex = 1;
            // 
            // lbRazaoNome
            // 
            this.lbRazaoNome.AutoSize = true;
            this.lbRazaoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRazaoNome.ForeColor = System.Drawing.Color.Black;
            this.lbRazaoNome.Location = new System.Drawing.Point(97, 75);
            this.lbRazaoNome.Name = "lbRazaoNome";
            this.lbRazaoNome.Size = new System.Drawing.Size(62, 20);
            this.lbRazaoNome.TabIndex = 263;
            this.lbRazaoNome.Text = "Cliente:";
            // 
            // gbOS
            // 
            this.gbOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbOS.Controls.Add(this.btFinalizar);
            this.gbOS.Controls.Add(this.btnGravar);
            this.gbOS.Controls.Add(this.txtObservacao);
            this.gbOS.Controls.Add(this.btnSair);
            this.gbOS.Controls.Add(this.gbLancarServicos);
            this.gbOS.Controls.Add(this.gbDadosOS);
            this.gbOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOS.Location = new System.Drawing.Point(12, 12);
            this.gbOS.Name = "gbOS";
            this.gbOS.Size = new System.Drawing.Size(570, 501);
            this.gbOS.TabIndex = 14;
            this.gbOS.TabStop = false;
            this.gbOS.Text = "Cadastro de Ordem de Serviço";
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtObservacao.Location = new System.Drawing.Point(12, 447);
            this.txtObservacao.MaxLength = 60;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(366, 46);
            this.txtObservacao.TabIndex = 298;
            this.txtObservacao.Text = "OBS. GERAL";
            // 
            // gbLancarServicos
            // 
            this.gbLancarServicos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbLancarServicos.Controls.Add(this.dgvServicos);
            this.gbLancarServicos.Controls.Add(this.txtNomeServico);
            this.gbLancarServicos.Controls.Add(this.btAdd);
            this.gbLancarServicos.Controls.Add(this.txtDetalhesServico);
            this.gbLancarServicos.Controls.Add(this.label7);
            this.gbLancarServicos.Controls.Add(this.btRemover);
            this.gbLancarServicos.Controls.Add(this.label5);
            this.gbLancarServicos.Controls.Add(this.txtCodServico);
            this.gbLancarServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLancarServicos.Location = new System.Drawing.Point(6, 176);
            this.gbLancarServicos.Name = "gbLancarServicos";
            this.gbLancarServicos.Size = new System.Drawing.Size(552, 265);
            this.gbLancarServicos.TabIndex = 300;
            this.gbLancarServicos.TabStop = false;
            this.gbLancarServicos.Text = "Lançar Serviço(s)";
            // 
            // dgvServicos
            // 
            this.dgvServicos.AllowUserToAddRows = false;
            this.dgvServicos.AllowUserToDeleteRows = false;
            this.dgvServicos.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicos.Location = new System.Drawing.Point(9, 131);
            this.dgvServicos.Name = "dgvServicos";
            this.dgvServicos.ReadOnly = true;
            this.dgvServicos.Size = new System.Drawing.Size(532, 122);
            this.dgvServicos.TabIndex = 296;
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeServico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeServico.Location = new System.Drawing.Point(100, 50);
            this.txtNomeServico.MaxLength = 60;
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(377, 24);
            this.txtNomeServico.TabIndex = 290;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(487, 28);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(54, 46);
            this.btAdd.TabIndex = 294;
            this.btAdd.UseVisualStyleBackColor = false;
            // 
            // txtDetalhesServico
            // 
            this.txtDetalhesServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalhesServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhesServico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDetalhesServico.Location = new System.Drawing.Point(9, 80);
            this.txtDetalhesServico.MaxLength = 60;
            this.txtDetalhesServico.Multiline = true;
            this.txtDetalhesServico.Name = "txtDetalhesServico";
            this.txtDetalhesServico.Size = new System.Drawing.Size(468, 45);
            this.txtDetalhesServico.TabIndex = 297;
            this.txtDetalhesServico.Text = "DETALHES DO SERVIÇO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(96, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 291;
            this.label7.Text = "Serviço:";
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.Location = new System.Drawing.Point(487, 79);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(54, 46);
            this.btRemover.TabIndex = 295;
            this.btRemover.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(5, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 293;
            this.label5.Text = "Código:";
            // 
            // txtCodServico
            // 
            this.txtCodServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodServico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodServico.Location = new System.Drawing.Point(9, 50);
            this.txtCodServico.MaxLength = 6;
            this.txtCodServico.Name = "txtCodServico";
            this.txtCodServico.Size = new System.Drawing.Size(85, 24);
            this.txtCodServico.TabIndex = 292;
            // 
            // gbDadosOS
            // 
            this.gbDadosOS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDadosOS.Controls.Add(this.txtSituacao);
            this.gbDadosOS.Controls.Add(this.label3);
            this.gbDadosOS.Controls.Add(this.label1);
            this.gbDadosOS.Controls.Add(this.txtCodigo);
            this.gbDadosOS.Controls.Add(this.txtCodCliente);
            this.gbDadosOS.Controls.Add(this.label6);
            this.gbDadosOS.Controls.Add(this.label4);
            this.gbDadosOS.Controls.Add(this.txtDataInicial);
            this.gbDadosOS.Controls.Add(this.txtNomeCliente);
            this.gbDadosOS.Controls.Add(this.label2);
            this.gbDadosOS.Controls.Add(this.lbRazaoNome);
            this.gbDadosOS.Controls.Add(this.txtDataFinal);
            this.gbDadosOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosOS.Location = new System.Drawing.Point(6, 25);
            this.gbDadosOS.Name = "gbDadosOS";
            this.gbDadosOS.Size = new System.Drawing.Size(552, 145);
            this.gbDadosOS.TabIndex = 301;
            this.gbDadosOS.TabStop = false;
            // 
            // txtSituacao
            // 
            this.txtSituacao.Enabled = false;
            this.txtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSituacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSituacao.Location = new System.Drawing.Point(397, 46);
            this.txtSituacao.MaxLength = 10;
            this.txtSituacao.Name = "txtSituacao";
            this.txtSituacao.Size = new System.Drawing.Size(144, 24);
            this.txtSituacao.TabIndex = 286;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(391, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 287;
            this.label3.Text = "Situação:";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodCliente.Location = new System.Drawing.Point(6, 98);
            this.txtCodCliente.MaxLength = 6;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(85, 24);
            this.txtCodCliente.TabIndex = 288;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(2, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 289;
            this.label4.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(243, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 20);
            this.label2.TabIndex = 285;
            this.label2.Text = "DataFinal:";
            // 
            // txtDataFinal
            // 
            this.txtDataFinal.Enabled = false;
            this.txtDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataFinal.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDataFinal.Location = new System.Drawing.Point(247, 46);
            this.txtDataFinal.MaxLength = 10;
            this.txtDataFinal.Name = "txtDataFinal";
            this.txtDataFinal.Size = new System.Drawing.Size(144, 24);
            this.txtDataFinal.TabIndex = 284;
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.Silver;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btFinalizar.Image")));
            this.btFinalizar.Location = new System.Drawing.Point(384, 447);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(54, 46);
            this.btFinalizar.TabIndex = 302;
            this.btFinalizar.UseVisualStyleBackColor = false;
            // 
            // frmCadastroOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(593, 525);
            this.Controls.Add(this.gbOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro Ordem de Serviço";
            this.gbOS.ResumeLayout(false);
            this.gbOS.PerformLayout();
            this.gbLancarServicos.ResumeLayout(false);
            this.gbLancarServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicos)).EndInit();
            this.gbDadosOS.ResumeLayout(false);
            this.gbDadosOS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.TextBox txtDataInicial;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lbRazaoNome;
        private System.Windows.Forms.GroupBox gbOS;
        public System.Windows.Forms.TextBox txtSituacao;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtDataFinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.Button btAdd;
        public System.Windows.Forms.TextBox txtCodServico;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtNomeServico;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDetalhesServico;
        private System.Windows.Forms.DataGridView dgvServicos;
        public System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.GroupBox gbLancarServicos;
        private System.Windows.Forms.GroupBox gbDadosOS;
        private System.Windows.Forms.Button btFinalizar;
    }
}