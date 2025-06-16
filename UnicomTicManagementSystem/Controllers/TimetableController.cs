using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
        public class TimetableController
        {
            private string connectionString = "Data Source=unicomtic.db;Version=3;";

            // Get all timetables
            public List<Timetables> GetTimetables()
            {
                List<Timetables> list = new List<Timetables>();
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Timetables";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Timetables t = new Timetables
                        {
                            TimetableId = Convert.ToInt32(reader["TimetableID"]),
                            SubjectId = Convert.ToInt32(reader["SubjectID"]),
                            TimeSlot = reader["TimeSlot"].ToString(),
                            RoomId = Convert.ToInt32(reader["RoomID"])
                        };
                        list.Add(t);
                    }
                }
                return list;
            }

            // Add timetable
            public void AddTimetable(Timetables timetable)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) VALUES (@subject, @time, @room)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@subject", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@time", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@room", timetable.RoomId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Update timetable
            public void UpdateTimetable(Timetables timetable)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Timetables SET SubjectID = @subject, TimeSlot = @time, RoomID = @room WHERE TimetableID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@subject", timetable.SubjectId);
                    cmd.Parameters.AddWithValue("@time", timetable.TimeSlot);
                    cmd.Parameters.AddWithValue("@room", timetable.RoomId);
                    cmd.Parameters.AddWithValue("@id", timetable.TimetableId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Delete timetable
            public void DeleteTimetable(int id)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Timetables WHERE TimetableID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    
}

