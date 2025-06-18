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
    public partial class StudentsForm : Form
    {
        private StudentController studentController = new StudentController();
        private CourseController courseController = new CourseController();
        private int selectedstudentId = -1;
        public StudentsForm()
        {
            InitializeComponent();
            this.Load += StudentsForm_Load;
        }


        private void StudentsForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadCourses();
        }

       private void LoadCourses()
        {
            var courses = courseController.GetCourses();
            cmbCourse.DataSource = courses;
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseId";
        }

        private void LoadStudents()
        {
            var students = studentController.GetStudents();
            dataGridViewStudents.DataSource = students;
            dataGridViewStudents.AutoGenerateColumns = true;
            dataGridViewStudents.ClearSelection();
        }



        private void btnEditStudent_Click(object sender, EventArgs e)
        
        {
            if (selectedstudentId == -1)
            {
                MessageBox.Show("Please select a student from the list to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string studentName = txtStudentName.Text.Trim();

            if (string.IsNullOrWhiteSpace(studentName))
            {
                MessageBox.Show("Student name cannot be empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Students student = new Students
            {
                StudentId = selectedstudentId,
                Name = studentName,
                CourseId = Convert.ToInt32(cmbCourse.SelectedValue)
            };

            studentController.UpdateStudent(student);
            MessageBox.Show(" Student updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadStudents();
            ClearFields();
        }
        

        

        private void labelStudentName_Click(object sender, EventArgs e)
        {

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelCourse_Click(object sender, EventArgs e)
        {

        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddStudents_Click(object sender, EventArgs e)
        {
            string studentName = txtStudentName.Text.Trim();
            if (string.IsNullOrWhiteSpace(txtStudentName.Text))
            {
                MessageBox.Show("Please enter a student's name.","Input required",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            Students student = new Students
            {
                Name = txtStudentName.Text.Trim(),
                CourseId = Convert.ToInt32(cmbCourse.SelectedValue)
            };

            studentController.AddStudent(student);
            MessageBox.Show("Student added successfully","Success",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);
            LoadStudents();
            ClearFields();
        }

        

        private void btnDeleteStudent_Click(object sender, EventArgs e)
    
        {
            if (selectedstudentId == -1)
            {
                MessageBox.Show("Please select a student to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show(" Are you sure you want to delete this student?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                studentController.DeleteStudent(selectedstudentId);
                MessageBox.Show("Student deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadStudents();
                ClearFields();
            }
        }
        
            

        

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewStudents.SelectedRows[0];
                selectedstudentId = Convert.ToInt32(row.Cells["StudentID"].Value);
                txtStudentName.Text = row.Cells["Name"].Value.ToString();
                cmbCourse.SelectedValue = Convert.ToInt32(row.Cells["CourseID"].Value);
            }
            else
            {
                MessageBox.Show("Please select a student to view.");
            }
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard().Show();
        }

        private void ClearFields()
        {
            txtStudentName.Text = "";
            cmbCourse.SelectedIndex = -1;
            selectedstudentId = -1;
        }

        private void dataGridViewStudents_SelectionChanged(object sender, EventArgs e)
        
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewStudents.SelectedRows[0];

                if (row.Cells["StudentID"].Value != null)
                {
                    selectedstudentId = Convert.ToInt32(row.Cells["StudentID"].Value);

                    txtStudentName.Text = row.Cells["Name"].Value.ToString();
                    cmbCourse.SelectedValue = Convert.ToInt32(row.Cells["CourseID"].Value);
                }
            }
            else 
            { 
                selectedstudentId = -1;
            }
        }
    }
    
}
