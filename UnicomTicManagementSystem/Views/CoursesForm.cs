using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Views
{
    public partial class CoursesForm : Form
    {
        private CourseController controller = new CourseController();
        private int selectedCourseId = -1;

        public CoursesForm()
        {
            InitializeComponent();
            this.Load += CourseForm_Load;
        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
        }
        private void LoadCourses()
        {   var courses = controller.GetCourses();
 
            dataGridViewCourses.AutoGenerateColumns = true;
            dataGridViewCourses.DataSource = controller.GetCourses();

        }

        
     private void btnDelete_Click(object sender, EventArgs e)
        {

            if (selectedCourseId <= 0)
            {
                MessageBox.Show("Please select a course to delete.");
                return;
            }

            controller.Delete(selectedCourseId);
            LoadCourses();
            ClearFields();
        }

        

        private void btnAddCourse_Click(object sender, EventArgs e)
     
        {
            if (string.IsNullOrWhiteSpace(txtCourseName.Text))
            {
                MessageBox.Show("Course name is required.");
                return;
            }

            Courses course = new Courses
            {
                CourseName = txtCourseName.Text.Trim(),
                
            };

            controller.Add(course);
            LoadCourses();
            ClearFields();
        }



        private void btnEditCourse_Click(object sender, EventArgs e)
        {
            if (selectedCourseId <= 0)
            {
                MessageBox.Show("Please select a course to edit.");
                return;
            }

            Courses course = new Courses
            {
                CourseId = selectedCourseId,
                CourseName = txtCourseName.Text.Trim(),

            };

            controller.Update(course);
            LoadCourses();
            ClearFields();
        }

        private void ClearFields()
            {
            txtCourseName.Text = "";
            selectedCourseId = -1;
            }

        private void btnViewCourse_Click(object sender, EventArgs e)
        {
            if (dataGridViewCourses.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewCourses.CurrentRow;
                selectedCourseId = Convert.ToInt32(row.Cells[0].Value);
                txtCourseName.Text = row.Cells[1].Value.ToString();

            }
            else
            {
                MessageBox.Show("Please select a course from the list to view.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard dashboard = new AdminDashboard(LoginForm.LoggedInRole);
            dashboard.Show();

        }
    }    
}
