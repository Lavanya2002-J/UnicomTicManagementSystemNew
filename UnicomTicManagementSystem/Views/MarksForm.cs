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
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Views
{
    public partial class MarksForm : Form
    {
        private MarksController marksController = new MarksController();
        private StudentController studentController = new StudentController();
        private ExamController examController = new ExamController();
        private int selectedMarkId = -1;

        public MarksForm()
        {
            InitializeComponent();
            this.Load += MarksForm_Load;
        }

        
        private void LoadStudents()
        {
            var students = studentController.GetStudents();
            cmbStudent.DataSource = students;
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "StudentId";
            cmbStudent.SelectedIndex = -1;
        }
        private void LoadExams()
        {
            var exams = examController.GetExams();
            cmbExam.DataSource = exams;
            cmbExam.DisplayMember = "ExamName";
            cmbExam.ValueMember = "ExamId";
            cmbExam.SelectedIndex = -1;
        }
        private void LoadMarks()
        {
            var marks = marksController.GetMarks();
            dataGridViewMarks.DataSource = marks;
            dataGridViewMarks.AutoGenerateColumns = true;
            dataGridViewMarks.ClearSelection();
        }

        private void labelStudent_Click(object sender, EventArgs e)
        {

        }

        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelExam_Click(object sender, EventArgs e)
        {

        }

        private void cmbExam_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelScore_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddMark_Click(object sender, EventArgs e)
        {
            if (cmbStudent.SelectedIndex == -1 || cmbExam.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtScore.Text))
            {
                MessageBox.Show("Please fill all fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Marks mark = new Marks
            {
                StudentId = Convert.ToInt32(cmbStudent.SelectedValue),
                ExamId = Convert.ToInt32(cmbExam.SelectedValue),
                Score = Convert.ToInt32(txtScore.Text.Trim())
            };

            marksController.AddMark(mark);
            MessageBox.Show("Mark added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMarks();
            ClearFields();
        }

        

        private void btnEditMark_Click(object sender, EventArgs e)
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Marks mark = new Marks
            {
                MarkId = selectedMarkId,
                StudentId = Convert.ToInt32(cmbStudent.SelectedValue),
                ExamId = Convert.ToInt32(cmbExam.SelectedValue),
                Score = Convert.ToInt32(txtScore.Text.Trim())
            };

            marksController.UpdateMark(mark);
            MessageBox.Show("Mark updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadMarks();
            ClearFields();
        }

        

        private void btnDeleteMark_Click(object sender, EventArgs e)
        
        {
            if (selectedMarkId == -1)
            {
                MessageBox.Show("Please select a mark to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this mark?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                marksController.DeleteMark(selectedMarkId);
                MessageBox.Show("Mark deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMarks();
                ClearFields();
            }
        }

        

        private void btnViewMark_Click(object sender, EventArgs e)
        {
            if (dataGridViewMarks.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewMarks.SelectedRows[0];
                selectedMarkId = Convert.ToInt32(row.Cells["MarkId"].Value);
                cmbStudent.SelectedValue = Convert.ToInt32(row.Cells["StudentId"].Value);
                cmbExam.SelectedValue = Convert.ToInt32(row.Cells["ExamId"].Value);
                txtScore.Text = row.Cells["Score"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a mark to view.");
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
            txtScore.Clear();
            cmbStudent.SelectedIndex = -1;
            cmbExam.SelectedIndex = -1;
            selectedMarkId = -1;
        }

        private void MarksForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadExams();
            LoadMarks();
        }


    }
}

