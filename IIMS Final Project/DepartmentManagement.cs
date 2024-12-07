using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;

namespace IIMS_Final_Project
{
    public partial class DepartmentManagement : Form
    {
        // Your connection string
        private string connectionString = "Server=localhost;Port=3306;Database=iims_finalproject;Uid=root;Pwd=;";

        public DepartmentManagement()
        {
            InitializeComponent();
        }

        private void DepartmentManagement_Load(object sender, EventArgs e)
        {
            LoadDepartmentData();
        }

        // Load data from Department table into DataGridView
        private void LoadDepartmentData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Department"; // Correct table name

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dgvDepartments.DataSource = dataTable;
            }
        }

        // Add Department button click event handler
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string departmentName = txtDepartmentName.Text;
            string departmentCode = txtDepartmentCode.Text;
            string location = txtLocation.Text;

            if (string.IsNullOrEmpty(departmentName) || string.IsNullOrEmpty(departmentCode))
            {
                MessageBox.Show("Please enter both department name and department code.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Department (department_name, department_code, location) VALUES (@department_name, @department_code, @location)";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@department_name", departmentName);
                command.Parameters.AddWithValue("@department_code", departmentCode);
                command.Parameters.AddWithValue("@location", location);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            // Reload the data
            LoadDepartmentData();
        }

        // Edit Department button click event handler
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt32(txtDepartmentID.Text);
            string departmentName = txtDepartmentName.Text;
            string departmentCode = txtDepartmentCode.Text;
            string location = txtLocation.Text;

            if (string.IsNullOrEmpty(departmentName) || string.IsNullOrEmpty(departmentCode))
            {
                MessageBox.Show("Please enter both department name and department code.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Department SET department_name = @department_name, department_code = @department_code, location = @location WHERE department_id = @department_id";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@department_name", departmentName);
                command.Parameters.AddWithValue("@department_code", departmentCode);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@department_id", departmentID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            // Reload the data
            LoadDepartmentData();
        }

        // Delete Department button click event handler
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int departmentID = Convert.ToInt32(txtDepartmentID.Text);

            if (departmentID <= 0)
            {
                MessageBox.Show("Please select a valid department.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Department WHERE department_id = @department_id";

                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@department_id", departmentID);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }

            // Reload the data
            LoadDepartmentData();
        }

        // Event handler for Department Name TextBox change (optional)
        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text change
        }

        // Event handler for Department Code TextBox change (optional)
        private void txtDepartmentCode_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text change
        }

        // Event handler for Location TextBox change (optional)
        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text change
        }

        // Event handler for Department ID TextBox change (optional)
        private void txtDepartmentId_TextChanged(object sender, EventArgs e)
        {
            // Optionally handle text change
        }


        //INPUT CHECKERS
        private void txtDepartmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calling Functions
            IntChecker(e);
        }

        private void txtDepartmentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calling Functions
            StringChecker(e);
        }

        private void txtDepartmentCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calling Functions
            StringChecker(e);
        }

        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calling Functions
            StringChecker(e);
        }

        static void IntChecker(KeyPressEventArgs e)
        {
            //Check is the pressed key is a valid INT character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            { 
            
                e.Handled = true;
            }

        }
        static void StringChecker(KeyPressEventArgs e)
        {
            //Check is the pressed key is a valid string character
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z\s\b]"))
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();  // Show the Dashboard form
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeeManagement employeeManagementForm = new EmployeeManagement();
            employeeManagementForm.Show();  // Show the Employee Management form
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ProjectManagement projectManagementForm = new ProjectManagement();
            projectManagementForm.Show();  // Show the Project Management form
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            TaskManagement taskManagementForm = new TaskManagement();
            taskManagementForm.Show();  // Show the Task Management form
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            reportsForm.Show();  // Show the Reports form
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MainForm MainForm = new MainForm();
            MainForm.Show();  // Show the Reports form
            this.Hide();
        }
    }
}