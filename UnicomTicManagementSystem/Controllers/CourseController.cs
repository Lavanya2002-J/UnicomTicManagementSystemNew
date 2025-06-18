using System;
using System.Collections.Generic;
using System.Data.SQLite;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Controllers
{
    public class CourseController
    {
        // Get all courses
        public List<Courses> GetCourses()
        {
            List<Courses> courses = new List<Courses>();

            using (var conn = DataConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM Courses";

                using (var cmd = new SQLiteCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Courses
                        {
                            CourseId = Convert.ToInt32(reader["CourseID"]),
                            CourseName = reader["CourseName"].ToString()
                        });
                    }
                }
            }

            return courses;
        }

        // Add a new course
        public void Add(Courses course)
        {
            using (var conn = DataConfig.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO Courses (CourseName) VALUES (@name)";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", course.CourseName);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // ✅ Update course
        public void Update(Courses course)
        {
            using (var conn = DataConfig.GetConnection())
            {
                conn.Open();
                string query = "UPDATE Courses SET CourseName = @name WHERE CourseID = @id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", course.CourseName);
                    cmd.Parameters.AddWithValue("@id", course.CourseId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        // Delete course
        public void Delete(int courseId)
        {
            using (var conn = DataConfig.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM Courses WHERE CourseID = @id";

                using (var cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", courseId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}





