using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicomTicManagementSystem.Views
{
    public partial class StudentDashboard : Form
    {
        public StudentDashboard()
        {
            InitializeComponent();
        }

        private void StudentDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnViewSubjects_Click(object sender, EventArgs e)
        {
          



        }

        private void btnViewMarks_Click(object sender, EventArgs e)
        {
            this.Hide();
            new StudentViewMarksForm().Show();
        }

        private void btnViewTimetable_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {

        }
    }
}
