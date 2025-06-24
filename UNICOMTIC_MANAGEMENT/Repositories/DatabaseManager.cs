using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UNICOMTIC_MANAGEMENT.Repositories
{
    internal class DatabaseManager
    {
        public static void CreateTable()
        {
            try
            {

                using (var conn = DbConfig.GetConnection())
                {
                    var cmd = conn.CreateCommand();

                    cmd.CommandText = @"
                                    CREATE TABLE IF NOT EXISTS Users (
                                        UserID INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Username TEXT NOT NULL UNIQUE,
                                        Password TEXT NOT NULL,
                                        Role TEXT NOT NULL
                                        );

                                    CREATE TABLE IF NOT EXISTS Courses (
                                        CourseID INTEGER PRIMARY KEY AUTOINCREMENT,
                                        CourseName TEXT NOT NULL
                                    );


                                    CREATE TABLE IF NOT EXISTS Subjects (
                                        SubjectID INTEGER PRIMARY KEY AUTOINCREMENT,
                                        SubjectName TEXT NOT NULL,
                                        CourseID INTEGER,
                                        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
                                    );


                                    CREATE TABLE IF NOT EXISTS Students (
                                        StudentID INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Name TEXT NOT NULL,
                                        Address TEXT,
                                        Username TEXT NOT NULL,
                                        Password TEXT NOT NULL,
                                        CourseID INTEGER,
                                        FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)                         
                                
                                    );


                                    CREATE TABLE IF NOT EXISTS Staff (
                                        StaffID INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Name TEXT NOT NULL,
                                        Address TEXT,
                                        Username TEXT NOT NULL,
                                        Password TEXT NOT NULL
                                    );


                                    CREATE TABLE IF NOT EXISTS Lecturers (
                                        LecturerID INTEGER PRIMARY KEY AUTOINCREMENT,
                                        Name TEXT NOT NULL,
                                        Username TEXT NOT NULL,
                                        Password TEXT NOT NULL
                                    );


                                    CREATE TABLE IF NOT EXISTS Exams (
                                        ExamID INTEGER PRIMARY KEY AUTOINCREMENT,
                                        ExamName TEXT NOT NULL,
                                        ExamDate TEXT NOT NULL,
                                        RoomID INTEGER,
                                        SubjectID INTEGER,
                                        FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID),
                                        FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
                                    );


                                CREATE TABLE IF NOT EXISTS Marks (
                                    MarkID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    StudentID INTEGER,
                                    ExamID INTEGER,
                                    Score INTEGER CHECK (Score >= 0 AND Score <= 100),
                                    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
                                    FOREIGN KEY (ExamID) REFERENCES Exams(ExamID)
                                );


                                CREATE TABLE IF NOT EXISTS Rooms (
                                    RoomID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    RoomName TEXT NOT NULL,
                                    RoomType TEXT NOT NULL CHECK (RoomType IN ('Lab', 'Hall'))
                                );


                                CREATE TABLE IF NOT EXISTS Timetables (
                                    TimetableID INTEGER PRIMARY KEY AUTOINCREMENT,
                                    SubjectID INTEGER,
                                    TimeSlot TEXT NOT NULL,
                                    RoomID INTEGER,
                                    FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID),
                                    FOREIGN KEY (RoomID) REFERENCES Rooms(RoomID)
                                );";
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Tables created successfully.");
                }
            }
            catch (SQLiteException ex)
            {
                Console.WriteLine("SQLite error occurred: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }

        } 
    }
}
