using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class Adminlogin : Form
    {
        public Adminlogin()
        {
            InitializeComponent();
        }

        private void btnadminlogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(adminusername.Text))
                {
                    MessageBox.Show("Please enter a username.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    adminusername.Focus();
                    return;
                }
                if (adminusername.Text == "Admin" && adminpassword.Text == "Admin@123")
                {

                    MessageBox.Show("SuccessFully Logged in");

                    this.Hide();
                    AdminMenu adminForm = new AdminMenu();
                    adminForm.ShowDialog();
                }

                else
                {
                    MessageBox.Show("Invalid UserName or Password");
                }

            }
            catch (Exception ex)
            {
                // Log or handle unexpected errors
                MessageBox.Show("An unexpected error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }






        }

        private void adminusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void adminpassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Adminlogin_Load(object sender, EventArgs e)
        {
            adminpassword.PasswordChar = '.';
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showpassword.Checked)
            {
                adminpassword.PasswordChar = '\0'; // shows the actual text
            }
            else
            {
                adminpassword.PasswordChar = '*';  // hides it
            }
        }

        private void adminpassword_Enter(object sender, EventArgs e)
        {
            if (adminpassword.Text == "Enter the Password")
            {
                adminpassword.Text = "";
                adminpassword.ForeColor = Color.Black;
                adminpassword.PasswordChar = '*';
            }
        }

        private void adminpassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(adminpassword.Text))
            {
                adminpassword.Text = "Enter the Password";
                adminpassword.ForeColor = Color.Gray;
                adminpassword.PasswordChar = '\0'; //
            }
        }
    }
}
