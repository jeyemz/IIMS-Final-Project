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
        private string connectionString = "Server=localhost;Port=3306;Database=iims_finalproject;Uid=root;Pwd=;";  

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
                    string query = "SELECT * FROM Projects";  // Change 'Projects' to your table name if different
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

        private void txtProjectID_TextChanged(object sender, EventArgs e)
        {
            // Add validation or other logic as needed
        }

        private void txtProjectName_TextChanged(object sender, EventArgs e)
        {
            // Add validation or other logic as needed
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Add validation or other logic as needed
        }

        private void txtManagerID_TextChanged(object sender, EventArgs e)
        {
            // Add validation or other logic as needed
        }

        // Add Project Button Click
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string projectID = txtProjectID.Text;
            string projectName = txtProjectName.Text;
            string projectDescription = txtProjectDescription.Text;
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;
            string managerID = txtManagerID.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(projectID) || string.IsNullOrEmpty(projectName) || string.IsNullOrEmpty(managerID))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Projects (ProjectID, ProjectName, ProjectDescription, StartDate, EndDate, ManagerID) " +
                                   "VALUES (@ProjectID, @ProjectName, @ProjectDescription, @StartDate, @EndDate, @ManagerID)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectID", projectID);
                    cmd.Parameters.AddWithValue("@ProjectName", projectName);
                    cmd.Parameters.AddWithValue("@ProjectDescription", projectDescription);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@ManagerID", managerID);

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
            string managerID = txtManagerID.Text;

            // Validate inputs
            if (string.IsNullOrEmpty(projectID) || string.IsNullOrEmpty(projectName) || string.IsNullOrEmpty(managerID))
            {
                MessageBox.Show("Please fill in all required fields.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Projects SET ProjectName = @ProjectName, ProjectDescription = @ProjectDescription, " +
                                   "StartDate = @StartDate, EndDate = @EndDate, ManagerID = @ManagerID WHERE ProjectID = @ProjectID";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ProjectID", projectID);
                    cmd.Parameters.AddWithValue("@ProjectName", projectName);
                    cmd.Parameters.AddWithValue("@ProjectDescription", projectDescription);
                    cmd.Parameters.AddWithValue("@StartDate", startDate);
                    cmd.Parameters.AddWithValue("@EndDate", endDate);
                    cmd.Parameters.AddWithValue("@ManagerID", managerID);

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
                    string query = "DELETE FROM Projects WHERE ProjectID = @ProjectID";

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
            txtManagerID.Clear();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now;
        }
    }
}