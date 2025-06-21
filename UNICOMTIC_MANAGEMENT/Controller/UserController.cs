using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNICOMTIC_MANAGEMENT.Model;
using UNICOMTIC_MANAGEMENT.Repositories;

namespace UNICOMTIC_MANAGEMENT.Controller
{
    internal class UserController
    
    
        {
            // Add User
            public bool AddUser(User user)
            {
                using (var conn = DbConfig.GetConnection())
                {
                    conn.Open();
                    var command = new SQLiteCommand("INSERT INTO Users (UserName, Password, Role) VALUES (@UserName, @Password, @Role)", conn);
                    command.Parameters.AddWithValue("@UserName", user.UserName);
                    command.Parameters.AddWithValue("@Password", user.Password);
                    command.Parameters.AddWithValue("@Role", user.Role);

                    return command.ExecuteNonQuery() > 0;
                }
            }

            // Login Check
            public User Login(string username, string password)
            {
                using (var conn = DbConfig.GetConnection())
                {
                    conn.Open();
                    var command = new SQLiteCommand("SELECT * FROM Users WHERE UserName = @UserName AND Password = @Password", conn);
                    command.Parameters.AddWithValue("@UserName", username);
                    command.Parameters.AddWithValue("@Password", password);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new User
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                UserName = reader["UserName"].ToString(),
                                Password = reader["Password"].ToString(),
                                Role = reader["Role"].ToString()
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }
    }


