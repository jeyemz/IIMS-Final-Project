using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IIMS_Final_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Retrieve the text entered in the username and password textboxes
            string username = textBox1.Text;
            string password = textBox2.Text; // You can add password validation logic here if needed

            // Check if the entered username is "user" (you can add more complex validation here)
            if (username == "user" && password == "password") // Assuming "password" is the correct password
            {
                // Create an instance of the Dashboard form
                Dashboard dashboardForm = new Dashboard();

                // Optionally, pass data to the Dashboard form if needed
                dashboardForm.Show();  // Show the Dashboard form

                // Hide the current login form (optional)
                this.Hide();
            }
            else
            {
                // If the credentials are incorrect, show an error message
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
    
}
