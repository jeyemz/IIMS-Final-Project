using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace IIMS_Final_Project
{
    public partial class EmployeeManagement : Form
    {
        string connectionString = "Server=localhost;Database=iims_finalproject;User ID=root;Password=;";
        MySqlConnection connection;
        public EmployeeManagement()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
        }
        private void LoadEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT e.employee_id, e.first_name, e.last_name, e.email, d.department_name, e.hire_date " +
                                   "FROM Employee e LEFT JOIN Department d ON e.department_id = d.department_id";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }





        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string email = textBox4.Text;
            int departmentId = Convert.ToInt32(comboBox1.SelectedValue); // Assuming you have a combo box for departments
            DateTime hireDate = dateTimePicker1.Value;

            string query = "INSERT INTO Employee (first_name, last_name, email, department_id, hire_date) " +
                           "VALUES (@firstName, @lastName, @email, @departmentId, @hireDate)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@departmentId", departmentId);
                    cmd.Parameters.AddWithValue("@hireDate", hireDate);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee added successfully!");
                    LoadEmployees(); // Refresh the DataGridView
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure that a row is selected
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete.");
                return;
            }

            // Get the row index of the selected cell
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;

            // Get the employee ID from the selected row
            int employeeId = Convert.ToInt32(dataGridView1.Rows[selectedRowIndex].Cells["employee_id"].Value);

            // Prepare the delete query
            string query = "DELETE FROM Employee WHERE employee_id = @employeeId";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

                    // Execute the delete command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee deleted successfully!");
                        LoadEmployees(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("No employee found with the given ID.");
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select an employee to update.");
                return;
            }

            // Step 2: Get the employee ID from the selected row
            int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
            int employeeId;
            if (!int.TryParse(dataGridView1.Rows[selectedRowIndex].Cells["employee_id"].Value.ToString(), out employeeId))
            {
                MessageBox.Show("Invalid employee ID.");
                return;
            }

            // Step 3: Retrieve the data from the input fields
            string firstName = textBox1.Text.Trim();
            string lastName = textBox2.Text.Trim();
            string email = textBox4.Text.Trim();
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid department.");
                return;
            }
            int departmentId = Convert.ToInt32(comboBox1.SelectedValue);
            DateTime hireDate = dateTimePicker1.Value;

            // Step 4: Validate fields before updating
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Please fill in all required fields (First Name, Last Name, Email).");
                return;
            }

            // Step 5: Prepare the SQL UPDATE query
            string query = "UPDATE Employee SET first_name = @firstName, last_name = @lastName, email = @email, " +
                           "department_id = @departmentId, hire_date = @hireDate WHERE employee_id = @employeeId";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the SQL query
                    cmd.Parameters.AddWithValue("@firstName", firstName);
                    cmd.Parameters.AddWithValue("@lastName", lastName);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@departmentId", departmentId);
                    cmd.Parameters.AddWithValue("@hireDate", hireDate);
                    cmd.Parameters.AddWithValue("@employeeId", employeeId);

                    // Execute the query
                    int rowsAffected = cmd.ExecuteNonQuery();

                    // Check if any rows were updated
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee updated successfully!");
                        LoadEmployees(); // Refresh the DataGridView
                    }
                    else
                    {
                        MessageBox.Show("Error: No employee found with the provided ID.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                // Handle MySQL-specific errors
                MessageBox.Show("MySQL Error: " + ex.Message);
            }
            catch (FormatException ex)
            {
                // Handle invalid format (e.g., invalid department ID or hire date)
                MessageBox.Show("Invalid input format: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Handle general errors
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure row is selected
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                textBox1.Text = row.Cells["first_name"].Value.ToString();
                textBox2.Text = row.Cells["last_name"].Value.ToString();
                textBox4.Text = row.Cells["email"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["hire_date"].Value);
                // Set selected department in comboBox (if available)
                comboBox1.SelectedValue = row.Cells["department_id"].Value;
            }
        }

        // Form load event to load employees into the DataGridView
     

        private void button5_Click_1(object sender, EventArgs e)
        {
            Dashboard dashboardForm = new Dashboard();
            dashboardForm.Show();  // Show the Dashboard form
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            EmployeeManagement employeeManagementForm = new EmployeeManagement();
            employeeManagementForm.Show();  // Show the Employee Management form
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ProjectManagement projectManagementForm = new ProjectManagement();
            projectManagementForm.Show();  // Show the Project Management form
            this.Hide();  // Optionally hide the current form
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TaskManagement taskManagementForm = new TaskManagement();
            taskManagementForm.Show();  // Show the Task Management form
            this.Hide();  // Optionally hide the current form
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Reports reportsForm = new Reports();
            reportsForm.Show();  // Show the Reports form
            this.Hide();  // Optionally hide the current form
        
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AdminLogin loginForm = new AdminLogin();
            loginForm.Show();  // Show the Login form
            this.Hide();  // Optionally hide the current form
        }
    }

}

