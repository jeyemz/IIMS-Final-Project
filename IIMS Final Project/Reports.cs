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
        private readonly MySqlConnection con = new MySqlConnection("server=localhost; uid=root; pwd=; database=iims_finalproject; Port=3307");

        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            // Populate ComboBox with report types
            cmb_ReportType.Items.Add("Employee Report");
            cmb_ReportType.Items.Add("Project Report");
            cmb_ReportType.Items.Add("Task Report");
            cmb_ReportType.SelectedIndex = 0; // Default to the first option
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            string reportType = cmb_ReportType.SelectedItem.ToString();
            string query = "";

            // Determine the query based on selected report type
            switch (reportType)
            {
                case "Employee Report":
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
                    query = @"SELECT p.project_id, 
                                     p.project_name, 
                                     d.department_name, 
                                     p.start_date, 
                                     p.end_date 
                              FROM Project p
                              LEFT JOIN Department d ON p.department_id = d.department_id";
                    break;

                case "Task Report":
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
                    MessageBox.Show("Invalid report type selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            // Execute the query and bind results to the DataGridView
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgv_ReportViewer.DataSource = dt;

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No data found for the selected report.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void btn_BrowseFile_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV Files (*.csv)|*.csv",
                Title = "Save Report"
            })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtbox_FilePath.Text = saveFileDialog.FileName;
                }
            }
        }

        private void btn_Export_Click(object sender, EventArgs e)
        {
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
                using (StreamWriter sw = new StreamWriter(txtbox_FilePath.Text))
                {
                    // Write column headers
                    for (int i = 0; i < dgv_ReportViewer.Columns.Count; i++)
                    {
                        sw.Write(dgv_ReportViewer.Columns[i].HeaderText);
                        if (i < dgv_ReportViewer.Columns.Count - 1) sw.Write(",");
                    }
                    sw.WriteLine();

                    // Write rows
                    foreach (DataGridViewRow row in dgv_ReportViewer.Rows)
                    {
                        for (int i = 0; i < dgv_ReportViewer.Columns.Count; i++)
                        {
                            sw.Write(row.Cells[i].Value?.ToString() ?? "");
                            if (i < dgv_ReportViewer.Columns.Count - 1) sw.Write(",");
                        }
                        sw.WriteLine();
                    }
                }

                MessageBox.Show("Report exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
