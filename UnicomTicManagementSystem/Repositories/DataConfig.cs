using System;
using System.IO;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnicomTicManagementSystem.Controllers;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTicManagementSystem.Repositories
{
        public static class DataConfig
        {
            private static string dbFile = "unicomtic.db";
            private static string connectionString = $"Data Source={dbFile};Version=3";

            public static SQLiteConnection GetConnection()
            {
                if (!File.Exists(dbFile))
                {
                    SQLiteConnection.CreateFile(dbFile);
                }

                var connection = new SQLiteConnection(connectionString);
                connection.BusyTimeout = 5000; // Set busy timeout to 5 seconds
                return connection;
            }
        }
    }



