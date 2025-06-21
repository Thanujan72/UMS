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

        public List<Exam> GetExamList()
        {
            var exams = new List<Exam>();  
            using(var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand(@"SELECT e.ExamID,e.ExamName,e.ExamDate,e.RoomID, r.RoomName, e.SubjectID 
                                                  FROM  Exams e
                                                  LEFT JOIN Rooms r ON e.RoomID = r.RoomID
                                                  LEFT JOIN Subjects s ON e.SubjectID = s.SubjectID", conn);
                using(var reader = command.ExecuteReader())
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
                            //SubjectId = reader.GetInt32(5),
                           

                        };
                        exams.Add(exam);
                    }
                }
                        
            }
            return exams;
        }

        public List<Subject> GetSubjectList()
        {
            var subjects = new List<Subject>();
            using( var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("SELECT SubjectID,SubjectName FROM Subjects", conn);
                {
                    var reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Subject subject = new Subject
                        {
                            SubjectID = reader.GetInt32(0),
                            Subjectname = reader.GetString(1)
                        };
                        subjects.Add(subject);
                    }
                }
            }return subjects;
        }
        public List<Room> GetRoomList()
        {
            var rooms = new List<Room>();
            using ( var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT* FROM Rooms", conn);
                var reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        Room room = new Room
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            RoomType = reader.GetString(2),

                        }; rooms.Add(room);
                    }
                }
            }
            return rooms;
        }
        
        


        // Update Exam
        public void UpdateExam(Exam exam)
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

        /*// Delete Exam
        public void DeleteExam(int examId)
        {
            using (var conn = DbConfig.GetConnection())
            {
               var command = new SQLiteCommand("DELETE FROM Exams WHERE ExamID = @Id", conn);
                command.Parameters.AddWithValue("@Id", examId);

                command.ExecuteNonQuery();
            }
        }*/
    }

}

