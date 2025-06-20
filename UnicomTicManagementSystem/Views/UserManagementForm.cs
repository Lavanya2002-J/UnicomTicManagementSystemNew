using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class UserManagementForm : Form
    {
        private readonly UserController userController = new UserController();
        private int selectedUserId = -1;

        public UserManagementForm()
        {
            InitializeComponent();
            Load += UserManagementForm_Load;
        }

        private void LoadUsers()
        {
            var users = userController.GetUsers();
            dataGridViewUsers.DataSource = users;
            dataGridViewUsers.AutoGenerateColumns = true;
            dataGridViewUsers.ClearSelection();
        }

        

     

        private void dataGridViewUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewUsers.SelectedRows[0];
                selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
                txtUsername.Text = row.Cells["Username"].Value.ToString();
                textPassword.Text = row.Cells["Password"].Value.ToString();
                cmbRole.SelectedItem = row.Cells["Role"].Value.ToString();
            }
        }

        private void ClearFields()
        {
            txtUsername.Clear();
            textPassword.Clear();
            cmbRole.SelectedIndex = -1;
            selectedUserId = -1;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserManagementForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(new string[] { "Admin", "Student", "Lecturer", "Staff" });
            cmbRole.SelectedIndex = -1;
            LoadUsers();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddUser_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(textPassword.Text) || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Users user = new Users
            {
                UserName = txtUsername.Text.Trim(),
                Password = textPassword.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString()
            };

            int userId = userController.AddUser(user);
            MessageBox.Show("User added successfully!");

            // ✅ Only for students
            if (user.Role == "Student")
            {
                Students student = new Students
                {
                    Name = user.UserName,
                    UserId = userId,
                    CourseId = 1  // Default course
                };

                StudentController sc = new StudentController();
                sc.AddStudent(student);
                MessageBox.Show("Student profile created.");
            }

            ClearFields();
            LoadUsers();
        }

        
    
        



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                userController.DeleteUser(selectedUserId);
                MessageBox.Show("User deleted successfully.");
                ClearFields();
                LoadUsers();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(textPassword.Text) || cmbRole.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }

            Users user = new Users
            {
                UserId = selectedUserId,
                UserName = txtUsername.Text.Trim(),
                Password = textPassword.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString()
            };

            userController.UpdateUser(user);
            MessageBox.Show("User updated successfully!");
            LoadUsers(); 
            ClearFields(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard dashboard = new AdminDashboard(LoginForm.LoggedInRole);
            dashboard.ShowDialog();

        }
    }
    
    
}