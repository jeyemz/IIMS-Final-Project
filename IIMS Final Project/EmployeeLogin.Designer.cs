namespace IIMS_Final_Project
{
    partial class EmployeeLogin
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
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_Password = new System.Windows.Forms.TextBox();
            this.txtbox_EmployeeId = new System.Windows.Forms.TextBox();
            this.lbl_EmnployeeId = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(644, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(51, 27);
            this.btn_Back.TabIndex = 34;
            this.btn_Back.Text = "Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 37);
            this.label1.TabIndex = 37;
            this.label1.Text = "EMPLOYEE LOGIN";
            // 
            // txtbox_Password
            // 
            this.txtbox_Password.Location = new System.Drawing.Point(86, 204);
            this.txtbox_Password.Name = "txtbox_Password";
            this.txtbox_Password.Size = new System.Drawing.Size(220, 20);
            this.txtbox_Password.TabIndex = 32;
            this.txtbox_Password.TextChanged += new System.EventHandler(this.txtbox_Password_TextChanged);
            // 
            // txtbox_EmployeeId
            // 
            this.txtbox_EmployeeId.Location = new System.Drawing.Point(86, 157);
            this.txtbox_EmployeeId.Name = "txtbox_EmployeeId";
            this.txtbox_EmployeeId.Size = new System.Drawing.Size(220, 20);
            this.txtbox_EmployeeId.TabIndex = 31;
            this.txtbox_EmployeeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_EmployeeId_KeyPress);
            // 
            // lbl_EmnployeeId
            // 
            this.lbl_EmnployeeId.AutoSize = true;
            this.lbl_EmnployeeId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EmnployeeId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmnployeeId.Location = new System.Drawing.Point(82, 133);
            this.lbl_EmnployeeId.Name = "lbl_EmnployeeId";
            this.lbl_EmnployeeId.Size = new System.Drawing.Size(111, 21);
            this.lbl_EmnployeeId.TabIndex = 36;
            this.lbl_EmnployeeId.Text = "Employee ID:";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(82, 180);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(86, 21);
            this.lbl_Password.TabIndex = 35;
            this.lbl_Password.Text = "Password:";
            this.lbl_Password.Click += new System.EventHandler(this.lbl_Password_Click);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(127, 248);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(121, 37);
            this.btn_Login.TabIndex = 33;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtbox_Password);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtbox_EmployeeId);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.lbl_EmnployeeId);
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.lbl_Password);
            this.panel1.Controls.Add(this.btn_Login);
            this.panel1.Location = new System.Drawing.Point(154, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 406);
            this.panel1.TabIndex = 38;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Location = new System.Drawing.Point(24, 376);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 10);
            this.panel3.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(354, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 363);
            this.panel2.TabIndex = 46;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel9.Location = new System.Drawing.Point(24, 23);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(337, 10);
            this.panel9.TabIndex = 41;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel11.Location = new System.Drawing.Point(24, 23);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 363);
            this.panel11.TabIndex = 45;
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(707, 499);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.panel1);
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_Password;
        private System.Windows.Forms.TextBox txtbox_EmployeeId;
        private System.Windows.Forms.Label lbl_EmnployeeId;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel11;
    }
}