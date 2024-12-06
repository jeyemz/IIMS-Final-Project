namespace IIMS_Final_Project
{
    partial class Reports
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
            this.cmb_ReportType = new System.Windows.Forms.ComboBox();
            this.btn_GenerateReport = new System.Windows.Forms.Button();
            this.dgv_ReportViewer = new System.Windows.Forms.DataGridView();
            this.lbl_Export = new System.Windows.Forms.Label();
            this.txtbox_FilePath = new System.Windows.Forms.TextBox();
            this.btn_BrowseFile = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_BackToMenu = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_ReportType
            // 
            this.cmb_ReportType.FormattingEnabled = true;
            this.cmb_ReportType.Location = new System.Drawing.Point(229, 242);
            this.cmb_ReportType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_ReportType.Name = "cmb_ReportType";
            this.cmb_ReportType.Size = new System.Drawing.Size(298, 28);
            this.cmb_ReportType.TabIndex = 1;
            // 
            // btn_GenerateReport
            // 
            this.btn_GenerateReport.Location = new System.Drawing.Point(549, 208);
            this.btn_GenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GenerateReport.Name = "btn_GenerateReport";
            this.btn_GenerateReport.Size = new System.Drawing.Size(180, 62);
            this.btn_GenerateReport.TabIndex = 2;
            this.btn_GenerateReport.Text = "Generate Report";
            this.btn_GenerateReport.UseVisualStyleBackColor = true;
            this.btn_GenerateReport.Click += new System.EventHandler(this.btn_GenerateReport_Click);
            // 
            // dgv_ReportViewer
            // 
            this.dgv_ReportViewer.AllowUserToAddRows = false;
            this.dgv_ReportViewer.AllowUserToDeleteRows = false;
            this.dgv_ReportViewer.AllowUserToResizeColumns = false;
            this.dgv_ReportViewer.AllowUserToResizeRows = false;
            this.dgv_ReportViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ReportViewer.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgv_ReportViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ReportViewer.Location = new System.Drawing.Point(209, 335);
            this.dgv_ReportViewer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_ReportViewer.MultiSelect = false;
            this.dgv_ReportViewer.Name = "dgv_ReportViewer";
            this.dgv_ReportViewer.ReadOnly = true;
            this.dgv_ReportViewer.RowHeadersWidth = 62;
            this.dgv_ReportViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ReportViewer.Size = new System.Drawing.Size(1068, 580);
            this.dgv_ReportViewer.TabIndex = 3;
            // 
            // lbl_Export
            // 
            this.lbl_Export.AutoSize = true;
            this.lbl_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Export.Location = new System.Drawing.Point(197, 979);
            this.lbl_Export.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Export.Name = "lbl_Export";
            this.lbl_Export.Size = new System.Drawing.Size(170, 30);
            this.lbl_Export.TabIndex = 4;
            this.lbl_Export.Text = "Export to File:";
            // 
            // txtbox_FilePath
            // 
            this.txtbox_FilePath.Location = new System.Drawing.Point(387, 982);
            this.txtbox_FilePath.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtbox_FilePath.Name = "txtbox_FilePath";
            this.txtbox_FilePath.ReadOnly = true;
            this.txtbox_FilePath.Size = new System.Drawing.Size(598, 26);
            this.txtbox_FilePath.TabIndex = 5;
            // 
            // btn_BrowseFile
            // 
            this.btn_BrowseFile.Location = new System.Drawing.Point(1010, 973);
            this.btn_BrowseFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BrowseFile.Name = "btn_BrowseFile";
            this.btn_BrowseFile.Size = new System.Drawing.Size(150, 46);
            this.btn_BrowseFile.TabIndex = 6;
            this.btn_BrowseFile.Text = "Browse";
            this.btn_BrowseFile.UseVisualStyleBackColor = true;
            this.btn_BrowseFile.Click += new System.EventHandler(this.btn_BrowseFile_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(1169, 973);
            this.btn_Export.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(150, 46);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // btn_BackToMenu
            // 
            this.btn_BackToMenu.BackColor = System.Drawing.SystemColors.Control;
            this.btn_BackToMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BackToMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackToMenu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_BackToMenu.Location = new System.Drawing.Point(1127, 178);
            this.btn_BackToMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_BackToMenu.Name = "btn_BackToMenu";
            this.btn_BackToMenu.Size = new System.Drawing.Size(150, 46);
            this.btn_BackToMenu.TabIndex = 83;
            this.btn_BackToMenu.Text = "Menu";
            this.btn_BackToMenu.UseVisualStyleBackColor = false;
            this.btn_BackToMenu.Click += new System.EventHandler(this.btn_BackToMenu_Click);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(1469, 13);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(157, 97);
            this.button10.TabIndex = 89;
            this.button10.Text = "Logout";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(1071, 12);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(168, 97);
            this.button9.TabIndex = 88;
            this.button9.Text = "Reports";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(805, 12);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(247, 97);
            this.button8.TabIndex = 87;
            this.button8.Text = "Task Management";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(535, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(247, 97);
            this.button7.TabIndex = 86;
            this.button7.Text = "Project Management";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(271, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(245, 97);
            this.button6.TabIndex = 85;
            this.button6.Text = "Employee Management";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(9, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(245, 97);
            this.button5.TabIndex = 84;
            this.button5.Text = "Dashboard";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 46);
            this.label1.TabIndex = 90;
            this.label1.Text = "Reports";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel8.Location = new System.Drawing.Point(192, 317);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 616);
            this.panel8.TabIndex = 91;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(192, 923);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1102, 10);
            this.panel5.TabIndex = 92;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Location = new System.Drawing.Point(1284, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 616);
            this.panel1.TabIndex = 92;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(192, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1102, 10);
            this.panel2.TabIndex = 93;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(192, 301);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1102, 10);
            this.panel3.TabIndex = 94;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Location = new System.Drawing.Point(192, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 166);
            this.panel4.TabIndex = 92;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel6.Location = new System.Drawing.Point(1284, 145);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 166);
            this.panel6.TabIndex = 93;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(192, 142);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1102, 10);
            this.panel7.TabIndex = 95;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Location = new System.Drawing.Point(158, 955);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1184, 10);
            this.panel9.TabIndex = 96;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.White;
            this.panel10.Location = new System.Drawing.Point(158, 1027);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1184, 10);
            this.panel10.TabIndex = 97;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel11.Location = new System.Drawing.Point(158, 955);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 83);
            this.panel11.TabIndex = 93;
            // 
            // panel12
            // 
            this.panel12.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel12.Location = new System.Drawing.Point(1332, 955);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(10, 82);
            this.panel12.TabIndex = 94;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Font = new System.Drawing.Font("Palatino Linotype", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(1257, 14);
            this.button11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(197, 95);
            this.button11.TabIndex = 98;
            this.button11.Text = "Department";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1638, 1050);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_BackToMenu);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_BrowseFile);
            this.Controls.Add(this.txtbox_FilePath);
            this.Controls.Add(this.lbl_Export);
            this.Controls.Add(this.dgv_ReportViewer);
            this.Controls.Add(this.btn_GenerateReport);
            this.Controls.Add(this.cmb_ReportType);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel12);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_ReportType;
        private System.Windows.Forms.Button btn_GenerateReport;
        private System.Windows.Forms.DataGridView dgv_ReportViewer;
        private System.Windows.Forms.Label lbl_Export;
        private System.Windows.Forms.TextBox txtbox_FilePath;
        private System.Windows.Forms.Button btn_BrowseFile;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_BackToMenu;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Button button11;
    }
}