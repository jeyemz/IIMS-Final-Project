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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();  // Show the Dashboard form
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProjectManagement projectManagementForm = new ProjectManagement();
            projectManagementForm.Show();  // Show the Project Management form
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagementForm = new EmployeeManagement();
            employeeManagementForm.Show();  // Show the Employee Management form
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TaskManagement taskManagementForm = new TaskManagement();
            taskManagementForm.Show();  // Show the Task Management form
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminLogin loginForm = new AdminLogin();
            loginForm.Show();  // Show the Login form
            this.Hide();  // Optionally hide the current form
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            reportsForm.Show();  // Show the Reports form
            this.Hide();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DepartmentManagement departmentManagementForm = new DepartmentManagement();
            departmentManagementForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BackupAndRecovery BackupAndRecovery = new BackupAndRecovery();
            BackupAndRecovery.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
