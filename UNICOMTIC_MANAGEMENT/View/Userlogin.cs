using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICOMTIC_MANAGEMENT.Controller;
using UNICOMTIC_MANAGEMENT.Model;
using UNICOMTIC_MANAGEMENT.Session;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class Userlogin : Form
    {
        private UserController userController = new UserController(); // ✅ Correct controller

        public Userlogin()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
                try
                {
                    string username = txtusername.Text.Trim();
                    string password = txtpassword.Text;
                string selectedRole = userrole.SelectedItem.ToString();


                UserSession.UserName = username;
                UserSession.Role = selectedRole;
                UserSession.Password = password;

                    if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter both Username and Password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    

                    if (selectedRole == "Student")
                    {
                       
                        List<Student> students = userController.LoginStudent(username, password);
                        if (students != null && students.Count > 0)
                        {
                            MessageBox.Show("Student Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StudentViewForm studentForm = new StudentViewForm();
                            this.Hide();
                            studentForm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Student credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (selectedRole == "Lecturer") 
                    {
                        List<Lecturer> lecturers = userController.LoginLecturer(username, password);
                        if (lecturers != null && lecturers.Count > 0)
                        {
                            MessageBox.Show("Lecturer Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LactuerViewForm lecturerForm = new LactuerViewForm();
                            this.Hide();
                            lecturerForm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Lecturer credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (selectedRole == "Staff")
                    {
                        List<Staff> staffMembers = userController.LoginStaff(username, password);
                        if (staffMembers != null && staffMembers.Count > 0)
                        {
                            MessageBox.Show("Staff Login Successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            StaffMenu staffForm = new StaffMenu();
                            this.Hide();
                            staffForm.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Staff credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred during login:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            

        }

        private void Userlogin_Load(object sender, EventArgs e)
        {
           
            userrole.Items.Clear();

            // Add roles
            userrole.Items.Add("Student");
            userrole.Items.Add("Lecturer");
            userrole.Items.Add("Staff");

            
        }

    }
}
