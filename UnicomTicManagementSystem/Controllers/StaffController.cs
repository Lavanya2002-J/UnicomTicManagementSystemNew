using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
    public class StaffController
    {
            private readonly string connectionString = "Data Source=unicomtic.db;Version=3;";

            // Get all staff
            public List<Staff> GetStaffs()
            {
                List<Staff> staffList = new List<Staff>();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Staff";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        staffList.Add(new Staff
                        {
                            StaffId = reader["StaffID"] != DBNull.Value ? Convert.ToInt32(reader["StaffID"]) : 0,
                            Name = reader["Name"].ToString(),
                            UserId = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : 0
                        });
                    }
                }

                return staffList;
            }
        //Add Staff
        // Add staff
        public void AddStaff(Staff staff)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO Staff (Name, UserID) VALUES (@Name, @UserId)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", staff.Name);
                command.Parameters.AddWithValue("@UserId", staff.UserId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


        // Update staff
        public void UpdateStaff(Staff staff)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Staff SET Name = @name, UserID = @userId WHERE StaffID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", staff.Name);
                    cmd.Parameters.AddWithValue("@userId", staff.UserId);
                    cmd.Parameters.AddWithValue("@id", staff.StaffId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Delete staff
            public void DeleteStaff(int staffID)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Staff WHERE StaffID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", staffID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }


