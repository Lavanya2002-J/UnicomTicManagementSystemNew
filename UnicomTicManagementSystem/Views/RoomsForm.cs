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
    public partial class RoomsForm : Form
    {
        private RoomController roomController = new RoomController();
        private int selectedRoomId = -1;

        public RoomsForm()
        {
            InitializeComponent();
            this.Load += RoomsForm_Load;

            
        }

        private void DataGridViewRooms_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        // Load Room Types into ComboBox
        private void LoadRoomTypes()
        {
            cmbRoomType.Items.Clear();
            cmbRoomType.Items.Add("Classroom");
            cmbRoomType.Items.Add("Laboratory");
            cmbRoomType.Items.Add("Exam Hall");
            cmbRoomType.Items.Add("Conference Room");
            cmbRoomType.SelectedIndex = -1;
        }

        //  Load All Rooms
        private void LoadRooms()
        {
            dataGridViewRooms.DataSource = roomController.GetRooms();
            dataGridViewRooms.AutoGenerateColumns = true;
            dataGridViewRooms.ClearSelection();
        }



        //Add Room
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRoomName.Text) || cmbRoomType.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            Rooms newRoom = new Rooms
            {
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem.ToString()
            };

            roomController.AddRoom(newRoom);
            MessageBox.Show("✅ Room added successfully!");
            LoadRooms();
            ClearFields();
        }



        //Edit Room
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to edit.");
                return;
            }

            Rooms updatedRoom = new Rooms
            {
                RoomId = selectedRoomId,
                RoomName = txtRoomName.Text.Trim(),
                RoomType = cmbRoomType.SelectedItem.ToString()
            };

            roomController.UpdateRoom(updatedRoom);
            MessageBox.Show("✏ Room updated successfully!");
            LoadRooms();
            ClearFields();
        }

        //Delete Room
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedRoomId == -1)
            {
                MessageBox.Show("Please select a room to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this room?", "Confirm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                roomController.DeleteRoom(selectedRoomId);
                MessageBox.Show(" Room deleted.");
                LoadRooms();
                ClearFields();
            }


        }

        //View Room
        private void btnView_Click(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewRooms.SelectedRows[0];
                selectedRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
                txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
                cmbRoomType.SelectedItem = row.Cells["RoomType"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Please select a room to view.");
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminDashboard dashboard = new AdminDashboard(LoginForm.LoggedInRole);
            dashboard.Show();

        }



        private void dataGridViewRooms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Form Load
        private void RoomsForm_Load(object sender, EventArgs e)
        {
            LoadRoomTypes();
            LoadRooms();
        }


        //  Clear inputs
        private void ClearFields()
        {
            selectedRoomId = -1;
            txtRoomName.Text = "";
            cmbRoomType.SelectedIndex = -1;
        }

        // When row is selected
        private void dataGridViewRooms_SelectionChanged_1(object sender, EventArgs e)
        {
            if (dataGridViewRooms.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridViewRooms.SelectedRows[0];
                selectedRoomId = Convert.ToInt32(row.Cells["RoomID"].Value);
                txtRoomName.Text = row.Cells["RoomName"].Value.ToString();
                cmbRoomType.SelectedItem = row.Cells["RoomType"].Value.ToString();
            }

        }

    }
    
}

