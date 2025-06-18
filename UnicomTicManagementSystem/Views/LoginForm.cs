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

                string query = "SELECT UserID, Role FROM Users WHERE TRIM(Username) = @username AND TRIM(Password) = @password";
                SQLiteCommand cmd = new SQLiteCommand(query, connection);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                SQLiteDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    int userId = Convert.ToInt32(reader["UserID"]);
                    string role = reader["Role"].ToString();

                    if (role == "Student")
                    {
                        // Get StudentID linked to this UserID
                        string studentQuery = "SELECT StudentID FROM Students WHERE StudentID = @id";
                        SQLiteCommand studentCmd = new SQLiteCommand(studentQuery, connection);
                        studentCmd.Parameters.AddWithValue("@id", userId);
                        object studentIdObj = studentCmd.ExecuteScalar();

                        if (studentIdObj != null)
                        {
                            LoggedInStudentId = Convert.ToInt32(studentIdObj);
                            this.Hide();
                            new StudentDashboard().Show();
                        }
                        else
                        {
                            MessageBox.Show("Student not found in the Students table.");
                            return;
                        }
                    }
                    else if (role == "Admin")
                    {
                        this.Hide();
                        new AdminDashboard().Show();
                    }
                    else if (role == "Lecturer")
                    {
                        this.Hide();
                        new LecturerDashboard().Show();
                    }
                    else if (role == "Staff")
                    {
                        this.Hide();
                        new StaffDashboard().Show();
                    }
                    else
                    {
                        MessageBox.Show("Unknown role. Contact admin.");
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
