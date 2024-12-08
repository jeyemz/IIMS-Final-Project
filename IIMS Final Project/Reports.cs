using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IIMS_Final_Project;
using MySql.Data.MySqlClient;

namespace IIMS_Final_Project
{
    public partial class Reports : Form
    {
        // Establish a connection to the MySQL database
        private readonly MySqlConnection con = new MySqlConnection("server=localhost; uid=root; pwd=; database=iims_finalproject; Port=3307");

        public Reports()
        {
            InitializeComponent(); // Initialize the form and its UI components
        }

        // This method is triggered when the form loads
        private void Reports_Load(object sender, EventArgs e)
        {
            // Populate ComboBox with report types
            cmb_ReportType.Items.Add("Employee Report");
            cmb_ReportType.Items.Add("Project Report");
            cmb_ReportType.Items.Add("Task Report");
            cmb_ReportType.SelectedIndex = 0; // Set the default selected option to the first item
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            // Get the selected report type from the ComboBox
            string reportType = cmb_ReportType.SelectedItem.ToString();
            string query = ""; // Initialize an empty SQL query

            // Determine the SQL query to execute based on the selected report type
            switch (reportType)
            {
                case "Employee Report": 
                    // Query to retrieve employee details along with their department
                    query = @"SELECT e.employee_id, 
                                     CONCAT(e.first_name, ' ', e.last_name) AS full_name, 
                                     e.email, 
                                     d.department_name, 
                                     e.hire_date, 
                                     e.status 
                              FROM Employee e
                              LEFT JOIN Department d ON e.department_id = d.department_id";
                    break;

                case "Project Report":
                    // Query to retrieve project details along with associated department
                    query = @"SELECT p.project_id, 
                                     p.project_name, 
                                     d.department_name, 
                                     p.start_date, 
                                     p.end_date 
                              FROM Project p
                              LEFT JOIN Department d ON p.department_id = d.department_id";
                    break;

                case "Task Report":
                    // Query to retrieve task details, including assigned employee and project
                    query = @"SELECT t.task_id, 
                                     t.task_name, 
                                     CONCAT(e.first_name, ' ', e.last_name) AS assigned_to, 
                                     p.project_name, 
                                     t.status, 
                                     t.due_date 
                              FROM Task t
                              LEFT JOIN Employee e ON t.assigned_to = e.employee_id
                              LEFT JOIN Project p ON t.project_id = p.project_id";
                    break;

                default:
                    // Handle unexpected report type selection
                    MessageBox.Show("Invalid report type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Execute the selected SQL query and display the results in the DataGridView
            try
            {
                con.Open(); // Open a connection to the database
                MySqlCommand cmd = new MySqlCommand(query, con); // Prepare the SQL command
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd); // Use an adapter to retrieve data
                DataTable dt = new DataTable(); // Create a DataTable to store query results
                adapter.Fill(dt); // Fill the DataTable with data from the query

                dgv_ReportViewer.DataSource = dt; // DataTable to the DataGridView

                // Notify the user if no data was found
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the selected report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                // Handle errors that occur during query execution
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_BrowseFile_Click(object sender, EventArgs e)
        {
            // Open a file dialog for the user to specify where the report file should be saved
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv", // Restrict file format to .csv
                Title = "Save Report"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtbox_FilePath.Text = saveFileDialog.FileName; // Save the selected file path
                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
            // Validate that a file path and report data are provided
            if (string.IsNullOrWhiteSpace(txtbox_FilePath.Text))
            {
                MessageBox.Show("Please specify a file path to export the report.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dgv_ReportViewer.DataSource == null)
            {
                MessageBox.Show("Please generate a report before exporting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Export the report data to a CSV file
                using (StreamWriter sw = new StreamWriter(txtbox_FilePath.Text))
                {
                    // Write column headers to the CSV file
                    for (int i = 0; i < dgv_ReportViewer.Columns.Count; i++)
                    {
                        sw.Write(dgv_ReportViewer.Columns[i].HeaderText); // Write header text
                        if (i < dgv_ReportViewer.Columns.Count - 1) sw.Write(","); // Add a comma if not the last column
                    }
                    sw.WriteLine();

                    // Write each row of data to the CSV file
                    foreach (DataGridViewRow row in dgv_ReportViewer.Rows)
                    {
                        for (int i = 0; i < dgv_ReportViewer.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value?.ToString() ?? ""); // Write cell value or empty string
                            if (i < dgv_ReportViewer.Columns.Count - 1) sw.Write(","); // Add a comma if not the last column
                        }
                        sw.WriteLine(); // Move to the next line
                    }
                }

                // Notify the user of a successful export
                MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle errors during file writing
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Navigate back to the main menu
            Menu Menu = new Menu();
            Menu.Show();  // Show the Menu form
            this.Hide();  // Hide the current form
        }
    }
}
