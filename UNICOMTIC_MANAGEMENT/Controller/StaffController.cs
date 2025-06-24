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
    internal class StaffController
    {
        public void AddStaff(Staff staff)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd =new SQLiteCommand("INSERT INTO Staff (Name,Address,Username,Password) VALUES (@Name,@Address,@UserName,@Password)", conn);
                cmd.Parameters.AddWithValue("@Name", staff.Name);
                cmd.Parameters.AddWithValue("@Address", staff.Address);
                cmd.Parameters.AddWithValue("@UserName",staff.Username);
                cmd.Parameters.AddWithValue("@Password",staff.Password);
                cmd.ExecuteNonQuery();
            }
            

        }

        public List<Staff> GetStaffList()
        {
            var Staffs = new List<Staff>();

            using(var conn = DbConfig.GetConnection())
            {
                var cmd =new SQLiteCommand("SELECT * FROM Staff", conn);
                var Reader = cmd.ExecuteReader();

                while (Reader.Read())
                {
                    Staff staff = new Staff();
                    staff.StaffID = Reader.GetInt32(0);
                    staff.Name = Reader.GetString(1);
                    staff.Address = Reader.GetString(2);
                    staff.Username = Reader.GetString(3);
                    staff.Password = Reader.GetString(4);
                    Staffs.Add(staff);
                }
            }
            return Staffs;
        }

        public void UpdateStaff(Staff staff)
        {
            using(var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("UPDATE Staff SET Name = @Name , Address = @Address, Username = @UserName WHERE StaffID = @StaffID",conn);
                cmd.Parameters.AddWithValue("@Name",staff.Name);
                cmd.Parameters.AddWithValue("@Address",staff.Address);
                cmd.Parameters.AddWithValue("@UserName",staff.Username);
                cmd.Parameters.AddWithValue("@StaffID",staff.StaffID);
                cmd.ExecuteNonQuery();  

            }
        }

        public void DeleteStaff(int StaffID)
        {
            using (var conn = DbConfig.GetConnection())
            {
                var cmd = new SQLiteCommand("DELETE FROM Staff WHERE StaffID = @StaffID", conn);
                cmd.Parameters.AddWithValue("@StaffID", StaffID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
