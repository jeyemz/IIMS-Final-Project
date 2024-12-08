namespace IIMS_Final_Project
{
    partial class BackupAndRecovery
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl_BackupPath = new System.Windows.Forms.Label();
            this.btn_Backup = new System.Windows.Forms.Button();
            this.btn_BrowseBackup = new System.Windows.Forms.Button();
            this.txtbox_BackupPath = new System.Windows.Forms.TextBox();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Restore = new System.Windows.Forms.Button();
            this.btn_BrowseRestore = new System.Windows.Forms.Button();
            this.txtbox_RestorePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(578, 196);
            this.tabControl1.TabIndex = 76;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage1.Controls.Add(this.lbl_BackupPath);
            this.tabPage1.Controls.Add(this.btn_Backup);
            this.tabPage1.Controls.Add(this.btn_BrowseBackup);
            this.tabPage1.Controls.Add(this.txtbox_BackupPath);
            this.tabPage1.Controls.Add(this.lbl_Title);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(570, 170);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            // 
            // lbl_BackupPath
            // 
            this.lbl_BackupPath.AutoSize = true;
            this.lbl_BackupPath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BackupPath.Location = new System.Drawing.Point(33, 53);
            this.lbl_BackupPath.Name = "lbl_BackupPath";
            this.lbl_BackupPath.Size = new System.Drawing.Size(96, 13);
            this.lbl_BackupPath.TabIndex = 83;
            this.lbl_BackupPath.Text = "Backup File Path:";
            // 
            // btn_Backup
            // 
            this.btn_Backup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Backup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Backup.Location = new System.Drawing.Point(36, 101);
            this.btn_Backup.Name = "btn_Backup";
            this.btn_Backup.Size = new System.Drawing.Size(98, 30);
            this.btn_Backup.TabIndex = 79;
            this.btn_Backup.Text = "Backup";
            this.btn_Backup.UseVisualStyleBackColor = false;
            this.btn_Backup.Click += new System.EventHandler(this.btn_Backup_Click);
            // 
            // btn_BrowseBackup
            // 
            this.btn_BrowseBackup.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BrowseBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BrowseBackup.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowseBackup.Location = new System.Drawing.Point(442, 67);
            this.btn_BrowseBackup.Name = "btn_BrowseBackup";
            this.btn_BrowseBackup.Size = new System.Drawing.Size(100, 30);
            this.btn_BrowseBackup.TabIndex = 78;
            this.btn_BrowseBackup.Text = "Browse";
            this.btn_BrowseBackup.UseVisualStyleBackColor = false;
            this.btn_BrowseBackup.Click += new System.EventHandler(this.btn_BrowseBackup_Click);
            // 
            // txtbox_BackupPath
            // 
            this.txtbox_BackupPath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbox_BackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_BackupPath.Location = new System.Drawing.Point(36, 71);
            this.txtbox_BackupPath.Name = "txtbox_BackupPath";
            this.txtbox_BackupPath.ReadOnly = true;
            this.txtbox_BackupPath.Size = new System.Drawing.Size(396, 20);
            this.txtbox_BackupPath.TabIndex = 76;
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Title.Location = new System.Drawing.Point(31, 28);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(169, 25);
            this.lbl_Title.TabIndex = 75;
            this.lbl_Title.Text = "Database Backup:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.btn_Restore);
            this.tabPage2.Controls.Add(this.btn_BrowseRestore);
            this.tabPage2.Controls.Add(this.txtbox_RestorePath);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(570, 170);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 88;
            this.label2.Text = "Backup File Path:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(6, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 87;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Restore
            // 
            this.btn_Restore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Restore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Restore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Restore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_Restore.Location = new System.Drawing.Point(36, 101);
            this.btn_Restore.Name = "btn_Restore";
            this.btn_Restore.Size = new System.Drawing.Size(98, 30);
            this.btn_Restore.TabIndex = 86;
            this.btn_Restore.Text = "Restore";
            this.btn_Restore.UseVisualStyleBackColor = false;
            this.btn_Restore.Click += new System.EventHandler(this.btn_Restore_Click);
            // 
            // btn_BrowseRestore
            // 
            this.btn_BrowseRestore.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_BrowseRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BrowseRestore.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BrowseRestore.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BrowseRestore.Location = new System.Drawing.Point(442, 67);
            this.btn_BrowseRestore.Name = "btn_BrowseRestore";
            this.btn_BrowseRestore.Size = new System.Drawing.Size(100, 30);
            this.btn_BrowseRestore.TabIndex = 85;
            this.btn_BrowseRestore.Text = "Browse";
            this.btn_BrowseRestore.UseVisualStyleBackColor = false;
            this.btn_BrowseRestore.Click += new System.EventHandler(this.btn_BrowseRestore_Click);
            // 
            // txtbox_RestorePath
            // 
            this.txtbox_RestorePath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbox_RestorePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_RestorePath.Location = new System.Drawing.Point(36, 71);
            this.txtbox_RestorePath.Name = "txtbox_RestorePath";
            this.txtbox_RestorePath.ReadOnly = true;
            this.txtbox_RestorePath.Size = new System.Drawing.Size(396, 20);
            this.txtbox_RestorePath.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Database Restore:";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(518, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(72, 30);
            this.btn_Back.TabIndex = 83;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // BackupAndRecovery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(602, 244);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.tabControl1);
            this.Name = "BackupAndRecovery";
            this.Text = "BackupAndRecovery";
            this.Load += new System.EventHandler(this.BackupAndRecovery_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_Backup;
        private System.Windows.Forms.Button btn_BrowseBackup;
        private System.Windows.Forms.TextBox txtbox_BackupPath;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Restore;
        private System.Windows.Forms.Button btn_BrowseRestore;
        private System.Windows.Forms.TextBox txtbox_RestorePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_BackupPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back;
    }
}