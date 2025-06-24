using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNICOMTIC_MANAGEMENT.Model;
using UNICOMTIC_MANAGEMENT.Repositories;

namespace UNICOMTIC_MANAGEMENT.Controller
{
    internal class MarkController
    {
        public void AddMark(Mark mark)
        {
            try
            {

                using (var conn = DbConfig.GetConnection())
                {

                    var command = new SQLiteCommand("INSERT INTO Marks (StudentID, ExamID, Score) VALUES (@StudentID, @ExamID, @Score)", conn);
                    command.Parameters.AddWithValue("@StudentID", mark.StudentId);
                    command.Parameters.AddWithValue("@ExamID", mark.ExamID);
                    command.Parameters.AddWithValue("@Score", mark.Score);

                    command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in AddMark: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in AddMark: " + ex.Message);
            }
        }

        public  List<Mark> GetMarkList()
        {
            var marks = new List<Mark>();
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    var command = new SQLiteCommand(@"SELECT m.MarkID,m.StudentID, m.ExamID, m.Score,s.Name,e.ExamName
                                                    FROM Marks m
                                                     LEFT JOIN Students S ON S.StudentID = m.StudentID
                                                      LEFT JOIN Exams e  ON e.ExamID = m.ExamID", conn);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var mark = new Mark
                            {
                                MarkID = reader.GetInt32(0),
                                StudentId = reader.GetInt32(1),
                                ExamID = reader.GetInt32(2),
                                Score = reader.GetInt32(3),
                                StudentName = reader.GetString(4),
                                ExamName = reader.GetString(5)
                            }; marks.Add(mark);
                        }
                    }
                    



                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in GetMarkList: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in GetMarkList: " + ex.Message);
            }
            return marks;
        }

        public List <Student> GetStudentList()
        {
            var students = new List<Student>();
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    var command = new SQLiteCommand("SELECT StudentID,Name FROM Students", conn);
                    var reader = command.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            var student = new Student
                            {
                                StudentID = reader.GetInt32(0),
                                Name = reader.GetString(1),
                            };
                            students.Add(student);
                        }
                    }
                    
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in GetStudentList: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in GetStudentList: " + ex.Message);
            }
            return students;    
        }

        public List<Exam> GetExamList()
        {
            var examList = new List<Exam>();
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    var command = new SQLiteCommand("SELECT ExamID,ExamName FROM Exams ", conn);
                    var reader = command.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            Exam exam = new Exam
                            {
                                ExamId = reader.GetInt32(0),
                                ExamName = reader.GetString(1),
                            };
                            examList.Add(exam);
                        }

                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in GetExamList: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in GetExamList: " + ex.Message);
            }
            return examList;
        }

        // Update Mark
        public void UpdateMark(Mark mark)
        {
            try
            {

                using (var conn = DbConfig.GetConnection())
                {


                    var command = new SQLiteCommand("UPDATE Marks SET StudentID = @StudentID, ExamID = @ExamID, Score = @Score WHERE MarkID = @MarkID", conn);


                    command.Parameters.AddWithValue("@StudentID", mark.StudentId);
                    command.Parameters.AddWithValue("@ExamID", mark.ExamID);
                    command.Parameters.AddWithValue("@Score", mark.Score);
                    command.Parameters.AddWithValue("@MarkID", mark.MarkID);

                    command.ExecuteNonQuery();

                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in UpdateMark: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in UpdateMark: " + ex.Message);
            }
            
        }


        // Delete Mark
        public void DeleteMark(int MarekID)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    var command = new SQLiteCommand("DELETE FROM Marks WHERE MarkID = @MarkID", conn);
                    command.Parameters.AddWithValue("@MarkID", MarekID);


                    command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in UpdateExam: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in UpdateExam: " + ex.Message);
            }
        }
     }
}
    

