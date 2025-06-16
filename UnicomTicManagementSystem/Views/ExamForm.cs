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
        private ExamController examController = new ExamController();
        private SubjectController SubjectController = new SubjectController();
        private int selectedExamId = -1;

        public ExamForm()
        {
            InitializeComponent();
            this.Load += ExamForm_Load;
        }

        private void LoadSubjects()
        {
            var subjects = SubjectController.GetSubjects();
            cmbSubject.DataSource = subjects;
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectId";
            cmbSubject.SelectedIndex = -1;
        }
        private void LoadExams()
        {
            var exams = examController.GetExams();
            dataGridViewExams.DataSource = exams;
            dataGridViewExams.AutoGenerateColumns = true;
            dataGridViewExams.ClearSelection();
        }

        private void button2_Click(object sender, EventArgs e)
  
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to edit.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtExameName.Text))
            {
                MessageBox.Show("Exam name cannot be empty.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Exams updatedExam = new Exams
            {
                ExamId = selectedExamId,
                ExamName = txtExameName.Text.Trim(),
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue)
            };

            examController.UpdateExam(updatedExam);
            MessageBox.Show(" Exam updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadExams();
            ClearFields();
        }
        

        private void button5_Click(object sender, EventArgs e)
        
        {
            this.Hide();
            new AdminDashboard().Show();
        }
        

        private void button3_Click(object sender, EventArgs e)
        
        {
            if (selectedExamId == -1)
            {
                MessageBox.Show("Please select an exam to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this exam?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                examController.DeleteExam(selectedExamId);
                MessageBox.Show("🗑 Exam deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadExams();
                ClearFields();
            }
        }
        

        private void labelExameName_Click(object sender, EventArgs e)
        {

        }

        private void txtExameName_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSubject_Click(object sender, EventArgs e)
        {

        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewExams_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtExameName.Text))
            {
                MessageBox.Show("Please enter an exam name.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Exams exam = new Exams
            {
                ExamName = txtExameName.Text.Trim(),
                SubjectID = Convert.ToInt32(cmbSubject.SelectedValue)
            };

            examController.AddExam(exam);
            MessageBox.Show(" Exam added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadExams();
            ClearFields();
        }

        

        private void btnView_Click(object sender, EventArgs e)
        {
            
        
            if (dataGridViewExams.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewExams.SelectedRows[0];
                selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
                txtExameName.Text = row.Cells["ExamName"].Value.ToString();
                cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
            }
            else
            {
                MessageBox.Show("Please select an exam to view.");
            }
        }
        

        private void ExamForm_Load(object sender, EventArgs e)
        {

        }
        private void ClearFields()
        {
            txtExameName.Clear();
            cmbSubject.SelectedIndex = -1;
            selectedExamId = -1;
        }

        private void dataGridViewExams_SelectionChanged(object sender, EventArgs e)
        
        {
            if (dataGridViewExams.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewExams.SelectedRows[0];
                selectedExamId = Convert.ToInt32(row.Cells["ExamID"].Value);
                txtExameName.Text = row.Cells["ExamName"].Value.ToString();
                cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
            }
            else
            {
                selectedExamId = -1;
            }
        }
    }
    
}
