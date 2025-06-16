using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Views;
using UnicomTICManagementSystem.Controllers;

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
            string username = textUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (var connection = new SQLiteConnection("Data Source=unicomtic.db;Version=3;"))
            {
                connection.Open();

                string query = "SELECT Role FROM Users WHERE Username = @username AND Password = @password";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                var roleObj = cmd.ExecuteScalar();

                if (roleObj != null)
                {
                    string role = roleObj.ToString();

                    this.Hide();

                    if (role == "Admin")
                        new AdminDashboard().Show();
                    else if (role == "Student")
                        new StudentDashboard().Show();
                    else if (role == "Lecturer")
                        new LecturerDashboard().Show();
                    else if (role == "Staff")
                        new StaffDashboard().Show();
                    else
                        MessageBox.Show("Unknown role. Contact admin.");
                }
                else
                {
                    MessageBox.Show("Invalid username or password.");
                }

                connection.Close();
            }
        }

        private void textUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
