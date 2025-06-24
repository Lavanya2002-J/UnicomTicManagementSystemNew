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
    public partial class LecturerForm : Form
    {
        private LecturerController lecturerController = new LecturerController();
        private CourseController courseController = new CourseController();
        private int selectedLecturerId = -1;

        public LecturerForm()
        {
            InitializeComponent();
            this.Load += LecturersForm_Load;
        }
        private void LecturersForm_Load(object sender, EventArgs e)
        {
            LoadLecturer();
            LoadCourses();
        }


        private void LoadCourses()
        {
            var courses = courseController.GetCourses();
            cmbCourse.DataSource = courses;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseId";
        }
        private void LoadLecturer()
        {
            var lecturers = lecturerController.GetLecturers();
            dgvLecturers.DataSource = lecturers;
            dgvLecturers.AutoGenerateColumns = true;
            dgvLecturers.ClearSelection();
        }



       
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedLecturerId == -1)
            {
                MessageBox.Show("Please select a lecturer to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string lecturerName = txtName.Text.Trim();
            if (string.IsNullOrWhiteSpace(lecturerName))
            {
                MessageBox.Show("Lecturer name cannot be empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Lecturer lecturer = new Lecturer
            {
                LecturerId = selectedLecturerId,
                Name = lecturerName,
                CourseId = Convert.ToInt32(cmbCourse.SelectedValue),
                
            };

            lecturerController.UpdateLecturer(lecturer);
            MessageBox.Show("Lecturer updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadLecturer();
            ClearFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedLecturerId == -1)
            {
                MessageBox.Show("Please select a lecturer to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this lecturer?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                lecturerController.DeleteLecturer(selectedLecturerId);
                MessageBox.Show("Lecturer deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadLecturer();
                ClearFields();
            }
        }

        private void dataGridViewLecturers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLecturers.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvLecturers.SelectedRows[0];

                if (row.Cells["LecturerId"].Value != null)
                {
                    selectedLecturerId = Convert.ToInt32(row.Cells["LecturerId"].Value);
                    txtName.Text = row.Cells["Name"].Value.ToString();
                    cmbCourse.SelectedValue = Convert.ToInt32(row.Cells["CourseId"].Value);
                    
                }
            }
            else
            {
                selectedLecturerId = -1;
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
            txtName.Text = "";
            
            cmbCourse.SelectedIndex = -1;
            selectedLecturerId = -1;
        }
    }


}
    



