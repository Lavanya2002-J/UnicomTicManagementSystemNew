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
                        UserId = Convert.ToInt32(reader["UserId"]),
                        UserName = reader["Username"].ToString(),
                        Password = reader["Password"].ToString(),
                        Role = reader["Role"].ToString(),
                        Email = reader["Email"].ToString(),
                        Phone = reader["Phone"].ToString(),
                        NIC = reader["NIC"].ToString(),
                        Gender = reader["Gender"].ToString()

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
                {

                    string query = "INSERT INTO Users (Username, Password, Role,Email,Phone,NIC,Gender) VALUES (@username, @password, @role,@email,@phone,@nic,@gender)";
                    SQLiteCommand cmd = new SQLiteCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", user.UserName);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("@role", user.Role);
                    cmd.Parameters.AddWithValue("@email", user.Email);
                    cmd.Parameters.AddWithValue("@phone", user.Phone);
                    cmd.Parameters.AddWithValue("@nic", user.NIC);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.ExecuteNonQuery();

                    cmd.CommandText = "SELECT last_insert_rowid()";
                    long id = (long)cmd.ExecuteScalar();
                    return (int)id;
                }

            }
        }

        //  Update existing user
        public void UpdateUser(Users user)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connection))
            {
                conn.Open();
                string query = @"UPDATE Users SET Username = @username, Password = @password, Role = @role,Email = @email, Phone = @phone, NIC = @nic, Gender = @gender WHERE UserID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", user.UserName);
                cmd.Parameters.AddWithValue("@password", user.Password);
                cmd.Parameters.AddWithValue("@role", user.Role);
                cmd.Parameters.AddWithValue("@id", user.UserId);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@phone", user.Phone);
                cmd.Parameters.AddWithValue("@nic", user.NIC);
                cmd.Parameters.AddWithValue("@gender", user);
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

