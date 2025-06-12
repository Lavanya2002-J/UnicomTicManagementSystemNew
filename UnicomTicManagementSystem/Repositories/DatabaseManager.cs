using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;

namespace UnicomTICManagementSystem.Repositories
{
    public class DatabaseManager
    {
        // This is the name of the database file
        private static string dbFile = "unicomtic.db";

        // This is the connection string to connect to the SQLite database
        private static string connectionString = $"Data Source={dbFile};Version=";
        private SQLiteConnection sqliteConn;

        public static SQLiteConnection GetConnection()
        {

            if (!File.Exists(dbFile))
            {
                SQLiteConnection.CreateFile(dbFile);
            }

            // Return a new connection
            return new SQLiteConnection(connectionString);
        }

        // This method creates the tables if they don't already exist
        public static void InitializeDatabase()
        {
            // Open a connection to the database
            using (var connection = GetConnection())
            {
                connection.Open();

                // All the table creation commands
                string usersTable = @"CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT,
                    Password TEXT,
                    Role TEXT
                );";

                string coursesTable = @"CREATE TABLE IF NOT EXISTS Courses (
                    CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                    CourseName TEXT
                );";

                string subjectsTable = @"CREATE TABLE IF NOT EXISTS Subjects (
                    SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectName TEXT,
                    CourseID INTEGER
                );";

                string studentsTable = @"CREATE TABLE IF NOT EXISTS Students (
                    StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT,
                    CourseID INTEGER
                );";

                string examsTable = @"CREATE TABLE IF NOT EXISTS Exams (
                    ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                    ExamName TEXT,
                    SubjectID INTEGER
                );";

                string marksTable = @"CREATE TABLE IF NOT EXISTS Marks (
                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                    StudentID INTEGER,
                    ExamID INTEGER,
                    Score INTEGER
                );";

                string roomsTable = @"CREATE TABLE IF NOT EXISTS Rooms (
                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                    RoomName TEXT,
                    RoomType TEXT
                );";

                string timetableTable = @"CREATE TABLE IF NOT EXISTS Timetables (
                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                    SubjectID INTEGER,
                    TimeSlot TEXT,
                    RoomID INTEGER
                );";

                // Run each SQL command to create the table
                ExecuteCommand(usersTable, connection);
                ExecuteCommand(coursesTable, connection);
                ExecuteCommand(subjectsTable, connection);
                ExecuteCommand(studentsTable, connection);
                ExecuteCommand(examsTable, connection);
                ExecuteCommand(marksTable, connection);
                ExecuteCommand(roomsTable, connection);
                ExecuteCommand(timetableTable, connection);

                connection.Close();
            }
        }

        // This helper method runs one SQL command
        private static void ExecuteCommand(string commandText, SQLiteConnection connection)
        {
            using (var command = new SQLiteCommand(commandText, connection))
            {
                command.ExecuteNonQuery();
            }
        }




        public void OpenConnection()
        {
            sqliteConn = new SQLiteConnection("Data Source=courses.db;Version=3;");
            sqliteConn.Open();
        }

        public void CloseConnection()
        {
            if (sqliteConn != null && sqliteConn.State == System.Data.ConnectionState.Open)
                sqliteConn.Close();
        }

        public List<Courses> GetAllCourses()
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
                    CourseName = reader["CourseName"].ToString(),

                });
            }

            CloseConnection();
            return courses;
        }

        public void AddCourse(Courses course)
        {
            OpenConnection();
            string query = "INSERT INTO Courses (CourseName, Description) VALUES (@name, @desc)";
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
            cmd.Parameters.AddWithValue("@name", course.CourseName);

            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void UpdateCourse(Courses course)
        {
            OpenConnection();
            string query = "UPDATE Courses SET CourseName = @name, Description = @desc WHERE CourseID = @id";
            SQLiteCommand cmd = new SQLiteCommand(query, sqliteConn);
            cmd.Parameters.AddWithValue("@name", course.CourseName);

            cmd.Parameters.AddWithValue("@id", course.CourseId);
            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public void DeleteCourse(int courseId)
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







