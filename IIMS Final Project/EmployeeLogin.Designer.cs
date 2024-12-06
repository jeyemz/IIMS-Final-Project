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
            this.SuspendLayout();
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Back.Location = new System.Drawing.Point(319, 27);
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
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 33);
            this.label1.TabIndex = 37;
            this.label1.Text = "EMPLOYEE LOGIN";
            // 
            // txtbox_Password
            // 
            this.txtbox_Password.Location = new System.Drawing.Point(71, 224);
            this.txtbox_Password.Name = "txtbox_Password";
            this.txtbox_Password.Size = new System.Drawing.Size(220, 20);
            this.txtbox_Password.TabIndex = 32;
            // 
            // txtbox_EmployeeId
            // 
            this.txtbox_EmployeeId.Location = new System.Drawing.Point(71, 162);
            this.txtbox_EmployeeId.Name = "txtbox_EmployeeId";
            this.txtbox_EmployeeId.Size = new System.Drawing.Size(220, 20);
            this.txtbox_EmployeeId.TabIndex = 31;
            this.txtbox_EmployeeId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_EmployeeId_KeyPress);
            // 
            // lbl_EmnployeeId
            // 
            this.lbl_EmnployeeId.AutoSize = true;
            this.lbl_EmnployeeId.BackColor = System.Drawing.Color.Transparent;
            this.lbl_EmnployeeId.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EmnployeeId.Location = new System.Drawing.Point(66, 140);
            this.lbl_EmnployeeId.Name = "lbl_EmnployeeId";
            this.lbl_EmnployeeId.Size = new System.Drawing.Size(100, 19);
            this.lbl_EmnployeeId.TabIndex = 36;
            this.lbl_EmnployeeId.Text = "Employee ID";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Password.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(67, 202);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(76, 19);
            this.lbl_Password.TabIndex = 35;
            this.lbl_Password.Text = "Password";
            // 
            // btn_Login
            // 
            this.btn_Login.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Login.Location = new System.Drawing.Point(124, 273);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(121, 37);
            this.btn_Login.TabIndex = 33;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 357);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_Password);
            this.Controls.Add(this.txtbox_EmployeeId);
            this.Controls.Add(this.lbl_EmnployeeId);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.btn_Login);
            this.Name = "EmployeeLogin";
            this.Text = "EmployeeLogin";
            this.Load += new System.EventHandler(this.EmployeeLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_Password;
        private System.Windows.Forms.TextBox txtbox_EmployeeId;
        private System.Windows.Forms.Label lbl_EmnployeeId;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login;
    }
}