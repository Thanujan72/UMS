using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICOMTIC_MANAGEMENT.Model;
using UNICOMTIC_MANAGEMENT.Repositories;
using UNICOMTIC_MANAGEMENT.View;

namespace UNICOMTIC_MANAGEMENT.Controller
{
    internal class StudentController
    {
        public void AddStudent(Student student)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("INSERT INTO Students(Name,Address,UserName,Password,CourseID)VALUES (@name,@address,@userName,@password,@courseID)", conn);
                command.Parameters.AddWithValue("@name", student.Name);
                command.Parameters.AddWithValue("@address", student.Adderss);
                command.Parameters.AddWithValue("@userName", student.Username);
                command.Parameters.AddWithValue("@password", student.Password);
                command.Parameters.AddWithValue("@courseID", student.CourseID);
                command.ExecuteNonQuery();
            }
        }

       public List<Student> GetAllStudets()
        {
            var students = new List<Student>();

            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand(@"
                            SELECT s.StudentID, s.Name, s.Address, s.Username, s.Password, s.CourseID,c.CourseName
                            FROM Students s
                            LEFT JOIN Courses c ON s.CourseID = c.CourseID", conn);




                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var student = new Student
                        {
                            StudentID = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Adderss = reader.GetString(2),
                            Username = reader.GetString(3),
                            Password = reader.GetString(4),
                            CourseID = reader.IsDBNull(5) ? (int?)null : reader.GetInt32(5),
                            CourseName = reader.IsDBNull(6) ? null : reader.GetString(6)

                        };
                        students.Add(student);
                    }
                }

            }
            return students;
        }
        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();

            using (var conn = DbConfig.GetConnection())
            {
              
                var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    courses.Add(new Course
                    {
                        CourseID = reader.GetInt32(0),
                        CourseName = reader.GetString(1)
                    });
                }
            }

            return courses;
        }





        public void UpdateStudent(Student student)
        { 
                    using (var conn = DbConfig.GetConnection())
                    {
                        var command = new SQLiteCommand("UPDATE Students SET Name=@Name,Address=@Address,UserName =@UserName, Password=@Password WHERE StudentID = @Id ", conn);
                        command.Parameters.AddWithValue("@Name", student.Name);
                        command.Parameters.AddWithValue("@Address", student.Adderss);
                        command.Parameters.AddWithValue("@UserName", student.Username);
                        command.Parameters.AddWithValue("@Password", student.Password);
                        command.Parameters.AddWithValue("@Id",student.StudentID);
                        
                        command.ExecuteNonQuery();
                    }
         }

        public void DeleteStudent(int studentId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Students WHERE StudentID = @Id", conn);
                command.Parameters.AddWithValue("@Id", studentId);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected == 0)
                {
                    MessageBox.Show("No student was deleted. Check the StudentID.");
                }
            }
        }
    }

}