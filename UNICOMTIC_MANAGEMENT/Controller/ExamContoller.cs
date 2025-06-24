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
    internal class ExamContoller
    {
        //Add Exam
        public void AddExam(Exam exam)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {

                    var command = new SQLiteCommand("INSERT INTO Exams (ExamName, ExamDate,RoomID,SubjectId) VALUES (@ExamName,@ExamDate,@RoomID, @SubjectId)", conn);

                    command.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    command.Parameters.AddWithValue("@ExamDate", exam.ExamDate);
                    command.Parameters.AddWithValue("@RoomID", exam.RoomID);
                    command.Parameters.AddWithValue("@SubjectId", exam.SubjectID);

                    command.ExecuteNonQuery();
                }


            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in AddCourse: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in AddCourse: " + ex.Message);
            }

        }


        public List<Exam> GetExamList()
        {
            var exams = new List<Exam>();
            try

            {
                
                using (var conn = DbConfig.GetConnection())
                {
                    var command = new SQLiteCommand(@"SELECT e.ExamID,e.ExamName,e.ExamDate,e.RoomID,r.RoomName, e.SubjectID 
                                                        FROM  Exams e
                                                        LEFT JOIN Rooms r ON e.RoomID = r.RoomID
                                                        LEFT JOIN Subjects s ON e.SubjectID = s.SubjectID", conn);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var exam = new Exam
                            {
                                ExamId = reader.GetInt32(0),
                                ExamName = reader.GetString(1),
                                ExamDate = DateTime.Parse(reader.GetString(2)),
                                RoomID = reader.GetInt32(3),
                                RoomName = reader.GetString(4),
                                SubjectID = reader.GetInt32(5),


                            };
                            exams.Add(exam);
                        }
                    }

                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in GetAllCourses: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in GetAllCourses: " + ex.Message);
            }
            return exams;
        }
    

        public List<Subject> GetSubjectList()
        {
            var subjects = new List<Subject>();
            try
            {
                using (var conn = DbConfig.GetConnection())
                {

                    var command = new SQLiteCommand("SELECT SubjectID, SubjectName FROM Subjects", conn);
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Subject subject = new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            SubjectName = reader.GetString(1)  // Property name match பண்ணுங்க
                        };
                        subjects.Add(subject);
                    }
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in GetSubjectList: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in GetSubjectList: " + ex.Message);
            }

            return subjects;
        }

        public List<Room> GetRoomList()
        {
            var rooms = new List<Room>();
            try
            {
                using (var conn = DbConfig.GetConnection())
                {

                    var cmd = new SQLiteCommand("SELECT * FROM Rooms", conn);
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Room room = new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            RoomType = reader.GetString(2)
                        };
                        rooms.Add(room);
                    }
                }
            }

            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in GetRoomList: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in GetRoomList: " + ex.Message);
            }
            return rooms;
        }

    




    // Update Exam
    public void UpdateExam(Exam exam)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    var command = new SQLiteCommand("UPDATE Exams SET  ExamName = @ExamName,ExamDate = @ExamDate,RoomID = @RoomID,SubjectID = @SubjectID WHERE ExamID = @Id", conn);

                    command.Parameters.AddWithValue("@ExamName", exam.ExamName);
                    command.Parameters.AddWithValue("@ExamDate", exam.ExamDate);
                    command.Parameters.AddWithValue("@RoomID", exam.RoomID);
                    command.Parameters.AddWithValue("@SubjectID", exam.SubjectID);
                    command.Parameters.AddWithValue("@Id", exam.ExamId);

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

        // Delete Exam
        public void DeleteExam(int examId)
        {
            try
            {
                using (var conn = DbConfig.GetConnection())
                {
                    var command = new SQLiteCommand("DELETE FROM Exams WHERE ExamID = @Id", conn);
                    command.Parameters.AddWithValue("@Id", examId);

                    command.ExecuteNonQuery();
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error in DeleteExam: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error in DeleteExam: " + ex.Message);
            }
        }
    }

}

