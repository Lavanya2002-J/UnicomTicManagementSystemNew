using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UnicomTicManagementSystem.Views;

namespace UnicomTicManagementSystem.Views
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }
        private void btnCourses_Click(object sender, EventArgs e)
        {
            
            CoursesForm coursesForm = new CoursesForm();

            // Show the CoursesForm
            coursesForm.Show();

            // Hide the AdminDashboard
            this.Hide();
        }
        private void btnSubjects_Click(object sender, EventArgs e)
        {
            // Create a new instance of the SubjectsForm
            SubjectsForm subjectsForm = new SubjectsForm();

            // Show the SubjectsForm
            subjectsForm.Show();

            // Hide the AdminDashboard
            this.Hide();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            // Create a new instance of the StudentsForm
            StudentsForm studentsForm = new StudentsForm();

            // Show the StudentsForm
            studentsForm.Show();

            // Hide the AdminDashboard
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Create a new instance of the LoginForm
                LoginForm loginForm = new LoginForm();

                // Show the LoginForm
                loginForm.Show();

                // Hide the AdminDashboard
                this.Hide();
            }
        }

        private void btnViewExam_Click(object sender, EventArgs e)
        {
            ExamForm examForm = new ExamForm();
            examForm.Show();
            this.Hide();

        }

        private void btnViewMarks_Click(object sender, EventArgs e)
        {
            MarksForm marksForm = new MarksForm();
            marksForm.Show();
            this.Hide();
        }

        private void btnViewTimetable_Click(object sender, EventArgs e)
        {
            TimetableForm timetableForm = new TimetableForm();  
            timetableForm.Show();
            this.Hide();
        }

        private void btnViewRooms_Click(object sender, EventArgs e)
        {
            RoomsForm roomsForm = new RoomsForm();
            roomsForm.Show();
            this.Hide();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.Show();
            this.Hide();
            
        }
    }
}