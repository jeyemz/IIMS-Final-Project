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
        // Connection string to MySQL database
        private string connectionString = "Server=localhost;Port=3306;Database=iims_finalproject;Uid=root;Pwd=;";

        public DepartmentManagement()
        {
            InitializeComponent();
        }

        // Load event handler for the form
        private void DepartmentManagement_Load(object sender, EventArgs e)
        {
            LoadDepartmentData(); // Load Department table data
            ConfigureDataGridView(); // Configure DataGridView display settings
        }

        // Load data from the Department table into DataGridView
        private void LoadDepartmentData()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM Department"; // Query to retrieve all departments
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection); // Adapter to fill data
                DataTable dataTable = new DataTable(); // Create a data table
                dataAdapter.Fill(dataTable); // Fill the data table with data
                dgvDepartments.DataSource = dataTable; // Bind data to DataGridView
            }
        }

        // Configure DataGridView settings for better display
        private void ConfigureDataGridView()
        {
            dgvDepartments.Width = 450;  // Set the width of DataGridView
            dgvDepartments.Height = 175; // Set the height of DataGridView

            // Enable automatic resizing for columns and rows
            dgvDepartments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDepartments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            // Add padding for better readability
            dgvDepartments.DefaultCellStyle.Padding = new Padding(5);

            // Change font size for rows and column headers
            dgvDepartments.DefaultCellStyle.Font = new Font("Arial", 10);
            dgvDepartments.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);

            // Enable horizontal and vertical scroll bars
            dgvDepartments.ScrollBars = ScrollBars.Both;
        }

        // Add Department button click event handler
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Retrieve input values from text boxes
            string departmentName = txtDepartmentName.Text.Trim();
            string location = txtLocation.Text.Trim();

            // Check if inputs are empty
            if (string.IsNullOrEmpty(departmentName) || string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Please fill in all fields (Department Name and Location).");
                return;
            }

            // Add the new department to the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "INSERT INTO Department (department_name, location) VALUES (@department_name, @location)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@department_name", departmentName);
                command.Parameters.AddWithValue("@location", location);

                try
                {
                    connection.Open(); // Open database connection
                    command.ExecuteNonQuery(); // Execute query
                    MessageBox.Show("Department added successfully!"); // Success message
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}"); // Display error
                }
                finally
                {
                    connection.Close(); // Close connection
                }
            }

            LoadDepartmentData(); // Reload data into DataGridView
        }

        // Edit Department button click event handler
        private void btnEdit_Click(object sender, EventArgs e)
        {
            // Check if Department ID is selected
            if (string.IsNullOrEmpty(txtDepartmentID.Text))
            {
                MessageBox.Show("Please select a department to edit.");
                return;
            }

            // Retrieve updated data from text boxes
            int departmentID = Convert.ToInt32(txtDepartmentID.Text);
            string departmentName = txtDepartmentName.Text.Trim();
            string location = txtLocation.Text.Trim();

            // Check if inputs are empty
            if (string.IsNullOrEmpty(departmentName) || string.IsNullOrEmpty(location))
            {
                MessageBox.Show("Please fill in all fields (Department Name and Location).");
                return;
            }

            // Update the selected department in the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "UPDATE Department SET department_name = @department_name, location = @location WHERE department_id = @department_id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@department_name", departmentName);
                command.Parameters.AddWithValue("@location", location);
                command.Parameters.AddWithValue("@department_id", departmentID);

                try
                {
                    connection.Open(); // Open database connection
                    command.ExecuteNonQuery(); // Execute query
                    MessageBox.Show("Department updated successfully!"); // Success message
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}"); // Display error
                }
                finally
                {
                    connection.Close(); // Close connection
                }
            }

            LoadDepartmentData(); // Reload data into DataGridView
        }

        // Delete Department button click event handler
        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if Department ID is selected
            if (string.IsNullOrEmpty(txtDepartmentID.Text))
            {
                MessageBox.Show("Please select a department to delete.");
                return;
            }

            // Retrieve Department ID
            int departmentID = Convert.ToInt32(txtDepartmentID.Text);

            // Delete the selected department from the database
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "DELETE FROM Department WHERE department_id = @department_id";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@department_id", departmentID);

                try
                {
                    connection.Open(); // Open database connection
                    command.ExecuteNonQuery(); // Execute query
                    MessageBox.Show("Department deleted successfully!"); // Success message
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}"); // Display error
                }
                finally
                {
                    connection.Close(); // Close connection
                }
            }

            LoadDepartmentData(); // Reload data into DataGridView
        }

        // Input validation methods
        private void txtDepartmentID_KeyPress(object sender, KeyPressEventArgs e)
        {
            IntChecker(e); // Allow only integer input
        }

        private void txtDepartmentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringChecker(e); // Allow only alphabetic input
        }

        private void txtLocation_KeyPress(object sender, KeyPressEventArgs e)
        {
            StringChecker(e); // Allow only alphabetic input
        }

        // Method to validate integer input
        static void IntChecker(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Reject non-numeric input
            }
        }

        // Method to validate string input
        static void StringChecker(KeyPressEventArgs e)
        {
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[a-zA-Z\s\b]"))
            {
                e.Handled = true; // Reject non-alphabetic input
            }
        }

        // Back button click event handler
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu(); // Navigate back to Menu form
            menu.Show();
            this.Hide();
        }
    }
}