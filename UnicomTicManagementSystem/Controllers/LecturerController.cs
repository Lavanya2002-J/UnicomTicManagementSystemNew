using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;
using UnicomTicManagementSystem.Controllers;

namespace UnicomTicManagementSystem.Controllers
{
    internal class LecturerController
    {
            private readonly string connectionString = "Data Source=unicomtic.db;Version=3;";

        // Get all lecturers
        public List<Lecturer> GetLecturers()
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Lecturer";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lecturers.Add(new Lecturer
                    {
                        LecturerId = reader["LecturerID"] != DBNull.Value ? Convert.ToInt32(reader["LecturerID"]) : 0,
                        Name = reader["Name"].ToString(),
                        CourseId = reader["CourseID"] != DBNull.Value ? Convert.ToInt32(reader["CourseID"]) : 0,
                        UserId = reader["UserID"] != DBNull.Value ? Convert.ToInt32(reader["UserID"]) : 0
                    });
                }
            }

            return lecturers;
        }

        // Add new lecturer
        public void AddLecturer(Lecturer l)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Lecturer (Name, CourseID, UserID) VALUES (@name, @courseId, @userId)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", l.Name);
                cmd.Parameters.AddWithValue("@courseId", l.CourseId);
                cmd.Parameters.AddWithValue("@userId", l.UserId);
                cmd.ExecuteNonQuery();
            }
        }

        // Update lecturer
        public void UpdateLecturer(Lecturer l)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Lecturer SET Name = @name, CourseID = @courseId, UserID = @userId WHERE LecturerID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", l.Name);
                cmd.Parameters.AddWithValue("@courseId", l.CourseId);
                cmd.Parameters.AddWithValue("@userId", l.UserId);
                cmd.Parameters.AddWithValue("@id", l.LecturerId);
                cmd.ExecuteNonQuery();
            }
        }

        // Delete lecturer
        public void DeleteLecturer(int lecturerId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Lecturer WHERE LecturerID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", lecturerId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

