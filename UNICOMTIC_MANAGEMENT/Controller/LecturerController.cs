using System;
using System.Collections.Generic;
using System.Data.SQLite;
using UNICOMTIC_MANAGEMENT.Model;
using UNICOMTIC_MANAGEMENT.Repositories;

namespace UNICOMTIC_MANAGEMENT.Controller
{
    internal class LecturerController
    {
        // Add Lecturer
        public void AddLecturer(Lecturer lecturer)
        {
            using (var conn = DbConfig.GetConnection())
            {
                using (var command = new SQLiteCommand("INSERT INTO Lecturers (Name,UserName,Password) VALUES (@Name,@UserName,@Password)", conn))
                {
                    command.Parameters.AddWithValue("@Name", lecturer.Name);
                    command.Parameters.AddWithValue("@UserName", lecturer.UserName);
                    command.Parameters.AddWithValue("@Password", lecturer.Password);

                    command.ExecuteNonQuery();
                }
            }
        }
        //View All Lecturer
        public List<Lecturer> ViewAllLecturer()
        {
            var lecturers = new List<Lecturer>();

            using (var conn = DbConfig.GetConnection())
            {
                    using (var cmd = new SQLiteCommand("SELECT * FROM Lecturers", conn))               
                    using (var reader = cmd.ExecuteReader())
                    {
                    while (reader.Read())
                    {
                        Lecturer lecture = new Lecturer();

                        lecture.LecturerID = reader.GetInt32(0);
                        lecture.Name = reader.GetString(1);
                        lecture.UserName = reader.GetString(2);
                        lecture.Password = reader.GetString(3);

                        lecturers.Add(lecture);
                    }
                        
                    }
                    return lecturers;
                
            }

           
        }


        // Update Lecturer
        public void UpdateLecturer(Lecturer lecturer)
        {
            using (var conn = DbConfig.GetConnection())
            {

                using (var command = new SQLiteCommand("UPDATE Lecturers SET Name = @Name, UserName = @UserName, Password = @Password WHERE LecturerID = @LecturerID", conn))
                {
                    command.Parameters.AddWithValue("@LecturerID",lecturer.LecturerID);
                    command.Parameters.AddWithValue("@Name", lecturer.Name);
                    command.Parameters.AddWithValue("@UserName", lecturer.UserName);
                    command.Parameters.AddWithValue("@Password", lecturer.Password);

                    command.ExecuteNonQuery();
                }
            }
        }

        // Delete Lecturer
        public void DeleteLecturer(int lecturerId)
        {
            using (var conn = DbConfig.GetConnection())
            {

                using (var command = new SQLiteCommand("DELETE FROM Lecturers WHERE LecturerID = @Id", conn))
                {
                    command.Parameters.AddWithValue("@Id", lecturerId);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

