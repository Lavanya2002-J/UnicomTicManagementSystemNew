using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Models;


namespace UnicomTicManagementSystem.Controllers
{
    public class UserController
    {
        private string connection = "Data Source=unicomtic.db;Version=3;";

        // Get all users
        public List<Users> GetUsers()
        {
            List<Users> users = new List<Users>();

            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string query = "SELECT * FROM Users";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Users user = new Users
                    {
                        UserId = Convert.ToInt32(reader["UserID"]),
                        UserName = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString()
                    };

                    users.Add(user);
                }
            }

            return users;
        }

        //  Add new user
        public int AddUser(Users user)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {

                conn.Open();
                string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT last_insert_rowid()";
                long id = (long)cmd.ExecuteScalar();  
                return (int)id;
                /* conn.Open();
                 string query = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                 SQLiteCommand cmd = new SQLiteCommand(query, conn);
                 cmd.Parameters.AddWithValue("@username", user.UserName);
                 cmd.Parameters.AddWithValue("@password", user.Password);
                 cmd.Parameters.AddWithValue("@role", user.Role);
                 cmd.ExecuteNonQuery();
                 cmd.CommandText = "SELECT last_insert_rowid()";
                 long id = (long)cmd.ExecuteScalar();*/

            }
        }

        //  Update existing user
        public void UpdateUser(Users user)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string query = "UPDATE Users SET Username = @username, Password = @password, Role = @role WHERE UserID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@id", user.UserId);
                cmd.ExecuteNonQuery();
            }
        }

        //  Delete user
        public void DeleteUser(int userId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string query = "DELETE FROM Users WHERE UserID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", userId);
                cmd.ExecuteNonQuery();
            }
        }
    }
}

