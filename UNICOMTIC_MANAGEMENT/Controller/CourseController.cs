using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Drawing;
using UNICOMTIC_MANAGEMENT.Model;
using UNICOMTIC_MANAGEMENT.Repositories;
using UNICOMTIC_MANAGEMENT.View;
using static System.Collections.Specialized.BitVector32;

namespace UNICOMTIC_MANAGEMENT.Controller
{
    internal class CourseController
    {
        // Add Course
        public void AddCourse(Course course)
        {
            using (var conn = DbConfig.GetConnection())
            {                
                var command = new SQLiteCommand("INSERT INTO Courses (CourseName) VALUES (@CourseName)", conn);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);                

                command.ExecuteNonQuery();
            }
        }

        //view
        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();

            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT * FROM Courses", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Course course = new Course();
                    course.CourseID = reader.GetInt32(0);
                    course.CourseName = reader.GetString(1);
                    courses.Add(course);
                    
                   
                }
            }

            return courses;
        }


        // Update Course
        public void UpdateCourse(Course course)
        {
            using (var conn = DbConfig.GetConnection())
            {
                
                var command = new SQLiteCommand("UPDATE Courses SET CourseName = @CourseName WHERE CourseID = @CourseID", conn);
                command.Parameters.AddWithValue("@CourseName", course.CourseName);
                command.Parameters.AddWithValue("@CourseID", course.CourseID);
                

                command.ExecuteNonQuery();
            }
        }

        // Delete Course
        public void DeleteCourse(int CourseID)
        {
            using (var conn = DbConfig.GetConnection())
            {
                
                var command = new SQLiteCommand("DELETE FROM Courses WHERE CourseID = @CourseID", conn);
                command.Parameters.AddWithValue("@CourseID",CourseID);

                command.ExecuteNonQuery() ;
            }
        }
    }
}
