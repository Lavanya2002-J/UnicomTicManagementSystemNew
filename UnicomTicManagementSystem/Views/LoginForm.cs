using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTICManagementSystem.Controllers;
using UnicomTicManagementSystem.Views;

namespace UnicomTicManagementSystem.Views
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get what the user typed in
            string username = textUsername.Text.Trim();      // Get username
            string password = txtPassword.Text.Trim();      // Get password
            string role = cmRole.SelectedItem?.ToString(); // Get selected role

            // Check if any field is empty
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all the fields before logging in.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Stop here, don’t check login if something is missing
            }

            // Ask the LoginController to check if the user is valid
            bool isValid = LoginController.ValidateLogin(username, password, role);

            if (isValid)
            {
                // If valid, show a welcome message
                MessageBox.Show($"Login successful! Welcome, {role}.", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (role == "Admin")
                {
                    this.Hide(); // Hide this login form
                    AdminDashboard adminDashboard = new AdminDashboard();   
                    adminDashboard.Show();
                }
            }
            else
            {
                // If invalid, show an error message
                MessageBox.Show("Oops! The username, password, or role is incorrect.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
