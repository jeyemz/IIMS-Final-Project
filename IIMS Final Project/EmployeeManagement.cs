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
        string connectionString = "Server=localhost;Database=iims_finalproject;User ID=root;Password=peybi29INC";
        MySqlConnection connection;

        public EmployeeManagement()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            this.Load += new System.EventHandler(this.Form_Load);
        }

        private void EmployeeManagement_Load(object sender, EventArgs e)
        {

        }

        private void LoadEmployees()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT e.employee_id, e.first_name, e.last_name, e.email, d.department_name, e.password, e.hire_date " +
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
        private void Form_Load(object sender, EventArgs e)
        {
            // Fetch department data from your database and bind to ComboBox
            string query = "SELECT department_id, department_name FROM Department";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionString);
            DataTable dtDepartments = new DataTable();
            adapter.Fill(dtDepartments);

            // Bind ComboBox
            comboBox1.DataSource = dtDepartments;
            comboBox1.ValueMember = "department_id";  // ID will be used for selection
            comboBox1.DisplayMember = "department_name"; // Name will be displayed to the user

            // Load the employees data into the DataGridView
            LoadEmployees();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = textBox1.Text;
            string lastName = textBox2.Text;
            string email = textBox4.Text;
            string password = textBox3.Text; // Get the password from the password textbox
            int departmentId = 0;

            // Validate if the names contain any numbers
            if (firstName.Any(char.IsDigit) || lastName.Any(char.IsDigit))
            {
                MessageBox.Show("Names should not contain numbers.");
                return; // Exit the method if names contain numbers
            }

            // Check if a department is selected
            if (comboBox1.SelectedIndex == -1 || comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a department.");
                return; // Exit method if no department is selected
            }
            else
            {
                departmentId = Convert.ToInt32(comboBox1.SelectedValue); // Get the selected department ID
            }

            // Validate that password is provided
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a password.");
                return; // Exit the method if the password is not entered
            }

            DateTime hireDate = dateTimePicker1.Value;

            // Insert SQL query (including password field)
            string query = "INSERT INTO Employee (first_name, last_name, email, password, department_id, hire_date) " +
                           "VALUES (@firstName, @lastName, @email, @password, @departmentId, @hireDate)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // Add parameters to the SQL command to prevent SQL injection
                    cmd.Parameters.Add("@firstName", MySqlDbType.VarChar).Value = firstName;
                    cmd.Parameters.Add("@lastName", MySqlDbType.VarChar).Value = lastName;
                    cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
                    cmd.Parameters.Add("@password", MySqlDbType.VarChar).Value = password; // Add password parameter
                    cmd.Parameters.Add("@departmentId", MySqlDbType.Int32).Value = departmentId;
                    cmd.Parameters.Add("@hireDate", MySqlDbType.Date).Value = hireDate;

                    // Execute the query
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Employee added successfully!");
                    LoadEmployees(); // Refresh the DataGridView with the latest data
                }
                catch (Exception ex)
                {
                    // Show error message if the operation fails
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Ensure a row is selected
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select an employee to delete.");
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

            // Step 3: Prepare the DELETE query based on employee_id
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
            string password = textBox3.Text.Trim();  // Assuming password is in textBox3
            if (comboBox1.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid department.");
                return;
            }
            int departmentId = Convert.ToInt32(comboBox1.SelectedValue);
            DateTime hireDate = dateTimePicker1.Value;

            // Step 4: Validate fields before updating
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please fill in all required fields (First Name, Last Name, Email, and Password).");
                return;
            }

            // Step 5: Prepare the SQL UPDATE query
            string query = "UPDATE Employee SET first_name = @firstName, last_name = @lastName, email = @email, " +
                           "password = @password, department_id = @departmentId, hire_date = @hireDate WHERE employee_id = @employeeId";

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
                    cmd.Parameters.AddWithValue("@password", password); // Add password to parameters
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

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            textBox3.PasswordChar = '*';
        }
        // Form load event to load employees into the DataGridView
    }
}



