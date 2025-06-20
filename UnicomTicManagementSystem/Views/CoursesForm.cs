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
    public partial class CoursesForm : Form
    {
        private CourseController controller = new CourseController();
        private int selectedCourseId = -1;

        public CoursesForm()
        {
            InitializeComponent();
            this.Load += CoursesForm_Load;

        }

        private void CoursesForm_Load(object sender, EventArgs e)
        {
            LoadCourses();


        }
        private void LoadCourses()
        {
            var courses = controller.GetCourses();
            dataGridViewCourses.AutoGenerateColumns = true;
            dataGridViewCourses.DataSource = courses;
        }

        private void ClearFields()
        {
            txtCourseName.Text = "";
            selectedCourseId = -1;
        }

        private void btnAddCourse_Click_1(object sender, EventArgs e)
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

            try
            {
                controller.Add(course);
                MessageBox.Show("Course added successfully!");
                LoadCourses();
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding course: " + ex.Message);
            }
        }

        private void btnEditCourseName_Click(object sender, EventArgs e)
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

        private void btnDelete_Click_1(object sender, EventArgs e)
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

        private void btnViewCourse_Click_1(object sender, EventArgs e)
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard dashboard = new AdminDashboard(LoginForm.LoggedInRole);
            dashboard.Show();
        }

        
        }
    }



    
