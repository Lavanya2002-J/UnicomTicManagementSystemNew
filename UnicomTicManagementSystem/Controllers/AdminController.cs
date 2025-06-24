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
    public class AdminController
        {
            private readonly string connectionString = "Data Source=unicomtic.db;Version=3;";

            // Get all admins
            public List<Admin> GetAdmins()
            {
                List<Admin> admins = new List<Admin>();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Admin";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        admins.Add(new Admin
                        {
                            AdminId = reader["AdminID"] != DBNull.Value ? Convert.ToInt32(reader["AdminID"]) : 0,
                            Name = reader["Name"].ToString(),
                            UserId  = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : 0
                        });
                    }
                }

                return admins;
            }
        // Add admin
        public void AddAdmin(Admin admin)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string query = "INSERT INTO Admin (Name, UserId) VALUES (@Name, @UserId)";
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Name", admin.Name);
                command.Parameters.AddWithValue("@UserId", admin.UserId);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }


        // Update admin
        public void UpdateAdmin(Admin admin)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Admin SET Name = @name, UserID = @userId WHERE AdminID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", admin.Name);
                    cmd.Parameters.AddWithValue("@userId", admin.UserId);
                    cmd.Parameters.AddWithValue("@id", admin.AdminId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Delete admin
            public void DeleteAdmin(int adminID)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Admin WHERE AdminID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", adminID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }


