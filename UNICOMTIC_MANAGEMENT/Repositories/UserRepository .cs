using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNICOMTIC_MANAGEMENT.Repositories
{
    internal class UserRepository
    {
        public static void   stysxt(string username, string password, string role)
        {
            using (var conn = DbConfig.GetConnection())
            {

                // 1. Check if username already exists
                var checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", conn);
                checkCmd.Parameters.AddWithValue("@Username", username);

                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    MessageBox.Show("Username already exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2. Insert new user
                var insertCmd = new SQLiteCommand("INSERT INTO Users (Username, Password, Role) VALUES (@Username, @Password, @Role)", conn);
                insertCmd.Parameters.AddWithValue("@Username", username);
                insertCmd.Parameters.AddWithValue("@Password", password);  // 🔐 You should hash the password in real projects
                insertCmd.Parameters.AddWithValue("@Role", role);

                insertCmd.ExecuteNonQuery();

                MessageBox.Show("User created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

       
    }
}
