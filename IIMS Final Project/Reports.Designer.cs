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
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_RemoveFilter = new System.Windows.Forms.Button();
            this.btn_ApplyFilter = new System.Windows.Forms.Button();
            this.dtp_EndDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_EndDate = new System.Windows.Forms.Label();
            this.lbl_StartDate = new System.Windows.Forms.Label();
            this.dtp_StartDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportViewer)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_ReportType
            // 
            this.cmb_ReportType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_ReportType.FormattingEnabled = true;
            this.cmb_ReportType.Location = new System.Drawing.Point(14, 52);
            this.cmb_ReportType.Name = "cmb_ReportType";
            this.cmb_ReportType.Size = new System.Drawing.Size(200, 21);
            this.cmb_ReportType.TabIndex = 1;
            // 
            // btn_GenerateReport
            // 
            this.btn_GenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_GenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GenerateReport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_GenerateReport.Location = new System.Drawing.Point(220, 46);
            this.btn_GenerateReport.Name = "btn_GenerateReport";
            this.btn_GenerateReport.Size = new System.Drawing.Size(93, 32);
            this.btn_GenerateReport.TabIndex = 2;
            this.btn_GenerateReport.Text = "Generate";
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
            this.dgv_ReportViewer.Location = new System.Drawing.Point(14, 147);
            this.dgv_ReportViewer.MultiSelect = false;
            this.dgv_ReportViewer.Name = "dgv_ReportViewer";
            this.dgv_ReportViewer.ReadOnly = true;
            this.dgv_ReportViewer.RowHeadersWidth = 62;
            this.dgv_ReportViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ReportViewer.Size = new System.Drawing.Size(712, 377);
            this.dgv_ReportViewer.TabIndex = 3;
            // 
            // lbl_Export
            // 
            this.lbl_Export.AutoSize = true;
            this.lbl_Export.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbl_Export.Location = new System.Drawing.Point(10, 539);
            this.lbl_Export.Name = "lbl_Export";
            this.lbl_Export.Size = new System.Drawing.Size(121, 22);
            this.lbl_Export.TabIndex = 4;
            this.lbl_Export.Text = "Export to File:";
            // 
            // txtbox_FilePath
            // 
            this.txtbox_FilePath.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtbox_FilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbox_FilePath.Location = new System.Drawing.Point(128, 542);
            this.txtbox_FilePath.Name = "txtbox_FilePath";
            this.txtbox_FilePath.ReadOnly = true;
            this.txtbox_FilePath.Size = new System.Drawing.Size(400, 20);
            this.txtbox_FilePath.TabIndex = 5;
            // 
            // btn_BrowseFile
            // 
            this.btn_BrowseFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_BrowseFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BrowseFile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_BrowseFile.Location = new System.Drawing.Point(536, 536);
            this.btn_BrowseFile.Name = "btn_BrowseFile";
            this.btn_BrowseFile.Size = new System.Drawing.Size(91, 30);
            this.btn_BrowseFile.TabIndex = 6;
            this.btn_BrowseFile.Text = "Browse";
            this.btn_BrowseFile.UseVisualStyleBackColor = true;
            this.btn_BrowseFile.Click += new System.EventHandler(this.btn_BrowseFile_Click);
            // 
            // btn_Export
            // 
            this.btn_Export.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Export.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_Export.Location = new System.Drawing.Point(636, 536);
            this.btn_Export.Name = "btn_Export";
            this.btn_Export.Size = new System.Drawing.Size(91, 30);
            this.btn_Export.TabIndex = 7;
            this.btn_Export.Text = "Export";
            this.btn_Export.UseVisualStyleBackColor = true;
            this.btn_Export.Click += new System.EventHandler(this.btn_Export_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 30);
            this.label2.TabIndex = 91;
            this.label2.Text = "REPORTS";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.SystemColors.Control;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(654, 9);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(72, 30);
            this.btn_Back.TabIndex = 82;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_RemoveFilter);
            this.panel2.Controls.Add(this.btn_ApplyFilter);
            this.panel2.Controls.Add(this.dtp_EndDate);
            this.panel2.Controls.Add(this.lbl_EndDate);
            this.panel2.Controls.Add(this.lbl_StartDate);
            this.panel2.Controls.Add(this.dtp_StartDate);
            this.panel2.Controls.Add(this.btn_Back);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.dgv_ReportViewer);
            this.panel2.Controls.Add(this.btn_Export);
            this.panel2.Controls.Add(this.cmb_ReportType);
            this.panel2.Controls.Add(this.btn_BrowseFile);
            this.panel2.Controls.Add(this.btn_GenerateReport);
            this.panel2.Controls.Add(this.txtbox_FilePath);
            this.panel2.Controls.Add(this.lbl_Export);
            this.panel2.Location = new System.Drawing.Point(19, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(742, 586);
            this.panel2.TabIndex = 92;
            // 
            // btn_RemoveFilter
            // 
            this.btn_RemoveFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RemoveFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_RemoveFilter.Location = new System.Drawing.Point(562, 94);
            this.btn_RemoveFilter.Name = "btn_RemoveFilter";
            this.btn_RemoveFilter.Size = new System.Drawing.Size(91, 30);
            this.btn_RemoveFilter.TabIndex = 97;
            this.btn_RemoveFilter.Text = "Clear";
            this.btn_RemoveFilter.UseVisualStyleBackColor = true;
            this.btn_RemoveFilter.Click += new System.EventHandler(this.btn_RemoveFilter_Click);
            // 
            // btn_ApplyFilter
            // 
            this.btn_ApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ApplyFilter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_ApplyFilter.Location = new System.Drawing.Point(465, 94);
            this.btn_ApplyFilter.Name = "btn_ApplyFilter";
            this.btn_ApplyFilter.Size = new System.Drawing.Size(91, 30);
            this.btn_ApplyFilter.TabIndex = 96;
            this.btn_ApplyFilter.Text = "Apply Filter";
            this.btn_ApplyFilter.UseVisualStyleBackColor = true;
            this.btn_ApplyFilter.Click += new System.EventHandler(this.btn_ApplyFilter_Click);
            // 
            // dtp_EndDate
            // 
            this.dtp_EndDate.Location = new System.Drawing.Point(243, 104);
            this.dtp_EndDate.Name = "dtp_EndDate";
            this.dtp_EndDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_EndDate.TabIndex = 95;
            // 
            // lbl_EndDate
            // 
            this.lbl_EndDate.AutoSize = true;
            this.lbl_EndDate.Location = new System.Drawing.Point(240, 88);
            this.lbl_EndDate.Name = "lbl_EndDate";
            this.lbl_EndDate.Size = new System.Drawing.Size(55, 13);
            this.lbl_EndDate.TabIndex = 94;
            this.lbl_EndDate.Text = "End Date:";
            // 
            // lbl_StartDate
            // 
            this.lbl_StartDate.AutoSize = true;
            this.lbl_StartDate.Location = new System.Drawing.Point(16, 88);
            this.lbl_StartDate.Name = "lbl_StartDate";
            this.lbl_StartDate.Size = new System.Drawing.Size(58, 13);
            this.lbl_StartDate.TabIndex = 93;
            this.lbl_StartDate.Text = "Start Date:";
            // 
            // dtp_StartDate
            // 
            this.dtp_StartDate.Location = new System.Drawing.Point(19, 104);
            this.dtp_StartDate.Name = "dtp_StartDate";
            this.dtp_StartDate.Size = new System.Drawing.Size(200, 20);
            this.dtp_StartDate.TabIndex = 92;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(777, 617);
            this.Controls.Add(this.panel2);
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ReportViewer)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_ReportType;
        private System.Windows.Forms.Button btn_GenerateReport;
        private System.Windows.Forms.DataGridView dgv_ReportViewer;
        private System.Windows.Forms.Label lbl_Export;
        private System.Windows.Forms.TextBox txtbox_FilePath;
        private System.Windows.Forms.Button btn_BrowseFile;
        private System.Windows.Forms.Button btn_Export;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbl_StartDate;
        private System.Windows.Forms.DateTimePicker dtp_StartDate;
        private System.Windows.Forms.Button btn_RemoveFilter;
        private System.Windows.Forms.Button btn_ApplyFilter;
        private System.Windows.Forms.DateTimePicker dtp_EndDate;
        private System.Windows.Forms.Label lbl_EndDate;
    }
}