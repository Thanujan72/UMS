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
            try
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
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in AddLecturer: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in AddLecturer: " + ex.Message);
            }
        }
        //View All Lecturer
        public List<Lecturer> ViewAllLecturer()
        {
            var lecturers = new List<Lecturer>();
            try
            {
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
                    

                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in ViewAllLecturer: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in ViewAllLecturer: " + ex.Message);
            }
            return lecturers;


        }


        // Update Lecturer
        public void UpdateLecturer(Lecturer lecturer)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {

                    using (var command = new SQLiteCommand("UPDATE Lecturers SET Name = @Name, UserName = @UserName, Password = @Password WHERE LecturerID = @LecturerID", conn))
                    {
                        command.Parameters.AddWithValue("@LecturerID", lecturer.LecturerID);
                        command.Parameters.AddWithValue("@Name", lecturer.Name);
                        command.Parameters.AddWithValue("@UserName", lecturer.UserName);
                        command.Parameters.AddWithValue("@Password", lecturer.Password);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in UpdateLecturer: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in UpdateLecturer: " + ex.Message);
            }
        }

        // Delete Lecturer
        public void DeleteLecturer(int lecturerId)
        {
            try
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
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in DeleteLecturer: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in DeleteLecturer: " + ex.Message);
            }
        }
    }
}

