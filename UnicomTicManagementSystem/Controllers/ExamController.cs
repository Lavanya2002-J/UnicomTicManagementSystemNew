using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
   
        public class ExamController
        {
            private readonly string connectionString = "Data Source=unicomtic.db;Version=3;";

            // Get all exams
            public List<Exams> GetExams()
            {
                List<Exams> examList = new List<Exams>();

                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT * FROM Exams";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    SQLiteDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Exams exam = new Exams
                        {
                            ExamId = Convert.ToInt32(reader["ExamID"]),
                            ExamName = reader["ExamName"].ToString(),
                            SubjectID = Convert.ToInt32(reader["SubjectID"])
                        };

                        examList.Add(exam);
                    }
                }

                return examList;
            }

            // Add new exam
            public void AddExam(Exams exam)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "INSERT INTO Exams (ExamName, SubjectID) VALUES (@name, @subjectId)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                    cmd.ExecuteNonQuery();
                }
            }

            // Update exam
            public void UpdateExam(Exams exam)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "UPDATE Exams SET ExamName = @name, SubjectID = @subjectId WHERE ExamID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", exam.ExamName);
                    cmd.Parameters.AddWithValue("@subjectId", exam.SubjectID);
                    cmd.Parameters.AddWithValue("@id", exam.ExamId);
                    cmd.ExecuteNonQuery();
                }
            }

            //Delete exam
            public void DeleteExam(int id)
            {
                using (SQLiteConnection conn = new SQLiteConnection(connectionString))
                {
                    conn.Open();
                    string query = "DELETE FROM Exams WHERE ExamID = @id";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    
}
