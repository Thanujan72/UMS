using System.Collections.Generic;
using System.Data.SQLite;
using UNICOMTIC_MANAGEMENT.Model;
using UNICOMTIC_MANAGEMENT.Repositories;

namespace UNICOMTIC_MANAGEMENT.Controller
{
    internal class SubjectController
    {
        public void AddSubject(Subject subject)
        {
            using (var conn = DbConfig.GetConnection())
            {
               
                using (var command = new SQLiteCommand("INSERT INTO Subjects(SubjectName,CourseID) VALUES (@Subjectname,@CourseID)", conn))
                {
                    command.Parameters.AddWithValue("@Subjectname", subject.Subjectname);
                    command.Parameters.AddWithValue("@CourseID", subject.CourseID);
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<Course> GetAllCourses()
        {
            var courses = new List<Course>();
            using (var conn = DbConfig.GetConnection())
            {
               
                using (var cmd = new SQLiteCommand("SELECT CourseID, CourseName FROM Courses", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        courses.Add(new Course
                        {
                            CourseID = reader.GetInt32(0),
                            CourseName = reader.GetString(1)
                        });
                    }
                }
            }
            return courses;
        }

        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();
            using (var conn = DbConfig.GetConnection())
            {
                
                using (var cmd = new SQLiteCommand(@"SELECT s.SubjectID, s.SubjectName, s.CourseID, c.CourseName
                                                    FROM Subjects s
                                                    LEFT JOIN Courses c ON s.CourseID = c.CourseID", conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var subject = new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            Subjectname = reader.GetString(1),
                            CourseID = reader.GetInt32(2),
                            CourseName = reader.GetString(3) // if needed
                        };
                        subjects.Add(subject);
                    }
                }
            }
            return subjects;
        }

        public void updateSubject(Subject subject)
        {
            using (var conn = DbConfig.GetConnection())
            {
                
                using (var cmd = new SQLiteCommand("UPDATE Subjects SET SubjectName = @SubjectName, CourseID = @CourseID WHERE SubjectID = @SubjectID", conn))
                {
                    cmd.Parameters.AddWithValue("@SubjectName", subject.Subjectname);
                    cmd.Parameters.AddWithValue("@CourseID", subject.CourseID);
                    cmd.Parameters.AddWithValue("@SubjectID", subject.SubjectID);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public void deleteSubject(int SubjectID)
        {
            using (var conn = DbConfig.GetConnection())
            {

                using (var command = new SQLiteCommand("DELETE FROM Subjects WHERE SubjectID = @Id", conn))
                {
                    command.Parameters.AddWithValue("@Id", SubjectID);

                    command.ExecuteNonQuery();
                }
            }
        }
    } 
} 
