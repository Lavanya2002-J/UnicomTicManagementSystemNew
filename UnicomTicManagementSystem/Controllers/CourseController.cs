using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;
using UnicomTicManagementSystem.Repositories;



namespace UnicomTicManagementSystem.Controllers
{
        public class CourseController
        {

        
            private readonly string connectionString = "Data Source=unicomtic.db;Version=3;";
            private SQLiteConnection sqliteConn;

            private void OpenConnection()
            {
                sqliteConn = new SQLiteConnection(connectionString);
                sqliteConn.Open();
            }

            private void CloseConnection()
            {
                if (sqliteConn != null && sqliteConn.State == System.Data.ConnectionState.Open)
                    sqliteConn.Close();
            }

            public List<Courses> GetCourses()
            {
                
                List<Courses> courses = new List<Courses>();
                OpenConnection();

                string query = "SELECT * FROM Courses";
                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    courses.Add(new Courses
                    {
                        CourseId = Convert.ToInt32(reader["CourseID"]),
                        CourseName = reader["CourseName"].ToString()
                    });
                }

                CloseConnection();
                return courses;
            }

            public void Add(Courses course)
            {
                OpenConnection();
                string query = "INSERT INTO Courses (CourseName) VALUES (@name)";
                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                cmd.Parameters.AddWithValue("@name", course.CourseName);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }

            public void Update(Courses course)
            {
                OpenConnection();
                string query = "UPDATE Courses SET CourseName = @name WHERE CourseID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                cmd.Parameters.AddWithValue("@name", course.CourseName);
                cmd.Parameters.AddWithValue("@id", course.CourseId);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }

            public void Delete(int courseId)
            {
                OpenConnection();
                string query = "DELETE FROM Courses WHERE CourseID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
                cmd.Parameters.AddWithValue("@id", courseId);
                cmd.ExecuteNonQuery();
                CloseConnection();
            }
        }
    }


    


