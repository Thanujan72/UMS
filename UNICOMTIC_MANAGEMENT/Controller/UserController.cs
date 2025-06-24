using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICOMTIC_MANAGEMENT.Model;
using UNICOMTIC_MANAGEMENT.Repositories;

namespace UNICOMTIC_MANAGEMENT.Controller
{
    internal class UserController 
    {
        public List<User> GetUsers(string username, string password)
        {
            var users = new List<User>();

            using (var conn = DbConfig.GetConnection())
            {
               var cmd = new SQLiteCommand(@"
                                SELECT Username, Password, Role 
                                FROM Users 
                                WHERE Username = @username AND Password = @password", conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        users.Add(new User
                        {
                            UserName = reader.GetString(0),
                            Password = reader.GetString(1),
                            Role = reader.GetString(2)
                        });
                    }
                }
            }

            return users;
        }



        public List<Student> LoginStudent(string Username, string password)
        {
            var students = new List<Student>();

            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                                            SELECT StudentID, Username, Password
                                            FROM Students WHERE Username = @username AND Password = @password", conn);



                cmd.Parameters.AddWithValue("@username", Username);
                cmd.Parameters.AddWithValue("@password", password);


                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var student = new Student
                        {
                            StudentID = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2),

                        };
                        students.Add(student);
                    }
                }
            }
            return students;
        }

        public List<Lecturer> LoginLecturer(string username, string password)
        {
            var lecturers = new List<Lecturer>();

            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT LecturerID, Username, Password FROM Lecturers WHERE Username = @username AND Password = @password", conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var lecturer = new Lecturer
                        {
                            LecturerID = reader.GetInt32(0),
                            UserName = reader.GetString(1),
                            Password = reader.GetString(2)
                        };

                        lecturers.Add(lecturer);
                    }
                }
            }

            return lecturers;
        }

        public List<Staff> LoginStaff(string username, string password)
        {
            var staffList = new List<Staff>();

            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
            SELECT StaffID, Username, Password
            FROM Staff
            WHERE Username = @username AND Password = @password", conn);

                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var staff = new Staff
                        {
                            StaffID = reader.GetInt32(0),
                            Username = reader.GetString(1),
                            Password = reader.GetString(2)
                        };
                        staffList.Add(staff);
                    }
                }
            }

            return staffList;
        }



    }

}
        
    


