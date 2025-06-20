using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
        public class StudentController
        {
            private readonly string connectionString = "Data Source=unicomtic.db;Version=3;";

            // Get all students
            public List<Students> GetStudents()
            {
                List<Students> students = new List<Students>();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Students";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        students.Add(new Students
                        {
                            StudentId = Convert.ToInt32(reader["StudentID"]),
                            Name = reader["Name"].ToString(),
                            CourseId = Convert.ToInt32(reader["CourseID"])
                        });
                    }
                }

                return students;
            }

            // Add student
            public void AddStudent(Students s)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Students (Name, CourseID,UserID) VALUES (@name, @courseId,@userId)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@courseId", s.CourseId);
                    cmd.Parameters.AddWithValue("@userId",s.UserId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Update student
            public void UpdateStudent(Students s)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Students SET Name = @name, CourseID = @courseId WHERE StudentID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", s.Name);
                    cmd.Parameters.AddWithValue("@courseId", s.CourseId);
                    cmd.Parameters.AddWithValue("@id", s.StudentId);
                    cmd.ExecuteNonQuery();
                }
            }

            // Delete student
            public void DeleteStudent(int studentId)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Students WHERE StudentID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", studentId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    
}

