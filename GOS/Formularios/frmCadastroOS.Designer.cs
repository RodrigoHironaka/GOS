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
            this.components = new System.ComponentModel.Container();
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
            this.pbCancelado = new System.Windows.Forms.PictureBox();
            this.btFinalizar = new System.Windows.Forms.Button();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.gbLancarServicos = new System.Windows.Forms.GroupBox();
            this.btProcurar = new System.Windows.Forms.Button();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btAdd = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            this.txtNomeServico = new System.Windows.Forms.TextBox();
            this.txtDetalhesServico = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodServico = new System.Windows.Forms.TextBox();
            this.gbDadosOS = new System.Windows.Forms.GroupBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.pbFinalizado = new System.Windows.Forms.PictureBox();
            this.txtCelCliente = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSituacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataFinal = new System.Windows.Forms.TextBox();
            this.ttInfo = new System.Windows.Forms.ToolTip(this.components);
            this.gbOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelado)).BeginInit();
            this.gbLancarServicos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.gbDadosOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinalizado)).BeginInit();
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
            this.btnGravar.TabIndex = 6;
            this.ttInfo.SetToolTip(this.btnGravar, "Salvar OS");
            this.btnGravar.UseVisualStyleBackColor = false;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Silver;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(504, 447);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(54, 46);
            this.btnSair.TabIndex = 7;
            this.ttInfo.SetToolTip(this.btnSair, "Sair OS");
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
            this.txtDataInicial.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(93, 23);
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
            this.txtCodigo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(2, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 20);
            this.label1.TabIndex = 280;
            this.label1.Text = "OS:";
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeCliente.Location = new System.Drawing.Point(97, 98);
            this.txtNomeCliente.MaxLength = 60;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(324, 24);
            this.txtNomeCliente.TabIndex = 290;
            this.txtNomeCliente.TabStop = false;
            // 
            // lbRazaoNome
            // 
            this.lbRazaoNome.AutoSize = true;
            this.lbRazaoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRazaoNome.ForeColor = System.Drawing.Color.Black;
            this.lbRazaoNome.Location = new System.Drawing.Point(93, 75);
            this.lbRazaoNome.Name = "lbRazaoNome";
            this.lbRazaoNome.Size = new System.Drawing.Size(62, 20);
            this.lbRazaoNome.TabIndex = 263;
            this.lbRazaoNome.Text = "Cliente:";
            // 
            // gbOS
            // 
            this.gbOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gbOS.Controls.Add(this.pbCancelado);
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
            // pbCancelado
            // 
            this.pbCancelado.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelado.Image")));
            this.pbCancelado.Location = new System.Drawing.Point(509, 17);
            this.pbCancelado.Name = "pbCancelado";
            this.pbCancelado.Size = new System.Drawing.Size(48, 48);
            this.pbCancelado.TabIndex = 293;
            this.pbCancelado.TabStop = false;
            this.pbCancelado.Visible = false;
            // 
            // btFinalizar
            // 
            this.btFinalizar.BackColor = System.Drawing.Color.Silver;
            this.btFinalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFinalizar.Image = ((System.Drawing.Image)(resources.GetObject("btFinalizar.Image")));
            this.btFinalizar.Location = new System.Drawing.Point(384, 447);
            this.btFinalizar.Name = "btFinalizar";
            this.btFinalizar.Size = new System.Drawing.Size(54, 46);
            this.btFinalizar.TabIndex = 8;
            this.ttInfo.SetToolTip(this.btFinalizar, "Finalizar OS");
            this.btFinalizar.UseVisualStyleBackColor = false;
            this.btFinalizar.Click += new System.EventHandler(this.btFinalizar_Click);
            // 
            // txtObservacao
            // 
            this.txtObservacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacao.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtObservacao.Location = new System.Drawing.Point(12, 428);
            this.txtObservacao.MaxLength = 300;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.Size = new System.Drawing.Size(366, 65);
            this.txtObservacao.TabIndex = 5;
            this.txtObservacao.Text = "OBS. GERAL";
            this.ttInfo.SetToolTip(this.txtObservacao, "Digite aqui uma observação geral da OS.");
            this.txtObservacao.Click += new System.EventHandler(this.TxtObservacao_Click);
            // 
            // gbLancarServicos
            // 
            this.gbLancarServicos.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbLancarServicos.Controls.Add(this.btProcurar);
            this.gbLancarServicos.Controls.Add(this.dgvItens);
            this.gbLancarServicos.Controls.Add(this.btAdd);
            this.gbLancarServicos.Controls.Add(this.btRemover);
            this.gbLancarServicos.Controls.Add(this.txtNomeServico);
            this.gbLancarServicos.Controls.Add(this.txtDetalhesServico);
            this.gbLancarServicos.Controls.Add(this.label7);
            this.gbLancarServicos.Controls.Add(this.label5);
            this.gbLancarServicos.Controls.Add(this.txtCodServico);
            this.gbLancarServicos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLancarServicos.Location = new System.Drawing.Point(6, 163);
            this.gbLancarServicos.Name = "gbLancarServicos";
            this.gbLancarServicos.Size = new System.Drawing.Size(552, 259);
            this.gbLancarServicos.TabIndex = 300;
            this.gbLancarServicos.TabStop = false;
            this.gbLancarServicos.Text = "Serviço(s)";
            // 
            // btProcurar
            // 
            this.btProcurar.BackColor = System.Drawing.Color.Silver;
            this.btProcurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btProcurar.Image")));
            this.btProcurar.Location = new System.Drawing.Point(71, 36);
            this.btProcurar.Name = "btProcurar";
            this.btProcurar.Size = new System.Drawing.Size(38, 38);
            this.btProcurar.TabIndex = 297;
            this.btProcurar.UseVisualStyleBackColor = false;
            this.btProcurar.Click += new System.EventHandler(this.btProcurar_Click);
            // 
            // dgvItens
            // 
            this.dgvItens.AllowUserToAddRows = false;
            this.dgvItens.AllowUserToDeleteRows = false;
            this.dgvItens.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvItens.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvItens.Location = new System.Drawing.Point(6, 149);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.ReadOnly = true;
            this.dgvItens.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItens.Size = new System.Drawing.Size(535, 104);
            this.dgvItens.TabIndex = 296;
            this.dgvItens.TabStop = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 84;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Serviço";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 86;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Detalhes";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 98;
            // 
            // btAdd
            // 
            this.btAdd.BackColor = System.Drawing.Color.Gainsboro;
            this.btAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdd.Image = ((System.Drawing.Image)(resources.GetObject("btAdd.Image")));
            this.btAdd.Location = new System.Drawing.Point(459, 9);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(38, 38);
            this.btAdd.TabIndex = 3;
            this.btAdd.UseVisualStyleBackColor = false;
            this.btAdd.Click += new System.EventHandler(this.BtAdd_Click);
            // 
            // btRemover
            // 
            this.btRemover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Image = ((System.Drawing.Image)(resources.GetObject("btRemover.Image")));
            this.btRemover.Location = new System.Drawing.Point(503, 9);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(38, 38);
            this.btRemover.TabIndex = 4;
            this.btRemover.UseVisualStyleBackColor = false;
            this.btRemover.Click += new System.EventHandler(this.BtRemover_Click);
            // 
            // txtNomeServico
            // 
            this.txtNomeServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNomeServico.Enabled = false;
            this.txtNomeServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeServico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNomeServico.Location = new System.Drawing.Point(114, 50);
            this.txtNomeServico.MaxLength = 60;
            this.txtNomeServico.Name = "txtNomeServico";
            this.txtNomeServico.Size = new System.Drawing.Size(427, 24);
            this.txtNomeServico.TabIndex = 29;
            this.txtNomeServico.TabStop = false;
            // 
            // txtDetalhesServico
            // 
            this.txtDetalhesServico.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalhesServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalhesServico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDetalhesServico.Location = new System.Drawing.Point(6, 80);
            this.txtDetalhesServico.MaxLength = 300;
            this.txtDetalhesServico.Multiline = true;
            this.txtDetalhesServico.Name = "txtDetalhesServico";
            this.txtDetalhesServico.Size = new System.Drawing.Size(535, 63);
            this.txtDetalhesServico.TabIndex = 2;
            this.ttInfo.SetToolTip(this.txtDetalhesServico, "Digite aqui o que será feito.");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(110, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 291;
            this.label7.Text = "Serviço:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 293;
            this.label5.Text = "Código:";
            // 
            // txtCodServico
            // 
            this.txtCodServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodServico.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodServico.Location = new System.Drawing.Point(6, 50);
            this.txtCodServico.MaxLength = 6;
            this.txtCodServico.Name = "txtCodServico";
            this.txtCodServico.Size = new System.Drawing.Size(59, 24);
            this.txtCodServico.TabIndex = 1;
            this.ttInfo.SetToolTip(this.txtCodServico, "Digite o código do serviço ou de um Enter com o campo em branco para pesquisar.");
            this.txtCodServico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodServico_KeyPress);
            this.txtCodServico.Leave += new System.EventHandler(this.txtCodServico_Leave);
            // 
            // gbDadosOS
            // 
            this.gbDadosOS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gbDadosOS.Controls.Add(this.txtCodCliente);
            this.gbDadosOS.Controls.Add(this.pbFinalizado);
            this.gbDadosOS.Controls.Add(this.txtCelCliente);
            this.gbDadosOS.Controls.Add(this.label8);
            this.gbDadosOS.Controls.Add(this.txtSituacao);
            this.gbDadosOS.Controls.Add(this.label3);
            this.gbDadosOS.Controls.Add(this.label1);
            this.gbDadosOS.Controls.Add(this.txtCodigo);
            this.gbDadosOS.Controls.Add(this.label6);
            this.gbDadosOS.Controls.Add(this.label4);
            this.gbDadosOS.Controls.Add(this.txtDataInicial);
            this.gbDadosOS.Controls.Add(this.txtNomeCliente);
            this.gbDadosOS.Controls.Add(this.label2);
            this.gbDadosOS.Controls.Add(this.lbRazaoNome);
            this.gbDadosOS.Controls.Add(this.txtDataFinal);
            this.gbDadosOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDadosOS.Location = new System.Drawing.Point(6, 25);
            this.gbDadosOS.Name = "gbDadosOS";
            this.gbDadosOS.Size = new System.Drawing.Size(552, 132);
            this.gbDadosOS.TabIndex = 301;
            this.gbDadosOS.TabStop = false;
            this.gbDadosOS.Text = "Dados";
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCodCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCodCliente.Location = new System.Drawing.Point(6, 98);
            this.txtCodCliente.MaxLength = 300;
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(85, 24);
            this.txtCodCliente.TabIndex = 0;
            this.ttInfo.SetToolTip(this.txtCodCliente, "Digite aqui o que será feito.");
            this.txtCodCliente.Leave += new System.EventHandler(this.txtCodCliente_Leave);
            // 
            // pbFinalizado
            // 
            this.pbFinalizado.Image = ((System.Drawing.Image)(resources.GetObject("pbFinalizado.Image")));
            this.pbFinalizado.Location = new System.Drawing.Point(503, -8);
            this.pbFinalizado.Name = "pbFinalizado";
            this.pbFinalizado.Size = new System.Drawing.Size(48, 48);
            this.pbFinalizado.TabIndex = 302;
            this.pbFinalizado.TabStop = false;
            this.pbFinalizado.Visible = false;
            // 
            // txtCelCliente
            // 
            this.txtCelCliente.Enabled = false;
            this.txtCelCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelCliente.Location = new System.Drawing.Point(427, 98);
            this.txtCelCliente.Mask = "(00)00000-0000";
            this.txtCelCliente.Name = "txtCelCliente";
            this.txtCelCliente.Size = new System.Drawing.Size(114, 24);
            this.txtCelCliente.TabIndex = 292;
            this.txtCelCliente.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(425, 75);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 20);
            this.label8.TabIndex = 291;
            this.label8.Text = "Celular:";
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
            this.txtSituacao.TabStop = false;
            this.txtSituacao.TextChanged += new System.EventHandler(this.txtSituacao_TextChanged);
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
            this.txtDataFinal.TabStop = false;
            // 
            // frmCadastroOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(595, 525);
            this.Controls.Add(this.gbOS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastroOS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Cadastro Ordem de Serviço";
            this.gbOS.ResumeLayout(false);
            this.gbOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelado)).EndInit();
            this.gbLancarServicos.ResumeLayout(false);
            this.gbLancarServicos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.gbDadosOS.ResumeLayout(false);
            this.gbDadosOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFinalizado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.TextBox txtDataInicial;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label lbRazaoNome;
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
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtDetalhesServico;
        public System.Windows.Forms.TextBox txtObservacao;
        private System.Windows.Forms.MaskedTextBox txtCelCliente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolTip ttInfo;
        private System.Windows.Forms.PictureBox pbCancelado;
        public System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        public System.Windows.Forms.Button btFinalizar;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.GroupBox gbOS;
        public System.Windows.Forms.GroupBox gbLancarServicos;
        public System.Windows.Forms.GroupBox gbDadosOS;
        private System.Windows.Forms.PictureBox pbFinalizado;
        public System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.Button btProcurar;
    }
}