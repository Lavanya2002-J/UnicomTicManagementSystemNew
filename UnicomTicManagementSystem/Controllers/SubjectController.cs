using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;






namespace UnicomTicManagementSystem.Controllers
{
    public class SubjectController
 
        {
            string connection = "Data Source=unicomtic.db;Version=3;";

            // Show all subjects
            public List<Subjects> GetSubjects()
            {
                List<Subjects> subjects = new List<Subjects>();

                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    string query = "SELECT * FROM Subjects";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Subjects s = new Subjects();
                        s.SubjectId = Convert.ToInt32(reader["SubjectID"]);
                        s.SubjectName = reader["SubjectName"].ToString();
                        s.CourseId = Convert.ToInt32(reader["CourseID"]);

                        subjects.Add(s);
                    }
                }

                return subjects;
            }

            // Add a new subject
            public void AddSubject(Subjects s)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    string query = "INSERT INTO Subjects (SubjectName, CourseID) VALUES (@name, @courseId)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", s.SubjectName);
                    cmd.Parameters.AddWithValue("@courseId", s.CourseId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Update subject
            public void UpdateSubject(Subjects s)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    string query = "UPDATE Subjects SET SubjectName = @name, CourseID = @courseId WHERE SubjectID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", s.SubjectName);
                    cmd.Parameters.AddWithValue("@courseId", s.CourseId);
                    cmd.Parameters.AddWithValue("@id", s.SubjectId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Delete subject
            public void DeleteSubject(int id)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connection))
                {
                    conn.Open();
                    string query = "DELETE FROM Subjects WHERE SubjectID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
    }
}


