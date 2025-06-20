using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Views;
using UnicomTICManagementSystem.Controllers;

namespace UnicomTicManagementSystem.Views
{
    public partial class LoginForm : Form
    { 
        public static int LoggedInStudentId = -1;
        public static string LoggedInRole = ""; 
        public  LoginForm()
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

                string query = "SELECT UserID, Role FROM Users WHERE Username = @username AND Password = @password";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string role = reader["Role"].ToString();
                    int userId = Convert.ToInt32(reader["UserID"]);
                    LoginForm.LoggedInRole = role;
                    reader.Close(); 

                    if (role == "Student")
                    {
                        string studentQuery = "SELECT StudentID FROM Students WHERE UserID = @userId";
                        SQLiteCommand studentCmd = new SQLiteCommand(studentQuery, connection);
                        studentCmd.Parameters.AddWithValue("@userId", userId);

                        object studentIdObj = studentCmd.ExecuteScalar();
                        if (studentIdObj != null)
                        {
                            LoginForm.LoggedInStudentId = Convert.ToInt32(studentIdObj);
                            this.Hide();
                            new AdminDashboard(role).Show();  
                        }
                        else
                        {
                            MessageBox.Show("Student account not found in Students table.");
                            return;
                        }
                    }
                    else
                    {
                        this.Hide();
                        new AdminDashboard(role).Show();  
                    }
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
