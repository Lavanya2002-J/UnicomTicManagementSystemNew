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
    public partial class StaffForm : Form
    {
        private StaffController staffController = new StaffController();
        private int selectedStaffId = -1;

        public StaffForm()
        {
            InitializeComponent();
            LoadStaff();

        }
        private void LoadStaff()
        {
            dataGridViewStaff.DataSource = null;
            dataGridViewStaff.DataSource = staffController.GetStaffs();

            // Optional: Set headers
            dataGridViewStaff.Columns["StaffID"].HeaderText = "Staff ID";
            dataGridViewStaff.Columns["Name"].HeaderText = "Staff Name";
            dataGridViewStaff.Columns["UserID"].HeaderText = "User ID";
        }


        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStaffId != -1)
            {
                Staff staff = new Staff
                {
                    StaffId = selectedStaffId,
                    Name = txtName.Text,
                    UserId = Convert.ToInt32(dataGridViewStaff.SelectedRows[0].Cells["UserID"].Value)
                };

                staffController.UpdateStaff(staff);
                MessageBox.Show("Staff updated successfully.");
                LoadStaff();
                ClearFields();
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStaffId != -1)
            {
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    staffController.DeleteStaff(selectedStaffId);
                    MessageBox.Show("Staff deleted successfully.");
                    LoadStaff();
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

        private void dataGridViewStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewStaff.Rows[e.RowIndex];
                selectedStaffId = Convert.ToInt32(row.Cells["StaffID"].Value);
                txtName.Text = row.Cells["Name"].Value.ToString();
            }
        }
        private void ClearFields()
        {
            txtName.Clear();
            selectedStaffId = -1;
        }
    }

}
    

