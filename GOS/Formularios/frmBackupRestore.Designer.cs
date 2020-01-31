namespace GOS.Formularios
{
    partial class frmBackupRestore
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
            this.tcBackupRestore = new System.Windows.Forms.TabControl();
            this.tabPBackup = new System.Windows.Forms.TabPage();
            this.lbRealizado = new System.Windows.Forms.Label();
            this.btBackup = new System.Windows.Forms.Button();
            this.tabPRestore = new System.Windows.Forms.TabPage();
            this.lbRestoreRealizado = new System.Windows.Forms.Label();
            this.btRestore = new System.Windows.Forms.Button();
            this.tcBackupRestore.SuspendLayout();
            this.tabPBackup.SuspendLayout();
            this.tabPRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcBackupRestore
            // 
            this.tcBackupRestore.Controls.Add(this.tabPBackup);
            this.tcBackupRestore.Controls.Add(this.tabPRestore);
            this.tcBackupRestore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcBackupRestore.Location = new System.Drawing.Point(12, 12);
            this.tcBackupRestore.Name = "tcBackupRestore";
            this.tcBackupRestore.SelectedIndex = 0;
            this.tcBackupRestore.Size = new System.Drawing.Size(346, 256);
            this.tcBackupRestore.TabIndex = 0;
            // 
            // tabPBackup
            // 
            this.tabPBackup.Controls.Add(this.lbRealizado);
            this.tabPBackup.Controls.Add(this.btBackup);
            this.tabPBackup.Location = new System.Drawing.Point(4, 29);
            this.tabPBackup.Name = "tabPBackup";
            this.tabPBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tabPBackup.Size = new System.Drawing.Size(338, 223);
            this.tabPBackup.TabIndex = 0;
            this.tabPBackup.Text = "Backup";
            this.tabPBackup.UseVisualStyleBackColor = true;
            // 
            // lbRealizado
            // 
            this.lbRealizado.AutoSize = true;
            this.lbRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbRealizado.ForeColor = System.Drawing.Color.Green;
            this.lbRealizado.Location = new System.Drawing.Point(1, 122);
            this.lbRealizado.Name = "lbRealizado";
            this.lbRealizado.Size = new System.Drawing.Size(338, 25);
            this.lbRealizado.TabIndex = 1;
            this.lbRealizado.Text = "Backup Realizado com sucesso!!!";
            this.lbRealizado.Visible = false;
            // 
            // btBackup
            // 
            this.btBackup.BackColor = System.Drawing.Color.Gainsboro;
            this.btBackup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBackup.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBackup.Location = new System.Drawing.Point(6, 6);
            this.btBackup.Name = "btBackup";
            this.btBackup.Size = new System.Drawing.Size(326, 75);
            this.btBackup.TabIndex = 0;
            this.btBackup.Text = "Realizar Backup";
            this.btBackup.UseVisualStyleBackColor = false;
            this.btBackup.Click += new System.EventHandler(this.btBackup_Click);
            // 
            // tabPRestore
            // 
            this.tabPRestore.Controls.Add(this.lbRestoreRealizado);
            this.tabPRestore.Controls.Add(this.btRestore);
            this.tabPRestore.Location = new System.Drawing.Point(4, 29);
            this.tabPRestore.Name = "tabPRestore";
            this.tabPRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPRestore.Size = new System.Drawing.Size(338, 223);
            this.tabPRestore.TabIndex = 1;
            this.tabPRestore.Text = "Restore";
            this.tabPRestore.UseVisualStyleBackColor = true;
            // 
            // lbRestoreRealizado
            // 
            this.lbRestoreRealizado.AutoSize = true;
            this.lbRestoreRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.lbRestoreRealizado.ForeColor = System.Drawing.Color.Green;
            this.lbRestoreRealizado.Location = new System.Drawing.Point(0, 131);
            this.lbRestoreRealizado.Name = "lbRestoreRealizado";
            this.lbRestoreRealizado.Size = new System.Drawing.Size(340, 25);
            this.lbRestoreRealizado.TabIndex = 2;
            this.lbRestoreRealizado.Text = "Restore Realizado com sucesso!!!";
            this.lbRestoreRealizado.Visible = false;
            // 
            // btRestore
            // 
            this.btRestore.BackColor = System.Drawing.Color.Gainsboro;
            this.btRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRestore.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRestore.Location = new System.Drawing.Point(6, 6);
            this.btRestore.Name = "btRestore";
            this.btRestore.Size = new System.Drawing.Size(326, 75);
            this.btRestore.TabIndex = 1;
            this.btRestore.Text = "Realizar Restore";
            this.btRestore.UseVisualStyleBackColor = false;
            this.btRestore.Click += new System.EventHandler(this.btRestore_Click);
            // 
            // frmBackupRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 278);
            this.Controls.Add(this.tcBackupRestore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBackupRestore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup / Restore";
            this.tcBackupRestore.ResumeLayout(false);
            this.tabPBackup.ResumeLayout(false);
            this.tabPBackup.PerformLayout();
            this.tabPRestore.ResumeLayout(false);
            this.tabPRestore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcBackupRestore;
        private System.Windows.Forms.TabPage tabPBackup;
        private System.Windows.Forms.TabPage tabPRestore;
        private System.Windows.Forms.Button btBackup;
        private System.Windows.Forms.Button btRestore;
        private System.Windows.Forms.Label lbRealizado;
        private System.Windows.Forms.Label lbRestoreRealizado;
    }
}