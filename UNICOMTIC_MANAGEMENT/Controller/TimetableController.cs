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
    internal class TimetableController

    {
        // Add
        public void AddTimetable(Timetable timetable)
        {
            using (var conn = DbConfig.GetConnection())
            {

                var command = new SQLiteCommand("INSERT INTO Timetables (SubjectID, TimeSlot, RoomID) VALUES (@SubjectID, @TimeSlot, @RoomID)", conn);
                command.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                command.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                command.Parameters.AddWithValue("@RoomID", timetable.RoomID);

                command.ExecuteNonQuery();
            }
        }

        public List<Timetable> GetTimetableList()
        {
            var timetables = new List<Timetable>();
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand(@"SELECT t.TimetableID,t.SubjectID,t.TimeSlot,t.RoomID,r.RoomType,s.SubjectName
                                                    FROM Timetables t 
                                                     LEFT JOIN Subjects s ON t.SubjectID = s.SubjectID
                                                      LEFT JOIN Rooms r ON t.RoomID = r.RoomID", conn);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var timetable = new Timetable
                        {
                            TimeTableID = Convert.ToInt32(reader["TimeTableID"]),
                            SubjectID = Convert.ToInt32(reader["SubjectID"]),
                            RoomID = Convert.ToInt32(reader["RoomID"]),
                            TimeSlot = reader["TimeSlot"]?.ToString(),
                            RoomType = reader["RoomType"]?.ToString(),
                            SubjectName = reader["SubjectName"]?.ToString()
                        };

                            timetables.Add(timetable);
                    }
                }
            }
            return timetables;
        }

        public List<Subject> GetAllSubjects()
        {
            var subjects = new List<Subject>();
            using (var conn = DbConfig.GetConnection())
            {

                using (var cmd = new SQLiteCommand("SELECT SubjectID, SubjectName FROM Subjects ", conn))
                {
                    cmd.ExecuteNonQuery();



                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var subject = new Subject
                            {
                                SubjectID = reader.GetInt32(0),
                                Subjectname = reader.GetString(1),
                            };
                            subjects.Add(subject);
                        }
                    }
                }
                return subjects;
            }
        }
        public List<Room> GetAllRooms()
        {

            {
                List<Room> rooms = new List<Room>();
                using (var conn = DbConfig.GetConnection())
                {
                    var cmd = new SQLiteCommand("SELECT RoomID,RoomType FROM Rooms", conn);
                    var reader = cmd.ExecuteReader();
                    {
                        while (reader.Read())
                        {
                            Room room = new Room
                            {
                                RoomID = reader.GetInt32(0),
                                
                                RoomType = reader.GetString(1),

                            }; rooms.Add(room);
                        }
                    }
                }
                return rooms;
            }

        }



        // Update
        public void UpdateTimetable(Timetable timetable)
        {
           
                using (var conn = DbConfig.GetConnection())
                {
                    var command = new SQLiteCommand("UPDATE Timetables SET TimeSlot=@TimeSlot, SubjectID=@SubjectID, RoomID=@RoomID WHERE TimetableID=@TimetableID", conn);

                    command.Parameters.AddWithValue("@TimetableID", timetable.TimeTableID);
                    command.Parameters.AddWithValue("@SubjectID", timetable.SubjectID);
                    command.Parameters.AddWithValue("@TimeSlot", timetable.TimeSlot);
                    command.Parameters.AddWithValue("@RoomID", timetable.RoomID);

                    command.ExecuteNonQuery();
                }
            

        }

        // Delete
        public void DeleteTimbleTable(int timetableId)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var command = new SQLiteCommand("DELETE FROM Timetables WHERE TimetableID = @TimetableID", conn);
                command.Parameters.AddWithValue("@TimetableID", timetableId);
                command.ExecuteNonQuery();
            }
        }

    }

}



