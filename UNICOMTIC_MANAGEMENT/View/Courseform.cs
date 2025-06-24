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
using static System.Collections.Specialized.BitVector32;

namespace UNICOMTIC_MANAGEMENT.View
{
    public partial class Courseform : Form
    {
        CourseController courseController;
        public Courseform()
        {
            courseController = new CourseController();
            InitializeComponent();
            LoadCourses();


        }

        public void LoadCourses()
        {
            try
            {
                coursegridview.DataSource = null;
                coursegridview.DataSource = courseController.GetAllCourses();
                coursegridview.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load courses: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lecid_TextChanged(object sender, EventArgs e)
        {

        }

        private void coubtnadd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(couname.Text))
            {
                MessageBox.Show("Please enter a course name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                couname.Focus();
                return;
            }
            try
            {
                Course course = new Course();
                course.CourseName = couname.Text;


                courseController.AddCourse(course);

                MessageBox.Show("Success");

                LoadCourses();

                couname.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            


        private void coubtndelete_Click(object sender, EventArgs e)
        {
            if (coursegridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (coursegridview.SelectedRows.Count > 0)

                try
                {


                    int CourseID = Convert.ToInt32(coursegridview.SelectedRows[0].Cells["CourseID"].Value);
                    Course courses = new Course()
                    {
                        CourseID = CourseID,
                        CourseName = couname.Text
                    };
                    courseController.DeleteCourse(CourseID);
                    LoadCourses();
                    couname.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        

        private void coubtnupdate_Click(object sender, EventArgs e)
        {
            if (coursegridview.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a course to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (coursegridview.SelectedRows.Count > 0)
                {
                    int CourseID = Convert.ToInt32(coursegridview.SelectedRows[0].Cells["CourseID"].Value);
                    Course course = new Course
                    {
                        CourseID = CourseID,
                        CourseName = couname.Text,
                    };


                    courseController.UpdateCourse(course);
                    MessageBox.Show("Updated SuccessFully");
                    LoadCourses();
                    couname.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update course: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void coursegridview_SelectionChanged(object sender, EventArgs e)
        {
           
        }

        private void coursegridview_SelectionChanged_1(object sender, EventArgs e)
        {
            if (coursegridview.SelectedRows.Count > 0)
            {
                couname.Text = coursegridview.SelectedRows[0].Cells["CourseName"].Value.ToString();
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
