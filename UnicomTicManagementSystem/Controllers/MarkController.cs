using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
        public class MarksController
        {
            private string connection = "Data Source=unicomtic.db;Version=3;";

            // Get all marks
            public List<Marks> GetMarks()
            {
                List<Marks> marksList = new List<Marks>();

                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    conn.BusyTimeout = 5000; // Set busy timeout to 5 seconds
                string query = "SELECT * FROM Marks";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        marksList.Add(new Marks
                        {
                            MarkId = Convert.ToInt32(reader["MarkID"]),
                            StudentId = Convert.ToInt32(reader["StudentID"]),
                            ExamId = Convert.ToInt32(reader["ExamID"]),
                            Score = Convert.ToInt32(reader["Score"])
                        });
                    }
                }

                return marksList;
            }

            // Add mark
            public void AddMark(Marks mark)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    conn.BusyTimeout = 5000; // Set busy timeout to 5 seconds
                    string query = "INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@studentId, @examId, @score)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentId", mark.StudentId);
                    cmd.Parameters.AddWithValue("@examId", mark.ExamId);
                    cmd.Parameters.AddWithValue("@score", mark.Score);
                    cmd.ExecuteNonQuery();
                }
            }

            // Update mark
            public void UpdateMark(Marks mark)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    string query = "UPDATE Marks SET StudentID = @studentId, ExamID = @examId, Score = @score WHERE MarkID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@studentId", mark.StudentId);
                    cmd.Parameters.AddWithValue("@examId", mark.ExamId);
                    cmd.Parameters.AddWithValue("@score", mark.Score);
                    cmd.Parameters.AddWithValue("@id", mark.MarkId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Delete mark
            public void DeleteMark(int markId)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    string query = "DELETE FROM Marks WHERE MarkID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", markId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    
}

