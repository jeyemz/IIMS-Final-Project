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
using MySql.Data.MySqlClient; // For MySql Connection

namespace IIMS_Final_Project
{
    public partial class EmployeeLogin : Form
    {
        // Establish Database Connection
        MySqlConnection con = new MySqlConnection("server=localhost; uid=root; pwd=; database=iims_finalproject; Port=3307");

        public EmployeeLogin()
        {
            InitializeComponent();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e)
        {

        }

        public static string SharedTextBoxValue;

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtbox_EmployeeId.Text))
            {
                //If the Username textbox are either null or empty
                MessageBox.Show("Employee ID is Empty!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//return message
            }

            if (string.IsNullOrEmpty(txtbox_Password.Text))
            {
                //If the Password textbox are either null or empty
                MessageBox.Show("Password is Required!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;//return message
            }

            try
            {
                //Ensuring Database connection is closed
                if (con.State != ConnectionState.Open)
                {
                    //Open Database Connection
                    con.Open();
                }

                // Checks if the user inserted value 
                //MySql Query
                string query = "SELECT * FROM Employee WHERE employee_id = @employee_id AND password = @password";
                MySqlCommand cmd = new MySqlCommand(query, con);
                cmd.Parameters.AddWithValue("@employee_id", txtbox_EmployeeId.Text);
                cmd.Parameters.AddWithValue("@password", txtbox_Password.Text);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    // Successful login
                    MessageBox.Show("Login successful!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SharedTextBoxValue = txtbox_EmployeeId.Text;
                    // Navigate to the MenuForm
                    Employee Employee = new Employee();
                    Employee.Show();
                    this.Hide();
                }
                else
                {
                    // Login failed
                    MessageBox.Show("Invalid username or password.", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                // Close used connections
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information); // If Error
            }
            finally
            {
                //Close Database Connection
                con.Close();
            }

        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            // Navigate to the Employee_AdminForm
            MainForm MainForm = new MainForm();
            MainForm.Show();
            this.Hide();
        }

        private void txtbox_EmployeeId_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Check is the pressed key is a valid integer character
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
