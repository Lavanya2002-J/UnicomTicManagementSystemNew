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
using UnicomTicManagementSystem.Views;


namespace UnicomTicManagementSystem.Views
{
    public partial class SubjectsForm : Form
    {
        private SubjectController Controller = new SubjectController();
        private CourseController courseController = new CourseController();
        private int selectedSubjectId = -1;

            public SubjectsForm()
        {
            InitializeComponent();
            this.Load += new
            System.EventHandler(this.SubjectsForm_Load);
            
        }
        private void SubjectsForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadCourses();
        }
        private void LoadCourses()
        {
            CourseController courseController = new CourseController();
            var courses = courseController.GetCourses();

            comboCourse.DataSource = courses;
            comboCourse.DisplayMember = "CourseName";
            comboCourse.ValueMember = "CourseId";
        }
        private void LoadSubjects()
        {
            var subjects = Controller.GetSubjects();
            dataGridView1.DataSource = subjects;
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.ClearSelection();
        }

        private void txtSubjectName_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboCourse_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void btnAddSubjects_Click(object sender, EventArgs e)
        
        {
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || comboCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var subject = new Subjects
            {
                SubjectName = txtSubjectName.Text.Trim(),
                CourseId = Convert.ToInt32(comboCourse.SelectedValue)
            };

            Controller.AddSubject(subject);
            MessageBox.Show("Subject added successfully");
            LoadSubjects();
            ClearFields();
        }

        

        private void btnEditSubjects_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to edit.");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSubjectName.Text) || comboCourse.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }


            var updatedsubject = new Subjects
            {
                SubjectId = selectedSubjectId,
                SubjectName = txtSubjectName.Text.Trim(),
                CourseId = Convert.ToInt32(comboCourse.SelectedValue)
            };

            Controller.UpdateSubject(updatedsubject);
            MessageBox.Show("Subject updated successfully");
            LoadSubjects();
            ClearFields();
        }

        

        private void btnDeleteSubjects_Click(object sender, EventArgs e)
        {
            if (selectedSubjectId == -1)
            {
                MessageBox.Show("Please select a subject to delete.");
                return;
            }
            var confirm = MessageBox.Show("Are you sure want to delete this subjects?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Controller.DeleteSubject(selectedSubjectId);
                MessageBox.Show("Subject deleted");
                LoadSubjects();
                ClearFields();
            }
        }



        private void btnBackSubjects_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard dashboard = new AdminDashboard(LoginForm.LoggedInRole);
            dashboard.Show();
        }
        
        

        private void ClearFields()
        {
            txtSubjectName.Text = "";
            comboCourse.SelectedIndex = -1;
            selectedSubjectId = -1;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
         
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                selectedSubjectId = Convert.ToInt32(row.Cells["SubjectId"].Value);
                txtSubjectName.Text = row.Cells["SubjectName"].Value.ToString();
                comboCourse.SelectedValue = Convert.ToInt32(row.Cells["CourseId"].Value);
            }
        }  
    }        
    
}
