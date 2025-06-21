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
    internal class RoomController
    {
        //Add Rooms
        public void AddRooms(Room room)
        {
            using (var conn = DbConfig.GetConnection())
            {
                using(var cmd = new SQLiteCommand("INSERT INTO Rooms(RoomName,RoomType)VALUES (@RoomName,@RoomType)",conn))
                {
                    cmd.Parameters.AddWithValue("@RoomName", room.RoomName);
                    cmd.Parameters.AddWithValue("@RoomType", room.RoomType);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Room> GetRooms()
        {
            List<Room> rooms = new List<Room>();
            using(var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("SELECT* FROM Rooms", conn);
                var reader = cmd.ExecuteReader();
                {
                    while (reader.Read())
                    {
                        Room room = new Room
                        {
                           RoomID =reader.GetInt32(0),
                           RoomName = reader.GetString(1),
                           RoomType = reader.GetString(2),

                        };rooms.Add(room);
                    }
                }
            }return rooms;
        }
        
    }
}
