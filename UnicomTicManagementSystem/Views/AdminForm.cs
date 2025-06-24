using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Views
{
    public partial class AdminForm : Form
    {
        private AdminController adminController = new AdminController();
        private int selectedAdminId = -1;

        public AdminForm()
        {
            InitializeComponent();
            LoadAdmins();
        }
        private void LoadAdmins()
        {
            dataGridViewAdmins.DataSource = null;
            dataGridViewAdmins.DataSource = adminController.GetAdmins();

            // Optional: Adjust column headers
            dataGridViewAdmins.Columns["AdminID"].HeaderText = "ID";
            dataGridViewAdmins.Columns["Name"].HeaderText = "Admin Name";
            dataGridViewAdmins.Columns["UserID"].HeaderText = "User ID";
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAdminId != -1)
            {
                Admin admin = new Admin
                {
                    AdminId = selectedAdminId,
                    Name = textAdminName.Text,
                    UserId = Convert.ToInt32(dataGridViewAdmins.SelectedRows[0].Cells["UserID"].Value)
                };

                adminController.UpdateAdmin(admin);
                MessageBox.Show("Admin updated successfully.");
                LoadAdmins();
                ClearFields();

            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedAdminId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    adminController.DeleteAdmin(selectedAdminId);
                    MessageBox.Show("Admin deleted successfully.");
                    LoadAdmins();
                    ClearFields();
                }

            }
        }
            

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard dashboard = new AdminDashboard(LoginForm.LoggedInRole);
            dashboard.Show();
        }
        
        private void ClearFields()
        {
            textAdminName.Clear();
            selectedAdminId = -1;
        }

        private void dataGridViewAdmins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewAdmins.Rows[e.RowIndex];
                selectedAdminId = Convert.ToInt32(row.Cells["AdminID"].Value);
                textAdminName.Text = row.Cells["Name"].Value.ToString();
            }
        }

        

    }
}



  

        