using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using UnicomTicManagementSystem.Repositories;

namespace UnicomTICManagementSystem.Controllers
{
    public class LoginController
    {
        // This method checks if the username, password, and role are valid
        public static bool ValidateLogin(string username, string password, string role)
        {
            try
            {
                // Connect to the SQLite database
                using (var connection = DataConfig.GetConnection())
                {
                    connection.Open();

                    // SQL query to find a matching user
                    string query = "SELECT * FROM Users WHERE Username = @username AND Password = @password AND Role = @role";

                    // Create the command and add values to parameters
                    using (var command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@role", role);

                        // Run the query and check if any matching user is found
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // If data is found, login is successful
                                return true;
                            }
                            else
                            {
                                // No match found = invalid login
                                return false;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Optional: Show error in a friendly way
                System.Windows.Forms.MessageBox.Show("Something went wrong: " + ex.Message);
                return false;
            }
        }
    }
}