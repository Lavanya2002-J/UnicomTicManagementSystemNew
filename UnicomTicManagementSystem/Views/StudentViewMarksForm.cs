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



namespace UnicomTicManagementSystem.Views
{
    public partial class StudentViewMarksForm : Form
    {
        private MarksController marksController = new MarksController();
        public StudentViewMarksForm()
        {
            InitializeComponent();
            this.Load += StudentViewMarksForm_Load;
        }

        private void StudentViewMarksForm_Load(object sender, EventArgs e) 
        {
            LoadStudentMarks();
        }


        private void LoadStudentMarks() 
        {
            var allMarks = marksController.GetMarks();
            var StudentsMarks = allMarks.Where(m => m.StudentId == LoginForm.LoggedInStudentId).ToList();
            
            dataGridViewMarks.DataSource = StudentsMarks;
            dataGridViewMarks.AutoGenerateColumns = true;
            dataGridViewMarks.ClearSelection();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentDashboard().Show();
        }
    }
}
