using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; // For MySql Connection

namespace IIMS_Final_Project
{
    public partial class Employee : Form
    {
        // Establish Database Connection
        MySqlConnection con = new MySqlConnection("server=localhost; uid=root; pwd=peybi29INC; database=iims_finalproject; Port=3306");

        public Employee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            try
            {
                //Function for refreshing data grids
                Refresh(dgv_Dept, dgv_Task, con);
                //Function for resizing data grids
                ResizeDGV(dgv_Dept);
                ResizeDGV(dgv_Task);
            }
            catch (Exception ex)
            {
                //If results in Error
                MessageBox.Show("Error" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void Refresh(DataGridView dgv1, DataGridView dgv2, MySqlConnection con)
        {
            try
            {
                //Display tables from MySql Workbench to Visual Studio
                //Ensuring Database connection is closed
                if (con.State != ConnectionState.Open)
                {
                    //Open Database Connection
                    con.Open();
                }

                string employee_id = EmployeeLogin.SharedTextBoxValue; //Get value from Employee_login

                // Supplier Table
                //MySql Query
                string query_Employee = "SELECT * FROM Employee WHERE employee_id = @employee_id;";
                MySqlCommand cmd_Employee = new MySqlCommand(query_Employee, con);
                cmd_Employee.Parameters.AddWithValue("@employee_id", employee_id);
                cmd_Employee.ExecuteNonQuery();//Return the value

                MySqlDataAdapter da_Employee = new MySqlDataAdapter(cmd_Employee);
                DataTable dt_Employee = new DataTable();
                da_Employee.Fill(dt_Employee);
                dgv1.DataSource = dt_Employee;//Put the values into dgv

                // Task Table
                //MySql Query
                string query_Task = "SELECT * FROM Task WHERE assigned_to = @employee_id;";
                MySqlCommand cmd_Task = new MySqlCommand(query_Task, con);
                cmd_Task.Parameters.AddWithValue("@employee_id", employee_id);
                cmd_Task.ExecuteNonQuery();//Return the value

                MySqlDataAdapter da_Task = new MySqlDataAdapter(cmd_Task);
                DataTable dt_Task = new DataTable();
                da_Task.Fill(dt_Task);
                dgv2.DataSource = dt_Task;//Put the values into dgv
            }
            catch (Exception ex)
            {
                //If result in Error
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Close Database Connection
                con.Close();
            }
        }

        static void ResizeDGV(DataGridView dgv)
        {
            try
            {
                //Autoresizing if columns within the dgv
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //Cell header alignment to Middle
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //Cell content alignment to Middle
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                //If results in Error
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            //Create a confirmation dialog
            DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //Check the user's response
            if (result == DialogResult.Yes)
            {
                // Navigate to the MainForm
                MainForm MainForm = new MainForm();
                MainForm.Show();
                this.Hide();
            }
        }
    }
}
