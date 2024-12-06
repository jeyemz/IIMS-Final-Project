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
            try
            {
                string query = "SELECT employee_id, first_name, last_name, email, phone_number, department_name, hire_date " +
                               "FROM Employee " +
                               "JOIN Department ON Employee.department_id = Department.department_id";

                // Using a DataAdapter to fetch the data
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();

                // Open the connection and fill the DataTable
                connection.Open();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
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
            try
            {
                string query = "INSERT INTO Employee (first_name, last_name, email, phone_number, department_id, hire_date) " +
                               "VALUES (@first_name, @last_name, @email, @phone_number, @department_id, @hire_date)";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@first_name", textBox1.Text);
                cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
                cmd.Parameters.AddWithValue("@email", textBox3.Text);
                cmd.Parameters.AddWithValue("@phone_number", textBox4.Text);
                cmd.Parameters.AddWithValue("@department_id", comboBox1.SelectedValue);
                cmd.Parameters.AddWithValue("@hire_date", dateTimePicker1.Value);

                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();

                // Refresh the DataGridView after adding
                LoadEmployees();
                MessageBox.Show("Employee added successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string query = "UPDATE Employee SET first_name = @first_name, last_name = @last_name, email = @email, " +
                                   "phone_number = @phone_number, department_id = @department_id, hire_date = @hire_date " +
                                   "WHERE employee_id = @employee_id";

                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@first_name", textBox1.Text);
                    cmd.Parameters.AddWithValue("@last_name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@email", textBox3.Text);
                    cmd.Parameters.AddWithValue("@phone_number", textBox4.Text);
                    cmd.Parameters.AddWithValue("@department_id", comboBox1.SelectedValue);
                    cmd.Parameters.AddWithValue("@hire_date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@employee_id", dataGridView1.SelectedRows[0].Cells["employee_id"].Value);

                    connection.Open();
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    // Refresh the DataGridView after updating
                    LoadEmployees();
                    MessageBox.Show("Employee updated successfully.");
                }
                else
                {
                    MessageBox.Show("Please select an employee to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (dataGridView1.SelectedRows.Count > 0)
                    {
                        int employeeId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["employee_id"].Value);

                        string query = "DELETE FROM Employee WHERE employee_id = @employee_id";

                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@employee_id", employeeId);

                        connection.Open();
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        // Refresh the DataGridView after deletion
                        LoadEmployees();
                        MessageBox.Show("Employee deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Please select an employee to delete.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            string query = "SELECT e.first_name, e.last_name, e.email, e.phone_number, e.hire_date, " +
               "d.department_name, e.employee_id, p.project_name, t.task_name, t.task_status, t.due_date " +
               "FROM Employee e " +
               "JOIN Department d ON e.department_id = d.department_id " + // Join with Department table
               "JOIN Task t ON e.employee_id = t.assigned_to " +
               "JOIN Project p ON t.project_id = p.project_id";

            // Create a MySqlDataAdapter and a DataTable
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();

            try
            {
                // Open the connection
                connection.Open();

                // Fill the DataTable with data
                dataAdapter.Fill(dataTable);

                // Check if the DataTable has any rows
                if (dataTable.Rows.Count > 0)
                {
                    // Bind the DataTable to the DataGridView
                    dataGridView1.DataSource = dataTable;

                    // Optionally, customize column headers (if needed)
                    dataGridView1.Columns["first_name"].HeaderText = "Employee First Name";
                    dataGridView1.Columns["last_name"].HeaderText = "Employee Last Name";
                    dataGridView1.Columns["email"].HeaderText = "Email";
                    dataGridView1.Columns["phone_number"].HeaderText = "Phone Number";
                    dataGridView1.Columns["hire_date"].HeaderText = "Hire Date";
                    dataGridView1.Columns["department_name"].HeaderText = "Department";
                    dataGridView1.Columns["employee_id"].HeaderText = "Employee ID";
                    dataGridView1.Columns["project_name"].HeaderText = "Project Name";
                    dataGridView1.Columns["task_name"].HeaderText = "Task Name";
                    dataGridView1.Columns["task_status"].HeaderText = "Task Status";
                    dataGridView1.Columns["due_date"].HeaderText = "Due Date";
                }
                else
                {
                    // Show a message if no data is returned
                    MessageBox.Show("No employee task data found.");
                }

                // Close the connection after executing the query
                connection.Close();
            }
            catch (Exception ex)
            {
                // Handle any exceptions (e.g., connection issues, query errors)
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                    // Ensure the cells are not null before assigning their values to the textboxes
                    textBox1.Text = row.Cells["first_name"].Value?.ToString();
                    textBox2.Text = row.Cells["last_name"].Value?.ToString();
                    textBox3.Text = row.Cells["email"].Value?.ToString();
                    textBox4.Text = row.Cells["phone_number"].Value?.ToString();
                    comboBox1.SelectedValue = row.Cells["department_id"].Value?.ToString();
                    dateTimePicker1.Value = row.Cells["hire_date"].Value != DBNull.Value ? Convert.ToDateTime(row.Cells["hire_date"].Value) : DateTime.Now;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        // Form load event to load employees into the DataGridView
        private void EmployeeManagement_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

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
            Login loginForm = new Login();
            loginForm.Show();  // Show the Login form
            this.Hide();  // Optionally hide the current form
        }
    }

}

