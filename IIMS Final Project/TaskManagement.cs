using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace IIMS_Final_Project
{
    public partial class TaskManagement : Form
    {
        private string connectionString = "Server=localhost;Database=iims_finalproject;User=root;Password=jrms;";
        private MySqlConnection conn;

        public TaskManagement()
        {
            InitializeComponent();
            LoadProjects();
            LoadEmployees();
            LoadTasks();

            // Set DropDownStyle to DropDownList for both ComboBoxes
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set SelectedIndex to -1 to ensure no item is selected initially
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;

        }

        private void LoadProjects()
        {
            comboBox1.Items.Clear(); // Clear previous items
            List<KeyValuePair<int, string>> projects = new List<KeyValuePair<int, string>>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT project_id, project_name FROM Project";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int projectId = Convert.ToInt32(reader["project_id"]);
                    string projectName = reader["project_name"].ToString();
                    projects.Add(new KeyValuePair<int, string>(projectId, projectName));
                }
                reader.Close();
            }

            comboBox1.DataSource = projects;
            comboBox1.DisplayMember = "Value";  // Display project name
            comboBox1.ValueMember = "Key";     // Hold project ID
        }


        private void LoadEmployees()
        {
            comboBox2.Items.Clear(); // Clear previous items
            List<KeyValuePair<int, string>> employees = new List<KeyValuePair<int, string>>();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT employee_id, CONCAT(first_name, ' ', last_name) AS employee_name FROM Employee";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int employeeId = Convert.ToInt32(reader["employee_id"]);
                    string employeeName = reader["employee_name"].ToString();
                    employees.Add(new KeyValuePair<int, string>(employeeId, employeeName));
                }
                reader.Close();
            }

            comboBox2.DataSource = employees;
            comboBox2.DisplayMember = "Value";  // Display employee name
            comboBox2.ValueMember = "Key";     // Hold employee ID
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Please select a project and an employee.");
                return;
            }

            int projectId = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
            int assignedTo = ((KeyValuePair<int, string>)comboBox2.SelectedItem).Key;
            string taskName = textBox1.Text;
            DateTime dueDate = dateTimePicker1.Value;

            if (string.IsNullOrEmpty(taskName) || projectId == 0 || assignedTo == 0)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Task (task_name, assigned_to, project_id, due_date) " +
                               "VALUES (@taskName, @assignedTo, @projectId, @dueDate)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@taskName", taskName);
                cmd.Parameters.AddWithValue("@assignedTo", assignedTo);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@dueDate", dueDate);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Task added successfully.");
            LoadTasks(); // Refresh DataGridView
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to edit.");
                return;
            }

            int taskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["task_id"].Value);
            string taskName = textBox1.Text;

            if (comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Please select a project and an employee.");
                return;
            }

            int projectId = (int)comboBox1.SelectedValue;
            int assignedTo = (int)comboBox2.SelectedValue;
            DateTime dueDate = dateTimePicker1.Value;

            if (string.IsNullOrEmpty(taskName) || projectId == 0 || assignedTo == 0)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Task SET task_name = @taskName, assigned_to = @assignedTo, project_id = @projectId, due_date = @dueDate WHERE task_id = @taskId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@taskName", taskName);
                cmd.Parameters.AddWithValue("@assignedTo", assignedTo);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@dueDate", dueDate);
                cmd.Parameters.AddWithValue("@taskId", taskId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Task updated successfully.");
            LoadTasks();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a task to delete.");
                return;
            }

            // Get the selected task ID
            int taskId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["task_id"].Value);

            // Delete the task from the database
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Task WHERE task_id = @taskId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@taskId", taskId);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Task deleted successfully.");
            LoadTasks(); // Refresh the DataGridView
        }

        private void LoadTasks()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT t.task_id, t.task_name, t.due_date, e.first_name, e.last_name, p.project_name " +
                               "FROM Task t " +
                               "JOIN Employee e ON t.assigned_to = e.employee_id " +
                               "JOIN Project p ON t.project_id = p.project_id";
                MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;

                dataGridView1.Columns["task_id"].Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
            AdminLogin loginForm = new AdminLogin();
            loginForm.Show();  // Show the Login form
            this.Hide();  // Optionally hide the current form
        }
    }
}
