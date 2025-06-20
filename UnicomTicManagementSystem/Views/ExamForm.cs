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
    public partial class ExamForm : Form
    {
        private readonly ExamController examController = new ExamController();
        private readonly SubjectController subjectController = new SubjectController();
        private int selectedExamId = -1;

        public ExamForm()
        {
            InitializeComponent();
            this.Load += ExamForm_Load;

        }

        private void ExamForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadExams();
        }
        private void LoadSubjects()
        {
            cmbSubject.DataSource = subjectController.GetSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        private void LoadExams()
        {
            dataGridViewExams.DataSource = examController.GetExams();
            dataGridViewExams.AutoGenerateColumns = true;
            dataGridViewExams.ClearSelection();
        }

        




        private void dataGridViewExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExameName.Text) || cmbSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Exams exam = new Exams
            {
                ExamName = txtExameName.Text.Trim(),
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue)
            };

            examController.AddExam(exam);
            MessageBox.Show("Exam added successfully.");
            LoadExams();
            ClearFields();
        }

        

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to edit.");
                return;
            }

            Exams exam = new Exams
            {
                ExamId = selectedExamId,
                ExamName = txtExameName.Text.Trim(),
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue)
            };

            examController.UpdateExam(exam);
            MessageBox.Show("Exam updated successfully.");
            LoadExams();
            ClearFields();
        }


        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure to delete this exam?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                examController.DeleteExam(selectedExamId);
                MessageBox.Show("Exam deleted.");
                LoadExams();
                ClearFields();
            }
        }

     

        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataGridViewExams.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewExams.SelectedRows[0];
                selectedExamId = Convert.ToInt32(row.Cells["ExamId"].Value);
                txtExameName.Text = row.Cells["ExamName"].ToString();
                cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"]);
            }
            else
            {
                MessageBox.Show("Please select an exam to view.");
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
            txtExameName.Clear();
            cmbSubject.SelectedIndex = -1;
            selectedExamId = -1;
        }
    }
}
