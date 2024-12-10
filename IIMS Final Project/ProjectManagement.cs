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
    public partial class ProjectManagement : Form
    {
        private string connectionString = "Server=localhost;Database=iims_finalproject;User ID=root;Password=peybi29INC";

        public ProjectManagement()
        {
            InitializeComponent();
        }

        private void ProjectManagement_Load(object sender, EventArgs e)
        {
            // Load project data into the DataGridView
            LoadProjectData();
        }

        private void LoadProjectData()
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Project";  // Ensure this is the correct table name
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dgvProjects.DataSource = dt;  // Populate DataGridView with project data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading project data: " + ex.Message);
            }
        }


        // Add Project Button Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string projectID = txtProjectID.Text;
            string projectName = txtProjectName.Text;
            string projectDescription = txtProjectDescription.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string deptID = txtDeptID.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(projectID) || string.IsNullOrEmpty(projectName) || string.IsNullOrEmpty(deptID))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start Date cannot be later than End Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Project (project_name, projectDescription, start_date, end_date, department_id) " +
                                   "VALUES (@ProjectName, @ProjectDescription, @StartDate, @EndDate, @DepartmentID)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectName", projectName);
                    cmd.Parameters.AddWithValue("@ProjectDescription", projectDescription);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@DepartmentID", deptID);  // Assuming you will assign a department_id (adjust logic accordingly)

                    cmd.ExecuteNonQuery();  // Execute the insert query
                    MessageBox.Show("Project Added!");

                    LoadProjectData();  // Refresh DataGridView after adding
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding project: " + ex.Message);
            }
        }

        // Update Project Button Click
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string projectID = txtProjectID.Text;
            string projectName = txtProjectName.Text;
            string projectDescription = txtProjectDescription.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string deptID = txtDeptID.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(projectID) || string.IsNullOrEmpty(projectName) || string.IsNullOrEmpty(deptID))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            if (dtpStartDate.Value > dtpEndDate.Value)
            {
                MessageBox.Show("Start Date cannot be later than End Date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Project SET project_name = @ProjectName, projectDescription = @ProjectDescription, " +
                                   "start_date = @StartDate, end_date = @EndDate, department_id = @department_id WHERE project_id = @project_id";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@project_id", projectID);
                    cmd.Parameters.AddWithValue("@ProjectName", projectName);
                    cmd.Parameters.AddWithValue("@ProjectDescription", projectDescription);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@department_id", deptID);

                    cmd.ExecuteNonQuery();  // Execute the update query
                    MessageBox.Show("Project Updated!");

                    LoadProjectData();  // Refresh DataGridView after updating
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating project: " + ex.Message);
            }
        }

        // Delete Project Button Click
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string projectID = txtProjectID.Text;

            // Validate input
            if (string.IsNullOrEmpty(projectID))
            {
                MessageBox.Show("Please enter a Project ID to delete.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Project WHERE project_id = @ProjectID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectID", projectID);

                    cmd.ExecuteNonQuery();  // Execute the delete query
                    MessageBox.Show("Project Deleted!");

                    LoadProjectData();  // Refresh DataGridView after deleting
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting project: " + ex.Message);
            }
        }

        // Clear Fields Button Click
        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all fields
            txtProjectID.Clear();
            txtProjectName.Clear();
            txtProjectDescription.Clear();
            txtDeptID.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();  // Show the Menu form
            this.Hide();  // Optionally hide the current form
        }
        
        //Key checker
        private void txtProjectID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calling Function
            IntChecker(e);
        }

        private void txtProjectName_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calling Functions
            StringChecker(e);
        }

        private void txtProjectDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calling Functions
            StringChecker(e);
        }

        private void txtManagerID_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Calling Function
            IntChecker(e);
        }

        static void IntChecker(KeyPressEventArgs e)
        {
            //Check is the pressed key is a valid integer character
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

        
    }
}