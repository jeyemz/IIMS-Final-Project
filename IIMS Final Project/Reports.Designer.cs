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
            this.lbl_Title = new System.Windows.Forms.Label();
            this.cmb_ReportType = new System.Windows.Forms.ComboBox();
            this.btn_GenerateReport = new System.Windows.Forms.Button();
            this.dgv_ReportViewer = new System.Windows.Forms.DataGridView();
            this.lbl_Export = new System.Windows.Forms.Label();
            this.txtbox_FilePath = new System.Windows.Forms.TextBox();
            this.btn_BrowseFile = new System.Windows.Forms.Button();
            this.btn_Export = new System.Windows.Forms.Button();
            this.btn_BackToMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Title.Location = new System.Drawing.Point(20, 20);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(82, 24);
            this.lbl_Title.TabIndex = 0;
            this.lbl_Title.Text = "Reports";
            // 
            // cmb_ReportType
            // 
            this.cmb_ReportType.FormattingEnabled = true;
            this.cmb_ReportType.Location = new System.Drawing.Point(20, 70);
            this.cmb_ReportType.Name = "cmb_ReportType";
            this.cmb_ReportType.Size = new System.Drawing.Size(200, 21);
            this.cmb_ReportType.TabIndex = 1;
            // 
            // btn_GenerateReport
            // 
            this.btn_GenerateReport.Location = new System.Drawing.Point(235, 59);
            this.btn_GenerateReport.Name = "btn_GenerateReport";
            this.btn_GenerateReport.Size = new System.Drawing.Size(120, 40);
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
            this.dgv_ReportViewer.Location = new System.Drawing.Point(40, 118);
            this.dgv_ReportViewer.MultiSelect = false;
            this.dgv_ReportViewer.Name = "dgv_ReportViewer";
            this.dgv_ReportViewer.ReadOnly = true;
            this.dgv_ReportViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ReportViewer.Size = new System.Drawing.Size(700, 400);
            this.dgv_ReportViewer.TabIndex = 3;
            // 
            // lbl_Export
            // 
            this.lbl_Export.AutoSize = true;
            this.lbl_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Export.Location = new System.Drawing.Point(20, 550);
            this.lbl_Export.Name = "lbl_Export";
            this.lbl_Export.Size = new System.Drawing.Size(121, 22);
            this.lbl_Export.TabIndex = 4;
            this.lbl_Export.Text = "Export to File:";
            // 
            // txtbox_FilePath
            // 
            this.txtbox_FilePath.Location = new System.Drawing.Point(147, 552);
            this.txtbox_FilePath.Name = "txtbox_FilePath";
            this.txtbox_FilePath.ReadOnly = true;
            this.txtbox_FilePath.Size = new System.Drawing.Size(400, 20);
            this.txtbox_FilePath.TabIndex = 5;
            // 
            // btn_BrowseFile
            // 
            this.btn_BrowseFile.Location = new System.Drawing.Point(562, 546);
            this.btn_BrowseFile.Name = "btn_BrowseFile";
            this.btn_BrowseFile.Size = new System.Drawing.Size(100, 30);
            this.btn_BrowseFile.TabIndex = 6;
            this.btn_BrowseFile.Text = "Browse";
            this.btn_BrowseFile.UseVisualStyleBackColor = true;
            this.btn_BrowseFile.Click += new System.EventHandler(this.btn_BrowseFile_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Location = new System.Drawing.Point(668, 546);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(100, 30);
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
            this.btn_BackToMenu.Location = new System.Drawing.Point(669, 14);
            this.btn_BackToMenu.Name = "btn_BackToMenu";
            this.btn_BackToMenu.Size = new System.Drawing.Size(100, 30);
            this.btn_BackToMenu.TabIndex = 83;
            this.btn_BackToMenu.Text = "Menu";
            this.btn_BackToMenu.UseVisualStyleBackColor = false;
            this.btn_BackToMenu.Click += new System.EventHandler(this.btn_BackToMenu_Click);
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 593);
            this.Controls.Add(this.btn_BackToMenu);
            this.Controls.Add(this.btn_Export);
            this.Controls.Add(this.btn_BrowseFile);
            this.Controls.Add(this.txtbox_FilePath);
            this.Controls.Add(this.lbl_Export);
            this.Controls.Add(this.dgv_ReportViewer);
            this.Controls.Add(this.btn_GenerateReport);
            this.Controls.Add(this.cmb_ReportType);
            this.Controls.Add(this.lbl_Title);
            this.Name = "Reports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.ComboBox cmb_ReportType;
        private System.Windows.Forms.Button btn_GenerateReport;
        private System.Windows.Forms.DataGridView dgv_ReportViewer;
        private System.Windows.Forms.Label lbl_Export;
        private System.Windows.Forms.TextBox txtbox_FilePath;
        private System.Windows.Forms.Button btn_BrowseFile;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Button btn_BackToMenu;
    }
}