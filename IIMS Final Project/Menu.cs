using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIMS_Final_Project
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Department_Click(object sender, EventArgs e)
        {
            // Navigate to the DepartmentManagementForm
            DepartmentManagement DepartmentManagement = new DepartmentManagement();
            DepartmentManagement.Show();
            this.Hide();
        }

        private void btn_Employee_Click(object sender, EventArgs e)
        {
            // Navigate to the EmployeeManagementForm
            EmployeeManagement EmployeeManagement = new EmployeeManagement();
            EmployeeManagement.Show();
            this.Hide();
        }

        private void btn_Project_Click(object sender, EventArgs e)
        {
            // Navigate to the ProjectManagementForm
            ProjectManagement ProjectManagement = new ProjectManagement();
            ProjectManagement.Show();
            this.Hide();
        }

        private void btn_Task_Click(object sender, EventArgs e)
        {
            // Navigate to the TaskManagementForm
            TaskManagement TaskManagement = new TaskManagement();
            TaskManagement.Show();
            this.Hide();
        }

        private void btn_Reports_Click(object sender, EventArgs e)
        {
            // Navigate to the ReportsForm
            Reports Reports = new Reports();
            Reports.Show();
            this.Hide();
        }

        private void btn_BR_Click(object sender, EventArgs e)
        {
            // Navigate to the BackupAndRecoveryForm
            BackupAndRecovery BackupAndRecovery = new BackupAndRecovery();
            BackupAndRecovery.Show();
            this.Hide();
        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            //Create a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Check the user's response
            if (result == DialogResult.Yes)
            {
                // Navigate to the MainForm
                MainForm MainForm = new MainForm();
                MainForm.Show();
                this.Hide();
            }
        }
    }
}
