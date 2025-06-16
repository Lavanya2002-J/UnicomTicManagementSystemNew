using System;
using System.Collections.Generic;
using System.Data.SQLite;
using UnicomTicManagementSystem.Models;

namespace UnicomTicManagementSystem.Controllers
{
    public class RoomController
    {
        private string connectionString = "Data Source=unicomtic.db;Version=3;";

        public List<Rooms> GetRooms()
        {
            List<Rooms> list = new List<Rooms>();

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM Rooms";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                SQLiteDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new Rooms
                    {
                        RoomId = Convert.ToInt32(reader["RoomID"]),
                        RoomName = reader["RoomName"].ToString(),
                        RoomType = reader["RoomType"].ToString()
                    });
                }
            }

            return list;
        }

        public void AddRoom(Rooms room)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO Rooms (RoomName, RoomType) VALUES (@name, @type)";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", room.RoomName);
                cmd.Parameters.AddWithValue("@type", room.RoomType);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateRoom(Rooms room)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "UPDATE Rooms SET RoomName = @name, RoomType = @type WHERE RoomID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", room.RoomName);
                cmd.Parameters.AddWithValue("@type", room.RoomType);
                cmd.Parameters.AddWithValue("@id", room.RoomId);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteRoom(int id)
        {
            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM Rooms WHERE RoomID = @id";
                SQLiteCommand cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
