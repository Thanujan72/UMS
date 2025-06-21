using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UNICOMTIC_MANAGEMENT.Controller;
using UNICOMTIC_MANAGEMENT.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class StudentFrom : Form
    {
        StudentController controller;
        public StudentFrom()
        {
            controller = new StudentController();
            InitializeComponent();
            LoadStudents();
        }
        public void LoadStudents()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = controller.GetAllStudets();
            if (dataGridView1.Columns.Contains("CourseID"))
            {
                dataGridView1.Columns["CourseID"].Visible = false;
            }
            dataGridView1.ClearSelection();


        }





        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void stuadd_Click(object sender, EventArgs e)
        {


            int courseId = (int)courseid.SelectedValue;


            Student student = new Student
            {
                Name = stuname.Text,
                Adderss = stuadderss.Text,
                Username = stuusername.Text,
                Password = stupassword.Text,
                CourseID = courseId
            };

            controller.AddStudent(student);
            MessageBox.Show("Student Added Success");
            LoadStudents();
            stuname.Text = "";
            stuadderss.Text = "";
            stuusername.Text = "";
            stupassword.Text = "";
            courseid.Text = "";
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                stuname.Text = dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString();
                stuadderss.Text = dataGridView1.SelectedRows[0].Cells["Adderss"].Value.ToString();
                stuusername.Text = dataGridView1.SelectedRows[0].Cells["UserName"].Value.ToString();
                stupassword.Text = dataGridView1.SelectedRows[0].Cells["Password"].Value.ToString();
                courseid.Text = dataGridView1.SelectedRows[0].Cells["CourseName"].Value.ToString();

            }
        }

        private void StudentFrom_Load(object sender, EventArgs e)
        {

            var courseList = controller.GetAllCourses();
            courseid.DataSource = courseList;
            courseid.DisplayMember = "CourseName";
            courseid.ValueMember = "CourseID";
            
        }

        private void courseid_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void stuupdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                {
                    int StudentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);
                    Student student = new Student
                    {
                        StudentID = StudentID,
                        Name = stuname.Text,
                        Adderss = stuadderss.Text,
                        Username = stuusername.Text,
                        Password = stupassword.Text,
                        
                    };
                    controller.UpdateStudent(student);
                    MessageBox.Show("Student Updated Success");
                    LoadStudents();
                    stuname.Text = "";
                    stuadderss.Text = "";
                    stuusername.Text = "";
                    stupassword.Text = "";
                    courseid.Text = "";
                }
            }
        }

        private void studelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int StudentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["StudentID"].Value);

                Student student = new Student
                {
                    StudentID = StudentID,
                   Name = stuname.Text,
                   Adderss = stuadderss.Text,
                   Username = stuusername.Text,
                   Password = stupassword.Text,
                
                };
                controller.DeleteStudent(StudentID);
                MessageBox.Show("Student Deleted SuccessFully");
                LoadStudents();
                stuname.Text = "";
                stuadderss.Text = "";
                stuusername.Text = "";
                stupassword.Text = "";
                courseid.Text = "";
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.ShowDialog();
        }
    }
}
                
        
    

