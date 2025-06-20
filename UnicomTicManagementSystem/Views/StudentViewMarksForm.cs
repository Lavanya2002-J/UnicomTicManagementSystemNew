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
            int studentId = LoginForm.LoggedInStudentId;

            var marks = marksController.GetMarksByStudentId(studentId);
            dataGridViewMarks.DataSource = marksController.GetMarksByStudentId(LoginForm.LoggedInStudentId);
            dataGridViewMarks.AutoGenerateColumns = true;
           
            if (dataGridViewMarks.Columns["MarkId"] != null)
                dataGridViewMarks.Columns["MarkId"].Visible = false;

            
            if (dataGridViewMarks.Columns["StudentId"] != null)
                dataGridViewMarks.Columns["StudentId"].Visible = false;

           
      
            dataGridViewMarks.ClearSelection();

        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new AdminDashboard(LoginForm.LoggedInRole).Show(); 
        }

        private void dataGridViewMarks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
