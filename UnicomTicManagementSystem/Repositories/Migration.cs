using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Repositories;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;


namespace UnicomTicManagementSystem.Repositories
{
        public static class Migration
        {
        public static void InitializeDatabase()
        {
            using (var connection = DataConfig.GetConnection())
            {
                connection.Open();

                string usersTable = @"CREATE TABLE IF NOT EXISTS Users (
                    UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT,
                    Password TEXT,
                    Role TEXT,
                    Email TEXT,
                    Phone TEXT,
                    NIC TEXT,
                    Gender Text
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
                    CourseID INTEGER,
                    UserID INTEGER
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
                    RoomID INTEGER,
                    DATE TEXT
                );";

                ExecuteCommand(usersTable, connection);
                ExecuteCommand(coursesTable, connection);
                ExecuteCommand(subjectsTable, connection);
                ExecuteCommand(studentsTable, connection);
                ExecuteCommand(examsTable, connection);
                ExecuteCommand(marksTable, connection);
                ExecuteCommand(roomsTable, connection);
                ExecuteCommand(timetableTable, connection);
            }
        }
            private static void ExecuteCommand(string commandText, SQLiteConnection connection)
            {
                using (var command = new SQLiteCommand(commandText, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }
    }



