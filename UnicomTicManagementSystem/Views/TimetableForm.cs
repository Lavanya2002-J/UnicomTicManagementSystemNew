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
    public partial class TimetableForm : Form

    {
        private TimetableController timetableController = new TimetableController();
        private SubjectController subjectController = new SubjectController();
        private RoomController roomController = new RoomController();
        private int selectedTimetableId = -1;



        public TimetableForm()
        {
            InitializeComponent();
            this.Load += TimetablesForm_Load;
        }
        //  Load on Form Open
        private void TimetablesForm_Load(object sender, EventArgs e)
        {
            LoadSubjects();
            LoadRooms();
            LoadTimetables();

            if (LoginForm.LoggedInRole == "Student" || LoginForm.LoggedInRole == "Lecturer")
            {
                
                labelSubject.Visible = false;
                labelRoom.Visible = false;
                labelTimeSlot.Visible = false;

               
                cmbSubject.Visible = false;
                cmbRoom.Visible = false;
                txtTimeSlot.Visible = false;

              
                buttonAdd.Visible = false;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                btnView.Visible = false;

                
                dataGridViewTimetable.Visible = true;
                btnBack.Visible = true;
            }
        }
        

        // Load all subjects into combo box
        private void LoadSubjects()
        {
            cmbSubject.DataSource = subjectController.GetSubjects();
            cmbSubject.DisplayMember = "SubjectName";
            cmbSubject.ValueMember = "SubjectID";
            cmbSubject.SelectedIndex = -1;
        }

        //  Load all rooms into combo box
        private void LoadRooms()
        {
            cmbRoom.DataSource = roomController.GetRooms();
            cmbRoom.DisplayMember = "RoomName";
            cmbRoom.ValueMember = "RoomID";
            cmbRoom.SelectedIndex = -1;
        }

        // Load all timetables into DataGridView
        private void LoadTimetables()
        {
            dataGridViewTimetable.DataSource = timetableController.GetTimetableViews();
            dataGridViewTimetable.AutoGenerateColumns = true;
            dataGridViewTimetable.ClearSelection();
            if ( dataGridViewTimetable.Columns["TimetableId"] != null )
                dataGridViewTimetable.Columns["TimetableId"].Visible = false;
            
            
        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  Add Timetable
            if (IsValidInput())
            {
                Timetables newTimetable = new Timetables
                {
                    SubjectId = Convert.ToInt32(cmbSubject.SelectedValue),
                    RoomId = Convert.ToInt32(cmbRoom.SelectedValue),
                    TimeSlot = txtTimeSlot.Text.Trim(),
                    Date = datePicker.Value.ToString("yyyy-MM-dd") 
                };

                timetableController.AddTimetable(newTimetable);
                MessageBox.Show("Timetable added successfully!");
                LoadTimetables();
                ClearFields();
            }
        }




        private void button2_Click(object sender, EventArgs e)
        //  Edit Timetable

        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable to edit.");
                return;
            }

            if (IsValidInput())
            {
                Timetables updatedTimetable = new Timetables
                {
                    TimetableId = selectedTimetableId,
                    SubjectId = Convert.ToInt32(cmbSubject.SelectedValue),
                    RoomId = Convert.ToInt32(cmbRoom.SelectedValue),
                    TimeSlot = txtTimeSlot.Text.Trim(),
                    Date = datePicker.Value.ToString("yyyy-MM-dd") 
                };

                timetableController.UpdateTimetable(updatedTimetable);
                MessageBox.Show("Timetable updated successfully!");
                LoadTimetables();
                ClearFields();
            }
        }



        private void btnDelete_Click(object sender, EventArgs e)
        //  Delete Timetable

        {
            if (selectedTimetableId == -1)
            {
                MessageBox.Show("Please select a timetable to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this timetable?", "Confirm", MessageBoxButtons.YesNo);

            if (confirm == DialogResult.Yes)
            {
                timetableController.DeleteTimetable(selectedTimetableId);
                MessageBox.Show("Timetable deleted.");
                LoadTimetables();
                ClearFields();
            }
        }




        private void btnView_Click(object sender, EventArgs e)
       

        {
            if (dataGridViewTimetable.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewTimetable.SelectedRows[0];
                selectedTimetableId = Convert.ToInt32(row.Cells["TimetableID"].Value);
                cmbSubject.SelectedValue = Convert.ToInt32(row.Cells["SubjectID"].Value);
                cmbRoom.SelectedValue = Convert.ToInt32(row.Cells["RoomID"].Value);
                txtTimeSlot.Text = row.Cells["TimeSlot"].Value.ToString();
                
            }
            else
            {
                MessageBox.Show("Please select a timetable to view.");
            }
        }





        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard dashboard = new AdminDashboard(LoginForm.LoggedInRole);
            dashboard.Show();

        }



        private void dataGridViewTimetable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewTimetable.SelectedRows.Count > 0)
            {
               


            }
        }
        // Validation Method
        private bool IsValidInput()
        {
            if (cmbSubject.SelectedIndex == -1 || cmbRoom.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtTimeSlot.Text))
            {
                MessageBox.Show(" Please fill in all fields.");
                return false;
            }
            return true;

        }
        //  Clear all input fields
        private void ClearFields()
        {
            selectedTimetableId = -1;
            cmbSubject.SelectedIndex = -1;
            cmbRoom.SelectedIndex = -1;
            txtTimeSlot.Clear();
        }

        private void TimetableForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewTimetable_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTimetable.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewTimetable.SelectedRows[0];
                selectedTimetableId = Convert.ToInt32(row.Cells["TimetableId"].Value);
                cmbSubject.Text = row.Cells["SubjectName"].Value.ToString();
                cmbRoom.Text = row.Cells["RoomName"].Value.ToString();
                txtTimeSlot.Text = row.Cells["TimeSlot"].Value.ToString();


            }
        }

        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string selectedDate = datePicker.Value.ToString("yyyy-MM-dd");
        }
    }
}